using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Ascend
{
	[TestFixture(Platform.Android)]
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
			app.Screenshot("App Launched");
		}


		[Test]
		public void UsernameNoPassword()
		{
			app.Tap("loginFormUsername");
			app.Screenshot("Tapped on the 'Username' Field");

			app.EnterText("Microsoft");
			app.Screenshot("Put in my username, 'Microsoft'");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("loginFormButtonOK");
			app.Screenshot("Tapped on 'Log In' Button");
		}

		[Test]
		public void PasswordNoUsername()
		{
			app.Tap("loginFormPassword");
			app.Screenshot("Tapped on the 'Password' Field");

			app.EnterText("Ascend");
			app.Screenshot("Put in my password, 'Ascend'");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("loginFormButtonOK");
			app.Screenshot("Tapped on 'Log In' Button");
		}


	}
}
