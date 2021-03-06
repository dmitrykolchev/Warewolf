﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Warewolf.ToolsSpecs.Toolbox.Scripting.Javascript
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class JavascriptFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Javascript.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Javascript", "\tIn order to execute javascripts\r\n\tAs a Warewolf user\r\n\tI want a tool that allows" +
                    " me to execute javascripts", ProgrammingLanguage.CSharp, new string[] {
                        "JavascriptFeature"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Javascript")))
            {
                Warewolf.ToolsSpecs.Toolbox.Scripting.Javascript.JavascriptFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute Javascript Variable is 1")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Javascript")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("JavascriptFeature")]
        public virtual void ExecuteJavascriptVariableIs1()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute Javascript Variable is 1", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I have a script variable \"[[val]]\" with this value \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("I have this script to execute \"javascript_one_variable.txt\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("I have selected the language as \"JavaScript\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.When("I execute the script tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("the script result should be \"one\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 13
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1587 = new TechTalk.SpecFlow.Table(new string[] {
                        "Language",
                        "Script"});
            table1587.AddRow(new string[] {
                        "JavaScript",
                        "String = String"});
#line 14
 testRunner.And("the debug inputs as", ((string)(null)), table1587, "And ");
#line hidden
            TechTalk.SpecFlow.Table table1588 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table1588.AddRow(new string[] {
                        "[[result]] = one"});
#line 17
 testRunner.And("the debug output as", ((string)(null)), table1588, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute Javascript blank script")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Javascript")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("JavascriptFeature")]
        public virtual void ExecuteJavascriptBlankScript()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute Javascript blank script", ((string[])(null)));
