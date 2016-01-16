using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace XamFormsMarvel.Droid
{
	[Activity (Label = "XamFormsMarvel.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			// TODO: AT. Aplicar Material Design Android. Heredar de FormsAppCompactActivity

			// TODO: AU. Aplicar tema android:theme="@style/MyTheme" en el archivo AndroidManifest.xml en el nodo de aplicación

			// TODO: AV. Elegir el esquema de colores y explicar el tema aplicado. http://www.materialpalette.com/

			// TODO: Probar a ejecutar la App de Android con un dispositivo MarshMallow

			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			LoadApplication (new App ());
		}
	}
}

