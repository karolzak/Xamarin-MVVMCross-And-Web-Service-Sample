﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.9.7.0
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

using System;
using System.Linq;
using Newtonsoft.Json.Linq;
using XamFormsMvvmAndRESTServices.Models;

namespace XamFormsMvvmAndRESTServices.Models
{
    public partial class Order
    {
        private Customer _customer;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public Customer Customer
        {
            get { return this._customer; }
            set { this._customer = value; }
        }
        
        private int? _customerId;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? CustomerId
        {
            get { return this._customerId; }
            set { this._customerId = value; }
        }
        
        private int? _id;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private string _productName;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string ProductName
        {
            get { return this._productName; }
            set { this._productName = value; }
        }
        
        private int? _quantity;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public int? Quantity
        {
            get { return this._quantity; }
            set { this._quantity = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the Order class.
        /// </summary>
        public Order()
        {
        }
        
        /// <summary>
        /// Deserialize the object
        /// </summary>
        public virtual void DeserializeJson(JToken inputObject)
        {
            if (inputObject != null && inputObject.Type != JTokenType.Null)
            {
                JToken customerValue = inputObject["Customer"];
                if (customerValue != null && customerValue.Type != JTokenType.Null)
                {
                    Customer customer = new Customer();
                    customer.DeserializeJson(customerValue);
                    this.Customer = customer;
                }
                JToken customerIdValue = inputObject["CustomerId"];
                if (customerIdValue != null && customerIdValue.Type != JTokenType.Null)
                {
                    this.CustomerId = ((int)customerIdValue);
                }
                JToken idValue = inputObject["Id"];
                if (idValue != null && idValue.Type != JTokenType.Null)
                {
                    this.Id = ((int)idValue);
                }
                JToken productNameValue = inputObject["ProductName"];
                if (productNameValue != null && productNameValue.Type != JTokenType.Null)
                {
                    this.ProductName = ((string)productNameValue);
                }
                JToken quantityValue = inputObject["Quantity"];
                if (quantityValue != null && quantityValue.Type != JTokenType.Null)
                {
                    this.Quantity = ((int)quantityValue);
                }
            }
        }
        
        /// <summary>
        /// Serialize the object
        /// </summary>
        /// <returns>
        /// Returns the json model for the type Order
        /// </returns>
        public virtual JToken SerializeJson(JToken outputObject)
        {
            if (outputObject == null)
            {
                outputObject = new JObject();
            }
            if (this.Customer != null)
            {
                outputObject["Customer"] = this.Customer.SerializeJson(null);
            }
            if (this.CustomerId != null)
            {
                outputObject["CustomerId"] = this.CustomerId.Value;
            }
            if (this.Id != null)
            {
                outputObject["Id"] = this.Id.Value;
            }
            if (this.ProductName != null)
            {
                outputObject["ProductName"] = this.ProductName;
            }
            if (this.Quantity != null)
            {
                outputObject["Quantity"] = this.Quantity.Value;
            }
            return outputObject;
        }
    }
}
