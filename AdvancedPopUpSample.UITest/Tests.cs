using System;
using System.IO;
using System.Linq;
using System.Threading;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace AdvancedPopUpSample.UITest
{
    // [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void WelcomeTextIsDisplayed()
        {
            /*AppResult[] results = app.WaitForElement(c => c.Marked("Welcome to Xamarin.Forms!"));
            app.Screenshot("Welcome screen.");
            Assert.IsTrue(results.Any());*/

            // AppResult[] results = app.WaitForElement(c => c.Marked("Hello PopopX!"));
            app.Screenshot("Start PopopX");

            // Assert.IsTrue(results.Any());

            Thread.Sleep(1000);
            app.Screenshot("Start to PRESS");
            app.Tap(c => c.Marked("Click to display PopUp"));

            Thread.Sleep(5000);
            app.Screenshot("Imitation auth");
            app.WaitForElement(c => c.Marked("Name:"));

            Thread.Sleep(1000);
            app.Screenshot("Check fileds");
            app.Tap(c => c.Marked("Write your name"));

            Thread.Sleep(1000);
            app.Screenshot("Set name");
            app.EnterText(c => c.Marked("Write your name"), "set name");

            Thread.Sleep(1000);
            app.EnterText(c => c.Marked("Write your last name"), "Set last name");

            app.Screenshot("press");
            app.Tap(c => c.Marked("Send"));

            // var lastName = app.WaitForElement(c => c.Marked("Write your last name"));
            Assert.AreEqual("Set last name", app.Query(c => c.Marked("Write your last name")).First().Text);
        }
    }
}
