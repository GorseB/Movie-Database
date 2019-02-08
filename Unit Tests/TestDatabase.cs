using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Unit_Tests
{
    [TestClass]
    public class TestDatabase
    {
        [TestMethod]
        public void Database()
        {
            Test();
        }

        public void Test()
        {
            SqlConnection SCNT = new SqlConnection();
            SqlCommand SCMD = new SqlCommand();
            SqlDataAdapter DA = new SqlDataAdapter();
            string ConnectionString = null;
            string ConfigPath = @".\blockbusted_config.bin";
            ConnectionString = System.IO.File.ReadAllText(ConfigPath);
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            SCNT.ConnectionString = ConnectionString;
            SCMD.Connection = SCNT;
            DataTable DT = new DataTable();
            using (DA = new SqlDataAdapter("select * from Movies", SCNT))
            {
                DA.Fill(DT);
                SCNT.Close();
            }
            if (DT.Rows.Count >= 1)
            {
                Assert.AreEqual(1, 1);
            }
            else
            {
                Assert.Fail();
            }
        }

        // (60) Does about exactly the same thing as "Check Connection String" only outside of the program, takes on average 3 seconds to pull the whole table from SQL
        // Could be modified to take less time if someone wanted to.
    }
}