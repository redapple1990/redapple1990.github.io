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
namespace Enable_UIAutomation.Features.Factfind_V2.Admin.Factfind_Editor.Factfind_Template.Fact_Find
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("FactFind", new string[] {
            "Reg"}, Description="\tAs an advisor I want to create bespoke fact find templates\r\n\tSo that I can captu" +
        "re my customers needs and objectives in fact finds of my design", SourceFile="Features\\Factfind_V2\\Admin\\Factfind_Editor\\Factfind_Template\\Fact_Find\\FactFind.f" +
        "eature", SourceLine=1)]
    public partial class FactFindFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FactFind.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FactFind", "\tAs an advisor I want to create bespoke fact find templates\r\n\tSo that I can captu" +
                    "re my customers needs and objectives in fact finds of my design", ProgrammingLanguage.CSharp, new string[] {
                        "Reg"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("New Fact Find Template Modal", new string[] {
                "LoginEnableTaur"}, SourceLine=6)]
        public virtual void NewFactFindTemplateModal()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("New Fact Find Template Modal", null, new string[] {
                        "LoginEnableTaur"});
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 testRunner.Given("I am on the fact find admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.When("I click on add new fact find", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then("the Fact Find entry modal dialog displays", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void AddFactFindTemplate(string title, string description, string notes, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Smoke",
                    "LoginEnableTaur"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Fact Find Template", null, @__tags);
#line 14
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 15
 testRunner.Given("I am on the fact find admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
 testRunner.When(string.Format("I add a new Fact Find with \"{0}\", \"{1}\" and \"{2}\"", title, description, notes), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.Then("I see my new Fact Find in the Fact finds area", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add Fact Find Template, New Fact Find", new string[] {
                "Smoke",
                "LoginEnableTaur"}, SourceLine=19)]
        public virtual void AddFactFindTemplate_NewFactFind()
        {
#line 14
this.AddFactFindTemplate("New Fact Find", "A nice new Fact Find", "NewFactFindNotes", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add Cancel Fact Find Template", new string[] {
                "LoginEnableTaur"}, SourceLine=22)]
        public virtual void AddCancelFactFindTemplate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Cancel Fact Find Template", null, new string[] {
                        "LoginEnableTaur"});
#line 23
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 24
 testRunner.Given("I am on the fact find admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
 testRunner.And("I click on add new fact find", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.And("I enter \"Title\", \"Description\" and \"Notes\" for the Fact Find", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.When("I cancel on the FactFind modal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 28
 testRunner.Then("dont see the Fact Find entry modal", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Edit Fact Find Template", new string[] {
                "LoginEnableTaur"}, SourceLine=30)]
        public virtual void EditFactFindTemplate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Fact Find Template", null, new string[] {
                        "LoginEnableTaur"});
