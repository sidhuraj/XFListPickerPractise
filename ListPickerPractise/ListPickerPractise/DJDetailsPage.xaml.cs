using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListPickerPractise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DJDetailsPage : ContentPage
    {
        public DJDetailsPage( DJ item)
        {
            InitializeComponent();


            Title = item.DjAlubum;

            lblDj.Text = item.DjAlubum;
            lblLangu.Text = item.Djcollections;
            lblPhoto.Text = item.DjPhoto;
            lblage.Text = item.DjAge;
            imgPhoto.Source = item.DjPhoto;


            lblCon.Text = item.djContent; lbllady.Text = item.djlady;lblmaster.Text = item.djmaster;lblking.Text = item.djking;
            
            



        }
    }
}