#line 21
this.ScenarioSetup(scenarioInfo);
#line 22
 testRunner.Given("I have this script to execute \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 23
 testRunner.And("I have selected the language as \"JavaScript\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.When("I execute the script tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
 testRunner.Then("the script result should be \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 26
 testRunner.And("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1589 = new TechTalk.SpecFlow.Table(new string[] {
                        "Language",
                        "Script"});
            table1589.AddRow(new string[] {
                        "JavaScript",
                        "\"\""});
#line 27
 testRunner.And("the debug inputs as", ((string)(null)), table1589, "And ");
#line hidden
            TechTalk.SpecFlow.Table table1590 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table1590.AddRow(new string[] {
                        "[[result]] ="});
#line 30
 testRunner.And("the debug output as", ((string)(null)), table1590, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute Javascript Variable is 2")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Javascript")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("JavascriptFeature")]
        public virtual void ExecuteJavascriptVariableIs2()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute Javascript Variable is 2", ((string[])(null)));
#line 34
this.ScenarioSetup(scenarioInfo);
#line 35
 testRunner.Given("I have a script variable \"[[val]]\" with this value \"2\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
 testRunner.And("I have this script to execute \"javascript_one_variable.txt\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.And("I have selected the language as \"JavaScript\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
 testRunner.When("I execute the script tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
 testRunner.Then("the script result should be \"two\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 40
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1591 = new TechTalk.SpecFlow.Table(new string[] {
                        "Language",
                        "Script"});
            table1591.AddRow(new string[] {
                        "JavaScript",
                        "String = String"});
#line 41
 testRunner.And("the debug inputs as", ((string)(null)), table1591, "And ");
#line hidden
            TechTalk.SpecFlow.Table table1592 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table1592.AddRow(new string[] {
                        "[[result]] = two"});
#line 44
 testRunner.And("the debug output as", ((string)(null)), table1592, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute Javascript Variable is 3")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Javascript")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("JavascriptFeature")]
        public virtual void ExecuteJavascriptVariableIs3()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute Javascript Variable is 3", ((string[])(null)));
#line 48
this.ScenarioSetup(scenarioInfo);
#line 49
 testRunner.Given("I have a script variable \"[[val]]\" with this value \"3\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 50
 testRunner.And("I have this script to execute \"javascript_one_variable.txt\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.And("I have selected the language as \"JavaScript\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.When("I execute the script tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
 testRunner.Then("the script result should be \"not one or two\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 54
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1593 = new TechTalk.SpecFlow.Table(new string[] {
                        "Language",
                        "Script"});
            table1593.AddRow(new string[] {
                        "JavaScript",
                        "String = String"});
#line 55
 testRunner.And("the debug inputs as", ((string)(null)), table1593, "And ");
#line hidden
            TechTalk.SpecFlow.Table table1594 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table1594.AddRow(new string[] {
                        "[[result]] = not one or two"});
#line 58
 testRunner.And("the debug output as", ((string)(null)), table1594, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute Javascript Variable is 100")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Javascript")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("JavascriptFeature")]
        public virtual void ExecuteJavascriptVariableIs100()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute Javascript Variable is 100", ((string[])(null)));
#line 62
this.ScenarioSetup(scenarioInfo);
#line 63
 testRunner.Given("I have a script variable \"[[val]]\" with this value \"100\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 64
 testRunner.And("I have this script to execute \"javascript_one_variable.txt\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.And("I have selected the language as \"JavaScript\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.When("I execute the script tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 67
 testRunner.Then("the script result should be \"not one or two\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 68
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1595 = new TechTalk.SpecFlow.Table(new string[] {
                        "Language",
                        "Script"});
            table1595.AddRow(new string[] {
                        "JavaScript",
                        "String = String"});
#line 69
 testRunner.And("the debug inputs as", ((string)(null)), table1595, "And ");
#line hidden
            TechTalk.SpecFlow.Table table1596 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table1596.AddRow(new string[] {
                        "[[result]] = not one or two"});
#line 72
 testRunner.And("the debug output as", ((string)(null)), table1596, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute badly formed Javascript")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Javascript")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("JavascriptFeature")]
        public virtual void ExecuteBadlyFormedJavascript()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute badly formed Javascript", ((string[])(null)));
#line 76
this.ScenarioSetup(scenarioInfo);
#line 77
 testRunner.Given("I have a script variable \"[[val]]\" with this value \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 78
 testRunner.And("I have this script to execute \"javascript_badly_formatted.txt\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.And("I have selected the language as \"JavaScript\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.When("I execute the script tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
 testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table1597 = new TechTalk.SpecFlow.Table(new string[] {
                        "Language",
                        "Script"});
            table1597.AddRow(new string[] {
                        "JavaScript",
                        "String = String"});
#line 82
 testRunner.And("the debug inputs as", ((string)(null)), table1597, "And ");
#line hidden
            TechTalk.SpecFlow.Table table1598 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table1598.AddRow(new string[] {
                        "[[result]] ="});
#line 85
 testRunner.And("the debug output as", ((string)(null)), table1598, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute Javascript with 2 variables")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Javascript")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("JavascriptFeature")]
        public virtual void ExecuteJavascriptWith2Variables()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute Javascript with 2 variables", ((string[])(null)));
#line 89
this.ScenarioSetup(scenarioInfo);
#line 90
 testRunner.Given("I have a script variable \"[[val1]]\" with this value \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 91
 testRunner.Given("I have a script variable \"[[val2]]\" with this value \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 92
 testRunner.And("I have this script to execute \"javascript_two_variables.txt\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("I have selected the language as \"JavaScript\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.When("I execute the script tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
 testRunner.Then("the script result should be \"two\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 96
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1599 = new TechTalk.SpecFlow.Table(new string[] {
                        "Language",
                        "Script"});
            table1599.AddRow(new string[] {
                        "JavaScript",
                        "String = String"});
#line 97
 testRunner.And("the debug inputs as", ((string)(null)), table1599, "And ");
#line hidden
            TechTalk.SpecFlow.Table table1600 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table1600.AddRow(new string[] {
                        "[[result]] = two"});
#line 100
 testRunner.And("the debug output as", ((string)(null)), table1600, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void ExcuteJavascriptWithIncorrectValues(string script, string errorOccured, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Excute Javascript with incorrect values", exampleTags);
#line 104
 this.ScenarioSetup(scenarioInfo);
#line 105
 testRunner.Given("I have the script to execute \"<script>\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 106
 testRunner.And("I have selected the language as \"JavaScript\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
 testRunner.When("I execute the script tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 108
 testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 109
 testRunner.And(string.Format("the execution has \"{0}\" error", errorOccured), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1601 = new TechTalk.SpecFlow.Table(new string[] {
                        "Language",
                        "Script"});
            table1601.AddRow(new string[] {
                        "JavaScript",
                        "<script>"});
#line 110
 testRunner.And("the debug inputs as", ((string)(null)), table1601, "And ");
#line hidden
            TechTalk.SpecFlow.Table table1602 = new TechTalk.SpecFlow.Table(new string[] {
                        ""});
            table1602.AddRow(new string[] {
                        "[[result]] ="});
#line 113
 testRunner.And("the debug output as", ((string)(null)), table1602, "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Excute Javascript with incorrect values: 88")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Javascript")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("JavascriptFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "88")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Script", "88")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ErrorOccured", "There was an error when returning a value from your script, remember to use the \"" +
            "Return\" keyword when returning the result")]
        public virtual void ExcuteJavascriptWithIncorrectValues_88()
        {
            this.ExcuteJavascriptWithIncorrectValues("88", "There was an error when returning a value from your script, remember to use the \"" +
                    "Return\" keyword when returning the result", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Excute Javascript with incorrect values: [[var]]")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Javascript")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("JavascriptFeature")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "[[var]]")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Script", "[[var]]")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ErrorOccured", "Scalar value {var} is NULL")]
        public virtual void ExcuteJavascriptWithIncorrectValues_Var()
        {
            this.ExcuteJavascriptWithIncorrectValues("[[var]]", "Scalar value {var} is NULL", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute JavaScript with a null variable")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Javascript")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("JavascriptFeature")]
        public virtual void ExecuteJavaScriptWithANullVariable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute JavaScript with a null variable", ((string[])(null)));
#line 121
this.ScenarioSetup(scenarioInfo);
#line 122
 testRunner.Given("I have a script variable \"[[val1]]\" with this value \"null\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 123
 testRunner.Given("I have a script variable \"[[val2]]\" with this value \"null\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 124
 testRunner.And("I have this script to execute \"[[val2]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 125
 testRunner.And("I have selected the language as \"JavaScript\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 126
 testRunner.When("I execute the script tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 127
 testRunner.Then("the execution has \"An\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Execute JavaScript with a non existent variable")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Javascript")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("JavascriptFeature")]
        public virtual void ExecuteJavaScriptWithANonExistentVariable()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Execute JavaScript with a non existent variable", ((string[])(null)));
#line 130
 this.ScenarioSetup(scenarioInfo);
#line 131
 testRunner.Given("I have this script to execute \"[[val2]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 132
 testRunner.And("I have selected the language as \"JavaScript\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
 testRunner.When("I execute the script tool", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 134
 testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
