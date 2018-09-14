using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HighestScoringWord;
using NUnit.Framework;

namespace HighestScoringWordTests
{
    [TestFixture]
    public class HighestScoringWordTestsClass
    {
        [Test]
        public void Score_GivenAnEmptyString_ShouldReturn0()
        {
            //Arrange
            var stringWord = "";
            var sut = new HighestScoringWordClass();

            //Act
            var actual = sut.Score(stringWord);

            //Assert
            var expected = "0";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Score_GivenAWord_ShouldReturnTheWordWithTHeHightestScore()
        {
            //Arrange
            var stringWord = "ant";
            var sut = new HighestScoringWordClass();

            //Act
            var actual = sut.Score(stringWord);

            //Assert
            var expected = "ant";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Score_GivenTwoWord_ShouldReturnTheWordWithTheHightestScore()
        {
            //Arrange
            var stringWord = "my name";
            var sut = new HighestScoringWordClass();

            //Act
            var actual = sut.Score(stringWord);

            //Assert
            var expected = "my";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Score_GivenThreeWords_ShouldReturnTheWordWithTheHightestScore()
        {
            //Arrange
            var stringWord = "my name is";
            var sut = new HighestScoringWordClass();

            //Act
            var actual = sut.Score(stringWord);

            //Assert
            var expected = "my";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Score_GivenTwoWordsWithTheSameScore_ShouldReturnTheWordWhichAppearsEarliest()
        {
            //Arrange
            var stringWord = "dad de";
            var sut = new HighestScoringWordClass();

            //Act
            var actual = sut.Score(stringWord);

            //Assert
            var expected = "dad";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Score_GivenTwoWordsWithSecondHavingHightestScore_ShouldReturnTheWordWithHighestScore()
        {
            //Arrange
            var stringWord = "we went";
            var sut = new HighestScoringWordClass();

            //Act
            var actual = sut.Score(stringWord);

            //Assert
            var expected = "went";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Score_GivenAnUppercaseWord_ShouldReturnTheWordInLowercase()
        {
            //Arrange
            var stringWord = "WE";
            var sut = new HighestScoringWordClass();

            //Act
            var actual = sut.Score(stringWord);

            //Assert
            var expected = "we";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Score_GivenAnUppercaseSentence_ShouldReturnTheWordInLowercase()
        {
            //Arrange
            var stringWord = "WE NEED FOOD";
            var sut = new HighestScoringWordClass();

            //Act
            var actual = sut.Score(stringWord);

            //Assert
            var expected = "food";
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Score_GivenAnUppercaseSentenceHavingBothUpperAnLowercaseLetters_ShouldReturnTheWordInLowercase()
        {
            //Arrange
            var stringWord = "We Need Money";
            var sut = new HighestScoringWordClass();

            //Act
            var actual = sut.Score(stringWord);

            //Assert
            var expected = "money";
            Assert.AreEqual(expected, actual);
        }
    }
}
