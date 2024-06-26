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
    public sealed partial class SuicidePage : Page
    {
        public SuicidePage()
        {
            this.InitializeComponent();
        }

        private async void btn_Suicide_Click(object sender, RoutedEventArgs e)
        {
            ContentDialog dieDialog = new ContentDialog
            {
                XamlRoot = this.XamlRoot,
                Title = "Death",
                Content = "You have killed the app. The moment this dialog box closes, the app will die.",
                PrimaryButtonText = "SKILL ISSUE LOL"
            };


            ContentDialogResult dieResult = await dieDialog.ShowAsync();

            Application.Current.Exit();

        }
    }
}
