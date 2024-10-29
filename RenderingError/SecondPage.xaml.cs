namespace RenderingError;

public partial class SecondPage : ContentPage
{
    private readonly Action<string> _callback;

    public SecondPage(Action<string> callback)
    {
        InitializeComponent();

        BindingContext = new SecondPageViewModel(Navigation, callback);
    }

    override protected async void OnAppearing()
    {
        await Task.Delay(500);

        _entry.Focus();

        base.OnAppearing();
    }

    protected override void OnDisappearing()
    {
        _entry.Unfocus();

        base.OnDisappearing();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopModalAsync();
    }
}