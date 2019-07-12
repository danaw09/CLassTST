using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitClass;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

        public void Add_AddToEmptyList_ValueGoesToIndexZero()
        {
            // arrange
            CustomClass<int> test = new CustomClass<int>();
            int expected = 10;
            int actual;
            // act
            test.Add(10);
            actual = test[0];
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Two_classes_For_Six_Values()
        {
            CustomClass<string> CustomClass = new CustomClass<string>();
            string inputValue1 = "1";
            string inputValue2 = "String 2";
            string inputValue3 = "String 3";
            string inputValue4 = "String 4";
            string inputValue5 = "String 5";
            string inputValue6 = "String 6";
            string expected = "String 6";
            // act
            CustomClass.Add(inputValue1);
            CustomClass.Add(inputValue2);
            CustomClass.Add(inputValue3);
            CustomClass.Add(inputValue4);
            CustomClass.Add(inputValue5);
            CustomClass.Add(inputValue6);
            int actual = 5;


            // assert
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void Adds_Count_For_One()
        {
            // arrange
            CustomClass<string> List = new CustomClass<string>();
            string inputValue = "String 1";
            int expected = 1;


            // act
            List.Add(inputValue);
            int actual = List.Count;

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void _Adds_Count_For_Three()
        {
            // arrange
            CustomClass<string> CustomClass = new CustomClass<string>();
            string inputValue1 = "String 1";
            string inputValue2 = "String 2";
            string inputValue3 = "String 3";
            int expected = 3;

            // act
            CustomClass.Add(inputValue1);
            CustomClass.Add(inputValue2);
            CustomClass.Add(inputValue3);
            int actual = CustomClass.Count;

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void _Adds_Count_For_Two()
        {
            // arrange
            CustomClass<string> customList = new CustomClass<string>();
            string inputValue1 = "one";
            string inputValue2 = "two";

            int expected = 2;
           


            // act
            customList.Add(inputValue1);
            customList.Add(inputValue2);

            int actual = customList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Adds_String_Checks_Count_For_One()
        {
            // arrange
            CustomClass<string> customList = new CustomClass<string>();
            string inputValue = " 1";
            int expected = 1;
            
            // act
            customList.Add(inputValue);
            int actual = customList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

    }

}   
    

