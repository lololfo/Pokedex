using MVVM_Implementacion_JEMF.Modelo;
using MVVM_Implementacion_JEMF.Vistas;
using MvvmGuia.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_Implementacion_JEMF.VistaModelo
{
    public class VMMenuPrincipal : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<MenuPrincipal> listaMenus { get; set; }
        #endregion

        #region CONSTRUCTOR
        public VMMenuPrincipal(INavigation navigation)
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
            listaMenus = new List<MenuPrincipal>{
                new MenuPrincipal {
                    Pagina = "Entry, datepicker, picker, label, navegacion",
                    Icono = "https://i.ibb.co/gvpcDWw/pescado.png"
                },
                new MenuPrincipal {
                    Pagina = "Collection view sin enlace a base de datos",
                    Icono = "https://i.ibb.co/RSrm1rJ/pulpo.png"
                },
                new MenuPrincipal {
                    Pagina = "Crud pokemon",
                    Icono = "https://i.ibb.co/ZLCmpR7/caja-de-leche.png"
                }
            };
        }

        public async Task Navegar(MenuPrincipal parametros)
        {
            string pagina;
            pagina = parametros.Pagina;

            if (pagina.Contains("Entry, datepicker"))
            {
                await Navigation.PushAsync(new Pagina());
            }
            if (pagina.Contains("CollectionView sin enlace"))
            {
                await Navigation.PushAsync(new Page2());
            }
            if (pagina.Contains("Crud pokemon"))
            {
                await Navigation.PushAsync(new CrudPokemon());
            }
        }
        #endregion

        #region COMMANDS
        // public ICommand VolverCommand => new Command(async () => await Volver());
        public ICommand NavegarCommand => new Command<MenuPrincipal>(async (p) => await Navegar(p));
        #endregion
    }
}
