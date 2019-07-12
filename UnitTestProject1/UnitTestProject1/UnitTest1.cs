using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitClass;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        //public void Add_AddToEmptyList_ValueGoesToIndexZero()
        //{
        //    arrange
        //    CustomClass<int> test = new CustomClass<int>();
        //    int expected = 10;
        //    int actual;
        //    act
        //    test.Add(10);
        //    actual = test[0];
        //    assert
        //    Assert.AreEqual(expected, actual);
        //}

        [TestMethod]
        public void Remove_An_Object()
        {

        }



        [TestMethod]
        public void Add_OneObject_ToList()
        {
            //Arrange
            CustomClass<int> list = new CustomClass<int>();
            //Act
            list.Add(1);
            //Assert
            Assert.AreEqual(list.size, 1);
        }

       [ TestMethod]
        public void Add_Multiple_Strings()
        {
            ////Arrange
            CustomClass<string> list = new CustomClass<string>();
            //Act
            list.Add("string1");
            list.Add("string2");
            list.Add("string3");
            //Assert
            Assert.AreEqual(list.size, 3);
        }

    }
}

   
    

