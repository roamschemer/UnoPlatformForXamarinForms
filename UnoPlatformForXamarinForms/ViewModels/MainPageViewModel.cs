using Reactive.Bindings;
using System;
using Reactive.Bindings.Extensions;
using System.Text;
using UnoPlatformForXamarinForms.Extends;
using UnoPlatformForXamarinForms.Models;
using Xamarin.Forms;


namespace UnoPlatformForXamarinForms.ViewModels {
    public class MainPageViewModel : BindableBase {
        public ReactiveProperty<string> LabelText { get; }
        public ReactiveCommand LotteryCommand { get; }

        private int age;
        public int Age {
            get { return this.age; }
            set { this.SetProperty(ref this.age, value); }
        }
        public Command AgeCommand { get; }

        public MainPageViewModel(INavigation navigation, Lottery lottery) {
            LabelText = new ReactiveProperty<string>();
            LabelText = lottery.ObserveProperty(x => x.Name).ToReactiveProperty();
            LotteryCommand = new ReactiveCommand();
            LotteryCommand.Subscribe(_ => lottery.Action());
            Age = 17;

            AgeCommand = new Command(() => Age = 10);
        }
    }
}
