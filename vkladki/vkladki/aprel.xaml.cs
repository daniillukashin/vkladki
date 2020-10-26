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
    public partial class aprel : ContentPage
    {
        public aprel()
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
            Label nimetus = new Label { Text = "Салли", FontSize = 100 };
            Image img = new Image { Source = "salli.jpg" };
            Label kirjeldus = new Label { Text = "Салли внутри выглядит несколько хуже, чем снаружи. Он по прежнему остается комфортным и функциональным. Внутренняя отделка представляет собой недорогие материалы (ткань,металл,пластик и искусственная кожа).Сиденья хоть и не имеет приятной обшивки и мягкого наполнения,но все равно являются очень комфортными. Багажник вмещается в себя достаточно большое количество груза при его объеме в 350 литров,а при сложенных задних сидениях,его объем увеличивается за 1000 литров." };
            var tap = new TapGestureRecognizer();
            tap.Tapped += async (s, e) =>
            {
                img = (Image)s;
                await DisplayAlert("Цена", "На данный момент цена на новый Салли не раскрыта.", "Закрыть");
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