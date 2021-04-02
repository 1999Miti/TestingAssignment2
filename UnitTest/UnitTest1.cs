using System;
using UnitTest_2;
using Xunit;

namespace UnitTest
{
    public class UnitTest1
    {
        /// <summary>
        /// Convert To Upper Case Equal And Not Equal Test Cases
        /// </summary>
        [Fact]
        public void ConvertToUpper_Equal()
        {
            //Arrange
            string a = "miti";
            //Act 
            string result = a.ConvertToUpper();
            //Assert
            Assert.Equal("MITI", result);
        }

        [Fact]
        public void ConvertToUpper_Equal_SpecialCharacterCase()
        {
            //Arrange
            string a = "testing c#";
            //Act 
            string result = a.ConvertToUpper();
            //Assert
            Assert.Equal("TESTING C#", result);
        }
        [Fact]
        public void ConvertToUpper_NotEqual_MixCase()
        {
            //Arrange
            string a = "miti Nayak";
            //Act 
            string result = a.ConvertToUpper();
            //Assert
            Assert.Equal("MITI NAYAK", result);
        }
        [Fact]
        public void ConvertToUpper_NotEqual()
        {
            //Arrange
            string a = "miti";
            //Act
            string result = a.ConvertToUpper();
            //Assert
            Assert.NotEqual("Miti", result);
        }
        /// <summary>
        /// Convert To Lower Equal And Not Equal Test Cases 
        /// </summary>
        [Fact]
        public void ConvertToLower_Equal()
        {
            //Arrange
            string a = "MITI";
            //Act
            string result = a.ConvertToLower();
            //Assert
            Assert.Equal("miti", result);
        }
        [Fact]
        public void ConvertToLower_Equal_MixCase()
        {
            //Arrange
            string a = "MITI Nayak";
            //Act
            string result = a.ConvertToLower();
            //Assert
            Assert.Equal("miti nayak", result);
        }
        [Fact]
        public void ConvertToLower_Equal_SpecialCharacterCase()
        {
            //Arrange
            string a = "Testing Assignment C#%";
            //Act
            string result = a.ConvertToLower();
            //Assert
            Assert.Equal("testing assignment c#%", result);
        }
        [Fact]
        public void ConvertToLower_NotEqual()
        {
            //Arrange
            string a = "MITI";
            //Act
            string result = a.ConvertToLower();
            //Assert
            Assert.NotEqual("Miti", result);
        }
        [Fact]
        public void ConvertToLower_NotEqual_SpecialCharacterCase()
        {
            //Arrange
            string a = "TESTING ASSIGNMENT _C#$%";
            //Act
            string result = a.ConvertToLower();
            //Assert
            Assert.NotEqual("Testing Assignment _c#$%", result);
        }
        /// <summary>
        /// Title Case Test Cases
        /// </summary>
        [Fact]
        public void ConvertToTitleCase_Equal()
        {
            //Arrange
            string a = "this is an example input";
            //Act
            string result = a.ConvertToTitleCase();
            //Assert
            Assert.Equal("This Is An Example Input", result);
        }
        [Fact]
        public void ConvertToTitleCase_Equal_MixCase()
        {
            //Arrange
            string a = "this Is An example Input";
            //Act
            string result = a.ConvertToTitleCase();
            //Assert
            Assert.Equal("This Is An Example Input", result);
        }
        [Fact]
        public void ConvertToTitleCase_Equal_SpecialCharacterCase()
        {
            //Arrange
            string a = "this is An example Input%$#@";
            //Act
            string result = a.ConvertToTitleCase();
            //Assert
            Assert.Equal("This Is An Example Input%$#@", result);
        }
        [Fact]
        public void ConvertToTitleCase_NotEqual()
        {
            //Arrange
            string a = "this is an example input";
            //Act
            string result = a.ConvertToTitleCase();
            //Assert
            Assert.NotEqual("This Is An Example input", result);
        }
        [Fact]
        public void ConvertToTitleCase_NotEqual_MixCase()
        {
            //Arrange
            string a = "this is An example Input";
            //Act
            string result = a.ConvertToTitleCase();
            //Assert
            Assert.NotEqual("This Is An Example input", result);
        }
        [Fact]
        public void ConvertToTitleCase_NotEqual_SpecialCharacterCase()
        {
            //Arrange
            string a = "this is an example input #@!%$";
            //Act
            string result = a.ConvertToTitleCase();
            //Assert
            Assert.NotEqual("This Is An Example Input $#", result);
        }
        /// <summary>
        ///Is Lower Case Test Cases
        /// </summary>
        [Fact]
        public void IsLower_True()
        {
            //Arrange
            string a = "miti";
            //Act
            bool result = a.IsLower();
            //Assert
            Assert.True(result);
        }
        [Fact]
        public void IsLower_False()
        {
            //Arrange
            string a = "Miti";
            //Act
            bool result = a.IsLower();
            //Assert
            Assert.False(result);
        }
        /// <summary>
        /// Is Upper Test Cases
        /// </summary>
        [Fact]
        public void IsUpper_True()
        {
            //Arrange
            string a = "MITI";
            //Act
            bool result = a.IsUpper();
            //Assert
            Assert.True(result);
        }
        [Fact]
        public void IsUpper_False()
        {
            //Arrange
            string a = "mItI";
            //Act
            bool result = a.IsUpper();
            //Assert
            Assert.False(result);
        }
        /// <summary>
        /// Convert To Capitalize Test Cases
        /// </summary>
        [Fact]
        public void ConvertToCapitalize_Equal()
        {
            //Arrange
            string a = "input example";
            //Act
            string result = a.ConvertToCapitalize();
            //Assert
            Assert.Equal("Input example", result);
        }
        [Fact]
        public void ConvertToCapitalize_NotEqual()
        {
            //Arrange
            string a = "input example";
            //Act
            string result = a.ConvertToCapitalize();
            //Assert
            Assert.NotEqual("Input Example", result);
        }
        [Fact]
        public void ConvertToCapitalize_NotEqual_MixCase()
        {
            //Arrange
            string a = "input Example testing";
            //Act
            string result = a.ConvertToCapitalize();
            //Assert
            Assert.NotEqual("Input Example Testing", result);
        }
        /// <summary>
        /// Total Word Count Test Cases
        /// </summary>
        [Fact]
        public void CountingTotalWord_Equal()
        {
            //Arrange
            string a = "miti nayak";
            //Act
            int result = a.CountingWord();
            //Assert
            Assert.Equal(2, result);
        }
        [Fact]
        public void CountingTotalWord_Equal_SpecialCharacterCase()
        {
            //Arrange
            string a = "miti nayak #$%";
            //Act
            int result = a.CountingWord();
            //Assert
            Assert.Equal(3, result);
        }
        [Fact]
        public void CountingTotalWord_Equal_PunctuationCase()
        {
            //Arrange
            string a = "this is testing assignment .";
            //Act
            int result = a.CountingWord();
            //Assert
            Assert.Equal(5, result);
        }
        [Fact]
        public void CountingTotalWord_NotEqual_SpecialCharacterCase()
        {
            //Arrange
            string a = "miti nayak #$%";
            //Act
            int result = a.CountingWord();
            //Assert
            Assert.NotEqual(4, result);
        }
        [Fact]
        public void CountingTotalWord_NotEqual()
        {
            //Arrange
            string a = "miti nayak";
            //Act
            int result = a.CountingWord();
            //Assert
            Assert.NotEqual(3, result);
        }
        /// <summary>
        /// Remove Last Character Test Cases
        /// </summary>
        [Fact]
        public void RemoveLastCharacterFrom_Equal()
        {
            //Arrange
            string a = "miti";
            //Act
            string result = a.RemoveLastCharacterFrom();
            //Assert
            Assert.Equal("mit", result);
        }
        [Fact]
        public void RemoveLastCharacterFrom_Equal_SpecialCharacterCase()
        {
            //Arrange
            string a = "miti#$";
            //Act
            string result = a.RemoveLastCharacterFrom();
            //Assert
            Assert.Equal("miti#", result);
        }
        [Fact]
        public void RemoveLastCharacterFrom_NotEqual()
        {
            //Arrange
            string a = "miti";
            //Act
            string result = a.RemoveLastCharacterFrom();
            //Assert
            Assert.NotEqual("m", result);
        }
        [Fact]
        public void RemoveLastCharacterFrom_NotEqual_SpecialCharacterCase()
        {
            //Arrange
            string a = "miti#$%";
            //Act
            string result = a.RemoveLastCharacterFrom();
            //Assert
            Assert.NotEqual("miti#", result);
        }
        /// <summary>
        /// Is Valid Numeric Test Cases
        /// </summary>
        [Fact]
        public void IsValidNumeric_True()
        {
            //Arrange
            string a = "19999";
            //Act
            bool result = a.IsValidNumeric();
            //Assert
            Assert.True(result);
        }
        [Fact]
        public void IsValidNumeric_False_SpecialCharacterCase()
        {
            //Arrange
            string a = "19999#$";
            //Act
            bool result = a.IsValidNumeric();
            //Assert
            Assert.False(result);
        }
        [Fact]
        public void IsValidNumeric_False_PunctuationCase()
        {
            //Arrange
            string a = "1999!.?";
            //Act
            bool result = a.IsValidNumeric();
            //Assert
            Assert.False(result);
        }
        [Fact]
        public void IsValidNumeric_False()
        {
            //Arrange
            string a = "1999miti";
            //Act
            bool result = a.IsValidNumeric();
            //Assert
            Assert.False(result);
        }
        /// <summary>
        /// Convert String To Number Test Cases
        /// </summary>
        [Fact]
        public void ConvertStringToNumber_True()
        {
            //Arrange
            string a = "1999";
            //Act
            bool result = a.ConvertStringToNumber();
            //Assert
            Assert.True(result);
        }
        [Fact]
        public void ConvertStringToNumber_False__DecimalCase()
        {
            //Arrange
            string a = "1999.9";
            //Act
            bool result = a.ConvertStringToNumber();
            //Assert
            Assert.False(result);
        }
        [Fact]
        public void ConvertStringToNumber_False()
        {
            //Arrange
            string a = "miti";
            //Act
            bool result = a.ConvertStringToNumber();
            //Assert
            Assert.False(result);
        }
        [Fact]
        public void ConvertStringToNumber_False_SpecialCharacterCase()
        {
            //Arrange
            string a = "miti#$@";
            //Act
            bool result = a.ConvertStringToNumber();
            //Assert
            Assert.False(result);
        }
        [Fact]
        public void ConvertStringToNumber_False_PunctuationCase()
        {
            //Arrange
            string a = "!?.";
            //Act
            bool result = a.ConvertStringToNumber();
            //Assert
            Assert.False(result);
        }
    }
}
