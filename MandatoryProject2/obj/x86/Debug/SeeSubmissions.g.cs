﻿#pragma checksum "C:\Users\sara\Documents\GitHub\c-sharp-project\MandatoryProject2\SeeSubmissions.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FC6B00E5C439AE756C7EB6C7BA17414B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MandatoryProject2
{
    partial class SeeSubmissions : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.NameValue = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 11 "..\..\..\SeeSubmissions.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.NameValue).GotFocus += this.TextBox_GotFocus;
                    #line default
                }
                break;
            case 2:
                {
                    this.NameLabel = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 3:
                {
                    this.NameLabel_Copy = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 4:
                {
                    global::Windows.UI.Xaml.Controls.Button element4 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 14 "..\..\..\SeeSubmissions.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)element4).Click += this.Button_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.Query = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                    #line 15 "..\..\..\SeeSubmissions.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBlock)this.Query).SelectionChanged += this.Query_SelectionChanged;
                    #line default
                }
                break;
            case 6:
                {
                    this.PasswordValue = (global::Windows.UI.Xaml.Controls.PasswordBox)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

