using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitClass;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //[TestMethod]
        //public void Add_AddToEmptyList_ValueGoesToIndexZero()
        //{
        //    //arrange
        //    CustomClass<int> customclass = new CustomClass<int>();
        //    int[] inputValue = new int[] { };

        //    //assert
        //    customclass.Add(inputValue)

        //    Assert.AreSame(customclass[0], inputValue)
        //}

        [TestMethod]
        public void Remove_An_Object()
        {
           // Arrange
            CustomClass<string> list = new CustomClass<string>();
            list.Add("string1");
            list.Add("string2");
            list.Add("string3");
           // act
            list.Remove("string1");
           // Assert
            Assert.AreEqual(list.size, 2);
        }
        [TestMethod]
        public void Remove_Another_Object()
        {
            CustomClass<string> list = new CustomClass<string>();
            list.Add("string1");
            list.Add("string2");
           // act
            list.Remove("string1");
            //assert
            Assert.AreEqual(list.objects[0], "string1");
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

        [TestMethod]
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

        [TestMethod]
        public void Add_Six_Strings()
        {
            ////Arrange
            CustomClass<string> list = new CustomClass<string>();
            //Act
            list.Add("string1");
            list.Add("string2");
            list.Add("string3");
            list.Add("string");
            list.Add("string2");
            list.Add("string3");
            //Assert
            Assert.AreEqual(list.size, 6);

        }
        [TestMethod]
        public void Convert_ToString()
        {
            //Arrange
            CustomClass<int> list = new CustomClass<int>();
            list.Add(5);
            //Act
            string result = list.ToString();
            //Assert
            Assert.AreEqual(result, "10");
        }

    }
}

   
    

