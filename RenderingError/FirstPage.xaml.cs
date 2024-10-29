namespace RenderingError;

public partial class FirstPage : ContentPage
{
    public FirstPage()
    {
        InitializeComponent();

        BindingContext = new FirstPageViewModel { Text = "--" };
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new SecondPage(ItemSelected));
    }

    private void ItemSelected(string item)
    {
        if (item != null)
        {
            ((FirstPageViewModel)BindingContext).Text = item;
        }
    }
}