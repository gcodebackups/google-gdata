﻿using NUnit.Framework;
using Google.GData.Client.UnitTests;
using Google.GData.YouTube;

namespace Google.GData.Client.UnitTests.YouTube

{
    
    
    /// <summary>
    ///This is a test class for PlaylistEntryTest and is intended
    ///to contain all PlaylistEntryTest Unit Tests
    ///</summary>
    [TestFixture][Category("YouTube")]
    public class PlaylistEntryTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Position
        ///</summary>
        [Test]
        public void PositionTest()
        {
            PlaylistEntry target = new PlaylistEntry(); // TODO: Initialize to an appropriate value
            int expected = 4; // TODO: Initialize to an appropriate value
            int actual;
            target.Position = expected;
            actual = target.Position;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Description
        ///</summary>
        [Test]
        public void DescriptionTest()
        {
            PlaylistEntry target = new PlaylistEntry(); // TODO: Initialize to an appropriate value
            string expected = "secret text string"; // TODO: Initialize to an appropriate value
            string actual;
            target.Description = expected;
            actual = target.Description;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for PlaylistEntry Constructor
        ///</summary>
        [Test]
        public void PlaylistEntryConstructorTest()
        {
            PlaylistEntry target = new PlaylistEntry();
            Assert.IsNotNull(target);
            Assert.AreEqual(target.Position, 0);
            Assert.IsNull(target.Description);

        }
    }
}