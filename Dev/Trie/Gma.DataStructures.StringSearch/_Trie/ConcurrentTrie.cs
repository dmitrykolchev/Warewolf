// This code is distributed under MIT license. Copyright (c) 2013 George Mamaladze
// See license.txt or http://opensource.org/licenses/mit-license.php
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Gma.DataStructures.StringSearch
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class ConcurrentTrie<TValue> : ConcurrentTrieNode<TValue>, ITrie<TValue>
    {
        public IEnumerable<TValue> Retrieve(string query)
        {
            return Retrieve(query, 0);
        }

        public void Add(string key, TValue value)
        {
            Add(key, 0, value);
        }
    }
}