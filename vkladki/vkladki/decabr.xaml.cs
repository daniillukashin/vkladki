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
    public partial class decabr : ContentPage
    {
        public decabr()
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
            Label nimetus = new Label { Text = "Маквин", FontSize = 100};
            Image img = new Image { Source = "makvin.jpg" };
            Label kirjeldus = new Label { Text = "Интерьер MAKVIN достаточно изворотливый, и, хотя у него есть некоторые распределительные устройства с другими продуктами МОЛНИЯ, большинство переключателей и циферблатов будут казаться чуждым тем, кто не знаком с брендом. Это хорошо в разреженном секторе, в котором находится MAKVIN, и даже перед тем, как вы войдете внутрь, диэдронные спин-спиральные двери наиболее подходят для вас." };
            var tap = new TapGestureRecognizer();
            tap.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Цена", " Цена на самый быстрый гиперкар составляет 1 685 985,20 евро", "Закрыть");
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