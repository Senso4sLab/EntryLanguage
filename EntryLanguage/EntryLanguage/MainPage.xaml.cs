using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EntryLanguage
{
    public partial class MainPage : ContentPage
    {

        double numericalNumber;
        public double NumericalNumber
        {
            get => numericalNumber;
            set
            {
                numericalNumber = value;
                OnPropertyChanged();
            }
        }
        double numericalNumber1;
        public double NumericalNumber1
        {
            get => numericalNumber1;
            set
            {
                numericalNumber1 = value;
                OnPropertyChanged();
            }
        }

        double result;
        public double Result
        {
            get => result;
            set
            {
                result = value;
                OnPropertyChanged();
            }
        }
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Result = NumericalNumber1 * NumericalNumber;
        }
    }
}
