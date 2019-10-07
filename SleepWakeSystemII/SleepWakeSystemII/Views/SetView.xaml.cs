using SleepWakeSystemII.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SleepWakeSystemII.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SetView : ContentPage
	{
		public SetView ()
		{
			InitializeComponent ();
            this.BindingContext = new SetViewModel(Navigation);
		}
	}
}