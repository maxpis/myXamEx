using Xamarin.Forms;
using XamForms.Controls;
using System;

namespace MasterDetailPageNavigation
{
    public partial class Calendario : ContentPage
    {
        public Calendario()
        {
            InitializeComponent();

            /*
             * calendar.DateClicked += (object sender, DateTimeEventArgs e) =>
            {
                var dateSelect = calendar.SelectedDate;
                System.Console.Out.WriteLine(dateSelect);
            };
            */

            calendar.DateClicked += onDataSelection;
            calendar.SpecialDates.Add(new SpecialDate(DateTime.Now.AddDays(5))
            {
                BackgroundColor = Color.Fuchsia,
                TextColor = Color.Accent,
                BorderColor = Color.Maroon,
                BorderWidth = 8
            }
                                     );
            calendar.SpecialDates.Add(new SpecialDate(DateTime.Now.AddDays(6))
            {
                BackgroundColor = Color.Fuchsia,
                TextColor = Color.Accent,
                BorderColor = Color.Maroon,
                BorderWidth = 8
            });
            calendar.RaiseSpecialDatesChanged();

        }

        private void onDataSelection(object sender, DateTimeEventArgs e)
        {
            var dateSelect = (sender as Calendar).SelectedDate;
            System.Console.Out.WriteLine(dateSelect);

        }

    }
}

