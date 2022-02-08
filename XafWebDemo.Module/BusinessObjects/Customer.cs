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
    public class Customer : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Customer(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string _firstName;
        
        public string FirstName
        {
            get { return _firstName; }
            set { SetPropertyValue(nameof(FirstName), ref _firstName, value); }
        }

        string _lastname;

        public string Lastname
        {
            get { return _lastname; }
            set { SetPropertyValue(nameof(Lastname), ref _lastname, value); }
        }

        string _address;
        public string Address
        {
            get { return _address; }
            set { SetPropertyValue(nameof(Address), ref _address, value); }
        }

        string _city;
        public string City
        {
            get { return _city; }
            set { SetPropertyValue(nameof(City), ref _city, value); }
        }

        string _country;
        public string Country
        {
            get { return _country; }
            set { SetPropertyValue(nameof(Country), ref _country, value); }
        }

        string _postalCode;
        public string PostalCode
        {
            get { return _postalCode; }
            set { SetPropertyValue(nameof(PostalCode), ref _postalCode, value); }
        }

        string _phoneNumber;
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { SetPropertyValue(nameof(PhoneNumber), ref _phoneNumber, value); }
        }

        string _email;
        public string Email
        {
            get { return _email; }
            set { SetPropertyValue(nameof(Email), ref _email, value); }
        }

        DateTime _birthday;
        public DateTime Birthday
        {
            get { return _birthday; }
            set { SetPropertyValue(nameof(Birthday), ref _birthday, value); }
        }

    }
}