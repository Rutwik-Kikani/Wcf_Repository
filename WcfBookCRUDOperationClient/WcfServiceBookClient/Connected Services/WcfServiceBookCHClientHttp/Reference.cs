﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceBookClient.WcfServiceBookCHClientHttp {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceLibraryBook")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BookNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoryNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int NumberInStockField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TotalStockField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public string BookName {
            get {
                return this.BookNameField;
            }
            set {
                if ((object.ReferenceEquals(this.BookNameField, value) != true)) {
                    this.BookNameField = value;
                    this.RaisePropertyChanged("BookName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public string AuthorName {
            get {
                return this.AuthorNameField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorNameField, value) != true)) {
                    this.AuthorNameField = value;
                    this.RaisePropertyChanged("AuthorName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public string CategoryName {
            get {
                return this.CategoryNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoryNameField, value) != true)) {
                    this.CategoryNameField = value;
                    this.RaisePropertyChanged("CategoryName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public int NumberInStock {
            get {
                return this.NumberInStockField;
            }
            set {
                if ((this.NumberInStockField.Equals(value) != true)) {
                    this.NumberInStockField = value;
                    this.RaisePropertyChanged("NumberInStock");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=5)]
        public int TotalStock {
            get {
                return this.TotalStockField;
            }
            set {
                if ((this.TotalStockField.Equals(value) != true)) {
                    this.TotalStockField = value;
                    this.RaisePropertyChanged("TotalStock");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfServiceBookCHClientHttp.IBookService")]
    public interface IBookService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetData", ReplyAction="http://tempuri.org/IBookService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetData", ReplyAction="http://tempuri.org/IBookService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/InsertBookDetails", ReplyAction="http://tempuri.org/IBookService/InsertBookDetailsResponse")]
        string InsertBookDetails(WcfServiceBookClient.WcfServiceBookCHClientHttp.Book bookInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/InsertBookDetails", ReplyAction="http://tempuri.org/IBookService/InsertBookDetailsResponse")]
        System.Threading.Tasks.Task<string> InsertBookDetailsAsync(WcfServiceBookClient.WcfServiceBookCHClientHttp.Book bookInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetAllBookDetails", ReplyAction="http://tempuri.org/IBookService/GetAllBookDetailsResponse")]
        System.Data.DataSet GetAllBookDetails();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetAllBookDetails", ReplyAction="http://tempuri.org/IBookService/GetAllBookDetailsResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetAllBookDetailsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/DeleteBookDetails", ReplyAction="http://tempuri.org/IBookService/DeleteBookDetailsResponse")]
        bool DeleteBookDetails(int bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/DeleteBookDetails", ReplyAction="http://tempuri.org/IBookService/DeleteBookDetailsResponse")]
        System.Threading.Tasks.Task<bool> DeleteBookDetailsAsync(int bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/UpdateBookDetails", ReplyAction="http://tempuri.org/IBookService/UpdateBookDetailsResponse")]
        string UpdateBookDetails(WcfServiceBookClient.WcfServiceBookCHClientHttp.Book bookInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/UpdateBookDetails", ReplyAction="http://tempuri.org/IBookService/UpdateBookDetailsResponse")]
        System.Threading.Tasks.Task<string> UpdateBookDetailsAsync(WcfServiceBookClient.WcfServiceBookCHClientHttp.Book bookInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBookById", ReplyAction="http://tempuri.org/IBookService/GetBookByIdResponse")]
        System.Data.DataSet GetBookById(int bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBookById", ReplyAction="http://tempuri.org/IBookService/GetBookByIdResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetBookByIdAsync(int bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBookByName", ReplyAction="http://tempuri.org/IBookService/GetBookByNameResponse")]
        System.Data.DataSet GetBookByName(string bookInfoName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookService/GetBookByName", ReplyAction="http://tempuri.org/IBookService/GetBookByNameResponse")]
        System.Threading.Tasks.Task<System.Data.DataSet> GetBookByNameAsync(string bookInfoName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookServiceChannel : WcfServiceBookClient.WcfServiceBookCHClientHttp.IBookService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookServiceClient : System.ServiceModel.ClientBase<WcfServiceBookClient.WcfServiceBookCHClientHttp.IBookService>, WcfServiceBookClient.WcfServiceBookCHClientHttp.IBookService {
        
        public BookServiceClient() {
        }
        
        public BookServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public string InsertBookDetails(WcfServiceBookClient.WcfServiceBookCHClientHttp.Book bookInfo) {
            return base.Channel.InsertBookDetails(bookInfo);
        }
        
        public System.Threading.Tasks.Task<string> InsertBookDetailsAsync(WcfServiceBookClient.WcfServiceBookCHClientHttp.Book bookInfo) {
            return base.Channel.InsertBookDetailsAsync(bookInfo);
        }
        
        public System.Data.DataSet GetAllBookDetails() {
            return base.Channel.GetAllBookDetails();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetAllBookDetailsAsync() {
            return base.Channel.GetAllBookDetailsAsync();
        }
        
        public bool DeleteBookDetails(int bookId) {
            return base.Channel.DeleteBookDetails(bookId);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteBookDetailsAsync(int bookId) {
            return base.Channel.DeleteBookDetailsAsync(bookId);
        }
        
        public string UpdateBookDetails(WcfServiceBookClient.WcfServiceBookCHClientHttp.Book bookInfo) {
            return base.Channel.UpdateBookDetails(bookInfo);
        }
        
        public System.Threading.Tasks.Task<string> UpdateBookDetailsAsync(WcfServiceBookClient.WcfServiceBookCHClientHttp.Book bookInfo) {
            return base.Channel.UpdateBookDetailsAsync(bookInfo);
        }
        
        public System.Data.DataSet GetBookById(int bookId) {
            return base.Channel.GetBookById(bookId);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetBookByIdAsync(int bookId) {
            return base.Channel.GetBookByIdAsync(bookId);
        }
        
        public System.Data.DataSet GetBookByName(string bookInfoName) {
            return base.Channel.GetBookByName(bookInfoName);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> GetBookByNameAsync(string bookInfoName) {
            return base.Channel.GetBookByNameAsync(bookInfoName);
        }
    }
}
