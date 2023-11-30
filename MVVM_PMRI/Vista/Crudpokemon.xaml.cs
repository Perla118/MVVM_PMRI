using MVVM_PMRI.VistaModelo;
using MVVM_PMRI.VistaModelo.VMpokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_PMRI.Vista
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Crudpokemon : ContentPage
	{
		public Crudpokemon ()
		{
			InitializeComponent ();
            
        }
	}
}