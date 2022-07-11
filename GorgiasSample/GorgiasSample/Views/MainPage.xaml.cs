
using Xamarin.Forms;

namespace GorgiasSample.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            DependencyService.Get<IDeviceSpecificService>().ClearCookies();
            webView.Reload();
        }
    }
}
