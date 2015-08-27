using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using areaLib;

namespace triangleTest
{
    [TestClass]
    public class ClassLibrary1Test
    {
        // unit test code
       [TestMethod]
        public void Test_Triangle_Сhypotenuse()
        {
            // arrange
            double a = 5;
            double b = 3;
            double expected = 5.831;

            // act
            double actual = triangle.Сhypotenuse(a, b);

            // assert            
            Assert.AreEqual(expected, actual, 0.001, "Неверные расчеты");
        }
        [TestMethod]
        public void Test_Triangle_Area()
        {
            // arrange
            double a = 5;
            double b = 5;
            double c = 7.071;
            double expected = 12.5;

            // act
            double actual = triangle.Striangle(a, b, c);

            // assert            
            Assert.AreEqual(expected, actual, 0.001, "Неверные расчеты");
        }
        [TestMethod]
        public void Test_Triangle_Сhypotenuse_Zero()
        {
            //arrange
            double a = 0;
            double b = 0;
                       

            try
            {
                //act
                double actual = triangle.Сhypotenuse(a, b);               
            }
            catch (ArgumentOutOfRangeException e)
            {
                //assert
                StringAssert.Contains(e.Message, triangle.ChypotenuseMessageZero);
                return;
            }    
        }

        [TestMethod]
        public void Test_Triangle_Area_Zero()
        {
            //arrange
            double a = 0;
            double b = 0;
            double c = 0;


            try
            {
                //act
                double actual = triangle.Striangle(a, b, c);
            }
            catch (ArgumentOutOfRangeException e)
            {
                //assert
                StringAssert.Contains(e.Message, triangle.ChypotenuseMessageZero);
                return;
            }


        }
    }
}
