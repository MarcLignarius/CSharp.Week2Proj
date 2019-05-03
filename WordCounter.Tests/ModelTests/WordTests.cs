using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{

    [TestClass]
    public class RepeatCounterTest
    {

        [TestMethod]
        public void RepeatCounter_FindsOneMatch_Int()
        {
            // Arrange
            RepeatCounter newRepeatCounter = new RepeatCounter("I love coding", "coding");
            // Assert
            Assert.AreEqual(1, newRepeatCounter.AddWordMatches());
        }

        [TestMethod]
        public void RepeatCounter_FindsMultipleMatches_Int()
        {
            //Arrange
            RepeatCounter newRepeatCounter = new RepeatCounter("I love coding I think coding is great!", "coding");

            //Assert
            Assert.AreEqual(2, newRepeatCounter.AddWordMatches());
        }

        [TestMethod]
        public void RepeatCounter_IsNotCaseSensitive_Int()
        {
            // Arrange
            RepeatCounter newRepeatCounter = new RepeatCounter("I love CODING", "coding");

            // Assert
            Assert.AreEqual(1, newRepeatCounter.AddWordMatches());
        }

        [TestMethod]
        public void CheckSentence_IgnoresPartials_Int()
        {
            // Arrange
            RepeatCounter newRepeatCounter = new RepeatCounter("I guess decoding is cool too.", "coding");

            // Assert
            Assert.AreEqual(0, newRepeatCounter.AddWordMatches());
        }

    }

}
