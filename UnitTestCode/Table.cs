using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyQuanCafe;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;

namespace UnitTestCode
{
    /// <summary>
    /// Summary description for Table
    /// </summary>
    [TestClass]
    public class Table
    {
        #region Upadate
        // update lai bang Tablefood
         [TestMethod]
        public void UpDateTable_True()
        {
           // [id], [name], [status]
            int id = 2;
            string name = "Ban 2";
            string status = "Het cho";
            bool expected = true;
           Assert.AreEqual(expected, TableDAO.Instance.UpdateTable(id,name,status));
        } // khi update dữ liệu hàm có lấy đúng id ---> cập nhật lại dữ liệu ---> true
         [TestMethod]
         [ExpectedException(typeof(IndexOutOfRangeException))]
         public void UpDateTable_False_Am()
         {
             // [id], [name], [status]
             int id = -1;
             string name = "Ban 2";
             string status = "Het cho";
             bool expected = true;
             Assert.AreEqual(expected, TableDAO.Instance.UpdateTable(id, name, status));
             //Assert.Fail();
         } // khi update dữ liệu  id âm  ---> cập nhật lại dữ liệu ---> false
         [TestMethod]
         [ExpectedException(typeof(IndexOutOfRangeException))]
         public void UpDateTable_False_Chuoi()
         {
             // [id], [name], [status]
             //int id = Convert.ToString('abc');
             int id = Convert.ToInt32("Hello");
             string name = "Ban 2";
             string status = "Het cho";
             bool expected = true;
             Assert.AreEqual(expected, TableDAO.Instance.UpdateTable(id, name, status));
         } // khi update dữ liệu  id dạng chuỗi ---> cập nhật lại dữ liệu ---> false
         [TestMethod]
         [ExpectedException(typeof(IndexOutOfRangeException))]
          public void UpDateTable_False_Null()
         {
             // [id], [name], [status]
             //int id = Convert.ToString('abc');
             int id = ' ';
             string name = "Ban 2";
             string status = "Het cho";
             bool expected = true;
             Assert.AreEqual(expected, TableDAO.Instance.UpdateTable(id, name, status));
         } // khi update dữ liệu  id dạng null ---> cập nhật lại dữ liệu ---> false
         [TestMethod]
         [ExpectedException(typeof(IndexOutOfRangeException))]
         public void UpDateTable_False_NonExit()
         {
             // [id], [name], [status]
             //int id = Convert.ToString('abc');
             int id = 1000;
             string name = "Ban 2";
             string status = "Het cho";
             bool expected = true;
             Assert.AreEqual(expected, TableDAO.Instance.UpdateTable(id, name, status));
         } // khi update dữ liệu  id k có ---> cập nhật lại dữ liệu ---> false
        #endregion 
        #region Delete
         [TestMethod]
         public void DeleteTable_True()
         {
             // [id], [name], [status]
             int id = 11;
             bool expected = true;
             Assert.AreEqual(expected, TableDAO.Instance.DeleteTable(id));
         } // Delete thành công , id có tồn tại
         [TestMethod]
         [ExpectedException(typeof(IndexOutOfRangeException))]
         public void DeleteTable_False_Am()
         {
             // [id], [name], [status]
             int id = -1;
             bool expected = true;
             Assert.AreEqual(expected, TableDAO.Instance.DeleteTable(id));
         } // khi Delete dữ liệu  id âm  ---> cập nhật lại dữ liệu ---> false
         [TestMethod]
         [ExpectedException(typeof(IndexOutOfRangeException))]
         public void DeleteTable_False_Chuoi()
         {
             // [id], [name], [status]
             //int id = Convert.ToString('abc');
             int id = Convert.ToInt32("Hello");
             bool expected = true;
             Assert.AreEqual(expected, TableDAO.Instance.DeleteTable(id));
         } // khi Delete dữ liệu  id dạng chuỗi ---> cập nhật lại dữ liệu ---> false
         [TestMethod]
         [ExpectedException(typeof(IndexOutOfRangeException))]
         public void DeleteTable_False_Null()
         {
             // [id], [name], [status]
             //int id = Convert.ToString('abc');
             int id = ' ';
             bool expected = true;
             Assert.AreEqual(expected, TableDAO.Instance.DeleteTable(id));
         } // khi Delete dữ liệu  id dạng null ---> cập nhật lại dữ liệu ---> false
         [TestMethod]
         [ExpectedException(typeof(IndexOutOfRangeException))]
         public void DeleteTable_False_NonExit()
         {
             // [id], [name], [status]
             //int id = Convert.ToString('abc');
             int id = 1000;
             bool expected = true;
             Assert.AreEqual(expected, TableDAO.Instance.DeleteTable(id));
         } // khi Delete dữ liệu  id k có ---> cập nhật lại dữ liệu ---> false
        #endregion
         #region Insert
         [TestMethod]
         public void InsertTable_True()
         {
             // [id], [name], [status]
             //int id = 11;
             string name = "Ban 11";
             string status = "Trống";
             bool expected = true;
             Assert.AreEqual(expected, TableDAO.Instance.InsertTable(name,status));
         } // insert thành công id tự động , name, status

         #endregion
    }
}
