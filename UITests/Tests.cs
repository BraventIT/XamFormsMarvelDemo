using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace XamFormsMarvel.UITests
{
	[TestFixture (Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests (Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest ()
		{
			app = AppInitializer.StartApp (platform);
		}

		// TODO: BA. UITest y Xamarin Test Recorder

		// TODO: BB. Generar pseodicódigo con Xamarin Test Recorder

		// TODO: BC. Incluir el app.PressEnter (); que simule la búsqueda


	}
}

