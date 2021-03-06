/*
*  Warewolf - Once bitten, there's no going back
*  Copyright 2017 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Reflection;
using Dev2.Common.Interfaces.Wrappers;
using Dev2.Data.Interfaces;
using Dev2.Data.Interfaces.Enums;
using Warewolf.Resource.Errors;

// ReSharper disable CheckNamespace
namespace Dev2.PathOperations
// ReSharper restore CheckNamespace
{

    /// <summary>
    /// PBI : 1172
    /// Status : New
    /// Purpose : To provide a factory for creating ActivityIO objects
    /// </summary>
    public static class ActivityIOFactory
    {

        private static IList<Type> _endPoints;
        private static readonly object EndPointsLock = new object();
        // used to check what type services what
        private static IList<IActivityIOOperationsEndPoint> _referenceCheckers;

        /// <summary>
        /// Return an IActivityIOPath based upont the path string
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="user">The user.</param>
        /// <param name="pass">The pass.</param>
        /// <param name="privateKeyFile">If private key file is required. This is the path</param>
        /// <returns></returns>
        public static IActivityIOPath CreatePathFromString(string path, string user, string pass, string privateKeyFile = "")
        {
            return CreatePathFromString(path, user, pass, false, privateKeyFile);
        }

        /// <summary>
        /// Return an IActivityIOPath based upont the path string
        /// </summary>
        /// <param name="path">The path.</param>
        /// <param name="user">The user.</param>
        /// <param name="pass">The pass.</param>
        /// <param name="isNotCertVerifiable">if set to <c>true</c> [is not cert verifiable].</param>
        /// <param name="privateKeyFile">If private key file is required. This is the path</param>
        /// <returns></returns>
        public static IActivityIOPath CreatePathFromString(string path, string user, string pass, bool isNotCertVerifiable, string privateKeyFile = "")
        {
            VerifyArgument.IsNotNull("path", path);
            enActivityIOPathType type = Dev2ActivityIOPathUtils.ExtractPathType(path);
            if (type == enActivityIOPathType.Invalid)
            {
                // Default to file system
                type = enActivityIOPathType.FileSystem;
                if (!Path.IsPathRooted(path))
                    throw new IOException(ErrorResource.InvalidPath);
            }

            return new Dev2ActivityIOPath(type, path, user, pass, isNotCertVerifiable, privateKeyFile);
        }


        /// <summary>
        /// Return an IActivityIOPath based upont the path string
        /// </summary>
        /// <param name="path"></param>
        /// <param name="isNotCertVerifiable"></param>
        /// <param name="privateKeyFile">If private key file is required. This is the path</param>
        /// <returns></returns>
        [SuppressMessage("ReSharper", "UnusedMember.Global")]
        public static IActivityIOPath CreatePathFromString(string path, bool isNotCertVerifiable, string privateKeyFile = "")
        {
            return CreatePathFromString(path, string.Empty, string.Empty, isNotCertVerifiable, privateKeyFile);
        }

        /// <summary>
        /// Return the appropriate operation end point based upon the IOPath type
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static IActivityIOOperationsEndPoint CreateOperationEndPointFromIOPath(IActivityIOPath target)
        {
            lock(EndPointsLock)
            {
                // load end-points if need be... aka first load
                if(_endPoints == null)
                {
                    _endPoints = new List<Type>();
                    _referenceCheckers = new List<IActivityIOOperationsEndPoint>();

                    var type = typeof(IActivityIOOperationsEndPoint);

                    List<Type> types = Assembly.GetExecutingAssembly().GetTypes()
                        .Where(t => type.IsAssignableFrom(t))
                        .ToList();

                    foreach(Type t in types)
                    {
                        if(t != typeof(IActivityIOOperationsEndPoint))
                        {
                            _endPoints.Add(t);
                            _referenceCheckers.Add((IActivityIOOperationsEndPoint)Activator.CreateInstance(t));
                        }
                    }
                }
            }

            // now find the right match ;)
            int pos = 0;

            while(pos < _referenceCheckers.Count && !_referenceCheckers[pos].HandlesType(target.PathType))
            {
                pos++;
            }
            IActivityIOOperationsEndPoint result;
            if (_endPoints != null && _endPoints.Count > 0)
            {
                 result =
                    (IActivityIOOperationsEndPoint)Activator.CreateInstance(_endPoints[pos]);
                result.IOPath = target;


            }
            else
            {
                result = new Dev2FileSystemProvider { IOPath = target };
            }
            return result;
        }

        /// <summary>
        /// Create an operations broker object
        /// </summary>
        /// <returns></returns>
        public static IActivityOperationsBroker CreateOperationsBroker()
        {
            return new Dev2ActivityIOBroker();
        } 
        /// <summary>
        /// Create an operations broker object
        /// </summary>
        /// <returns></returns>
        [SuppressMessage("ReSharper", "UnusedMember.Global")]
        public static IActivityOperationsBroker CreateOperationsBroker(IFile file, ICommon common)
        {
            return new Dev2ActivityIOBroker(file, common);
        }

        /// <summary>
        /// Create an PutRawOperationTo object
        /// </summary>
        /// <returns></returns>
        public static Dev2PutRawOperationTO CreatePutRawOperationTO(WriteType writeType, string contents)
        {
            return new Dev2PutRawOperationTO(writeType, contents);
        }

        /// <summary>
        /// Create an UnZipOperationTO object
        /// </summary>
        /// <returns></returns>
        public static Dev2UnZipOperationTO CreateUnzipTO(string passwd, bool overwrite)
        {
            return new Dev2UnZipOperationTO(passwd, overwrite);
        }

        /// <summary>
        /// Create an ZipOperationTO object
        /// </summary>
        /// <returns></returns>
        public static Dev2ZipOperationTO CreateZipTO(string ratio, string passwd, string name, bool overwrite = false)
        {
            return new Dev2ZipOperationTO(ratio, passwd, name, overwrite);
        }
    }
}
