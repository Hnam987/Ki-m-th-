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
    /// Summary description for UnitTest
    /// </summary>
    [TestClass]
    public class UnitTest
    {
        #region insert
        [TestMethod]
        public void insertFood_true()
        {
            bool expected = true;
            string name ="Capuchino" ;
            int idCategory = 5 ;
            float price = 35000;
            Assert.AreEqual(expected, FoodDAO.Instance.InsertFood(name,idCategory,price)); // true trả lại 
        } // Them DỮ LIỆU đúng . id tự tăng 

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void insertFood_false()
        {
            bool expected = true;
            string name = "Capuchino";
            int idCategory = 7;
            float price = 35000;
            Assert.AreEqual(expected, FoodDAO.Instance.InsertFood(name, idCategory, price)); // true trả lại 
        } // Them DỮ LIỆU sai . id tự tăng đúng , idcategory k đúng 
        // xóa 
         [TestMethod]
        public void DeleteFood_true()
        {
            bool expected = true;
            int id = 3;
            Assert.AreEqual(expected, FoodDAO.Instance.DeleteFood(id)); // true trả lại 
        } // xóa DỮ LIỆU đúng . id đúng
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void DeleteFood_false_exit()
        {
            bool expected = true;
            int id = 1;
            Assert.AreEqual(expected, FoodDAO.Instance.DeleteFood(id)); // true trả lại 
        } // xóa DỮ LIỆU sai . id k tồn tại , 
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void DeleteFood_false_bienduoi()
        {
            bool expected = true;
            int id = 0;
            Assert.AreEqual(expected, FoodDAO.Instance.DeleteFood(id)); // true trả lại 
        } // xóa DỮ LIỆU sai . id = 0 sát biên 1 
        // trường hợp biên trên thì trong trường hợp này k sai . id tăng nên id k giới hạn k xác định dc cận biên trên
        //----------------------------UpdateFood//
        [TestMethod]
        public void UpDateFood_True()
        {
            bool expected = true;
            int id = 4;
            string name = "Nước cam";
            int idCategory = 5;
            float price =30000;
            Assert.AreEqual(expected, FoodDAO.Instance.UpdateFood(id,name,idCategory,price)); // true trả lại 
        } // update DỮ LIỆU đúng . id chính xác , idcategory cũng chính xác
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void UpDateFood_false()
        {
            bool expected = true;
            int id = 4;
            string name = "Nước cam";
            int idCategory = 5;
            float price = 30000;
            Assert.AreEqual(expected, FoodDAO.Instance.UpdateFood(id, name, idCategory, price)); // true trả lại 
        } // update DỮ LIỆU đúng . id chính xác , idcategory không chính xác
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void UpDateFood_false_notExit()
        {
            bool expected = true;
            int id = 4;
            string name = "Nước cam";
            int idCategory = 5;
            float price = 30000;
            Assert.AreEqual(expected, FoodDAO.Instance.UpdateFood(id, name, idCategory, price)); // true trả lại 
        } // update DỮ LIỆU đúng . id không chính xác  , idcategory không chính xác
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void UpDateFood_false_Id()
        {
            bool expected = true;
            int id = 4;
            string name = "Nước cam";
            int idCategory = 5;
            float price = 30000;
            Assert.AreEqual(expected, FoodDAO.Instance.UpdateFood(id, name, idCategory, price)); // true trả lại 
        } // update DỮ LIỆU đúng . id không chính xác  , idcategory chính xác
        #endregion
    }
}
