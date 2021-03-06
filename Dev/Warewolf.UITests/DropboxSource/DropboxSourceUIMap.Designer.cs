// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 14.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace Warewolf.UITests.DropboxSource.DropboxSourceUIMapClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public partial class DropboxSourceUIMap
    {
        
        #region Properties
        public MainStudioWindow MainStudioWindow
        {
            get
            {
                if ((this.mMainStudioWindow == null))
                {
                    this.mMainStudioWindow = new MainStudioWindow();
                }
                return this.mMainStudioWindow;
            }
        }
        #endregion
        
        #region Fields
        private MainStudioWindow mMainStudioWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class MainStudioWindow : WpfWindow
    {
        
        public MainStudioWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.Name, "Warewolf", PropertyExpressionOperator.Contains));
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.SearchConfigurations.Add(SearchConfiguration.AlwaysSearch);
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public DockManager DockManager
        {
            get
            {
                if ((this.mDockManager == null))
                {
                    this.mDockManager = new DockManager(this);
                }
                return this.mDockManager;
            }
        }
        #endregion
        
        #region Fields
        private DockManager mDockManager;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class DockManager : WpfCustom
    {
        
        public DockManager(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.XamDockManager";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "DockManager";
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public SplitPaneMiddle SplitPaneMiddle
        {
            get
            {
                if ((this.mSplitPaneMiddle == null))
                {
                    this.mSplitPaneMiddle = new SplitPaneMiddle(this);
                }
                return this.mSplitPaneMiddle;
            }
        }
        #endregion
        
        #region Fields
        private SplitPaneMiddle mSplitPaneMiddle;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class SplitPaneMiddle : WpfCustom
    {
        
        public SplitPaneMiddle(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.SplitPane";
            this.SearchProperties[WpfControl.PropertyNames.Instance] = "2";
            this.SearchConfigurations.Add(SearchConfiguration.NextSibling);
            this.SearchConfigurations.Add(SearchConfiguration.DisambiguateChild);
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public TabManSplitPane TabManSplitPane
        {
            get
            {
                if ((this.mTabManSplitPane == null))
                {
                    this.mTabManSplitPane = new TabManSplitPane(this);
                }
                return this.mTabManSplitPane;
            }
        }
        #endregion
        
        #region Fields
        private TabManSplitPane mTabManSplitPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class TabManSplitPane : WpfCustom
    {
        
        public TabManSplitPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.SplitPane";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "UI_SplitPane_AutoID";
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public TabMan TabMan
        {
            get
            {
                if ((this.mTabMan == null))
                {
                    this.mTabMan = new TabMan(this);
                }
                return this.mTabMan;
            }
        }
        #endregion
        
        #region Fields
        private TabMan mTabMan;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class TabMan : WpfTabList
    {
        
        public TabMan(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTabList.PropertyNames.AutomationId] = "UI_TabManager_AutoID";
            this.WindowTitles.Add("Warewolf");
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public OAuthSourceWizardTab OAuthSourceWizardTab
        {
            get
            {
                if ((this.mOAuthSourceWizardTab == null))
                {
                    this.mOAuthSourceWizardTab = new OAuthSourceWizardTab(this);
                }
                return this.mOAuthSourceWizardTab;
            }
        }
        #endregion
        
        #region Fields
        private OAuthSourceWizardTab mOAuthSourceWizardTab;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class OAuthSourceWizardTab : WpfTabPage
    {
        
        public OAuthSourceWizardTab(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTabPage.PropertyNames.Name] = "Dev2.ViewModels.SourceViewModel`1[Dev2.Common.Interfaces.IOAuthSource]";
            this.WindowTitles.Add("Warewolf (DEV2\\DYLAN.DELPORT)");
            #endregion
        }
        
        #region Properties
        public WpfButton CloseTabButton
        {
            get
            {
                if ((this.mCloseTabButton == null))
                {
                    this.mCloseTabButton = new WpfButton(this);
                    #region Search Criteria
                    this.mCloseTabButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "closeBtn";
                    this.mCloseTabButton.WindowTitles.Add("Warewolf (DEV2\\DYLAN.DELPORT)");
                    #endregion
                }
                return this.mCloseTabButton;
            }
        }
        
        public WorkSurfaceContext WorkSurfaceContext
        {
            get
            {
                if ((this.mWorkSurfaceContext == null))
                {
                    this.mWorkSurfaceContext = new WorkSurfaceContext(this);
                }
                return this.mWorkSurfaceContext;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mCloseTabButton;
        
        private WorkSurfaceContext mWorkSurfaceContext;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class WorkSurfaceContext : WpfCustom
    {
        
        public WorkSurfaceContext(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.XamDockManager";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "ContentDockManager";
            this.WindowTitles.Add("Warewolf (DEV2\\DYLAN.DELPORT)");
            #endregion
        }
        
        #region Properties
        public WpfButton AuthoriseButton
        {
            get
            {
                if ((this.mAuthoriseButton == null))
                {
                    this.mAuthoriseButton = new WpfButton(this);
                    #region Search Criteria
                    this.mAuthoriseButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "AuthoriseButton";
                    this.mAuthoriseButton.WindowTitles.Add("Warewolf (DEV2\\DYLAN.DELPORT)");
                    #endregion
                }
                return this.mAuthoriseButton;
            }
        }
        
        public ServerTypeComboBox ServerTypeComboBox
        {
            get
            {
                if ((this.mServerTypeComboBox == null))
                {
                    this.mServerTypeComboBox = new ServerTypeComboBox(this);
                }
                return this.mServerTypeComboBox;
            }
        }
        
        public WpfEdit OAuthKeyTextBox
        {
            get
            {
                if ((this.mOAuthKeyTextBox == null))
                {
                    this.mOAuthKeyTextBox = new WpfEdit(this);
                    #region Search Criteria
                    this.mOAuthKeyTextBox.SearchProperties[WpfEdit.PropertyNames.AutomationId] = "OAuthKeyTextBox";
                    this.mOAuthKeyTextBox.WindowTitles.Add("Warewolf (DEV2\\DYLAN.DELPORT)");
                    #endregion
                }
                return this.mOAuthKeyTextBox;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mAuthoriseButton;
        
        private ServerTypeComboBox mServerTypeComboBox;
        
        private WpfEdit mOAuthKeyTextBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "14.0.23107.0")]
    public class ServerTypeComboBox : WpfCustom
    {
        
        public ServerTypeComboBox(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.XamComboEditor";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "ServerTypeComboBox";
            this.WindowTitles.Add("Warewolf (DEV2\\DYLAN.DELPORT)");
            #endregion
        }
        
        #region Properties
        public WpfButton ToggleButton
        {
            get
            {
                if ((this.mToggleButton == null))
                {
                    this.mToggleButton = new WpfButton(this);
                    #region Search Criteria
                    this.mToggleButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "ToggleButton";
                    this.mToggleButton.WindowTitles.Add("Warewolf (DEV2\\DYLAN.DELPORT)");
                    #endregion
                }
                return this.mToggleButton;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mToggleButton;
        #endregion
    }
}
