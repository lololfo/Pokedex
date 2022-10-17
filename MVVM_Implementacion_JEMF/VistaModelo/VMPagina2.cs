using MvvmGuia.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_Implementacion_JEMF.Modelo;

namespace MVVM_Implementacion_JEMF.VistaModelo
{
    public class VMPagina2 : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Musuarios> listaUsuarios { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMPagina2(INavigation navigation)
        {
            Navigation = navigation;
            MostrarUsuarios();
        }
        #endregion

        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion

        #region PROCESS
        public async Task Volver()
        {
            await Navigation.PopAsync();
        }

        public void ProcesoSimple()
        {

        }

        public void MostrarUsuarios ()
        {
            listaUsuarios = new List<Musuarios>{
                new Musuarios {
                    Nombre = "Diana",
                    Imagen = "https://i.ibb.co/fdgsc9P/pizza.png"
                },
                new Musuarios {
                    Nombre = "Juan",
                    Imagen = "https://i.ibb.co/3r5mqB1/hamburgo.png"
                },
                new Musuarios {
                    Nombre = "Parra",
                    Imagen = "https://i.ibb.co/0ypFfg3/sushi.png"
                }
            };
        }

        public async Task Alerta (Musuarios parametros)
        {
            await DisplayAlert("Titutlo", parametros.Nombre, "OK");
        }
        #endregion

        #region COMMANDS
        public ICommand VolverCommand => new Command(async () => await Volver());
        public ICommand AlertaCommand => new Command<Musuarios>(async (p) => await Alerta(p));
        #endregion
    }
}
