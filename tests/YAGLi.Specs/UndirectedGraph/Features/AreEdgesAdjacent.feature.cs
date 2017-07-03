﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.2.0.0
//      SpecFlow Generator Version:2.2.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace YAGLi.Specs.UndirectedGraph.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.2.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Check if two edges are adjacent in a undirected graph")]
    public partial class CheckIfTwoEdgesAreAdjacentInAUndirectedGraphFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AreEdgesAdjacent.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Check if two edges are adjacent in a undirected graph", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check that two edges who share a common vertex in a undirected graph are adjacent" +
            "")]
        public virtual void CheckThatTwoEdgesWhoShareACommonVertexInAUndirectedGraphAreAdjacent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check that two edges who share a common vertex in a undirected graph are adjacent" +
                    "", ((string[])(null)));
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
 testRunner.Given("the property allow loops", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.And("the property allow parallel edges", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table1.AddRow(new string[] {
                        "v0"});
            table1.AddRow(new string[] {
                        "v1"});
            table1.AddRow(new string[] {
                        "v2"});
            table1.AddRow(new string[] {
                        "v3"});
            table1.AddRow(new string[] {
                        "v4"});
#line 6
 testRunner.And("the vertices", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "End1",
                        "End2"});
            table2.AddRow(new string[] {
                        "v0",
                        "v1"});
            table2.AddRow(new string[] {
                        "v1",
                        "v4"});
            table2.AddRow(new string[] {
                        "v4",
                        "v4"});
            table2.AddRow(new string[] {
                        "v4",
                        "v3"});
            table2.AddRow(new string[] {
                        "v4",
                        "v3"});
#line 13
 testRunner.And("the edges", ((string)(null)), table2, "And ");
#line 20
 testRunner.And("the undirected graph created with them", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "End1",
                        "End2"});
            table3.AddRow(new string[] {
                        "v0",
                        "v1"});
            table3.AddRow(new string[] {
                        "v1",
                        "v4"});
#line 21
 testRunner.When("I check if the following edges are adjacent", ((string)(null)), table3, "When ");
#line 25
 testRunner.Then("I get the answer true", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check that two vertices who do not share a common vertex in a undirected graph ar" +
            "e not adjacent")]
        public virtual void CheckThatTwoVerticesWhoDoNotShareACommonVertexInAUndirectedGraphAreNotAdjacent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check that two vertices who do not share a common vertex in a undirected graph ar" +
                    "e not adjacent", ((string[])(null)));
#line 27
this.ScenarioSetup(scenarioInfo);
#line 28
 testRunner.Given("the property allow loops", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
 testRunner.And("the property allow parallel edges", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table4.AddRow(new string[] {
                        "v0"});
            table4.AddRow(new string[] {
                        "v1"});
            table4.AddRow(new string[] {
                        "v2"});
            table4.AddRow(new string[] {
                        "v3"});
            table4.AddRow(new string[] {
                        "v4"});
#line 30
 testRunner.And("the vertices", ((string)(null)), table4, "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "End1",
                        "End2"});
            table5.AddRow(new string[] {
                        "v0",
                        "v1"});
            table5.AddRow(new string[] {
                        "v1",
                        "v4"});
            table5.AddRow(new string[] {
                        "v4",
                        "v4"});
            table5.AddRow(new string[] {
                        "v4",
                        "v3"});
            table5.AddRow(new string[] {
                        "v4",
                        "v3"});
#line 37
 testRunner.And("the edges", ((string)(null)), table5, "And ");
#line 44
 testRunner.And("the undirected graph created with them", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "End1",
                        "End2"});
            table6.AddRow(new string[] {
                        "v0",
                        "v1"});
            table6.AddRow(new string[] {
                        "v4",
                        "v4"});
#line 45
 testRunner.When("I check if the following edges are adjacent", ((string)(null)), table6, "When ");
#line 49
 testRunner.Then("I get the answer false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Check that two vertices with one not contains in the graph but who share a common" +
            " vertex are not adjacent")]
        public virtual void CheckThatTwoVerticesWithOneNotContainsInTheGraphButWhoShareACommonVertexAreNotAdjacent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check that two vertices with one not contains in the graph but who share a common" +
                    " vertex are not adjacent", ((string[])(null)));
#line 51
this.ScenarioSetup(scenarioInfo);
#line 52
 testRunner.Given("the property allow loops", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 53
 testRunner.And("the property allow parallel edges", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name"});
            table7.AddRow(new string[] {
                        "v0"});
            table7.AddRow(new string[] {
                        "v1"});
            table7.AddRow(new string[] {
                        "v2"});
            table7.AddRow(new string[] {
                        "v3"});
            table7.AddRow(new string[] {
                        "v4"});
#line 54
 testRunner.And("the vertices", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "End1",
                        "End2"});
            table8.AddRow(new string[] {
                        "e0",
                        "v0",
                        "v1"});
            table8.AddRow(new string[] {
                        "e1",
                        "v1",
                        "v4"});
            table8.AddRow(new string[] {
                        "e2",
                        "v4",
                        "v4"});
            table8.AddRow(new string[] {
                        "e3",
                        "v4",
                        "v3"});
            table8.AddRow(new string[] {
                        "e4",
                        "v4",
                        "v3"});
#line 61
 testRunner.And("the edges", ((string)(null)), table8, "And ");
#line 68
 testRunner.And("the undirected graph created with them", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "End1",
                        "End2"});
            table9.AddRow(new string[] {
                        "v0",
                        "v1"});
            table9.AddRow(new string[] {
                        "v0",
                        "v4"});
#line 69
 testRunner.When("I check if the following edges are adjacent", ((string)(null)), table9, "When ");
#line 73
 testRunner.Then("I get the answer false", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
