﻿using MvvmGuia.VistaModelo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_Implementacion_JEMF.Modelo;
using MVVM_Implementacion_JEMF.Vistas.Pokemon;
using MVVM_Implementacion_JEMF.Datos;
using System.Collections.ObjectModel;
namespace MVVM_Implementacion_JEMF.VistaModelo.VMpokemon
{
    public class VMlistapokemon : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        List<Mpokemon> _Listapokemon;
        #endregion

        #region CONSTRUCTOR
        public VMlistapokemon(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarpokemon();
        }
        #endregion

        #region OBJETOS
        public List<Mpokemon> Listapokemon
        {
            get { return _Listapokemon; }
            set { SetValue(ref _Listapokemon, value); 
            OnPropertyChanged();
            }
        }
        #endregion
        #region PROCESS
        public async Task Mostrarpokemon()
        {
            var funcion = new Dpokemon();
            Listapokemon = await funcion.MostrarPokemones();
        }
        public async Task Iraregistro()
        {
            await Navigation.PushAsync(new Registrarpokemon());
        }

        public void ProcesoSimple()
        {

        }
        #endregion

        #region COMMANDS
        public ICommand Iraregistrocommand => new Command(async () => await Iraregistro());
        public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
    }
}
