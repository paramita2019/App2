using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public static int sustainabilityScore = 70;
        public static int sustainabilityTotalCredits = 200;
        public static void onclickRating(object sender, System.EventArgs e)
        {
            sustainabilityScore++;
            ((Button)sender).Text = $"This Year's Sustainability Rating is {sustainabilityScore}";
        }

        public static void onNonGreenPurchase(object sender, System.EventArgs e)
        {
            sustainabilityTotalCredits--;
            ((Button)sender).Text = $"Credits Remaining {sustainabilityTotalCredits}";
        }
    }
}
