using R1App.Master.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace R1App.NewFolder
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Orcamento_Clicked(object sender, EventArgs e)
        {
            await Navegacao.PushAsync(new Orcamento());
        }
    }
}