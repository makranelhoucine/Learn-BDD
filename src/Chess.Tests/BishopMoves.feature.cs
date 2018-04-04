﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.0.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Chess.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class BishopMovesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
#line 1 "BishopMoves.feature"
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
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Bishop Moves", "<table margin=\'5\'>\r\n\t<tr>\r\n\t\t<td>\r\n\t\t\t<img src =\'./Board.png\' alt=\'Board\' width=\'" +
                    "200\' height=\'200\' />\r\n\t\t</td>\r\n\t\t<td>\r\n\t\tIn order follow the chess game rules<br" +
                    "/>\r\n\t\tAs a <b>Bishop</b><br/>\r\n\t\tI have to respect some move rules\r\n\t\t</td>\r\n\t</" +
                    "tr>\r\n</table>", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "Bishop Moves")))
            {
                global::Chess.Tests.BishopMovesFeature.FeatureSetup(null);
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
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(TestContext);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void AWhiteBishopCanMoveDiagonaly(string initialPosition, string validPositions, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Bishop"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A white bishop can move diagonaly", @__tags);
#line 16
this.ScenarioSetup(scenarioInfo);
#line 18
 testRunner.Given(string.Format("A bishop is placed at the initial position {0}", initialPosition), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
 testRunner.And("The piece color is White", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.When("I ask for bishop valid moves", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.Then(string.Format("Moves to the positions {0} are valid", validPositions), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A white bishop can move diagonaly: 33")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Bishop Moves")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Bishop")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "33")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:InitialPosition", "33")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ValidPositions", "22,11,44,55,66,77,88,24,15,42,51")]
        public virtual void AWhiteBishopCanMoveDiagonaly_33()
        {
#line 16
this.AWhiteBishopCanMoveDiagonaly("33", "22,11,44,55,66,77,88,24,15,42,51", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A white bishop can move diagonaly: 88")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Bishop Moves")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Bishop")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "88")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:InitialPosition", "88")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:ValidPositions", "77,66,55,44,33,22,11")]
        public virtual void AWhiteBishopCanMoveDiagonaly_88()
        {
#line 16
this.AWhiteBishopCanMoveDiagonaly("88", "77,66,55,44,33,22,11", ((string[])(null)));
#line hidden
        }
        
        public virtual void ABlackBishopCanNotGoOutsideBoardBounds(string initialPosition, string invalidPositions, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Bishop"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A black bishop can not go outside board bounds", @__tags);
#line 29
this.ScenarioSetup(scenarioInfo);
#line 30
 testRunner.Given(string.Format("A bishop is placed at the initial position {0}", initialPosition), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 31
 testRunner.And("The piece color is Black", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.When("I ask for bishop valid moves", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
 testRunner.Then(string.Format("Moves to the positions {0} are invalid", invalidPositions), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("A black bishop can not go outside board bounds: 18")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Bishop Moves")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Bishop")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "18")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:InitialPosition", "18")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:InvalidPositions", "09,29,07")]
        public virtual void ABlackBishopCanNotGoOutsideBoardBounds_18()
        {
#line 29
this.ABlackBishopCanNotGoOutsideBoardBounds("18", "09,29,07", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
