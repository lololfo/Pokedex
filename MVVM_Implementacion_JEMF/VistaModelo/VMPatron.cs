﻿using MvvmGuia.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_Implementacion_JEMF.VistaModelo
{
    class VMPatron : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion

        #region CONSTRUCTOR
        public VMPatron (INavigation navigation)
        {
            Navigation = navigation;
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
        public async Task ProcesoAsyncrono ()
        {

        }

        public void ProcesoSimple ()
        {

        }
        #endregion

        #region COMMANDS
        public ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}