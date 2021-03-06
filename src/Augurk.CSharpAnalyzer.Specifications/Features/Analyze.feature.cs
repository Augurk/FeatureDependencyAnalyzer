﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Augurk.CSharpAnalyzer.Specifications.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class AnalyzeACProjectWithASingleTestProjectFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "Analyze.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner(null, 0);
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Analyze a C# project with a single test project", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Analyze a C# project with a single test project")))
            {
                global::Augurk.CSharpAnalyzer.Specifications.Features.AnalyzeACProjectWithASingleTestProjectFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When calls directly into a single entrypoint")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Analyze a C# project with a single test project")]
        public virtual void WhenCallsDirectlyIntoASingleEntrypoint()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When calls directly into a single entrypoint", null, ((string[])(null)));
#line 3
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 testRunner.Given("\'Cucumis.Specifications\' contains feature files", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 6
 testRunner.When("an analysis is run", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Kind",
                        "Local",
                        "Expression/Signature"});
            table1.AddRow(new string[] {
                        "When",
                        "",
                        "entrypoint is invoked directly"});
            table1.AddRow(new string[] {
                        "Public",
                        "true",
                        "Cucumis.Gardener.PlantGherkin(), Cucumis"});
            table1.AddRow(new string[] {
                        "Public",
                        "",
                        "System.Console.WriteLine(string), mscorlib"});
#line 7
 testRunner.Then("the resulting report contains \'When entrypoint is invoked directly\'", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Entrypoint is surrounded by other invocations")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Analyze a C# project with a single test project")]
        public virtual void EntrypointIsSurroundedByOtherInvocations()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Entrypoint is surrounded by other invocations", null, ((string[])(null)));
#line 13
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 15
 testRunner.Given("\'Cucumis.Specifications\' contains feature files", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
 testRunner.When("an analysis is run", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Kind",
                        "Local",
                        "Expression/Signature"});
            table2.AddRow(new string[] {
                        "When",
                        "",
                        "entrypoint is surrounded by other invocations"});
            table2.AddRow(new string[] {
                        "Public",
                        "",
                        "System.Console.WriteLine(string), mscorlib"});
            table2.AddRow(new string[] {
                        "Public",
                        "true",
                        "Cucumis.Gardener.PlantGherkin(), Cucumis"});
            table2.AddRow(new string[] {
                        "Public",
                        "",
                        "System.Console.WriteLine(string), mscorlib"});
            table2.AddRow(new string[] {
                        "Public",
                        "",
                        "Cucumis.Specifications.Support.ConsoleWriter.WriteDefaultMessage(), Cucumis.Speci" +
                            "fications"});
            table2.AddRow(new string[] {
                        "Public",
                        "",
                        "System.Console.WriteLine(string), mscorlib"});
#line 17
 testRunner.Then("the resulting report contains \'When entrypoint is surrounded by other invocations" +
                    "\'", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When invokes two seperate entrypoints")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Analyze a C# project with a single test project")]
        public virtual void WhenInvokesTwoSeperateEntrypoints()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When invokes two seperate entrypoints", null, ((string[])(null)));
#line 26
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 28
 testRunner.Given("\'Cucumis.Specifications\' contains feature files", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
 testRunner.When("an analysis is run", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Kind",
                        "Local",
                        "Expression/Signature"});
            table3.AddRow(new string[] {
                        "When",
                        "",
                        "two separate entrypoints are invoked"});
            table3.AddRow(new string[] {
                        "Public",
                        "true",
                        "Cucumis.Gardener.PlantGherkin(), Cucumis"});
            table3.AddRow(new string[] {
                        "Public",
                        "",
                        "System.Console.WriteLine(string), mscorlib"});
            table3.AddRow(new string[] {
                        "Public",
                        "true",
                        "Cucumis.Gardener.WaterPlants(), Cucumis"});
            table3.AddRow(new string[] {
                        "Public",
                        "",
                        "System.Console.WriteLine(string), mscorlib"});
#line 30
 testRunner.Then("the resulting report contains \'When two separate entrypoints are invoked\'", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("When an asynchronous entrypoint is invoked")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Analyze a C# project with a single test project")]
        public virtual void WhenAnAsynchronousEntrypointIsInvoked()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("When an asynchronous entrypoint is invoked", null, ((string[])(null)));
#line 38
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 40
 testRunner.Given("\'Cucumis.Specifications\' contains feature files", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 41
 testRunner.When("an analysis is run", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Kind",
                        "Local",
                        "Expression/Signature"});
            table4.AddRow(new string[] {
                        "When",
                        "",
                        "an asynchronous entrypoint is invoked"});
            table4.AddRow(new string[] {
                        "Public",
                        "true",
                        "Cucumis.Plant.Procreate(), Cucumis"});
            table4.AddRow(new string[] {
                        "Public",
                        "",
                        "System.Threading.Thread.Sleep(int), mscorlib"});
            table4.AddRow(new string[] {
                        "Public",
                        "",
                        "System.Threading.Tasks.Task.GetAwaiter(), mscorlib"});
            table4.AddRow(new string[] {
                        "Public",
                        "",
                        "System.Runtime.CompilerServices.TaskAwaiter.GetResult(), mscorlib"});
#line 42
 testRunner.Then("the resulting report contains \'When an asynchronous entrypoint is invoked\'", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
