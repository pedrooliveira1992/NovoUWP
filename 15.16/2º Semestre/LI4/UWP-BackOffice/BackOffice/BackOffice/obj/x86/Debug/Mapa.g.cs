﻿#pragma checksum "C:\Users\pedro\Desktop\15.16\2º Semestre\LI4\UWP-BackOffice\BackOffice\BackOffice\Mapa.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "651870445D2D565B498FCA0610DB30C9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BackOffice
{
    partial class Mapa : 
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
                    this.wideState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 2:
                {
                    this.narrowState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 3:
                {
                    this.RootGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.myMap = (global::Windows.UI.Xaml.Controls.Maps.MapControl)(target);
                }
                break;
            case 5:
                {
                    this.ErrorBorder = (global::Windows.UI.Xaml.Controls.Border)(target);
                }
                break;
            case 6:
                {
                    this.StatusBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.zoomSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            case 8:
                {
                    this.headingSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            case 9:
                {
                    this.desiredPitchSlider = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            case 10:
                {
                    this.StyleStackPanel = (global::Windows.UI.Xaml.Controls.StackPanel)(target);
                }
                break;
            case 11:
                {
                    this.trafficFlowVisibleCheckBox = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                    #line 59 "..\..\..\Mapa.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.trafficFlowVisibleCheckBox).Checked += this.TrafficFlowVisible_Checked;
                    #line 60 "..\..\..\Mapa.xaml"
                    ((global::Windows.UI.Xaml.Controls.CheckBox)this.trafficFlowVisibleCheckBox).Unchecked += this.trafficFlowVisibleCheckBox_Unchecked;
                    #line default
                }
                break;
            case 12:
                {
                    this.styleCombobox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 61 "..\..\..\Mapa.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)this.styleCombobox).SelectionChanged += this.styleCombobox_SelectionChanged;
                    #line default
                }
                break;
            case 13:
                {
                    this.description = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
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

