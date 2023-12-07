using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_PMRI.Modelo;
using MVVM_PMRI.Vista.Pokemon;
using MVVM_PMRI.Datos;
using System.Collections.ObjectModel;
using MVVM_PMRI.VistaModelo;

namespace MVVM_PMRI.VistaModelo.VMpokemon
{
    public class VMlistapokemon : BaseViewModel
    {
        ////////////////////////////


        #region VARIABLES


        // ObservableCollection<Mpokemon> _Listapokemon;//tiempo real 
        List<Mpokemon> _Listapokemon;// este no sirve para el tiempo real
        #endregion
        #region Contructor
        public VMlistapokemon(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarpokemon();
        }
        #endregion
        #region Objetivo;
        //Este sirve para que la aplicacion corra en tiempo real
        /*
        public ObservableCollection<Mpokemon> Listapokemon
        {
            get { return _Listapokemon; }
            set { SetValue(ref _Listapokemon, value);
                OnpropertyChanged();//es nesario para actualizar tus datos si despues de hacer algun cambio a tus registros o tiempo real
            
            }
        }
        
         */

        //este sirve para que el la aplicacion optenga una lista No es en tiempo real
        public List<Mpokemon> Listapokemon
        {
            get { return _Listapokemon; }
            set
            {
                SetValue(ref _Listapokemon, value);
                OnpropertyChanged();//es nesario para actualizar tus datos si despues de hacer algun cambio a tus registros o tiempo real

            }
        }
        #endregion
        #region PROCESOS
        public async Task Mostrarpokemon()
        {
            var funcion = new Dpokemon();
            Listapokemon = await funcion.MostrarPokemon2();//Cambiar esto a MostrarPokemon 2 para que saea en tiempo real
        }

        public async Task IrARegistro()
        {
            await Navigation.PushAsync(new Registrarpokemon());
        }
        public async Task IraEditar(Mpokemon poquimon)
        {
            await Navigation.PushAsync(new Mostrarpokemon(poquimon));
        }

        #endregion.

        #region COMANDOS
        public ICommand IrARegistrocommand => new Command(async () => await IrARegistro());
        public ICommand IraEditarcommand => new Command<Mpokemon>(async (p) => await IraEditar(p));
        #endregion







        ///////////////////////////


    }
}


