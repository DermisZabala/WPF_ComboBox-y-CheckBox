﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "06D60497ABB858CDA217897B024B61B724A392265FB9144167FDFE313C3BAF1D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace WPF_CHECKBOX_COMBOBOX_1 {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox miCombo;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox miCheck;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox SantoDomingo;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox SanCristobal;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox SanPedro;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox SanJuan;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox Peravia;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WPF_CHECKBOX_COMBOBOX_1;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.miCombo = ((System.Windows.Controls.ComboBox)(target));
            
            #line 20 "..\..\MainWindow.xaml"
            this.miCombo.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.miCombo_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.miCheck = ((System.Windows.Controls.CheckBox)(target));
            
            #line 46 "..\..\MainWindow.xaml"
            this.miCheck.Checked += new System.Windows.RoutedEventHandler(this.miCheck_Checked);
            
            #line default
            #line hidden
            
            #line 47 "..\..\MainWindow.xaml"
            this.miCheck.Unchecked += new System.Windows.RoutedEventHandler(this.miCheck_Unchecked);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SantoDomingo = ((System.Windows.Controls.CheckBox)(target));
            
            #line 52 "..\..\MainWindow.xaml"
            this.SantoDomingo.Checked += new System.Windows.RoutedEventHandler(this.CheckedIndividual_checked);
            
            #line default
            #line hidden
            
            #line 53 "..\..\MainWindow.xaml"
            this.SantoDomingo.Unchecked += new System.Windows.RoutedEventHandler(this.CheckedIndividual_Unchecked);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SanCristobal = ((System.Windows.Controls.CheckBox)(target));
            
            #line 58 "..\..\MainWindow.xaml"
            this.SanCristobal.Checked += new System.Windows.RoutedEventHandler(this.CheckedIndividual_checked);
            
            #line default
            #line hidden
            
            #line 59 "..\..\MainWindow.xaml"
            this.SanCristobal.Unchecked += new System.Windows.RoutedEventHandler(this.CheckedIndividual_Unchecked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SanPedro = ((System.Windows.Controls.CheckBox)(target));
            
            #line 64 "..\..\MainWindow.xaml"
            this.SanPedro.Checked += new System.Windows.RoutedEventHandler(this.CheckedIndividual_checked);
            
            #line default
            #line hidden
            
            #line 65 "..\..\MainWindow.xaml"
            this.SanPedro.Unchecked += new System.Windows.RoutedEventHandler(this.CheckedIndividual_Unchecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.SanJuan = ((System.Windows.Controls.CheckBox)(target));
            
            #line 70 "..\..\MainWindow.xaml"
            this.SanJuan.Checked += new System.Windows.RoutedEventHandler(this.CheckedIndividual_checked);
            
            #line default
            #line hidden
            
            #line 71 "..\..\MainWindow.xaml"
            this.SanJuan.Unchecked += new System.Windows.RoutedEventHandler(this.CheckedIndividual_Unchecked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Peravia = ((System.Windows.Controls.CheckBox)(target));
            
            #line 76 "..\..\MainWindow.xaml"
            this.Peravia.Checked += new System.Windows.RoutedEventHandler(this.CheckedIndividual_checked);
            
            #line default
            #line hidden
            
            #line 77 "..\..\MainWindow.xaml"
            this.Peravia.Unchecked += new System.Windows.RoutedEventHandler(this.CheckedIndividual_Unchecked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
