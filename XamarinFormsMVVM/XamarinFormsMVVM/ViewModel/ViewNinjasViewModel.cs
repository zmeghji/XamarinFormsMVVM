using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinFormsMVVM.Models;
using XamarinFormsMVVM.Repositories;

namespace XamarinFormsMVVM.ViewModel
{
    public class ViewNinjasViewModel  : ViewModelBase
    {
        private ObservableCollection<Ninja> _model;
        private NinjaRepository _ninjaRepository;
        public ViewNinjasViewModel(INavigation navigation)
        {
            _ninjaRepository = new NinjaRepository();
            _model = new ObservableCollection<Ninja>(_ninjaRepository.Get());
            this._navigation = navigation;
        }
        public ObservableCollection<Ninja> Ninjas { 
            get => _model;
            private set
            {
                _model = value;
                RaisePropertyChangedEvent(nameof(Ninjas));
            }
        }
        public ICommand NavigateToCreateNinjaPageCommand => new Command(OnNavigateToCreateNinjaPage);
        private readonly INavigation _navigation;

        private async void OnNavigateToCreateNinjaPage()
        {
            await _navigation.PushAsync(new CreateNinja());
        }

        public ICommand RefreshDataCommand => new Command(OnRefreshData);

        private async void OnRefreshData()
        {
            Ninjas = new ObservableCollection<Ninja>(_ninjaRepository.Get());
        }
    }
}
