using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace SMART
{
    /// <summary>
    /// Windows app page that navigates to sc.lg.esf.edu.hk and does some magic. :)
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
			SMARTWeb.Navigate(new Uri("https://sc.lg.esf.edu.hk"));
	        appBar.IsOpen = true;
	        appBar.IsSticky = false;
        }

	    private void HomeButton_OnClick(object sender, RoutedEventArgs e)
	    {
			SMARTWeb.Navigate(new Uri("https://sc.lg.esf.edu.hk"));
			appBar.IsOpen = false;
	    }

        private void MailButton_OnClick(object sender, RoutedEventArgs e)
        {
            SMARTWeb.Navigate(new Uri("https://mail.google.com"));
            appBar.IsOpen = false;
        }

        private void DriveButton_OnClick(object sender, RoutedEventArgs e)
        {
            SMARTWeb.Navigate(new Uri("https://drive.google.com"));
            appBar.IsOpen = false;
        }

        private void SitesButton_OnClick(object sender, RoutedEventArgs e)
        {
            SMARTWeb.Navigate(new Uri("https://sites.google.com"));
            appBar.IsOpen = false;
        }

        private void CalendarButton_OnClick(object sender, RoutedEventArgs e)
        {
            SMARTWeb.Navigate(new Uri("https://calendar.google.com"));
            appBar.IsOpen = false;
        }

    }
}
