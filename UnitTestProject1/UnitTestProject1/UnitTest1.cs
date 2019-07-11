using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitClass;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            public void Add_Two_classes_For_Six_Values()
            {
                // arrange
                CustomList<string> customList = new CustomList<string>();

                string inputValue1 = "String 1";
                string inputValue2 = "String 2";
                string inputValue3 = "String 3";
                string inputValue4 = "String 4";
                string inputValue5 = "String 5";
                string inputValue6 = "String 6";
                int expected = "String 6";
                // act
                customList.Add(inputValue1);
                customList.Add(inputValue2);
                customList.Add(inputValue3);
                customList.Add(inputValue4);
                customList.Add(inputValue5);
                customList.Add(inputValue6);
                int actual = customList[5];


                // assert
                Assert.AreEqual(expected, actual);


            }



            public void Add_Three_Strings()
            {
                CustomList<int> customlist = new CustomList<int>();
                string inputValue = "string 1";
                string inputValue = "string 2";
                string inputValue = "string 3";

                //act
                customList.Add(inputValue1);
                customList.Add(inputValue2);
                customList.Add(inputValue3);
                int actual = customList.Count;
                //assert
                Assert.AreEqual(expected, actual);

            }



            public void Adds_String_Checks_For_Two()
            {
                // arrange
                CustomList<string> customList = new CustomList<string>();
                string inputValue1 = "one";
                string inputValue2 = "two";

                int expected = 2;
                int actual;

                // act
                customList.Add(inputValue1);
                customList.Add(inputValue2);

                int actual = customList.Count;

                // assert
                Assert.AreEqual(expected, actual);
            }

            public void Add_AddToEmptyList_ValueGoesToIndexZero()
            {
                // arrange
                CustomList<int> test = new CustomList<int>();
                int expected = 10;
                int actual;
                // act
                test.Add(10);
                actual = test[0];
                // assert
                Assert.AreEqual(expected, actual);
            }


            public void Adds_String_Checks_Count_For_One()
            {
                // arrange
                CustomList<string> customList = new CustomList<string>();
                string inputValue = " 1";
                int expected = 1;
                actual;
                // act
                customList.Add(inputValue);
                int actual = customList.Count;

                // assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
    

