// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.4.0.0
//      Runtime Version:4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
namespace GameOfLife.Spec
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Game Of Life Rules")]
    public partial class GameOfLifeRulesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "GameRules.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Game Of Life Rules", "In order to demonstrate that comple* patterns can emerge from a simple set of rul" +
                    "es\nAs a geek\nI want to play the game of life by the rules", GenerationTargetLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A live cell with no neighbours dies")]
        public virtual void ALiveCellWithNoNeighboursDies()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A live cell with no neighbours dies", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "0",
                        "1"});
            table1.AddRow(new string[] {
                        "*",
                        ""});
            table1.AddRow(new string[] {
                        "",
                        ""});
#line 7
 testRunner.Given("a game of life grid", ((string)(null)), table1);
#line 11
 testRunner.When("the next generation");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "0",
                        "1"});
            table2.AddRow(new string[] {
                        "",
                        ""});
            table2.AddRow(new string[] {
                        "",
                        ""});
#line 12
 testRunner.Then("the grid should be", ((string)(null)), table2);
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A live cell with one neighbour dies")]
        public virtual void ALiveCellWithOneNeighbourDies()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A live cell with one neighbour dies", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "0",
                        "1"});
            table3.AddRow(new string[] {
                        "*",
                        "*"});
            table3.AddRow(new string[] {
                        "",
                        ""});
#line 18
 testRunner.Given("a game of life grid", ((string)(null)), table3);
#line 22
 testRunner.When("the next generation");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "0",
                        "1"});
            table4.AddRow(new string[] {
                        "",
                        ""});
            table4.AddRow(new string[] {
                        "",
                        ""});
#line 23
 testRunner.Then("the grid should be", ((string)(null)), table4);
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A live cell with two live neighbours survives")]
        public virtual void ALiveCellWithTwoLiveNeighboursSurvives()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A live cell with two live neighbours survives", ((string[])(null)));
#line 28
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "0",
                        "1",
                        "2"});
            table5.AddRow(new string[] {
                        "*",
                        "",
                        ""});
            table5.AddRow(new string[] {
                        "",
                        "*",
                        ""});
            table5.AddRow(new string[] {
                        "",
                        "",
                        "*"});
#line 29
 testRunner.Given("a game of life grid", ((string)(null)), table5);
#line 34
 testRunner.When("the next generation");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "0",
                        "1",
                        "2"});
            table6.AddRow(new string[] {
                        "",
                        "",
                        ""});
            table6.AddRow(new string[] {
                        "",
                        "*",
                        ""});
            table6.AddRow(new string[] {
                        "",
                        "",
                        ""});
#line 35
 testRunner.Then("the grid should be", ((string)(null)), table6);
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A live cell with three live neighbours survives")]
        public virtual void ALiveCellWithThreeLiveNeighboursSurvives()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A live cell with three live neighbours survives", ((string[])(null)));
#line 41
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "0",
                        "1"});
            table7.AddRow(new string[] {
                        "*",
                        "*"});
            table7.AddRow(new string[] {
                        "*",
                        "*"});
#line 42
 testRunner.Given("a game of life grid", ((string)(null)), table7);
#line 46
 testRunner.When("the next generation");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "0",
                        "1"});
            table8.AddRow(new string[] {
                        "*",
                        "*"});
            table8.AddRow(new string[] {
                        "*",
                        "*"});
#line 47
 testRunner.Then("the grid should be", ((string)(null)), table8);
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A live cell with more than three live neighbours dies")]
        public virtual void ALiveCellWithMoreThanThreeLiveNeighboursDies()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A live cell with more than three live neighbours dies", ((string[])(null)));
#line 52
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "0",
                        "1",
                        "2"});
            table9.AddRow(new string[] {
                        "*",
                        "",
                        ""});
            table9.AddRow(new string[] {
                        "*",
                        "*",
                        "*"});
            table9.AddRow(new string[] {
                        "*",
                        "",
                        ""});
#line 53
 testRunner.Given("a game of life grid", ((string)(null)), table9);
#line 58
 testRunner.When("the next generation");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "0",
                        "1",
                        "2"});
            table10.AddRow(new string[] {
                        "*",
                        "",
                        ""});
            table10.AddRow(new string[] {
                        "*",
                        "",
                        ""});
            table10.AddRow(new string[] {
                        "*",
                        "",
                        ""});
#line 59
 testRunner.Then("the grid should be", ((string)(null)), table10);
#line hidden
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("A dead cell with exactly three live neighbours becomes a live cell")]
        public virtual void ADeadCellWithExactlyThreeLiveNeighboursBecomesALiveCell()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A dead cell with exactly three live neighbours becomes a live cell", ((string[])(null)));
#line 65
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "0",
                        "1",
                        "2"});
            table11.AddRow(new string[] {
                        "",
                        "",
                        ""});
            table11.AddRow(new string[] {
                        "",
                        "*",
                        "*"});
            table11.AddRow(new string[] {
                        "",
                        "*",
                        ""});
#line 66
 testRunner.Given("a game of life grid", ((string)(null)), table11);
#line 71
 testRunner.When("the next generation");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "0",
                        "1",
                        "2"});
            table12.AddRow(new string[] {
                        "",
                        "",
                        ""});
            table12.AddRow(new string[] {
                        "",
                        "*",
                        "*"});
            table12.AddRow(new string[] {
                        "",
                        "*",
                        "*"});
#line 72
 testRunner.Then("the grid should be", ((string)(null)), table12);
#line hidden
            testRunner.CollectScenarioErrors();
        }
    }
}
#endregion
