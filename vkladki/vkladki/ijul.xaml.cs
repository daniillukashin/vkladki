using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace vkladki
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ijul : ContentPage
    {
        public ijul()
        {
            InitializeComponent();
            Grid grd = new Grid
            {
                RowDefinitions =
   {
   new RowDefinition {Height=new GridLength(1,GridUnitType.Star)},
   new RowDefinition {Height=new GridLength(1,GridUnitType.Star)},
   new RowDefinition {Height=new GridLength(1,GridUnitType.Star)}
   },
                ColumnDefinitions =
   {
   new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
   }
            };
            Label nimetus = new Label { Text = "Кинг", FontSize = 100 };
            Image img = new Image { Source = "king.jpg" };
            Label kirjeldus = new Label { Text = "Интерьер нового Кинга тоже получил множество изменений. Была установлена новая передняя панель, которая была выполнена из более качественных материалов. Она стала более современной и стильной." };
            var tap = new TapGestureRecognizer();
            tap.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Цена", "Цена на новый внедорожник 2 поколения Кинг будет начинаться от 8 427,77 евро.", "Закрыть");
                img.Opacity = 0;
            };
            img.GestureRecognizers.Add(tap);
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }
    }
}