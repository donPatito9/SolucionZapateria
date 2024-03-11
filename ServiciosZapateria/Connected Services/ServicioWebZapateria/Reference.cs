﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiciosZapateria.ServicioWebZapateria {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicioWebZapateria.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IngresarProducto", ReplyAction="http://tempuri.org/IService1/IngresarProductoResponse")]
        bool IngresarProducto(int id, string nombre_producto, string descripcion, int precio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/IngresarProducto", ReplyAction="http://tempuri.org/IService1/IngresarProductoResponse")]
        System.Threading.Tasks.Task<bool> IngresarProductoAsync(int id, string nombre_producto, string descripcion, int precio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Validar", ReplyAction="http://tempuri.org/IService1/ValidarResponse")]
        bool Validar(string usuario, string contrasenna);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Validar", ReplyAction="http://tempuri.org/IService1/ValidarResponse")]
        System.Threading.Tasks.Task<bool> ValidarAsync(string usuario, string contrasenna);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TraerTodo", ReplyAction="http://tempuri.org/IService1/TraerTodoResponse")]
        Negocio.ProductoNegocio[] TraerTodo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TraerTodo", ReplyAction="http://tempuri.org/IService1/TraerTodoResponse")]
        System.Threading.Tasks.Task<Negocio.ProductoNegocio[]> TraerTodoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : ServiciosZapateria.ServicioWebZapateria.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<ServiciosZapateria.ServicioWebZapateria.IService1>, ServiciosZapateria.ServicioWebZapateria.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool IngresarProducto(int id, string nombre_producto, string descripcion, int precio) {
            return base.Channel.IngresarProducto(id, nombre_producto, descripcion, precio);
        }
        
        public System.Threading.Tasks.Task<bool> IngresarProductoAsync(int id, string nombre_producto, string descripcion, int precio) {
            return base.Channel.IngresarProductoAsync(id, nombre_producto, descripcion, precio);
        }
        
        public bool Validar(string usuario, string contrasenna) {
            return base.Channel.Validar(usuario, contrasenna);
        }
        
        public System.Threading.Tasks.Task<bool> ValidarAsync(string usuario, string contrasenna) {
            return base.Channel.ValidarAsync(usuario, contrasenna);
        }
        
        public Negocio.ProductoNegocio[] TraerTodo() {
            return base.Channel.TraerTodo();
        }
        
        public System.Threading.Tasks.Task<Negocio.ProductoNegocio[]> TraerTodoAsync() {
            return base.Channel.TraerTodoAsync();
        }
    }
}
