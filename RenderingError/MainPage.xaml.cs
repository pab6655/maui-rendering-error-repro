using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

namespace RenderingError
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            Microsoft.Maui.Controls.Application.Current.On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().UseWindowSoftInputModeAdjust(WindowSoftInputModeAdjust.Resize);
        }

        private async void NavigateBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new FirstPage());
        }
    }
}
