using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamFormsMarvel.ViewModels;
using Xamarin.Forms.Xaml;
using XamFormsMarvel.Renderer;

namespace XamFormsMarvel.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstView : ContentPage
    {
        private FirstViewModel _vm;

        public FirstView()
        {
            InitializeComponent();

   
			// TODO: AI. Diseñar la primera ventana FirstView


			// TODO: AP. Realizar la navegación en code behind


            // Navigation to detail page
//            this.listCharacters.ItemSelected += (object sender, SelectedItemChangedEventArgs e) =>
//            {
//                var character = (CharacterItemViewModel)e.SelectedItem;
//                var detailVm = new DetailViewModel(character);
//
//                var detailView = new DetailView(detailVm);
//
//                this.Navigation.PushAsync(detailView);
//            };


			// TODO: AQ. Probar a ejecutar la aplicación


			// TODO: AK. Enlazar el ViewModel con la vista a partir del BindingContext y realizar la carga de los datos llamando a LoadData

			// TODO: AL. Probar a ejecutar la aplicación
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();

        }
    }
}

