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
    public partial class Fevral : ContentPage
    {
        public Fevral()
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
            Label nimetus = new Label { Text = "Мэтр", FontSize = 100 };
            Image img = new Image { Source = "makvin.jpg" };
            Label kirjeldus = new Label { Text = "Интерьер нового Мэтара получил значительные изменения. Мэ улучшили шумоизоляцию автомобиля.В автомобиле установлен 8 дюймовый HD дисплей мультимедийной системы.В салоне установлены 4 динамика, но за доплату можно установить 8 динамиков." };
            var tap = new TapGestureRecognizer();
            tap.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Информация", "базовая комплектация Comfort MT стартует от 9000 евро; средняя комплектация Luxury MT от 9500 евро; максимальный вариант Luxury CVT от 10000 евро.", "Закрыть");
            };
            img.GestureRecognizers.Add(tap);
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }
    }
}