using MvvmGuia.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_Implementacion_JEMF.Modelo;
using MVVM_Implementacion_JEMF.Datos;

namespace MVVM_Implementacion_JEMF.VistaModelo.VMpokemon
{
    public class VMregistropokemon  : BaseViewModel
    {
        #region VARIABLES
        string _Txtcolorfondo;
        string _Txtcolorpoder;
        string _Txtnombre;
        string _Txtnro;
        string _Txtpoder;
        string _Txticono;
        #endregion
        #region CONSTRUCTOR
        public VMregistropokemon(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS
        public string Txtcolorfondo
        {
            get { return _Txtcolorfondo; }
            set { SetValue(ref _Txtcolorfondo, value); }
        }
        public string Txtcolorpoder
        {
            get { return _Txtcolorpoder; }
            set { SetValue(ref _Txtcolorpoder, value); }
        }
        public string Txtnombre
        {
            get { return _Txtnombre; }
            set { SetValue(ref _Txtnombre, value); }
        }
        public string Txtnro
        {
            get { return _Txtnro; }
            set { SetValue(ref _Txtnro, value); }
        }
        public string Txtpoder
        {
            get { return _Txtpoder; }
            set { SetValue(ref _Txtpoder, value); }
        }
        public string Txticono
        {
            get { return _Txticono; }
            set { SetValue(ref _Txticono, value); }
        }
        #endregion

        #region PROCESS
        public async Task Insertar ()
        {
            var funcion = new Dpokemon();
            var paramaetros = new Mpokemon();
            paramaetros.Colorfondo = _Txtcolorfondo;
            paramaetros.Colorpoder = _Txtcolorpoder;
            paramaetros.Icono = _Txticono;
            paramaetros.Nombre= _Txtnro;
            paramaetros.NroOrden = _Txtnro;
            paramaetros.Poder= _Txtpoder;

            await funcion.InsertarPokemon(paramaetros);
            await Volver();
        }
        public async Task Volver()
        {
            await Navigation.PopAsync();    
        }

        public void ProcesoSimple()
        {

        }
        #endregion

        #region COMMANDS
        public ICommand InsertarCommand => new Command(async () => await Insertar());
        public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
