using System;
using Xamarin.Forms;
using BudgetBuddy.Models;
using Microsoft.Extensions.Logging;
using BudgetBuddy;
using BudgetBuddy.Views;


namespace BudgetBuddy
{
    public class HomePage : ContentPage
    {
        private readonly ILogger<HomePage> _logger;

        public HomePage(ILogger<HomePage> logger)
        {
            _logger = logger;

            var indexButton = new Button { Text = "Index" };
            var privacyButton = new Button { Text = "Privacy" };
            var errorButton = new Button { Text = "Error" };

            indexButton.Clicked += OnIndexButtonClicked;
            privacyButton.Clicked += OnPrivacyButtonClicked;
            errorButton.Clicked += OnErrorButtonClicked;

            Content = new StackLayout
            {
                Children = { indexButton, privacyButton, errorButton }
            };
        }

        private async void OnIndexButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IndexPage());
        }

        private async void OnPrivacyButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PrivacyPage());
        }

        private void OnErrorButtonClicked(object sender, EventArgs e)
        {
            _logger.LogError("Error button clicked.");
        }
    }
}
