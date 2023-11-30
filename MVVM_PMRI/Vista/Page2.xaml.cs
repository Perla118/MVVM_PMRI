using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVM_PMRI.VistaModelo;
using MVVM_PMRI.Vista;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM_PMRI.Vista
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		public Page2 ()
		{
			InitializeComponent ();
			BindingContext = new VMpage2(Navigation);
		}
	}
}