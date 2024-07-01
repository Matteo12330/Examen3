using System;
using System.Collections.Generic;
using Examen3.Models;

namespace Examen3.Data
{
    public class DatabaseServiceMR
    {
        // Simulación de una base de datos en memoria
        private List<Dog> _dogs = new List<Dog>();

        public void AddDog(Dog dog)
        {
            _dogs.Add(dog);
        }

        public List<Dog> GetDogs()
        {
            return _dogs;
        }
    }
}
