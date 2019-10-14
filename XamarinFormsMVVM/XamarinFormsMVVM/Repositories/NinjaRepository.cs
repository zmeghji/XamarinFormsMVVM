using System;
using System.Collections.Generic;
using System.Text;
using XamarinFormsMVVM.Models;

namespace XamarinFormsMVVM.Repositories
{
    public class NinjaRepository
    {
        private static ICollection<Ninja> _ninjas= new List<Ninja>();
        static NinjaRepository()
        {
            _ninjas.Add(new Ninja
            {
                FirstName = "Naruto",
                LastName = "Uzumaki"
            });
            _ninjas.Add(new Ninja
            {
                FirstName = "Sakura",
                LastName = "Haruno"
            });
            _ninjas.Add(new Ninja
            {
                FirstName = "Sasuke",
                LastName = "Uchiha"
            });
        }
        public NinjaRepository()
        {
        }
        public Ninja Create(Ninja ninja)
        {
            _ninjas.Add(ninja);
            return ninja;
        }
        public ICollection<Ninja> Get()
        {
            return _ninjas;
        }
    }
}
