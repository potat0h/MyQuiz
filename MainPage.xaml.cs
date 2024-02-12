using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage.Streams;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyQuiz
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void MenuFlyoutItem_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(About));
        }
        //###########################################################################

        bool a = false;
        bool b = false;
        bool c = false;
        bool X = false;
        private void C_Checked(object sender, RoutedEventArgs e)
        {
            a = false;
        }

        private void Python_Checked(object sender, RoutedEventArgs e)
        {
            a = false;
        }

        private void PHP_Checked(object sender, RoutedEventArgs e)
        {
            a = false;
        }

        private void HTML_Checked(object sender, RoutedEventArgs e)
        {
            a = true;
        }

        private void Check1_Checked(object sender, RoutedEventArgs e)
        {
            b = false;
            X = true;
        }

        private void Check2_Checked(object sender, RoutedEventArgs e)
        {
            b = false;
            X = true;
        }

        private void Check3_Checked(object sender, RoutedEventArgs e)
        {
            if(X != true)
            {
                b = true;
                X = false;
            }
        }

        private void Check3_Unchecked(object sender, RoutedEventArgs e)
        {
            b = false;
        }

        private void Check4_Checked(object sender, RoutedEventArgs e)
        {
            b = false;
        }

        private void ComboTinkercad_Tapped(object sender, TappedRoutedEventArgs e)
        {
            c = false;
        }

        private void ComboUnreal_Tapped(object sender, TappedRoutedEventArgs e)
        {
            c = false;
        }

        private void ComboUnity_Tapped(object sender, TappedRoutedEventArgs e)
        {
            c = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int counter = 0;
            if(a)
            {
                counter++;
            }
            if (b)
            {
                counter++;
            }
            if (c)
            {
                counter++;
            }
            OUTPUT.Text = Convert.ToString(counter);
        }

        
    }
}

