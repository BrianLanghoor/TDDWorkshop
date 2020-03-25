//using FluentAssertions;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using TDDWorkshop;
//using System.Linq;

//namespace UnitTest
//{
//    [TestClass]
//    public class CowSayBalloonTests
//    {
//        private CowSay _cowSay;

//        [TestInitialize]
//        public void Initialize()
//        {
//            _cowSay = new CowSay();
//        }

//        [TestMethod]
//        public void WhenCreatingTheCowTheUpperBalloonLineShouldMatch()
//        {
//            _cowSay.CreateCow("Hello World!").Result.First().Should().Be("  ______________");
//        }

//        [TestMethod]
//        public void WhenCreatingTheCowWithoutInputTheTextInsideTheBalloonShouldBeHelloWorld()
//        {
//            _cowSay.CreateCow("").Result[1].Should().Be(" < Hello World! >");
//        }

//        [TestMethod]
//        public void WhenCreatingTheCowTheLowerBalloonLineShouldMatch()
//        {
//            _cowSay.CreateCow("Hello World!").Result[2].Should().Be("  --------------");
//        }

//        [TestMethod]
//        public void WhenCreatingTheCowWithFooTheUpperBalloonLineShouldMatch()
//        {
//            _cowSay.CreateCow("Foo").Result.First().Should().Be("  _____");
//        }

//        [TestMethod]
//        public void WhenCreatingTheCowWithFooTheTextInsideTheBalloonShouldBeHelloWorld()
//        {
//            _cowSay.CreateCow("Foo").Result[1].Should().Be(" < Foo >");
//        }

//        [TestMethod]
//        public void WhenCreatingTheCowWithFooTheLowerBalloonLineShouldShouldMatch()
//        {
//            _cowSay.CreateCow("Foo").Result[2].Should().Be("  -----");
//        }

//        [TestMethod]
//        public void WhenCreatingTheCowWith40CharactersTheTotalNumberOfPrintedLinesShouldBeEight()
//        {
//            _cowSay.CreateCow("123456789-123456789-123456789-123456789-").Result.Count.Should().Be(8);
//        }

//        [TestMethod]
//        public void WhenCreatingTheCowWith41CharactersTheTotalNumberOfPrintedLinesShouldBeNine()
//        {
//            _cowSay.CreateCow("123456789-123456789-123456789-123456789-1").Result.Count.Should().Be(9);
//        }

//        [TestMethod]
//        public void WhenCreatingTheCowWith81CharactersTheTotalNumberOfPrintedLinesShouldBeTen()
//        {
//            _cowSay.CreateCow("123456789-123456789-123456789-123456789-123456789-123456789-123456789-123456789-1").Result.Count.Should().Be(10);
//        }

//        [TestMethod]
//        public void WhenCreatingTwoTextLinesTheFirstLineShouldMatch()
//        {
//            _cowSay.CreateCow("123456789-123456789-123456789-123456789-1").Result[1].Should().Be(@" / 123456789-123456789-123456789-123456789- \");
//        }

//        [TestMethod]
//        public void WhenCreatingTwoTextLinesTheSecondLineShouldMatch()
//        {
//            _cowSay.CreateCow("123456789-123456789-123456789-123456789-1").Result[2].Should().Be(@" \ 1                                        /");
//        }

//        [TestMethod]
//        public void WhenCreatingThreeTextLinesTheTopLineShouldMatch()
//        {
//            _cowSay.CreateCow("123456789-123456789-123456789-123456789-987654321-987654321-987654321-987654321-9").Result[0].Should().Be("  __________________________________________");
//        }

//        [TestMethod]
//        public void WhenCreatingThreeTextLinesTheFirstLineShouldMatch()
//        {
//            _cowSay.CreateCow("123456789-123456789-123456789-123456789-987654321-987654321-987654321-987654321-9").Result[1].Should().Be(@" / 123456789-123456789-123456789-123456789- \");
//        }

//        [TestMethod]
//        public void WhenCreatingThreeTextLinesTheSecondLineShouldMatch()
//        {
//            _cowSay.CreateCow("123456789-123456789-123456789-123456789-987654321-987654321-987654321-987654321-9").Result[2].Should().Be(@" | 987654321-987654321-987654321-987654321- |");
//        }

//        [TestMethod]
//        public void WhenCreatingThreeTextLinesTheThirdLineShouldMatch()
//        {
//            _cowSay.CreateCow("123456789-123456789-123456789-123456789-987654321-987654321-987654321-987654321-987").Result[3].Should().Be(@" \ 987                                      /");
//        }

//        [TestMethod]
//        public void WhenCreatingThreeTextLinesTheBottomLineShouldMatch()
//        {
//            _cowSay.CreateCow("123456789-123456789-123456789-123456789-987654321-987654321-987654321-987654321-9").Result[4].Should().Be("  ------------------------------------------");
//        }
//    }
//}