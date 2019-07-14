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

        //[TestMethod]
        //public void Remove_An_Object()
        //{
        //   // Arrange
        //    CustomClass<string> list = new CustomClass<string>();
        //    list.Add("string1");
        //    list.Add("string2");
        //    list.Add("string3");
        //   // act
        //    list.Remove("string1");
        //   // Assert
        //    Assert.AreEqual(list.size, 2);
        //}
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
            string expect = list.ToString();
            //Assert
            Assert.AreEqual(expect, "5");
        }

        [TestMethod]
        public void _Check_For_Overloading_Plus_Operator()
        {

            //Arrange
            CustomClass<string> list = new CustomClass<string>();
            CustomClass<string> actualResult = new CustomClass<string>() { "string1", "string2", "string3", "string4" };
            list.Add("string1");
            list.Add("string2");
            CustomClass<string> secondList = new CustomClass<string>();
            secondList.Add("string3");
            secondList.Add("string4");
            bool compare = true;
            for (int i = 0; i < list.size; i++)
            {
                if (list.objects[i] != actualResult.objects[i])
                {
                    compare = false;
                }
            }
            //Act
            CustomClass<string> result = (list + secondList);
            //Assert
            Assert.IsTrue(compare);
        }


        [TestMethod]
        public void Zip_Lists_ReturnZippedList()
        {
            //Arrange
            CustomClass<string> list = new CustomClass<string>() { "string1", "string2" };
            CustomClass<string> secondList = new CustomClass<string>() { "string3", "string4" };
            CustomClass<string>  actual = new CustomClass<string> () { "string1", "string3", "string2", "string4" };
            //Act
            CustomClass<string> result = list.Zip(list, secondList);
            bool compare = true;
            for (int i = 0; i < list.size; i++)
            {
                if (result.objects[i] != actual.objects[i])
                {
                    compare = false;
                }
            }
            //Assert
            Assert.IsTrue(compare);

        }




        [TestMethod]
        public void Overloading_PlusOperator()
        {

        }




        [TestMethod]
        public void Overloading_MinusOperator()
        {
            //Arrange
            CustomClass<string> list = new CustomClass<string>() { "one", "two" };
            CustomClass<string>  second = new CustomClass<string>() { "three", "four" };
            CustomClass<string> actualResult = new CustomClass<string>() { "one", "two" };
            CustomClass<string> combinedList = (list + second);
            bool compare = true;
            for (int i = 0; i < list.size; i++)
            {
                if (list.objects[i] != actualResult.objects[i])
                {
                    compare = false;
                }
            }
            //Act
            CustomClass<string> result = (combinedList - second);
            //Assert
            Assert.IsTrue(compare);







        }



    }
}

   
    

