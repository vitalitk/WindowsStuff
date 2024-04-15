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
using Microsoft.UI;
using Microsoft.UI.Windowing;
using WinRT.Interop;
using Windows.UI.WindowManagement;
using Windows.ApplicationModel;

// To learn more about WinUI, the WinUI project structure,
namespace App1
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            ExtendsContentIntoTitleBar = true;
            Title = "Test App";
        }
      

       /* private void myButton_Click(object sender, RoutedEventArgs e)
        {
            myButton.Content = "Clicked";
        }*/

        //Create an event handler that calls a dialog box when the button is clicked
        private async void myButton_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog dialog = new ContentDialog();
            dialog.XamlRoot = this.Content.XamlRoot;
            dialog.Title = "Clicked";
            dialog.Content = "You clicked the button";
            dialog.CloseButtonText = "Ok";
            ContentDialogResult result = await dialog.ShowAsync();
            myButton.Content = "Clicked";
        }

        // Switch main page to BlankPage1.xaml when tag CalcPage is selected in the navView
        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            NavigationViewItem item = args.SelectedItem as NavigationViewItem;
            if (item != null)
            {
                switch (item.Tag)
                {
                    case "CalcPage":
                        ContentFrame.Navigate(typeof(BlankPage1));
                        break;
                }
            }
        }
    }
}
