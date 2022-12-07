using Firebase.Database;
using Firebase.Database.Query;
using MVVM_Implementacion_JEMF.Conexion;
using MVVM_Implementacion_JEMF.Modelo;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVVM_Implementacion_JEMF.Datos
{
    public class Dpokemon
    {
        public async Task InsertarPokemon(Mpokemon paramaetros) 
        {
            await Cconexion.firebase
                .Child("Pokemon")
                .PostAsync(new Mpokemon()
                {
                    Colorfondo = paramaetros.Colorfondo,
                    Colorpoder = paramaetros.Colorpoder,
                    Icono = paramaetros.Icono,
                    Nombre = paramaetros.Nombre,
                    NroOrden = paramaetros.NroOrden,
                    Poder = paramaetros.Poder
                });
        }
        public async Task<List<Mpokemon>> MostrarPokemones()
        {
            return (await Cconexion.firebase
            .Child("Pokemon")
            .OnceAsync<Mpokemon>())
            .Select(item => new Mpokemon
            {
                Idpokemon = item.Key,
                Nombre = item.Object.Nombre,
                Colorfondo = item.Object.Colorfondo,
                Colorpoder = item.Object.Colorpoder,
                Icono = item.Object.Icono,
                NroOrden = item.Object.NroOrden,
                Poder = item.Object.Poder
            }).ToList();
            //var data = await Task.Run(()=> Cconexion.firebase
            //    .Child("Pokemon")
            //    .AsObservable<Mpokemon>()
            //  .AsObservableCollection());
            //return data;

        }
    }
}
