using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ButtonPage : Page
    {
        public ButtonPage()
        {
            this.InitializeComponent();
        }

        // Call dialog when button is clicked
        private async void btn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ContentDialog noWifiDialog = new ContentDialog
                {
                    XamlRoot = this.XamlRoot,
                    Title = "Test",
                    Content = "Test",
                    Style = Application.Current.Resources["DefaultContentDialogStyle"] as Style,
                    PrimaryButtonText = "Done",
                    SecondaryButtonText = "Ok"
                };
                ContentDialogResult result = await noWifiDialog.ShowAsync();
            }
            catch(Exception ex)
            {
                    Console.WriteLine(ex.Message);
                }

           
        }
    }

}
