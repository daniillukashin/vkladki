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
    public partial class sentabr : ContentPage
    {
        public sentabr()
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
            Label nimetus = new Label { Text = "Сморкач", FontSize = 90 };
            Image img = new Image { Source = "smork.webp" };
            Label kirjeldus = new Label { Text = "Интерьер хэтчбека Сморкач выполнен также качественно, стильно и современно.Оснащается автомобиль 7-дюймовым цветным экраном бортового компьютера, мультифункциональным рулем, 8-дюймовым цветным сенсорным экраном мультимедийного комплекса, подогревом передних сидений, 7-ю подушками безопасности, электрическим ручным тормозом, системой автоматического торможения при обнаружение пешеходов и ситемой удержания полосы." };
            var tap = new TapGestureRecognizer();
            tap.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Цена", "Цена на новый хэтчбек Сморкач будет варьироваться от 13 748,10 евро.", "Закрыть");
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