using Xamarin.Forms;

namespace CoffeeX
{
    public partial class CoffeeXPage : ContentPage
    {
        public CoffeeXPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("hallo");
        }
    }
}
