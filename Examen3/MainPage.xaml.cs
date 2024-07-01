using Examen3.ViewModels;
using Examen3.Data;
using Examen3.Models;

namespace Examen3
{
    public partial class MainPage : ContentPage
    {
        private MainViewModelMR _viewModel;

        public MainPage()
        {
            InitializeComponent();
            var dogServiceMR = new DatabaseServiceMR();
            _viewModel = new MainViewModelMR(dogServiceMR);
            BindingContext = _viewModel;
        }

        private void OnAddDogButtonClicked(object sender, EventArgs e)
        {
            var newDog = new Dog
            {
                Id = 1,
                Name = "Fido",
                Breed = "Labrador"
            };
            _viewModel.AddDog(newDog);
        }
    }
}

