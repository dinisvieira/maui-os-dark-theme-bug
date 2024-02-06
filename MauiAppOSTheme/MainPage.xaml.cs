namespace MauiAppOSTheme
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            await Share.Default.RequestAsync(new ShareTextRequest
            {
                Uri = "https://learn.microsoft.com/en-us/dotnet/maui/?view=net-maui-8.0",
                Title = "Share Maui Doc"
            });
        }
    }
}