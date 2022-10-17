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
    public class VMPagina1 : BaseViewModel
    {
        #region VARIABLES
        string _TipoUsuario;
        string _N1;
        string _N2;
        string _R;
        string _Fecha;
        #endregion

        #region CONSTRUCTOR
        public VMPagina1(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion

        #region OBJETOS
        public string N1
        {
            get { return _N1; }
            set { SetValue(ref _N1, value); }
        }
        public string N2
        {
            get { return _N2; }
            set { SetValue(ref _N2, value); }
        }
        public string R
        {
            get { return _R; }
            set { SetValue(ref _R, value); }
        }

        public string TipoUsuario
        {
            get { return _TipoUsuario; }
            set { SetValue(ref _TipoUsuario, value); }
        }

        public string SeleccionarTipoUsuario
        {
            get { return _TipoUsuario; }
            set
            {
                SetProperty(ref _TipoUsuario, value);
                TipoUsuario = _TipoUsuario;
            }
        } 
        public string Fecha
        {
            get { return _Fecha; }
            set { SetValue(ref _Fecha, value); }
        }

        public string SeleccionarFecha
        {
            get { return _Fecha; }
            set
            {
                SetProperty(ref _Fecha, value);
                Fecha = _Fecha;
            }
        } 

        #endregion

        #region PROCESS
        public async Task ProcesoAsync()
        {
            await Navigation.PushAsync(new Page2());
        }

        public async Task IrAMenuPrincipal()
        {
            await Navigation.PushAsync(new Menuprincipal());
        }
        public void Suma()
        {
            double n1 = Convert.ToDouble(N1);
            double n2 = Convert.ToDouble(N2);
            double r = Convert.ToDouble(R);

            r = n1 + n2;

            R = r.ToString();
        }
        #endregion

        #region COMMANDS
        public ICommand PNavegarPagina2Coomand => new Command(async () => await ProcesoAsync());
        public ICommand PNavegarMenuPrincipal => new Command(async () => await IrAMenuPrincipal());
        public ICommand SumarCommand => new Command(Suma);
        #endregion
    }
}
