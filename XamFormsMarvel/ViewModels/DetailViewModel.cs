
using XamFormsMarvel.ViewModels;
using XamFormsMarvel.Services;
using Xamarin.Forms;
using System.Windows.Input;

namespace XamFormsMarvel.ViewModels
{
	public class DetailViewModel : ViewModelBase
	{
		//private readonly IOpenWebService _openWebService;

		public DetailViewModel (CharacterItemViewModel character)
		{
			// TODO: AM. Crear DetailVioewModel. Crear la propiedad Character y asignarla en el constructor


			//_openWebService = DependencyService.Get<IOpenWebService> ();

			// TODO: AN. Diseñar la ventana de Detalle
		}


//		#region OpenWeb Command
//
//		private ICommand _OpenWeb;
//
//		public ICommand OpenWeb {
//			get {
//				return _OpenWeb ?? (_OpenWeb = new Command (
//					ExecuteOpenWebCommand,
//					ValidateOpenWebCommand)); 
//			}
//		}
//
//		private void ExecuteOpenWebCommand ()
//		{
//			_openWebService.OpenUrl (Character.Thumbnail);
//		}
//
//		private bool ValidateOpenWebCommand ()
//		{
//			return true;
//		}
//
//		#endregion


	}
}

