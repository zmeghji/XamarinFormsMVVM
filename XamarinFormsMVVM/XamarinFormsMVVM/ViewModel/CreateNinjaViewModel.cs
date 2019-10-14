using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFormsMVVM.Models;
using XamarinFormsMVVM.Repositories;

namespace XamarinFormsMVVM.ViewModel
{
    public class CreateNinjaViewModel : ViewModelBase
    {
        private readonly NinjaRepository _ninjaRepository;
        public CreateNinjaViewModel()
        {
            _model = new Ninja();
            _ninjaRepository = new NinjaRepository();
        }
        public ICommand CreateNinjaCommand => new Command(OnCreateNinja);
        private async void OnCreateNinja()
        {
            _ninjaRepository.Create(_model);
            UserDialogs.Instance.Toast("Created Ninja");
            _model = new Ninja();
            FirstName = _model.FirstName;
            LastName = _model.LastName;

        }
        public string FirstName {
            get => _model.FirstName;
            set
            {
                _model.FirstName = value;
                RaisePropertyChangedEvent(nameof(_model.FirstName));
            }
        }
        public string LastName
        {
            get => _model.LastName;
            set
            {
                _model.LastName = value;
                RaisePropertyChangedEvent(nameof(_model.LastName));
            }
        }
        public Ninja _model { get; set; }
    }
}
