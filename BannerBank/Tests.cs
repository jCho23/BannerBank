using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

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

			app.EnterText("Banner Bank");

			app.DismissKeyboard();

			app.Tap("btn_sign_in");
		}

		[Test]
		public void PasswordNoLogin()
		{
			app.Tap("password");
		}




	}
}
