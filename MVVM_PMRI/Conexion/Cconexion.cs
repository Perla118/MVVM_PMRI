using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;


namespace MVVM_PMRI.Conexion
{
    public class Cconexion
    {
        public static FirebaseClient firebase = new FirebaseClient("https://mvvmpmri-default-rtdb.firebaseio.com/");
    }
}
