﻿#pragma checksum "..\..\..\View\TRADEWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "63C2DF611B6F0AA5E1A235F1F00962C97BC43958721D7F7AD3DF4478AF6C0C7D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using CRYPTOKliker;
using CRYPTOKliker.ViewModel.Helpers;
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


namespace CRYPTOKliker {
    
    
    /// <summary>
    /// TRADEWindow
    /// </summary>
    public partial class TRADEWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\View\TRADEWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock bububu;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\View\TRADEWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox KTONVVOD;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\View\TRADEWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RUBOTV;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\View\TRADEWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Perevod;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\View\TRADEWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox KTONVOD;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\View\TRADEWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DOLLARS;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\View\TRADEWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Perewod;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\View\TRADEWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button VIVOD;
        
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
            System.Uri resourceLocater = new System.Uri("/CRYPTOKliker;component/view/tradewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\TRADEWindow.xaml"
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
            this.bububu = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.KTONVVOD = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.RUBOTV = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.Perevod = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.KTONVOD = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\..\View\TRADEWindow.xaml"
            this.KTONVOD.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.KTONVOD_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.DOLLARS = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Perewod = ((System.Windows.Controls.Button)(target));
            
            #line 52 "..\..\..\View\TRADEWindow.xaml"
            this.Perewod.Click += new System.Windows.RoutedEventHandler(this.Perewod_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.VIVOD = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

