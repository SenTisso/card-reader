using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using card_reader.Models;
using card_reader.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace card_reader.Views
{
    public partial class CardListPage : ContentPage
    {
        
        public CardListPage()
        {
            InitializeComponent();
            
        }

        protected override async void OnAppearing()
        {
            this.IsBusy = true;
            
            // toto vygeneruje XAML content pro CardListPage
            // musi se to delat timto zpusobem, jelikoz z DB potrebuji dostat data do gridu a ne do list view a XAML nepodporuje array dat v gridu jakoby
            
            AbsoluteLayout Layout = new AbsoluteLayout()
            {
                BackgroundColor = (Color) Application.Current.Resources["Background"], // BackgroundColor="{StaticResource Background}"
                Padding = (Thickness) Application.Current.Resources["PagePadding"] // Padding="{StaticResource PagePadding}"
            };
            
            /* Grid */
            Grid Grid = new Grid
            {
                ColumnDefinitions =
                {
                    new ColumnDefinition() { Width = new GridLength(50, GridUnitType.Star) },
                    new ColumnDefinition() { Width = new GridLength(50, GridUnitType.Star) }
                }
            };

            /* Cards */
            List<Card> Cards = await App.Database.GetCards();

            decimal count = Math.Ceiling((decimal) Cards.Count / 2);
            for (int j = 0; j < count; j++)
            {
                Grid.RowDefinitions.Add(new RowDefinition()
                {
                    Height = 100
                });
            }

            int row = 0;
            int col = 0;
            int i = 0;
            foreach (Card SavedCard in Cards)
            {
                // index je delitelny 2 
                if (i > 0 && i % 2 == 0) row++; // to znamena, ze je dalsi radek (jelikoz jsou 2 sloupce)
                ImageButton CardButton = new ImageButton()
                {
                    Source = "billa.png",
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    CornerRadius = 7,
                    ClassId = SavedCard.ID.ToString()
                };
                CardButton.Clicked += OnViewCard; // prida Clicked event
                Grid.Children.Add(CardButton, col, row);

                // pokud col byl 0, tak dalsi dej na 1. Pokud byl 1, tak dalsi dej na 0
                if (col == 0) col++;
                else col--;
                
                i++;
            }
            AbsoluteLayout.SetLayoutFlags(Grid, AbsoluteLayoutFlags.All); // AbsoluteLayout.LayoutFlags="All"
            AbsoluteLayout.SetLayoutBounds(Grid, new Rectangle(0, 0, 1, 1)); // AbsoluteLayout.LayoutBounds="0,0,1,1"
            Layout.Children.Add(Grid); // prida dynamicky vygenerovany Grid jako dite Layoutu
            /* Cards */
            /* Grid */

            
            /* FAB */
            Button Button = new Button()
            {
                BackgroundColor = (Color) Application.Current.Resources["Primary"],
                Text = "+",
                FontSize = 36,
                TextColor = Color.White,
                HeightRequest = 80,
                WidthRequest = 80,
                CornerRadius = 40
            };
            Button.Clicked += OnAddCard; // prida event na pridani karty
            AbsoluteLayout.SetLayoutFlags(Button, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(Button, new Rectangle(0.95, 0.95, 72, 72));
            Layout.Children.Add(Button);
            /* FAB */
            
            Content = Layout;

            this.IsBusy = false;
        }

        async void OnViewCard(object sender, EventArgs e)
        {
            ImageButton ImageButton = (ImageButton) sender;

            Card SavedCard = await App.Database.GetCard(Int32.Parse(ImageButton.ClassId));
            
            // preda detailu karty kartu
            await Navigation.PushAsync(new CardDetailPage(SavedCard));
        }

        async void OnAddCard(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChooseCardPage { });
        }
    }
}
