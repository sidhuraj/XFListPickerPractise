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
    public partial class Direction : ContentPage
    {
        public Direction()
        {
            InitializeComponent();

            string[] coursename = new string[3];
            coursename[0] = "Direction";
            coursename[1] = "photography";
            coursename[2] = "Film Editing";

            pickerName.ItemsSource = coursename;
            //Another process
            //var Pickers = Mypicker.ItemsSource.ToString();
            //details.Text = string.Format("location:(0)", Pickers);
        }
    }
}