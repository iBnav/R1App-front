using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace R1App.Master.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Orcamento : ContentPage
    {
        public Orcamento()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}