using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnoPlatformForXamarinForms.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UnoPlatformForXamarinForms.Views {
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
            var nameList = new List<string> { "1", "2", "3", "4", "5", "6" };
            BindingContext = new ViewModels.MainPageViewModel(this.Navigation, new Lottery(nameList) { Name = "Uno Platform WebAssembly Renderers for Xamarin.Forms" });
        }
    }
}