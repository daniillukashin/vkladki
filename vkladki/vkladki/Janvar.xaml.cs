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
    public partial class Janvar : ContentPage
    {
        public Janvar()
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
                Label nimetus = new Label { Text = "Док Хадсон", FontSize = 100 };
                Image img = new Image { Source = "makvin.jpg" };
                Label kirjeldus = new Label
                {
                    Text = "Современный, стильный и красиво оформленный интерьер Дока. В Доке каждый компонент был тщательно разработан для обеспечения утонченного тактильного опыта. Кабина оборачивается вокруг водителя, а селектор передач SportShift находится у вас под рукой. Ультратонкое зеркало заднего вида имеет бескаркасную конструкцию."
                };
                var tap = new TapGestureRecognizer();
                tap.Tapped += async (s, e) =>
                {
                    img = (Image)s;
                    await DisplayAlert("Информация", "Цена начинается от 27000 евро в минимальной комплектации", "Закрыть");
                };
                img.GestureRecognizers.Add(tap);
                grd.Children.Add(nimetus, 0, 0);
                grd.Children.Add(img, 0, 1);
                grd.Children.Add(kirjeldus, 0, 2);
                Content = grd;
            }
        }
    }