using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Interop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.InteropServices;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI;
using Microsoft.UI.Windowing;
using WinRT.Interop;
using Windows.ApplicationModel;
using WinRT;
using Microsoft.UI.Composition.SystemBackdrops;
using Windows.Graphics;

// To learn more about WinUI, the WinUI project structure,
namespace App1
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>

    public sealed partial class MainWindow : Window
    {

        private AppWindow apw_;
        private OverlappedPresenter presenter_;

        public void GetAppWindowAndPresenter()
        {
            var hWnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(hWnd);
            apw_ = AppWindow.GetFromWindowId(windowId);
            presenter_ = apw_.Presenter as OverlappedPresenter;
        }



        public MainWindow()
        {
            this.InitializeComponent();
            ExtendsContentIntoTitleBar = true;
            Title = "Test App";
            GetAppWindowAndPresenter();
            presenter_.IsResizable = false;
            presenter_.IsMaximizable = false;
            apw_.Resize(new SizeInt32 { Width = 1280, Height = 800 });

        }


        /* private void myButton_Click(object sender, RoutedEventArgs e)
         {
             myButton.Content = "Clicked";
         }*/

        //Create an event handler that calls a dialog box when the button is clicked
        // Switch main page to BlankPage1.xaml when tag CalcPage is selected in the navView

        // if page is not calc page, resize back to default size
        public void NotCalcPage()
        {
            apw_.Resize(new SizeInt32 { Width = 1280, Height = 800 });
        }


        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            NavigationViewItem item = args.SelectedItem as NavigationViewItem;
            if (item != null)
            {
                switch (item.Tag)
                {
                    case "CalcPage":
                        ContentFrame.Navigate(typeof(CalcPage));
                        apw_.Resize(new SizeInt32 { Width = 400, Height = 400 });
                        break;
                    default:
                        apw_.Resize(new SizeInt32 { Width = 1280, Height = 800 });
                        break;
                    case "ButtonPage":
                        ContentFrame.Navigate(typeof(ButtonPage));
                        break;
                    case "SuicidePage":
                        ContentFrame.Navigate(typeof(SuicidePage));
                        break;

                }
            }
        }

    }
}
