﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DStreet.USAdvisory.Business.Admin.PremiumServices.DAL;


namespace DStreet.USAdvisory.Business.Admin.PremiumServices
{
    public class premiumservicesadd : IArticle
    {
        //Private member variables
        private int _articleId = 0;
        private string _articleDesc = string.Empty;
        private string _articleTitle = string.Empty;
        private DateTime _articleDateTime = DateTime.MinValue;
        private bool _isActive;
        private bool _isPaid;
        private string _ticker;
        TradingType _tradingType;

        public premiumservicesadd(string articleTitle, string articleDesc, DateTime articleDateTime, bool IsActive, bool IsPaid, string ticker,TradingType tradeType)
        {
            this._articleTitle = articleTitle;
            this._articleDesc = articleDesc;
            this._articleDateTime = articleDateTime;
            this._isActive = IsActive;
            this._isPaid = IsPaid;
            this.Ticker = ticker;
            this._tradingType = tradeType;
        }

        public void AddPremiumServices()
        {
            premiumservicesDAL.AddPremiumServices(_articleTitle,_articleDateTime,_articleDesc,_isActive,_isPaid,_ticker,_tradingType);
        }

        #region IArticle Members

        public int ArticleId
        {
            get
            {
                return _articleId;
            }
            set
            {
                _articleId = value;
            }
        }

        public string ArticleTitle
        {
            get
            {
                return _articleTitle;
            }
            set
            {
                _articleTitle = value;
            }
        }

        public string ArticleDesc
        {
            get
            {
                return _articleDesc;
            }
            set
            {
                _articleDesc = value;
            }
        }

        public DateTime ArticleDate
        {
            get
            {
                return _articleDateTime;
            }
            set
            {
                _articleDateTime = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>

        public bool IsPaid
        {
            get
            {
                return _isPaid;
            }
            set
            {
                _isPaid = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        
        public string Ticker
        {
            get
            {
                return _ticker;
            }

            set
            {
                _ticker = value;
            }

        }

        public bool IsActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                _isActive = value;
            }
        }

        #endregion

    }
}
