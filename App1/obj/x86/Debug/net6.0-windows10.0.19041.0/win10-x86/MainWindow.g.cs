﻿#pragma checksum "C:\Users\LCIUSER\source\repos\App1\App1\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E216D0A267E233188059D15A840F295E9D57C9DF5C06CA753163B27ACA71E3E7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App1
{
    partial class MainWindow : 
        global::Microsoft.UI.Xaml.Window, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2309")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainWindow.xaml line 16
                {
                    this.AppTitleBar = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Grid>(target);
                }
                break;
            case 3: // MainWindow.xaml line 40
                {
                    this.NavView = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.NavigationView>(target);
                    ((global::Microsoft.UI.Xaml.Controls.NavigationView)this.NavView).SelectionChanged += this.NavView_SelectionChanged;
                }
                break;
            case 4: // MainWindow.xaml line 45
                {
                    this.ContentFrame = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Frame>(target);
                }
                break;
            case 5: // MainWindow.xaml line 37
                {
                    this.myButton = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Button>(target);
                    ((global::Microsoft.UI.Xaml.Controls.Button)this.myButton).Click += this.myButton_Click;
                }
                break;
            case 6: // MainWindow.xaml line 19
                {
                    this.LeftPaddingColumn = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ColumnDefinition>(target);
                }
                break;
            case 7: // MainWindow.xaml line 20
                {
                    this.IconColumn = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ColumnDefinition>(target);
                }
                break;
            case 8: // MainWindow.xaml line 21
                {
                    this.TitleColumn = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.ColumnDefinition>(target);
                }
                break;
            case 9: // MainWindow.xaml line 24
                {
                    this.AppIcon = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Image>(target);
                }
                break;
            case 10: // MainWindow.xaml line 28
                {
                    this.TitleBarTextBlock = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2309")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
