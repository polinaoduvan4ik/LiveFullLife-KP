﻿#pragma checksum "..\..\..\View\AddEvent.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A2FF5051D8DC89D17F47340DE10B8578FDE69093AD89C1035809C4DB3FBB3FCF"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LiveFullLife;
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


namespace LiveFullLife {
    
    
    /// <summary>
    /// AddEvent
    /// </summary>
    public partial class AddEvent : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\View\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Input_NameEvent;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\View\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Input_AdressEvent;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\View\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Input_DescriptionEvent;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\View\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button LoadImage_Button;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\View\AddEvent.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Add_Button;
        
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
            System.Uri resourceLocater = new System.Uri("/LiveFullLife;component/view/addevent.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\AddEvent.xaml"
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
            this.Input_NameEvent = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.Input_AdressEvent = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.Input_DescriptionEvent = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.LoadImage_Button = ((System.Windows.Controls.Button)(target));
            
            #line 57 "..\..\..\View\AddEvent.xaml"
            this.LoadImage_Button.Click += new System.Windows.RoutedEventHandler(this.LoadImage_Button_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Add_Button = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\View\AddEvent.xaml"
            this.Add_Button.Click += new System.Windows.RoutedEventHandler(this.Add_Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

