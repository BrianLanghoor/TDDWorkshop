using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDWorkshop;

namespace UnitTest
{
    [TestClass]
    public class CowSaySpeakerTests
    {
        private CowSay _cowSay;

        [TestInitialize]
        public void Initialize()
        {
            _cowSay = new CowSay();
        }

        [TestMethod]
        public void WhenCreatingTheCowTheHornsShouldMatch()
        {
            _cowSay.CreateCow("Hello World!").Result[3].Should().Be(@"         \   ^__^ ");
        }

        [TestMethod]
        public void WhenCreatingTheCowTheEyesShouldMatch()
        {
            _cowSay.CreateCow("Hello World!").Result[4].Should().Be(@"          \  (oo)\_____");
        }

        [TestMethod]
        public void WhenCreatingTheCowTheMouthShouldMatch()
        {
            _cowSay.CreateCow("Hello World!").Result[5].Should().Be(@"             (__)\       )\/\");
        }

        [TestMethod]
        public void WhenCreatingTheCowTheUddersShouldMatch()
        {
            _cowSay.CreateCow("Hello World!").Result[6].Should().Be(@"                 ||----w |");
        }

        [TestMethod]
        public void WhenCreatingTheCowTheLegsShouldMatch()
        {
            _cowSay.CreateCow("Hello World!").Result[7].Should().Be(@"                 ||     ||");
        }

        [TestMethod]
        public void WhenCreatingThePenguinTheTextInsideTheBalloonShouldBeHelloWorld()
        {
            _cowSay.CreateCow("Penguin Hello World!").Result[1].Should().Be(" < Hello World! >");
        }

        [TestMethod]
        public void WhenCreatingThePenguinTheTopShouldMatch()
        {
            _cowSay.CreateCow("Penguin Hello World!").Result[3].Should().Be(@"   \    .--.");
        }

        [TestMethod]
        public void WhenCreatingThePenguinTheEyesShouldMatch()
        {
            _cowSay.CreateCow("Penguin Hello World!").Result[4].Should().Be(@"    \  |o_o |");
        }

        [TestMethod]
        public void WhenCreatingThePenguinTheMouthShouldMatch()
        {
            _cowSay.CreateCow("Penguin Hello World!").Result[5].Should().Be(@"       |:_/ |");
        }

        [TestMethod]
        public void WhenCreatingThePenguinTheShouldersShouldMatch()
        {
            _cowSay.CreateCow("Penguin Hello World!").Result[6].Should().Be(@"      //   \ \");
        }

        [TestMethod]
        public void WhenCreatingThePenguinTheChestShouldMatch()
        {
            _cowSay.CreateCow("Penguin Hello World!").Result[7].Should().Be(@"     (|     | )");
        }


        [TestMethod]
        public void WhenCreatingThePenguinTheBellyShouldMatch()
        {
            _cowSay.CreateCow("Penguin Hello World!").Result[8].Should().Be(@"    /'\_   _/`\");
        }


        [TestMethod]
        public void WhenCreatingThePenguinTheLegsShouldMatch()
        {
            _cowSay.CreateCow("Penguin Hello World!").Result[9].Should().Be(@"    \___)=(___/");
        }
    }
}