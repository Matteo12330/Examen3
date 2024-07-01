using Microsoft.Maui.Controls;
using ExamenProgra.ViewModels;
using ExamenProgra.Services;
using System.IO;
namespace ExamenProgra
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var apiService = new ApiServiceMR();
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "jokesMR.db3");
            var databaseService = new DatabaseServiceMR(dbPath);
            var viewModel = new MainViewModelMR(apiService, databaseService);
            BindingContext = viewModel;
            viewModel.LoadJokesAsync();
        }
    }
}