﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DbUnitTest
{
    [TestClass()]
    public class SqlServerUnitTestGetByAccountByUser : SqlDatabaseTestClass
    {

        public SqlServerUnitTestGetByAccountByUser()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction dbo_USP_GetAccountByUserNameTest_TestAction;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlServerUnitTestGetByAccountByUser));
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            this.dbo_USP_GetAccountByUserNameTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            dbo_USP_GetAccountByUserNameTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            // 
            // dbo_USP_GetAccountByUserNameTest_TestAction
            // 
            dbo_USP_GetAccountByUserNameTest_TestAction.Conditions.Add(rowCountCondition1);
            resources.ApplyResources(dbo_USP_GetAccountByUserNameTest_TestAction, "dbo_USP_GetAccountByUserNameTest_TestAction");
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 1;
            // 
            // dbo_USP_GetAccountByUserNameTestData
            // 
            this.dbo_USP_GetAccountByUserNameTestData.PosttestAction = null;
            this.dbo_USP_GetAccountByUserNameTestData.PretestAction = null;
            this.dbo_USP_GetAccountByUserNameTestData.TestAction = dbo_USP_GetAccountByUserNameTest_TestAction;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion


        [TestMethod()]
        public void dbo_USP_GetAccountByUserNameTest()
        {
            SqlDatabaseTestActions testActions = this.dbo_USP_GetAccountByUserNameTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        private SqlDatabaseTestActions dbo_USP_GetAccountByUserNameTestData;
    }
}
