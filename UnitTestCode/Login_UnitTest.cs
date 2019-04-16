using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyQuanCafe;
using QuanLyQuanCafe.DAO;

namespace UnitTestCode
{
    [TestClass]
    public class Login_UnitTest
    {
        //public frmLogin login;
        [TestMethod]
        public void TestSignIn_True()
        {
            //login = new frmLogin();
            bool expected = true;
            Assert.AreEqual(expected, AccountDAO.Instance.Login("K9", "1")); // true trả lại 

        }//tên đăng nhập, mật khẩu đúng
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestSignIn_False_Pass()
        {
            //login = new frmLogin();
            AccountDAO.Instance.Login("K9", "12"); /// user , pass k đúng 
        }// tên đăng nhập đúng , mật khẩu sai
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestSignIn_False_NullTk()
        {
            //login = new frmLogin();
            AccountDAO.Instance.Login("", "1"); /// user , pass k đúng 
        }// tên đăng nhập null , k mật khẩu
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestSignIn_False_PassNULL()
        {
            //login = new frmLogin();
            AccountDAO.Instance.Login("K9", ""); /// user , pass k đúng 
        }// tên đăng nhập đúng , k mật khẩu

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestSignIn_False_User()
        {
            //login = new frmLogin();
           AccountDAO.Instance.Login("K10", "1");  // User k tồn tại
        }// tên đăng nhập sai, mật khẩu đúng

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestSignIn_False()
        {
            //login = new frmLogin();
           AccountDAO.Instance.Login("an", "12");
        }// tên đăng nhập sai , mật khẩu sai


        //test form signup
        //public frmsignup signup;
        [TestMethod, Ignore]
        public void testsignup_true()
        {
            //signup = new frmsignup();
            bool expected = true; 
            Assert.AreEqual(expected, AccountDAO.Instance.Login("K9", "1"));

        }//tên đăng nhập, mật khẩu đúng --> muốn test lại, phải đổi user

    }
}
