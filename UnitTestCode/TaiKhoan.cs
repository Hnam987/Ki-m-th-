using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
namespace UnitTestCode
{
    /// <summary>
    /// Summary description for TaiKhoan
    /// </summary>
    [TestClass]
    public class TaiKhoan
    {
        #region Upadate
        // update lai TaiKHoan
        [TestMethod]
        public void UpDateAccount_True()
        {
            string userName ="K9";
            string disPlayName = "Admin";
            string pass = "1234";
            string type = "1";
            bool expected = true;
            Assert.AreEqual(expected,AccountDAO.Instance.UpdateAccount(userName,disPlayName,pass,type));
        } // khi update dữ liệu hàm có lấy đúng User Name ---> cập nhật lại dữ liệu ---> true
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void UpDateAccount_False_Exit()
        {
            string userName = "K10";
            string disPlayName = "Admin";
            string pass = "1234";
            string type = "1";
            bool expected = true;
            Assert.AreEqual(expected, AccountDAO.Instance.UpdateAccount(userName, disPlayName, pass, type));
            //Assert.Fail();
        } // khi update dữ liệu  UserName k tồn tại ---> cập nhật lại dữ liệu ---> false
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void UpDateAccount_False_null()
        {
            string userName = "";
            string disPlayName = "Admin";
            string pass = "1234";
            string type = "1";
            bool expected = true;
            Assert.AreEqual(expected, AccountDAO.Instance.UpdateAccount(userName, disPlayName, pass, type));
        } // khi update dữ liệu  id dạng null ---> cập nhật lại dữ liệu ---> false
      
        #endregion
        #region Delete
        [TestMethod]
        public void DeleteAccount_True()
        {
            string userName = "staff";
            bool expected = true;
            Assert.AreEqual(expected, AccountDAO.Instance.DeleteAccount(userName));
        } // Delete thành công , userName có tồn tại
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void DeleteAccount_False_null()
        {
            string userName = "";
            bool expected = true;
            Assert.AreEqual(expected, AccountDAO.Instance.DeleteAccount(userName));
        } // khi Delete dữ liệu  id null ---> cập nhật lại dữ liệu ---> false
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void DeleteAccount_False_notExit()
        {
            string userName = "abc";
            bool expected = true;
            Assert.AreEqual(expected, AccountDAO.Instance.DeleteAccount(userName));
        } // khi Delete dữ liệu  userName k tồn tại ---> cập nhật lại dữ liệu ---> false
       
        #endregion
        #region Insert
        [TestMethod]
        public void InsertAccount_True()
        {
            string userName = "ABC";
            string disPlayName = "Admin";
            string pass = "1234";
            string type = "1";
            bool expected = true;
            Assert.AreEqual(expected, AccountDAO.Instance.UpdateAccount(userName, disPlayName, pass, type));
        } // khi Thêm dữ liệu hàm có lấy  User Name  k tồn tại---> cập nhật lại dữ liệu ---> true
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void InsertAccount_False_Exit()
        {
            string userName = "K9";
            string disPlayName = "Admin";
            string pass = "1234";
            string type = "1";
            bool expected = true;
            Assert.AreEqual(expected, AccountDAO.Instance.UpdateAccount(userName, disPlayName, pass, type));
            //Assert.Fail();
        } // khi Thêm dữ liệu  UserName k tồn tại ---> cập nhật lại dữ liệu ---> false
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void InsertAccount_False_null()
        {
            string userName = " ";
            string disPlayName = "Admin";
            string pass = "1234";
            string type = "1";
            bool expected = true;
            Assert.AreEqual(expected, AccountDAO.Instance.UpdateAccount(userName, disPlayName, pass, type));
        } // khi update dữ liệu  id dạng null ---> cập nhật lại dữ liệu ---> false

        #endregion
    }
}
