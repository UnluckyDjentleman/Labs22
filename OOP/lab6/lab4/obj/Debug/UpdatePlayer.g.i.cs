﻿#pragma checksum "..\..\UpdatePlayer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "449141CCB3A51ACA15BB742513BDFA84B8BD06D6F4AFD0AF111536049D710A98"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using lab4;


namespace lab4 {
    
    
    /// <summary>
    /// UpdatePlayer
    /// </summary>
    public partial class UpdatePlayer : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\UpdatePlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button photo;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\UpdatePlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox name;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\UpdatePlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox countryPlayer;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\UpdatePlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem usa;
        
        #line default
        #line hidden
        
        
        #line 82 "..\..\UpdatePlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem svk;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\UpdatePlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem can;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\UpdatePlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem swe;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\UpdatePlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem fin;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\UpdatePlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBoxItem cze;
        
        #line default
        #line hidden
        
        
        #line 100 "..\..\UpdatePlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PositionPlayer;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\UpdatePlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox age;
        
        #line default
        #line hidden
        
        
        #line 117 "..\..\UpdatePlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox height;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\UpdatePlayer.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox weight;
        
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
            System.Uri resourceLocater = new System.Uri("/lab4;component/updateplayer.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UpdatePlayer.xaml"
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
            
            #line 14 "..\..\UpdatePlayer.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.ExecutedCustomCommand);
            
            #line default
            #line hidden
            
            #line 15 "..\..\UpdatePlayer.xaml"
            ((System.Windows.Input.CommandBinding)(target)).CanExecute += new System.Windows.Input.CanExecuteRoutedEventHandler(this.CanExecuteCustomCommand);
            
            #line default
            #line hidden
            return;
            case 2:
            this.photo = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.name = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.countryPlayer = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.usa = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 6:
            this.svk = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 7:
            this.can = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 8:
            this.swe = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 9:
            this.fin = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 10:
            this.cze = ((System.Windows.Controls.ComboBoxItem)(target));
            return;
            case 11:
            this.PositionPlayer = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 12:
            this.age = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.height = ((System.Windows.Controls.TextBox)(target));
            return;
            case 14:
            this.weight = ((System.Windows.Controls.TextBox)(target));
            return;
            case 15:
            
            #line 124 "..\..\UpdatePlayer.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

