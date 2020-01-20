using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Unike.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaInicial : ContentPage
    {
        public PaginaInicial()
        {
            InitializeComponent();
        }

        async void TenhoConta(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TenhoConta());
        }

        async void CriarConta(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CriarConta());
        }
    }
}