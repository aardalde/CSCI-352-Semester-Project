﻿#pragma checksum "..\..\AddEventSubWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "62E215756D9DE238796F4CBF15DC86309599E09C2AE6D01EAA4FDEC6F743CF3B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Productive;
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


namespace Productive {
    
    
    /// <summary>
    /// AddEventSubWindow
    /// </summary>
    public partial class AddEventSubWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\AddEventSubWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid SubGrid;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\AddEventSubWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox EventNameBar;
        
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
            System.Uri resourceLocater = new System.Uri("/Productive;component/addeventsubwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddEventSubWindow.xaml"
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
            this.SubGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.EventNameBar = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\AddEventSubWindow.xaml"
            this.EventNameBar.LostFocus += new System.Windows.RoutedEventHandler(this.TextBar_LostFocus);
            
            #line default
            #line hidden
            
            #line 16 "..\..\AddEventSubWindow.xaml"
            this.EventNameBar.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.TextBar_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 16 "..\..\AddEventSubWindow.xaml"
            this.EventNameBar.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.TextBar_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

