﻿#pragma checksum "..\..\..\..\Windows\FormAjoutProduit.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8AF241D8AD77ACF67C583E943F528E584F5902C4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using GestionStock.Windows;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace GestionStock.Windows {
    
    
    /// <summary>
    /// FormAjoutProduit
    /// </summary>
    public partial class FormAjoutProduit : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\..\..\Windows\FormAjoutProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox libelleArticle;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Windows\FormAjoutProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox quantite;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Windows\FormAjoutProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox categorie;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\..\Windows\FormAjoutProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRetour;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\..\Windows\FormAjoutProduit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEnregistrer;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GestionStock;component/windows/formajoutproduit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\FormAjoutProduit.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.libelleArticle = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.quantite = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.categorie = ((System.Windows.Controls.ComboBox)(target));
            
            #line 42 "..\..\..\..\Windows\FormAjoutProduit.xaml"
            this.categorie.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.categorie_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnRetour = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\..\..\Windows\FormAjoutProduit.xaml"
            this.btnRetour.Click += new System.Windows.RoutedEventHandler(this.BtnRetour_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnEnregistrer = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

