﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Restaurant.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class RestaurantCheckoutSystemFeature : object, Xunit.IClassFixture<RestaurantCheckoutSystemFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
        public RestaurantCheckoutSystemFeature(RestaurantCheckoutSystemFeature.FixtureData fixtureData, Restaurant_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en"), "Features", "Restaurant Checkout System", "Calculates the total bill including service charge and discounts based on item ty" +
                    "pe and time.", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Group of 4 orders full meals after 19")]
        [Xunit.TraitAttribute("FeatureTitle", "Restaurant Checkout System")]
        [Xunit.TraitAttribute("Description", "Group of 4 orders full meals after 19")]
        public void GroupOf4OrdersFullMealsAfter19()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Group of 4 orders full meals after 19", null, tagsOfScenario, argumentsOfScenario, featureTags);
            this.ScenarioInitialize(scenarioInfo);
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                testRunner.Given("a group of 4 orders 4 starters, 4 mains and 4 drinks at 20:00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
                testRunner.When("the bill is requested", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
                testRunner.Then("the total bill should be 58.40", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Group of 4 orders full meals at 19")]
        [Xunit.TraitAttribute("FeatureTitle", "Restaurant Checkout System")]
        [Xunit.TraitAttribute("Description", "Group of 4 orders full meals at 19")]
        public void GroupOf4OrdersFullMealsAt19()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Group of 4 orders full meals at 19", null, tagsOfScenario, argumentsOfScenario, featureTags);
            this.ScenarioInitialize(scenarioInfo);
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                testRunner.Given("a group of 4 orders 4 starters, 4 mains and 4 drinks at 19:00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
                testRunner.When("the bill is requested", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
                testRunner.Then("the total bill should be 58.40", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Group of 4 orders full meals before 19")]
        [Xunit.TraitAttribute("FeatureTitle", "Restaurant Checkout System")]
        [Xunit.TraitAttribute("Description", "Group of 4 orders full meals before 19")]
        public void GroupOf4OrdersFullMealsBefore19()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Group of 4 orders full meals before 19", null, tagsOfScenario, argumentsOfScenario, featureTags);
            this.ScenarioInitialize(scenarioInfo);
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                testRunner.Given("a group of 4 orders 4 starters, 4 mains and 4 drinks at 17:00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
                testRunner.When("the bill is requested", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
                testRunner.Then("the total bill should be 55.40", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Group of 2 orders, then 2 join later")]
        [Xunit.TraitAttribute("FeatureTitle", "Restaurant Checkout System")]
        [Xunit.TraitAttribute("Description", "Group of 2 orders, then 2 join later")]
        public void GroupOf2OrdersThen2JoinLater()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Group of 2 orders, then 2 join later", null, tagsOfScenario, argumentsOfScenario, featureTags);
            this.ScenarioInitialize(scenarioInfo);
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                testRunner.Given("a group of 2 orders 1 starters, 2 mains and 2 drinks at 18:00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
                testRunner.When("the intermediate bill is requested", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
                testRunner.Then("the intermediate bill at step 1 should be 23.30", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
                testRunner.Then("later at 20:00 2 more join and order 2 mains and 2 drinks", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
                testRunner.When("the final bill is requested", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
                testRunner.Then("the total bill should be 43.70", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Group of 4 orders, one cancels after 19")]
        [Xunit.TraitAttribute("FeatureTitle", "Restaurant Checkout System")]
        [Xunit.TraitAttribute("Description", "Group of 4 orders, one cancels after 19")]
        public void GroupOf4OrdersOneCancelsAfter19()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Group of 4 orders, one cancels after 19", null, tagsOfScenario, argumentsOfScenario, featureTags);
            this.ScenarioInitialize(scenarioInfo);
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                testRunner.Given("a group of 4 orders 4 starters, 4 mains and 4 drinks at 19:30", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
                testRunner.When("the intermediate bill is requested", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
                testRunner.Then("the intermediate bill at step 1 should be 58.40", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
                testRunner.Then("one member cancels their order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
                testRunner.When("the final bill is requested", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
                testRunner.Then("the total bill should be 43.80", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Group of 4 orders, one cancels at 19")]
        [Xunit.TraitAttribute("FeatureTitle", "Restaurant Checkout System")]
        [Xunit.TraitAttribute("Description", "Group of 4 orders, one cancels at 19")]
        public void GroupOf4OrdersOneCancelsAt19()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Group of 4 orders, one cancels at 19", null, tagsOfScenario, argumentsOfScenario, featureTags);
            this.ScenarioInitialize(scenarioInfo);
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                testRunner.Given("a group of 4 orders 4 starters, 4 mains and 4 drinks at 19:00", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
                testRunner.When("the intermediate bill is requested", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
                testRunner.Then("the intermediate bill at step 1 should be 58.40", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
                testRunner.Then("one member cancels their order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
                testRunner.When("the final bill is requested", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
                testRunner.Then("the total bill should be 43.80", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Group of 4 orders, one cancels before 19")]
        [Xunit.TraitAttribute("FeatureTitle", "Restaurant Checkout System")]
        [Xunit.TraitAttribute("Description", "Group of 4 orders, one cancels before 19")]
        public void GroupOf4OrdersOneCancelsBefore19()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Group of 4 orders, one cancels before 19", null, tagsOfScenario, argumentsOfScenario, featureTags);
            this.ScenarioInitialize(scenarioInfo);
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                testRunner.Given("a group of 4 orders 4 starters, 4 mains and 4 drinks at 18:30", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
                testRunner.When("the intermediate bill is requested", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
                testRunner.Then("the intermediate bill at step 1 should be 55.40", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
                testRunner.Then("one member cancels their order", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
                testRunner.When("the final bill is requested", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
                testRunner.Then("the total bill should be 41.55", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                RestaurantCheckoutSystemFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                RestaurantCheckoutSystemFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
