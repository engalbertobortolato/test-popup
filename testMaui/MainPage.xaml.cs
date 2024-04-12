using CommunityToolkit.Maui.Views;
using testMaui.Pages.Shared;

namespace testMaui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            PopUp setup_Password_Popup = new PopUp();
            var response = await this.ShowPopupAsync(setup_Password_Popup);
           

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
