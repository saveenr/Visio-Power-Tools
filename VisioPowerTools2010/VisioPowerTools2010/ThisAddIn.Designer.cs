﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Security.Permissions;
using Microsoft.Office.Interop.Visio;
using Microsoft.Office.Tools;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.VisualStudio.Tools.Applications.Runtime;

#pragma warning disable 414
namespace VisioPowerTools2010 {
    
    
    /// 
    [StartupObject(0)]
    [PermissionSet(SecurityAction.Demand, Name="FullTrust")]
    public sealed partial class ThisAddIn : AddInBase {
        
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        private Object missing = Type.Missing;
        
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        internal Application Application;
        
        /// 
        [DebuggerNonUserCode()]
        [EditorBrowsable(EditorBrowsableState.Never)]
        public ThisAddIn(Factory factory, IServiceProvider serviceProvider) : 
                base(factory, serviceProvider, "AddIn", "ThisAddIn") {
            Globals.Factory = factory;
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void Initialize() {
            base.Initialize();
            this.Application = this.GetHostItem<Application>(typeof(Application), "Application");
            Globals.ThisAddIn = this;
            System.Windows.Forms.Application.EnableVisualStyles();
            this.InitializeCachedData();
            this.InitializeControls();
            this.InitializeComponents();
            this.InitializeData();
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void FinishInitialization() {
            this.InternalStartup();
            this.OnStartup();
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        protected override void InitializeDataBindings() {
            this.BeginInitialization();
            this.BindToData();
            this.EndInitialization();
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private void InitializeCachedData() {
            if ((this.DataHost == null)) {
                return;
            }
            if (this.DataHost.IsCacheInitialized) {
                this.DataHost.FillCachedData(this);
            }
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private void InitializeData() {
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private void BindToData() {
        }
        
        /// 
        [DebuggerNonUserCode()]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        private void StartCaching(string MemberName) {
            this.DataHost.StartCaching(this, MemberName);
        }
        
        /// 
        [DebuggerNonUserCode()]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        private void StopCaching(string MemberName) {
            this.DataHost.StopCaching(this, MemberName);
        }
        
        /// 
        [DebuggerNonUserCode()]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        private bool IsCached(string MemberName) {
            return this.DataHost.IsCached(this, MemberName);
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private void BeginInitialization() {
            this.BeginInit();
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private void EndInitialization() {
            this.EndInit();
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private void InitializeControls() {
        }
        
        /// 
        [DebuggerNonUserCode()]
        [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
        [EditorBrowsable(EditorBrowsableState.Never)]
        private void InitializeComponents() {
        }
        
        /// 
        [DebuggerNonUserCode()]
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        private bool NeedsFill(string MemberName) {
            return this.DataHost.NeedsFill(this, MemberName);
        }
    }
    
    /// 
    [DebuggerNonUserCode()]
    [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
    internal sealed partial class Globals {
        
        /// 
        private Globals() {
        }
        
        private static ThisAddIn _ThisAddIn;
        
        private static Factory _factory;
        
        private static ThisRibbonCollection _ThisRibbonCollection;
        
        internal static ThisAddIn ThisAddIn {
            get {
                return Globals._ThisAddIn;
            }
            set {
                if ((Globals._ThisAddIn == null)) {
                    Globals._ThisAddIn = value;
                }
                else {
                    throw new NotSupportedException();
                }
            }
        }
        
        internal static Factory Factory {
            get {
                return Globals._factory;
            }
            set {
                if ((Globals._factory == null)) {
                    Globals._factory = value;
                }
                else {
                    throw new NotSupportedException();
                }
            }
        }
        
        internal static ThisRibbonCollection Ribbons {
            get {
                if ((Globals._ThisRibbonCollection == null)) {
                    Globals._ThisRibbonCollection = new ThisRibbonCollection(Globals._factory.GetRibbonFactory());
                }
                return Globals._ThisRibbonCollection;
            }
        }
    }
    
    /// 
    [DebuggerNonUserCode()]
    [GeneratedCode("Microsoft.VisualStudio.Tools.Office.ProgrammingModel.dll", "11.0.0.0")]
    internal sealed partial class ThisRibbonCollection : RibbonCollectionBase {
        
        /// 
        internal ThisRibbonCollection(RibbonFactory factory) : 
                base(factory) {
        }
    }
}
