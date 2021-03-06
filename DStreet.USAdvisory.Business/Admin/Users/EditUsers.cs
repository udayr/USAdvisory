﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DStreet.USAdvisory.Business.Admin.Users.DAL;

namespace DStreet.USAdvisory.Business.Admin.Users
{
    public class EditUsers : IUser
    {
        #region "Private variables"

        private string _userId;
        private string _password;
        private string _firstName;
        private string _lastName;
        private string _phoneNumber;
        private string _address;
        private string _state;
        private string _country;
        private int _zipCode;
        private bool _isPaidSubscriber;
        private bool _IsAutoRenewal;
        private DateTime _registrationDate = DateTime.MinValue;
        private DateTime _subscriptionStartDate = DateTime.MinValue;
        private DateTime _subscriptionEndDate = DateTime.MinValue;


        #endregion


        #region IUser Members

        //Email Id
        public string UserId
        {

            get { return _userId; }
            set { _userId = value; }

        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }

        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }

        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }

        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }

        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }

        }

        public string State
        {
            get { return _state; }
            set { _state = value; }

        }

        public string Country
        {
            get { return _country; }
            set { _country = value; }

        }

        public int ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }

        }

        public bool IsPaidSubscriber
        {
            get { return _isPaidSubscriber; }
            set { _isPaidSubscriber = value; }

        }

        public bool IsAutoRenewal
        {
            get { return _IsAutoRenewal; }
            set { _IsAutoRenewal = value; }

        }

        public DateTime RegistrationDate
        {
            get
            {
                return _registrationDate;
            }
            set
            {
                _registrationDate = value;
            }
        }

        public DateTime SubscriptionStartDate
        {
            get
            {
                return _subscriptionStartDate;
            }
            set
            {
                _subscriptionStartDate = value;
            }
        }

        public DateTime SubscriptionEndDate
        {
            get
            {
                return _subscriptionEndDate;
            }
            set
            {
                _subscriptionEndDate = value;
            }
        }

        #endregion

        public void UpdateUser(IUser user)
        {
            UsersDAL.UpdateUser(user,SubscriptionStartDate,SubscriptionEndDate);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_articleId"></param>
        public EditUsers GetUserByUserId(string userId)
        {
            return UsersDAL.GetUserByUserId(userId);
        }


        public void AddUser()
        {
            UsersDAL.AddPortfolio(this,_subscriptionStartDate,_subscriptionEndDate);
        }
    }
}
