﻿#pragma checksum "..\..\..\..\Windows\GestionArticles.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "398146589C8C80C1BC7C7D952F71A4DBAE1B8C86"
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
    /// GestionArticles
    /// </summary>
    public partial class GestionArticles : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\..\Windows\GestionArticles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgListeArticle;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\Windows\GestionArticles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAjout;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\Windows\GestionArticles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnModif;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Windows\GestionArticles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSuppr;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\Windows\GestionArticles.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRetour;
        
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
            System.Uri resourceLocater = new System.Uri("/GestionStock;component/windows/gestionarticles.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Windows\GestionArticles.xaml"
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
            this.dgListeArticle = ((System.Windows.Controls.DataGrid)(target));
            
            #line 36 "..\..\..\..\Windows\GestionArticles.xaml"
            this.dgListeArticle.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dgListeArticle_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnAjout = ((System.Windows.Controls.Button)(target));
            
            #line 55 "..\..\..\..\Windows\GestionArticles.xaml"
            this.btnAjout.Click += new System.Windows.RoutedEventHandler(this.BtnAjout_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnModif = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.btnSuppr = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.btnRetour = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\..\Windows\GestionArticles.xaml"
            this.btnRetour.Click += new System.Windows.RoutedEventHandler(this.BtnAnnule_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

