using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R1App
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class SendSMS : CarouselPage
    {
        public SendSMS()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.CurrentPage = Verify;
        }

        private void btn_confirmar_clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new Cadastro.Signup();
        }
    }
}
