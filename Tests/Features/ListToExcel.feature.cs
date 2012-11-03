﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.17929
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("List of objects export to excel")]
    public partial class ListOfObjectsExportToExcelFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ListToExcel.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "List of objects export to excel", "In order to export a list of objetcs\r\nAs user\r\nI want to export to excel", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
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
        [NUnit.Framework.DescriptionAttribute("Export list of person")]
        public virtual void ExportListOfPerson()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Export list of person", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Name",
                        "LastName",
                        "BirthDay",
                        "Country",
                        "Sex",
                        "NumberOfChildren",
                        "Height"});
            table1.AddRow(new string[] {
                        "Cosme",
                        "Fulanito",
                        "01/01/1980",
                        "Mexico",
                        "Male",
                        "0",
                        "1.70"});
            table1.AddRow(new string[] {
                        "Maria",
                        "Gomez",
                        "02/02/1980",
                        "Panama",
                        "Female",
                        "2",
                        "1.60"});
            table1.AddRow(new string[] {
                        "John",
                        "Doe",
                        "03/03/1975",
                        "USA",
                        "Male",
                        "1",
                        "1.90"});
#line 7
 testRunner.Given("a this list of persons", ((string)(null)), table1);
#line 12
 testRunner.Then("export the list to a excel file located in:\'C:\\output.xls\'");
#line 13
 testRunner.Then("export the list with header format to a excel file located in:\'C:\\outputh.xls\'");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
