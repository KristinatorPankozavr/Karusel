using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Karusel
{
    public partial class MainPage : CarouselPage
    {
        public MainPage()
        {
            Button openTestButton = new Button()
            {
                Text = "Пройти тест",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            openTestButton.Clicked += OpenTestButton_Clicked;
            var start = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                         new Frame
                        {
                            BackgroundColor = Color.Wheat,
                            Content = new Label { Text = "Виды темперамента", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                            HorizontalOptions = LayoutOptions.Center}

                        },
                          new Image {
                          Source = "es.jpg",
                          WidthRequest = 10,
                          HeightRequest = 400,},
                        new Label
                        {
                            Text = "Темперамент- Совокупность душевных, психических свойств человека, характеризующих степень его возбудимости и проявляющихся в его отношении к окружающей действительности, в поведении.",
                            HorizontalOptions = LayoutOptions.Center,
                            TextColor = Color.Black,
                            BackgroundColor = Color.Wheat,
                            WidthRequest = 300,
                            HeightRequest = 250,
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))
                        },
                        openTestButton
                    }
                }
            };
            var holerik = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Frame
                        {
                            BackgroundColor = Color.Wheat,
                            Content = new Label { Text = "Холерик", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                             HorizontalOptions = LayoutOptions.Center,}

                        },
                        new Label
                        {
                            Text = "Импульсивность, агрессия",
                            TextColor = Color.Black,
                            BackgroundColor = Color.Wheat,
                            HorizontalOptions = LayoutOptions.Center,
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))
                        },
                        new Image { Source = "zlo.jpg",
                          WidthRequest = 10,
                          HeightRequest = 400 },
                        openTestButton
                    }
                }
            };
            var sangvinik = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                        new Frame
                        {
                            BackgroundColor = Color.Wheat,
                            Content = new Label { Text = "Сангвиник", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                             HorizontalOptions = LayoutOptions.Center,}

                        },
                        new Label
                        {
                            Text = "Подвижный, социальный, уверенный в себе",
                            TextColor = Color.Black,
                            BackgroundColor = Color.Wheat,
                            HorizontalOptions = LayoutOptions.Center,
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))
                        },
                        new Image {Source = "vloroee.jpg",
                          WidthRequest = 10,
                          HeightRequest = 400},
                        openTestButton
                    }
                }
            };
            var flegmatik = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                         new Frame
                        {
                            BackgroundColor = Color.Wheat,
                            Content = new Label { Text = "Флегматик", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                             HorizontalOptions = LayoutOptions.Center,}

                        },
                        new Label
                        {
                            Text = "Социально отстраненный, погруженный в себя",
                            TextColor = Color.Black,
                            BackgroundColor = Color.Wheat,
                            HorizontalOptions = LayoutOptions.Center,
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))
                        },
                        new Image {Source = "fleg.jpg",
                          WidthRequest = 10,
                          HeightRequest = 400},
                        openTestButton
                    }
                }
            };
            var melanholik = new ContentPage
            {
                Content = new StackLayout
                {
                    Children =
                    {
                         new Frame
                        {
                            BackgroundColor = Color.Wheat,
                            Content = new Label { Text = "Меланхолик", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                             HorizontalOptions = LayoutOptions.Center,}

                        },
                        new Label
                        {
                            Text = "Грустный, боязливый, подавленный, слабый",
                            TextColor = Color.Black,
                            BackgroundColor = Color.Wheat,
                            HorizontalOptions = LayoutOptions.Center,
                            FontSize = Device.GetNamedSize (NamedSize.Large, typeof(Label))
                        },
                        new Image {Source = "grust.jpg",
                            WidthRequest = 300,
                            HeightRequest = 300},
                        openTestButton
                    }
                }
            };
            Children.Add(start);
            Children.Add(holerik);
            Children.Add(sangvinik);
            Children.Add(flegmatik);
            Children.Add(melanholik);
        }

        private async void OpenTestButton_Clicked(object sender, EventArgs e)
        {
            await Browser.OpenAsync("https://testometrika.com/personality-and-temper/the-formula-of-temperament-a-belov/");
        }
    }
}