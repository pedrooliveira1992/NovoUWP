﻿#pragma checksum "C:\Users\pedro\Desktop\15.16\2º Semestre\LI4\UWP-BackOffice\BackOffice\BackOffice\Login.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "CA549DDE07D04D706A1A2BE47F7910DD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirFIT
{
    partial class Login : 
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
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.textBox = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3:
                {
                    this.textBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 4:
                {
                    this.textBlock2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.textBox1 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 66 "..\..\..\Login.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.textBox1).TextChanged += this.textBox1_TextChanged;
                    #line default
                }
                break;
            case 6:
                {
                    this.textBox2 = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                    #line 75 "..\..\..\Login.xaml"
                    ((global::Windows.UI.Xaml.Controls.TextBox)this.textBox2).TextChanged += this.textBox2_TextChanged;
                    #line default
                }
                break;
            case 7:
                {
                    this.button = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 76 "..\..\..\Login.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button).Click += this.LoginButton_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.button1 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 77 "..\..\..\Login.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.button1).Click += this.RegisterButton_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.MyFrame = (global::Windows.UI.Xaml.Controls.Frame)(target);
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

