//using FluentAssertions;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using TDDWorkshop;
//using System.Linq;


//namespace UnitTest
//{
//    [TestClass]
//    public class CowCreationTests
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
//            _cowSay.CreatCow("Hello World!").Result.First().Should().Be("  ______________");
//        }

//        [TestMethod]
//        public void WhenCreatingTheCowWithoutInputTheTextInsideTheBalloonShouldBeHelloWorld()
//        {
//            _cowSay.CreatCow("").Result[1].Should().Be(" < Hello World! >");
//        }

//        [TestMethod]
//        public void WhenCreatingTheCowWithFooTheTextInsideTheBalloonShouldBeHelloWorld()
//        {
//            _cowSay.CreatCow("Foo").Result[1].Should().Be(" < Foo >");
//        }

//        [TestMethod]
//        public void WhenCreatingTheCowTheLowerBalloonLineShouldMatch()
//        {
//            _cowSay.CreatCow("Hello World!").Result[2].Should().Be("  --------------");
//        }

//        [TestMethod]
//        public void WhenCreatingTheCowTheHornsShouldMatch()
//        {
//            _cowSay.CreatCow("Hello World!").Result[3].Should().Be(@"         \   ^__^ ");
//        }

//        [TestMethod]
//        public void WhenCreatingTheCowTheEyesShouldMatch()
//        {
//            _cowSay.CreatCow("Hello World!").Result[4].Should().Be(@"          \  (oo)\_____");
//        }

//        [TestMethod]
//        public void WhenCreatingTheCowTheMouthShouldMatch()
//        {
//            _cowSay.CreatCow("Hello World!").Result[5].Should().Be(@"             (__)\       )\/\");
//        }

//        [TestMethod]
//        public void WhenCreatingTheCowTheUddersShouldMatch()
//        {
//            _cowSay.CreatCow("Hello World!").Result[6].Should().Be(@"                 ||----w |");
//        }

//        [TestMethod]
//        public void WhenCreatingTheCowTheLegsShouldMatch()
//        {
//            _cowSay.CreatCow("Hello World!").Result[7].Should().Be(@"                 ||     ||");
//        }
//    }
//}
