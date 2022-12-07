using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;

namespace MVVM_Implementacion_JEMF.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://pokedex-3a367-default-rtdb.firebaseio.com/");
    }
}
