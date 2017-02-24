using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace BannerBank
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
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void LoginNoPassword()
		{
			app.Tap("username");
			app.Screenshot("Let's start by Tapping on the 'username' Edit Text Field");

			app.EnterText("Banner Bank");
			app.Screenshot("We entered our username, 'Banner Bank'");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("btn_sign_in");
			app.Screenshot("Then we Tapped the 'Log In' Button");
		}

		[Test]
		public void PasswordNoLogin()
		{
			app.Tap("password");
			app.Screenshot("Let's start by Tapping on the 'password' Edit Text Field");

			app.EnterText("Mark J Grescovich");
			app.Screenshot("We entered our password, 'Mark J Grescovich'");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("btn_sign_in");
			app.Screenshot("Then we Tapped the 'Log In' Button");
		}

		[Test]
		public void PrivacyPolicyTest()
		{
			app.Tap("Privacy Policy");
			app.Screenshot("We Tapped on the 'Privacy Policy' Button");

			Thread.Sleep(4000);
			app.ScrollDown();
			app.Screenshot("We Scrolled down for more information");
		}

	}
}
