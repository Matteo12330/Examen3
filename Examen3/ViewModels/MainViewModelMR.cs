using System.Collections.ObjectModel;
using Examen3.Data;
using Examen3.Models;

namespace Examen3.ViewModels
{
    public class MainViewModelMR
    {
        private readonly DatabaseServiceMR _dogServiceMR;

        public ObservableCollection<Dog> Dogs { get; set; }

        public MainViewModelMR(DatabaseServiceMR dogServiceMR)
        {
            _dogServiceMR = dogServiceMR;
            Dogs = new ObservableCollection<Dog>(_dogServiceMR.GetDogs());
        }

        public void AddDog(Dog dog)
        {
            _dogServiceMR.AddDog(dog);
            Dogs.Add(dog);
        }
    }
}
