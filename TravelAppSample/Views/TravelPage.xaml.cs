using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TravelAppSample.Views
{
    public partial class TravelPage : ContentPage
    {
        Button lastButton;

        public TravelPage()
        {
            InitializeComponent();

            for (int i = 1; i <= DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month); i++)
            {
                Button btn = new Button()
                {
                    Text = $"{i}",
                    TextColor = Color.Black, 
                    Padding = new Thickness(30, 10),
                    BackgroundColor = Color.Transparent
                };

                btn.Clicked += (sender, EventArgs) =>
                 {
                     if (lastButton != null)
                     {
                         VisualStateManager.GoToState(lastButton, "DayUnSelected");
                     }

                     VisualStateManager.GoToState((Button)sender, "DaySelected");

                     lastButton = (Button)sender;
                 };

                DaysBlock.Children.Add(btn);
            }
        }
    }
}
