using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitClass;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_AddToEmptyList_ValueGoesToIndexZero()
        {
            // arrange
            customList<int> test = new customList<int>();
            int expected = 10;
            int actual;
            // act
            test.Add(10);
            actual = test [0];
            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_Two_classes_For_Six_Values()
        {
            customList<int> customlist = new customList<int>();
            string inputValue1 = "1";
            string inputValue2 = "String 2";
            string inputValue3 = "String 3";
            string inputValue4 = "String 4";
            string inputValue5 = "String 5";
            string inputValue6 = "String 6";
            int expected = 6;
            // act
            customlist.Add(inputValue1);
            customlist.Add(inputValue2);
            customlist.Add(inputValue3);
            customlist.Add(inputValue4);
            customlist.Add(inputValue5);
            customlist.Add(inputValue6);
            int actual = customlist[5];


            // assert
            Assert.AreEqual(expected, actual);


        }
        [TestMethod]
        public void Custom_List_Adds_String_Checks_Count_For_One()
        {
            // arrange
            customList<int> List = new customList<int>();
            string inputValue = "String 1";
            int expected = 1;
            

            // act
            List.Add(inputValue);
            int actual = List.Count;

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Custom_List_Adds_String_Checks_Count_For_Three()
        {
            // arrange
            customList<int> list = new customList<int>();
            string inputValue1 = "String 1";
            string inputValue2 = "String 2";
            string inputValue3 = "String 3";
            int expectedCount = 3;

            // act
            list.Add(inputValue1);
            list.Add(inputValue2);
            list.Add(inputValue3);
            int actualCount = list.Count;

            // assert
            Assert.AreEqual(expectedCount, actualCount);

        }




}   }
    

