using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListPickerPractise
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<DJ> objdj = new List<DJ>();
            objdj.Add(new DJ { DjPhoto = "hrithik.jpg", Djcollections = "English", DjAlubum = "RoshanAlubum", DjAge = "34",djContent="indian bollywood dancer and ever"});
            objdj.Add(new DJ { DjPhoto = "shakria.jpg", Djcollections = "spanish", DjAlubum = "ShakriaAlubum", DjAge = "40", djlady = "lady king of the world" });
            objdj.Add(new DJ { DjPhoto = "prabhu.jpg", Djcollections = "Telugu", DjAlubum = "DevaAlubum", DjAge = "58", djmaster = "second king of the world" });
            objdj.Add(new DJ { DjPhoto = "Michael.jpg", Djcollections = "English", DjAlubum = "JacksonAlubum", DjAge = "36", djking = "King of the world" });

            lbdjlist.ItemsSource = objdj;
            btncourse.Clicked += Btncourse_Clicked;
                   lbdjlist.ItemSelected += Lbdjlist_ItemSelected;

               }

                private void Lbdjlist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
                   {
                     var item = e.SelectedItem as DJ;

                       Navigation.PushAsync(new DJDetailsPage( item));
                  }

            private void Btncourse_Clicked(object sender, EventArgs e)
            {
                Navigation.PushAsync(new Direction());
            }
        }

    }
