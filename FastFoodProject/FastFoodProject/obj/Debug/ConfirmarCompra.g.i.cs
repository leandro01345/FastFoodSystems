﻿#pragma checksum "..\..\ConfirmarCompra.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "780DED6E9BD358FF3C94A119FB90886F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using FastFoodProject;
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


namespace FastFoodProject {
    
    
    /// <summary>
    /// ConfirmarCompra
    /// </summary>
    public partial class ConfirmarCompra : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ConfirmarCompra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtMontoIngresado;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ConfirmarCompra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTotalPagar;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ConfirmarCompra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\ConfirmarCompra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTotalPagar_Copy;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\ConfirmarCompra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblVuelto;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\ConfirmarCompra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtVuelto;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ConfirmarCompra.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lblTotalPagar_Copy1;
        
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
            System.Uri resourceLocater = new System.Uri("/FastFoodProject;component/confirmarcompra.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ConfirmarCompra.xaml"
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
            this.txtMontoIngresado = ((System.Windows.Controls.TextBox)(target));
            
            #line 10 "..\..\ConfirmarCompra.xaml"
            this.txtMontoIngresado.GotFocus += new System.Windows.RoutedEventHandler(this.txtMontoIngresado_GotFocus);
            
            #line default
            #line hidden
            
            #line 10 "..\..\ConfirmarCompra.xaml"
            this.txtMontoIngresado.KeyUp += new System.Windows.Input.KeyEventHandler(this.txtMontoIngresado_KeyUp);
            
            #line default
            #line hidden
            
            #line 10 "..\..\ConfirmarCompra.xaml"
            this.txtMontoIngresado.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtMontoIngresado_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.lblTotalPagar = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.button = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\ConfirmarCompra.xaml"
            this.button.Click += new System.Windows.RoutedEventHandler(this.button_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.lblTotalPagar_Copy = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.lblVuelto = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.txtVuelto = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.lblTotalPagar_Copy1 = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

