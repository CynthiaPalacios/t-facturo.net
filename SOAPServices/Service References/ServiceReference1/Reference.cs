﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.1
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SOAPServices.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Asesor", Namespace="http://schemas.datacontract.org/2004/07/SOAPServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Asesor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorreoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private SOAPServices.ServiceReference1.Sede SedeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Correo {
            get {
                return this.CorreoField;
            }
            set {
                if ((object.ReferenceEquals(this.CorreoField, value) != true)) {
                    this.CorreoField = value;
                    this.RaisePropertyChanged("Correo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SOAPServices.ServiceReference1.Sede Sede {
            get {
                return this.SedeField;
            }
            set {
                if ((object.ReferenceEquals(this.SedeField, value) != true)) {
                    this.SedeField = value;
                    this.RaisePropertyChanged("Sede");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Sede", Namespace="http://schemas.datacontract.org/2004/07/SOAPServices.Dominio")]
    [System.SerializableAttribute()]
    public partial class Sede : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CodigoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Codigo {
            get {
                return this.CodigoField;
            }
            set {
                if ((this.CodigoField.Equals(value) != true)) {
                    this.CodigoField = value;
                    this.RaisePropertyChanged("Codigo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IAsesores")]
    public interface IAsesores {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAsesores/CrearAsesor", ReplyAction="http://tempuri.org/IAsesores/CrearAsesorResponse")]
        SOAPServices.ServiceReference1.Asesor CrearAsesor(string nombre, string correo, int sede);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAsesores/ObtenerAsesor", ReplyAction="http://tempuri.org/IAsesores/ObtenerAsesorResponse")]
        SOAPServices.ServiceReference1.Asesor ObtenerAsesor(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAsesores/ModificarAsesor", ReplyAction="http://tempuri.org/IAsesores/ModificarAsesorResponse")]
        SOAPServices.ServiceReference1.Asesor ModificarAsesor(int codigo, string nombre, string correo, int sede);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAsesores/EliminarAsesor", ReplyAction="http://tempuri.org/IAsesores/EliminarAsesorResponse")]
        void EliminarAsesor(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAsesores/ListarAsesores", ReplyAction="http://tempuri.org/IAsesores/ListarAsesoresResponse")]
        SOAPServices.ServiceReference1.Asesor[] ListarAsesores();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAsesoresChannel : SOAPServices.ServiceReference1.IAsesores, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AsesoresClient : System.ServiceModel.ClientBase<SOAPServices.ServiceReference1.IAsesores>, SOAPServices.ServiceReference1.IAsesores {
        
        public AsesoresClient() {
        }
        
        public AsesoresClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AsesoresClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AsesoresClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AsesoresClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public SOAPServices.ServiceReference1.Asesor CrearAsesor(string nombre, string correo, int sede) {
            return base.Channel.CrearAsesor(nombre, correo, sede);
        }
        
        public SOAPServices.ServiceReference1.Asesor ObtenerAsesor(int codigo) {
            return base.Channel.ObtenerAsesor(codigo);
        }
        
        public SOAPServices.ServiceReference1.Asesor ModificarAsesor(int codigo, string nombre, string correo, int sede) {
            return base.Channel.ModificarAsesor(codigo, nombre, correo, sede);
        }
        
        public void EliminarAsesor(int codigo) {
            base.Channel.EliminarAsesor(codigo);
        }
        
        public SOAPServices.ServiceReference1.Asesor[] ListarAsesores() {
            return base.Channel.ListarAsesores();
        }
    }
}