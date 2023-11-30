using MVVM_PMRI.Vista;
using MVVM_PMRI.VistaModelo;
using System;
using MVVM_PMRI.Modelo;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_PMRI.VistaModelo
{
    class VMpage2 : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        public List<Musuarios> listausuarios { get; set; }
        #endregion
        #region CONSTRUCTOR
        public VMpage2(INavigation navigation)
        {
            Navigation = navigation;
            Mostrarusuarios();
        }

        #endregion
        #region OBJETOS

        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS

        public async Task Volver()
        {
            await Navigation.PopAsync();
        }

        public void ProcesoSimple()
        {

        }
        public void Mostrarusuarios()
        {
            listausuarios = new List<Musuarios>
            {
                new Musuarios
                {
                    Nombre="EduardoSlzr",
                    Imagen="https://i.ibb.co/XZ8Hw3d/baloncesto.png"
                },
                new Musuarios
                {
                    Nombre="Guillen",
                    Imagen="https://i.ibb.co/tbXWGJF/smartphone.png"
                },
                new Musuarios
                {
                    Nombre="Xana",
                    Imagen="https://i.ibb.co/xmVD538/trompo.png"
                }
            };
        }
        public async Task Alerta(Musuarios parametros)
        {
            await DisplayAlert("Titulo", parametros.Nombre, "Ok");
        }
        #endregion
        #region COMANDOS
        public ICommand Volvercommand => new Command(async () => await Volver());
        //public ICommand ProcesoSimpcommand => new Command(ProcesoSimple);
        #endregion
        public ICommand Alertacommand => new Command<Musuarios>(async (p) => await Alerta(p));
    }
}
