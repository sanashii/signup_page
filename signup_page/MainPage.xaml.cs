using Microsoft.Maui.Controls;

namespace signup_page
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Sign Up", "Sign Up button clicked", "OK");
        }

        private void OnLoginLabelTapped(object sender, EventArgs e)
        {
            DisplayAlert("Login", "Login button clicked!", "OK");
        }
    }

}
