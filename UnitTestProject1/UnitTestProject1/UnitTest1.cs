using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitClass;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void _AddToEmptyList_ValueGoesToIndexZero()
        {
            //arrange
            CustomClass<int> customclass = new CustomClass<int>();
            int expected = 10;
            int actual;
            //act
            customclass.Add(10);
            actual = customclass[0];
            //assert
            Assert.AreEqual(expected, actual);
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

    }
}

   
    

