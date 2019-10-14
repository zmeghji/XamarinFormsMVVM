using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsMVVM.Models;
using XamarinFormsMVVM.Repositories;
using XamarinFormsMVVM.ViewModel;

namespace XamarinFormsMVVM.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewNinjas : ContentPage
    {
        public ViewNinjasViewModel ViewModel { get; set; }
        public ViewNinjas()
        {
            InitializeComponent();
            ViewModel = new ViewNinjasViewModel(Navigation);
            BindingContext = ViewModel;
        }
    }
}