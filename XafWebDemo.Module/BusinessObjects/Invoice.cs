using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace XafWebDemo.Module.BusinessObjects
{
    [NavigationItem("Business")]
    public class Invoice : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Invoice(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        string _invoiceNumber;
        public string InvoiceNumber
        {
            get { return _invoiceNumber; }
            set { SetPropertyValue(nameof(InvoiceNumber), ref _invoiceNumber, value); }
        }

        string _description;
        [Size(-1)]
        public string Description
        {
            get { return _description; }
            set { SetPropertyValue(nameof(Description), ref _description, value); }
        }

        DateTime _invoiceDate;
        public DateTime InvoiceDate
        {
            get { return _invoiceDate; }
            set { SetPropertyValue(nameof(InvoiceDate), ref _invoiceDate, value); }
        }

        Customer _customer;
        public Customer Customer
        {
            get { return _customer; }
            set { SetPropertyValue(nameof(Customer), ref _customer, value); }
        }
    }
}