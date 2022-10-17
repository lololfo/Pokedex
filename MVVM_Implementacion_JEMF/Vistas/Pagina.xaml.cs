using MVVM_Implementacion_JEMF.VistaModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_Implementacion_JEMF.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina : ContentPage
    {
        public Pagina()
        {
            InitializeComponent();
            BindingContext = new VMPagina1(Navigation);
        }
    }
}