#line 31
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 32
 testRunner.Given("I am on the fact find admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 33
 testRunner.And("I create a Fact Find modal with title \"NewFactFind_00_Title\", description \"NewFac" +
                    "tFind_00 Desc\" and notes \"NewFactFind_00 Notes\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 34
 testRunner.And("I select the current Fact Find", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("I change the Fact Find title \"Title Modified\", description \"Description updated\" " +
                    "and notes \"Notes updated\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.When("I save the Fact Find", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 37
 testRunner.Then("I see the notification \"Saved The fact find has been saved\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Mandatory Validation Fact Find Template", new string[] {
                "validation",
                "LoginEnableTaur"}, SourceLine=40)]
        public virtual void MandatoryValidationFactFindTemplate()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mandatory Validation Fact Find Template", null, new string[] {
                        "validation",
                        "LoginEnableTaur"});
#line 41
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 42
 testRunner.Given("I am on the fact find admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 43
 testRunner.And("I click on New Fact Find button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 44
 testRunner.And("I save the Fact Find", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
 testRunner.And("I can see \"Title\" with highlight", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("I can see \"Description\" with highlight", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.And("I can see \"Notes\" with highlight", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 48
 testRunner.And("I enter \"NewFactFind_03\", \"NewFactFind_03_Desc\" and \"Notes\" for the Fact Find", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.When("I save the Fact Find", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 50
 testRunner.Then("I can see the Objectives and Assignments section", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Mandatory Validation for Fact Find Objectives", new string[] {
                "validation",
                "LoginEnableTaur"}, SourceLine=53)]
        public virtual void MandatoryValidationForFactFindObjectives()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mandatory Validation for Fact Find Objectives", null, new string[] {
                        "validation",
                        "LoginEnableTaur"});
#line 54
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 55
 testRunner.Given("I am on the fact find admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 56
 testRunner.And("I click on add new fact find", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 57
 testRunner.And("I enter \"NewFactFind_04\", \"NewFactFind_04_Desc\" and \"Notes\" for the Fact Find", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.And("I save the Fact Find", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 59
 testRunner.And("I save the objectives", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 60
 testRunner.And("I can see the highlight for Objective Field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.And("I enter the objectives as \"Asset\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 62
 testRunner.When("I save the objectives", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 63
 testRunner.Then("I can see the saved objectives", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Mandatory Validation for Fact Find Assignments", new string[] {
                "validation",
                "LoginEnableTaur"}, SourceLine=66)]
        public virtual void MandatoryValidationForFactFindAssignments()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Mandatory Validation for Fact Find Assignments", null, new string[] {
                        "validation",
                        "LoginEnableTaur"});
#line 67
 this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 68
 testRunner.Given("I am on the fact find admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 69
 testRunner.And("I click on add new fact find", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.And("I enter \"NewFactFind_05\", \"NewFactFind_05_Desc\" and \"Notes\" for the Fact Find", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
 testRunner.And("I save the Fact Find", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.And("I save the Assignments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.And("I can see the highlight for Client Type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.And("I select the client type as \"Pension\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.When("I save the Assignments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 76
 testRunner.Then("I can see the saved Assignments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add Mandatory Objective in Fact Find", new string[] {
                "Smoke",
                "FactFind"}, SourceLine=79)]
        public virtual void AddMandatoryObjectiveInFactFind()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Mandatory Objective in Fact Find", null, new string[] {
                        "Smoke",
                        "FactFind"});
#line 80
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 81
 testRunner.Given("I am on the fact find admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 82
    testRunner.And("I open an existing fact find record", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.And("I create a new objective with objective as \"A new objective\" and description as \"" +
                    "An objective description\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.When("I save the objectives", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 85
 testRunner.Then("I can see the mandatory objective as a new row", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Delete an Objective from Fact Find", new string[] {
                "FactFind"}, SourceLine=87)]
        public virtual void DeleteAnObjectiveFromFactFind()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete an Objective from Fact Find", null, new string[] {
                        "FactFind"});
#line 88
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 89
 testRunner.Given("I am on the fact find admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 90
    testRunner.And("I open an existing fact find record", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 91
 testRunner.And("I create a new objective with objective as \"A new objective\" and description as \"" +
                    "An objective description\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("I save the objectives", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("I can see the mandatory objective as a new row", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.When("I choose to delete the objective", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
 testRunner.Then("new objective is deleted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        public virtual void AddLiveNetworkAndMemberAssignmentInFactFind(string assign_Type, string assignee, string client_Type, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "FactFind"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add live Network and Member assignment in Fact find", null, @__tags);
#line 98
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 99
 testRunner.Given("I am on the fact find admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 100
    testRunner.And("I open an existing fact find record", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
    testRunner.And(string.Format("I create a new \"{0}\" for \"{1}\" of \"{2}\"", assign_Type, assignee, client_Type), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
    testRunner.And("I opt to make it live", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
    testRunner.And("I save assignments", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
    testRunner.Then(string.Format("I see my new live \"{0}\" Assignment created as a new row", assign_Type), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add live Network and Member assignment in Fact find, Variant 0", new string[] {
                "FactFind"}, SourceLine=106)]
        public virtual void AddLiveNetworkAndMemberAssignmentInFactFind_Variant0()
        {
#line 98
this.AddLiveNetworkAndMemberAssignmentInFactFind("Member", "Advisa Financial Services Ltd", "Individual", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add live Network and Member assignment in Fact find, Variant 1", new string[] {
                "FactFind"}, SourceLine=106)]
        public virtual void AddLiveNetworkAndMemberAssignmentInFactFind_Variant1()
        {
#line 98
this.AddLiveNetworkAndMemberAssignmentInFactFind("Network", "DMA", "Trust", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Add live Network and Member assignment in Fact find, Variant 2", new string[] {
                "FactFind"}, SourceLine=106)]
        public virtual void AddLiveNetworkAndMemberAssignmentInFactFind_Variant2()
        {
#line 98
this.AddLiveNetworkAndMemberAssignmentInFactFind("Network", "Quantum IMS", "Pension", ((string[])(null)));
#line hidden
        }
        
        public virtual void EditFactFindObjective(string objective, string objective_Description, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "FactFind"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Edit Fact Find Objective", null, @__tags);
#line 112
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 113
    testRunner.Given("I am on the fact find admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 114
 testRunner.And("I open an existing fact find record", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
    testRunner.And("I create a new objective with objective as \"Personal Details\" and description as " +
                    "\"Personal Details description\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
    testRunner.And("I save the objective", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
    testRunner.And("I can see the mandatory objective as a new row", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
    testRunner.When("I choose to edit the objective", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 119
 testRunner.And(string.Format("I change objective to \"{0}\" and description as \"{1}\"", objective, objective_Description), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.And("I save the objective", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.Then(string.Format("I can see the objective as \"{0}\" and description as \"{1}\"", objective, objective_Description), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Edit Fact Find Objective, Personal Details1", new string[] {
                "FactFind"}, SourceLine=123)]
        public virtual void EditFactFindObjective_PersonalDetails1()
        {
#line 112
this.EditFactFindObjective("Personal Details1", "Personal Details description1", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Clear Fact Find Objective", new string[] {
                "FactFind"}, SourceLine=127)]
        public virtual void ClearFactFindObjective()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Clear Fact Find Objective", null, new string[] {
                        "FactFind"});
#line 128
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 129
 testRunner.Given("I am on the fact find admin page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 130
 testRunner.And("I open an existing fact find record", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 131
 testRunner.And("I create a new objective with objective as \"Objective\" and description as \"Object" +
                    "ive description\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 132
 testRunner.And("I clear the objective", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 133
 testRunner.Then("the objective input fields are cleared", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
