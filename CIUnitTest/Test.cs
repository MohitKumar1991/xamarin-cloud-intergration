using NUnit.Framework;
using Xamarin.UITest;
using System;


namespace CIUnitTest
{
    [TestFixture()]
    public class Test
    {
        IApp app;

        [SetUp]
        public void Setup()
        {
            app = ConfigureApp.iOS.AppBundle("/Users/mohitkumar/GameChange/samples/CITest/iOS/bin/iPhoneSimulator/Debug/device-builds/iphone9.1-11.2/CITest.iOS.app").StartApp();
        }

        [Test()]
        public void TabSwitch()
        {
            app.Tap(c => c.Marked("tab_feed.png"));
            app.Tap(c => c.Marked("tab_about.png"));
        }

        [Test()]
        public void ReplTest()
        {
            app.Repl();
        }
       
    }
}
