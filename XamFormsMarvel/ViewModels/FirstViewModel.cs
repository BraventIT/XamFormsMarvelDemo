
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using System.Threading.Tasks;
using XamFormsMarvel.Services;
using Xamarin.Forms;

namespace XamFormsMarvel.ViewModels
{
    public class FirstViewModel : ViewModelBase
    {
		//TODO: AE. Recuperar el _marvelService del DependencyService en el constructor
		public FirstViewModel ()
		{
			
		}

		//TODO: AF. Crear las propiedades SearchText, CharacterList<CharacterItemViewModel> y SearchByName Command




//		#region SearchByName Command
//
//		private ICommand _SearchByName;
//
//		public ICommand SearchByName {
//			get {
//				return _SearchByName ?? (_SearchByName = new Command (
//					async () => await ExecuteSearchByNameCommand (),
//					ValidateSearchByNameCommand)); 
//			}
//		}
//
//		private async Task ExecuteSearchByNameCommand ()
//		{
//			await LoadData (SearchText);
//		}
//
//		private bool ValidateSearchByNameCommand ()
//		{
//			return true;
//		}
//
//		#endregion


		//TODO: AH. Decomentar la función que carga los personajes de Marvel

//		#region LoadData
//
//		public async Task LoadData (string filter = null, int limit = 0, int offset = 0)
//		{
//			IsBusy = true;
//
//			var result = await _marvelService.GetCharacters (filter, limit, offset);
//
//
//			if (result != null) {
//				CharacterList = (from p in result.Results
//				                 select new CharacterItemViewModel () {
//						Id = p.Id,
//						Name = p.Name,
//						Thumbnail = p.Thumbnail.Path + "." + p.Thumbnail.Extension,
//						Description = p.Description
//				}).ToList ();
//			}
//
//			IsBusy = false;
//
//		}
//
//		#endregion
    }
}
