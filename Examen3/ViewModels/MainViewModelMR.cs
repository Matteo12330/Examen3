using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using ExamenProgra.Models;
using ExamenProgra.Services;
using ExamenProgra.Data;
namespace ExamenProgra.ViewModels
{
    public class MainViewModelMR : BindableObject
    {
        private readonly ApiServiceMR _apiService;
        private readonly DatabaseServiceMR _databaseService;
        public ObservableCollection<JokeMR> Jokes { get; }
        public ICommand FetchJokeCommand { get; }
        public MainViewModelMR(ApiServiceMR apiService, DatabaseServiceMR databaseService)
        {
            _apiService = apiService;
            _databaseService = databaseService;
            Jokes = new ObservableCollection<JokeMR>();
            FetchJokeCommand = new Command(async () => await FetchJokeAsync());
        }
        private async Task FetchJokeAsync()
        {
            var joke = await _apiService.GetJokeAsync();
            var jokeMR = new JokeMR { Joke = joke };
            await _databaseService.SaveJokeAsync(jokeMR);
            Jokes.Add(jokeMR);
        }
        public async Task LoadJokesAsync()
        {
            var jokes = await _databaseService.GetJokesAsync();
            foreach (var joke in jokes)
            {
                Jokes.Add(joke);
            }
        }
    }
}