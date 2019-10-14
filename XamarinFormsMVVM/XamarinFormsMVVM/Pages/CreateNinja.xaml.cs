using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinFormsMVVM.ViewModel;

namespace XamarinFormsMVVM
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateNinja : ContentPage
    {
        public CreateNinjaViewModel ViewModel { get; set; }
        public CreateNinja()
        {
            InitializeComponent();
            ViewModel = new CreateNinjaViewModel();
            BindingContext = ViewModel;
        }
    }
}