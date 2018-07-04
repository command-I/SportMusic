using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportMusic;
using SportMusic.selenium;

namespace UnitTest_Selenium
{
    [TestClass]
    public class UnitTestConvertTimeStringToInt
    {
        [TestMethod]
        public void Test_accept_string_0305_returned_int_230()
        {
            //Arange
            TrackOptions element = new TrackOptions(1, "Шатунов", "Белые розы", "03:50", "http://", "001.mp3");
            int result = element.TimeStringToInt(element.Duration);

            //Act
            int actual = 230;

            //Assert
            Assert.AreEqual(actual, result);
        }


        [TestMethod]
        public void Test_accept_string_0000_returned_int_0()
        {
            //Arange
            TrackOptions element = new TrackOptions(1, "Шатунов", "Белые розы", "00:00", "http://", "001.mp3");
            int result = element.TimeStringToInt(element.Duration);

            //Act
            int actual = 0;

            //Assert
            Assert.AreEqual(actual, result);
        }


        [TestMethod]
        public void Test_accept_string_icorrect_format_returned_int_minus1()
        {
            //Arange
            TrackOptions element = new TrackOptions(1, "Шатунов", "Белые розы", "Три минуты", "http://", "001.mp3");
            int result = element.TimeStringToInt(element.Duration);

            //Act
            int actual = -1;

            //Assert
            Assert.AreEqual(actual, result);
        }


        [TestMethod]
        public void Test_accept_string_icorrect_format2_returned_int_minus1()
        {
            //Arange
            TrackOptions element = new TrackOptions(1, "Шатунов", "Белые розы", "0350", "http://", "001.mp3");
            int result = element.TimeStringToInt(element.Duration);

            //Act
            int actual = -1;

            //Assert
            Assert.AreEqual(actual, result);
        }
    }
}
