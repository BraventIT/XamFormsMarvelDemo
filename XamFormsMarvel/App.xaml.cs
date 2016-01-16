using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamFormsMarvel.Services;
using XamFormsMarvel.Views;

namespace XamFormsMarvel
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent (); 

			// TODO: AC. Register Marvel Service in DependencyService

			// TODO: AD. Set the MainPage un nuevo NavigationPage que vaya al FirstView

			// TODO: AR. Probrar Gorilla Player para diseñar XAML en tiempo real

			// TODO: AS. Crear DynamicResources y seguir probando Gorilla
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

