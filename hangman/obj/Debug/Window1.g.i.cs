﻿#pragma checksum "..\..\Window1.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9AAD336B7904A21EDA881B13B875708AE7F90A69F114361D7590BDCB3B0BFE7A"
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
using hangman;


namespace hangman {
    
    
    /// <summary>
    /// Window1
    /// </summary>
    public partial class Window1 : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 114 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image bloodImage;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image hangmanImage;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock outQuestion_Label;
        
        #line default
        #line hidden
        
        
        #line 126 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox endBox;
        
        #line default
        #line hidden
        
        
        #line 166 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label endLabel;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label endLabel2;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label endMessage;
        
        #line default
        #line hidden
        
        
        #line 169 "..\..\Window1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label endTimer;
        
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
            System.Uri resourceLocater = new System.Uri("/hangman;component/window1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Window1.xaml"
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
            
            #line 8 "..\..\Window1.xaml"
            ((hangman.Window1)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.MoveForm);
            
            #line default
            #line hidden
            return;
            case 2:
            this.bloodImage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.hangmanImage = ((System.Windows.Controls.Image)(target));
            return;
            case 4:
            
            #line 121 "..\..\Window1.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.CloseForm);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 122 "..\..\Window1.xaml"
            ((System.Windows.Controls.Label)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.MinimizeForm);
            
            #line default
            #line hidden
            return;
            case 6:
            this.outQuestion_Label = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.endBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            
            #line 128 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 129 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 130 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 131 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 132 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 133 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 134 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 136 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 137 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 138 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 139 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 140 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 141 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 142 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 144 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 145 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 146 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 147 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 26:
            
            #line 148 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 27:
            
            #line 149 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 28:
            
            #line 150 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 29:
            
            #line 152 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 30:
            
            #line 153 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 31:
            
            #line 154 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 32:
            
            #line 155 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 33:
            
            #line 156 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 34:
            
            #line 157 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 35:
            
            #line 158 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 36:
            
            #line 160 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 37:
            
            #line 161 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 38:
            
            #line 162 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 39:
            
            #line 163 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 40:
            
            #line 164 "..\..\Window1.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.LetterClick);
            
            #line default
            #line hidden
            return;
            case 41:
            this.endLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 42:
            this.endLabel2 = ((System.Windows.Controls.Label)(target));
            return;
            case 43:
            this.endMessage = ((System.Windows.Controls.Label)(target));
            return;
            case 44:
            this.endTimer = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
