//using FluentAssertions;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using TDDWorkshop;

//namespace UnitTest
//{
//    [TestClass]
//    public class CowSaySpeakerTests
//    {
//        private CowSay _cowCreator;

//        [TestInitialize]
//        public void Initialize()
//        {
//            _cowCreator = new CowSay();
//        }

//        [TestMethod]
//        public void WhenCreatingTheCowTheHornsShouldMatch()
//        {
//            _cowCreator.CreateCow("Hello World!").Result[3].Should().Be(@"         \   ^__^ ");
//        }

//        [TestMethod]
//        public void WhenCreatingTheCowTheEyesShouldMatch()
//        {
//            _cowCreator.CreateCow("Hello World!").Result[4].Should().Be(@"          \  (oo)\_____");
//        }

//        [TestMethod]
//        public void WhenCreatingTheCowTheMouthShouldMatch()
//        {
//            _cowCreator.CreateCow("Hello World!").Result[5].Should().Be(@"             (__)\       )\/\");
//        }

//        [TestMethod]
//        public void WhenCreatingTheCowTheUddersShouldMatch()
//        {
//            _cowCreator.CreateCow("Hello World!").Result[6].Should().Be(@"                 ||----w |");
//        }

//        [TestMethod]
//        public void WhenCreatingTheCowTheLegsShouldMatch()
//        {
//            _cowCreator.CreateCow("Hello World!").Result[7].Should().Be(@"                 ||     ||");
//        }
//    }
//}
