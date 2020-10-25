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
    public partial class nojabr : ContentPage
    {
        public nojabr()
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
            Label nimetus = new Label { Text = "Винтец", FontSize = 100 };
            Image img = new Image { Source = "makvin.jpg" };
            Label kirjeldus = new Label { Text = "В салоне появилась новая мультимедийная система с 8,4-дюймовым дисплеем, размещенная вертикально как у Теслы. Он реагирует на жесты голос. С данного дисплея производиться регулирование всех функций суперкара. Отделка интерьера представляется собой качественную ткань и алькантару. С помощью 8,4-дюймового экрана возможно настроить освещение интерьера суперкара в зависимости от манеры езды. Также возможно вывести на экран две камеры, установленные снаружи." };
            var tap = new TapGestureRecognizer();
            tap.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Цена", "Цена на обновленный суперкар Винтец составит 193 551,10 евро.", "Закрыть");
            };
            img.GestureRecognizers.Add(tap);
            grd.Children.Add(nimetus, 0, 0);
            grd.Children.Add(img, 0, 1);
            grd.Children.Add(kirjeldus, 0, 2);
            Content = grd;
        }
    }
}