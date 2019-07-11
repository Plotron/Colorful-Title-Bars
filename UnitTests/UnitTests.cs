using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO.Abstractions.TestingHelpers;
using RegistryUtils;
using ColorfulTitleBars.Logic;
using System.Drawing;
using System.Linq;

namespace UnitTests
{
    [TestClass]
    public class RegFileProcessorTest
    {
   
        [TestMethod]
        public void CanReadInactiveAccentColorFromRegFile()
        {
            // Arrange
            MockFileSystem mockFileSystem = new MockFileSystem();

            RegFileProcessor systemUnderTest = new RegFileProcessor(mockFileSystem);

            var mockInputRegFile = new MockFileData(
                "Windows Registry Editor Version 5.00"
                + "\r\n; created with Colorful Title Bars application"
                + "\r\n; visit https://github.com/Plotron/Colorful-Title-Bars for more details"
                + "\r\n[HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\DWM]"
                + "\r\n\"AccentColorInactive\"=dword:00D5BB72"
                + "\r\n\"AccentColor\"=dword:00FF9A7D2D");

            string mockInputFilePath = @"C:\test.reg";

            mockFileSystem.AddFile(mockInputFilePath, mockInputRegFile);

            Color expectedResult = Color.FromArgb(114, 187, 213);

            // Act
            Color? actualResult = systemUnderTest.LoadInactiveAccentColorFromRegFile(mockInputFilePath);

            // Assert
            Assert.IsTrue(actualResult.HasValue);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void CanWriteAccentColors()
        {
            // Arrange
            MockFileSystem mockFileSystem = new MockFileSystem();

            RegFileProcessor systemUnderTest = new RegFileProcessor(mockFileSystem);

            string mockOutputFilePath = @"C:\test.reg";

            string[] expectedResult =
{
                "Windows Registry Editor Version 5.00",
                "",
                "; created with Colorful Title Bars application",
                "; visit https://github.com/Plotron/Colorful-Title-Bars for more details",
                "",
                "[HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\DWM]",
                "\"AccentColorInactive\"=dword:00d5bb72",
                "\"AccentColor\"=dword:0072bbd5"
            };

            // Act
            systemUnderTest.SaveAccentColorsToRegFile(Color.FromArgb(114, 187, 213), Color.FromArgb(213, 187, 114), mockOutputFilePath);

            // Assert
            string[] outputLines = mockFileSystem.GetFile(mockOutputFilePath).TextContents.SplitLines();

            Assert.IsTrue(expectedResult.SequenceEqual(outputLines));
        }

        [TestMethod]
        public void CanWriteInactiveAccentColor()
        {
            // Arrange
            MockFileSystem mockFileSystem = new MockFileSystem();

            RegFileProcessor systemUnderTest = new RegFileProcessor(mockFileSystem);

            string mockOutputFilePath = @"C:\test.reg";

            string[] expectedResult =
            {
                "Windows Registry Editor Version 5.00",
                "",
                "; created with Colorful Title Bars application",
                "; visit https://github.com/Plotron/Colorful-Title-Bars for more details",
                "",
                "[HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\DWM]",
                "\"AccentColorInactive\"=dword:00d5bb72",
            };

            // Act
            systemUnderTest.SaveInactiveAccentColorToRegFile(Color.FromArgb(114, 187, 213), mockOutputFilePath);

            // Assert
            string[] outputLines = mockFileSystem.GetFile(mockOutputFilePath).TextContents.SplitLines();

            Assert.IsTrue(expectedResult.SequenceEqual(outputLines));
        }

        [TestMethod]
        public void ReadingInactiveAccentColorFromBlankRegFileReturnsNoValue()
        {
            // Arrange
            MockFileSystem mockFileSystem = new MockFileSystem();

            RegFileProcessor systemUnderTest = new RegFileProcessor(mockFileSystem);

            var mockInputRegFile = new MockFileData(
                "");

            string mockInputFilePath = @"C:\test.reg";

            mockFileSystem.AddFile(mockInputFilePath, mockInputRegFile);

            // Act
            Color? result = systemUnderTest.LoadInactiveAccentColorFromRegFile(mockInputFilePath);

            // Assert
            Assert.IsFalse(result.HasValue);
        }

        [TestMethod]
        public void ReadingInactiveAccentColorFromIncompleteRegFileReturnsNoValue()
        {
            // Arrange
            MockFileSystem mockFileSystem = new MockFileSystem();

            RegFileProcessor systemUnderTest = new RegFileProcessor(mockFileSystem);

            var mockInputRegFile = new MockFileData(
                "Windows Registry Editor Version 5.00"
                + "\r\n[HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\DWM]"
                + "\r\n\"AccentColorInactive\"=dword:00D5B");

            string mockInputFilePath = @"C:\test.reg";

            mockFileSystem.AddFile(mockInputFilePath, mockInputRegFile);

            // Act
            Color? result = systemUnderTest.LoadInactiveAccentColorFromRegFile(mockInputFilePath);

            // Assert
            Assert.IsFalse(result.HasValue);
        }
    }

    [TestClass]
    public class RegistryUtilsTest
    {
        [TestMethod]
        public void RgbToHexForCorrectPadding()
        {
            // Arrange
            Byte r = 1;
            Byte g = 2;
            Byte b = 3;

            // Act and Assert
            Assert.AreEqual("010203", HexUtility.RgbToHexValue(r, g, b));
        }

        [TestMethod]
        public void RgbToHexForCorrectLowercase()
        {
            // Arrange
            Byte r = 255;
            Byte g = 255;
            Byte b = 255;

            // Act and Assert
            Assert.AreEqual("ffffff", HexUtility.RgbToHexValue(r, g, b));
        }

        [TestMethod]
        public void RgbToHexForValueZero()
        {
            // Arrange
            Byte r = 0;
            Byte g = 0;
            Byte b = 0;

            // Act and Assert
            Assert.AreEqual("000000", HexUtility.RgbToHexValue(r, g, b));
        }

        [TestMethod]
        public void BgrToColorForCorrectLeadingByteRemoval()
        {
            // Arrange
            Color expectedResult = Color.FromArgb(255, 255, 255);

            // Act
            Color actualResult = WindowCustomizationUtility.BgrToColor("12FFFFFF");

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void BgrToColorThrowsExceptionWhenLengthTooShort()
        {
            // Act
            WindowCustomizationUtility.BgrToColor("007d5");
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void BgrToColorThrowsExceptionWhenArgumentIsNotHex()
        {
            // Act
            WindowCustomizationUtility.BgrToColor("D5ZZ72");
        }
    }
}
