﻿#pragma checksum "..\..\..\View\Tours.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "894A47FB155CA35965B9015026A891F657A13CD7158E4196333661A83D421D1D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LiveFullLife.View;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace LiveFullLife.View {
    
    
    /// <summary>
    /// Tours
    /// </summary>
    public partial class Tours : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\View\Tours.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Panel;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\View\Tours.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button City_Bytton;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\View\Tours.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridPanel;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\View\Tours.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonOff;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\View\Tours.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid List_Tours;
        
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
            System.Uri resourceLocater = new System.Uri("/LiveFullLife;component/view/tours.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Tours.xaml"
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
            this.Panel = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.City_Bytton = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\View\Tours.xaml"
            this.City_Bytton.Click += new System.Windows.RoutedEventHandler(this.City_Bytton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.GridPanel = ((System.Windows.Controls.Grid)(target));
            return;
            case 4:
            this.ButtonOff = ((System.Windows.Controls.Button)(target));
            
            #line 50 "..\..\..\View\Tours.xaml"
            this.ButtonOff.Click += new System.Windows.RoutedEventHandler(this.ButtonOff_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.List_Tours = ((System.Windows.Controls.DataGrid)(target));
            
            #line 56 "..\..\..\View\Tours.xaml"
            this.List_Tours.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.List_Tours_MouseDoubleClick);
            
            #line default
            #line hidden
            
            #line 56 "..\..\..\View\Tours.xaml"
            this.List_Tours.AutoGeneratingColumn += new System.EventHandler<System.Windows.Controls.DataGridAutoGeneratingColumnEventArgs>(this.OnAutoGeneratingColumn);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

