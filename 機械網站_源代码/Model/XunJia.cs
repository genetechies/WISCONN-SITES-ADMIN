using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class XunJia
    {
        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _LinksName;

        public string LinksName
        {
            get { return _LinksName; }
            set { _LinksName = value; }
        }
        private string _LinksTel;

        public string LinksTel
        {
            get { return _LinksTel; }
            set { _LinksTel = value; }
        }
        private string _LinksEmail;

        public string LinksEmail
        {
            get { return _LinksEmail; }
            set { _LinksEmail = value; }
        }
        private string _SerPro;

        public string SerPro
        {
            get { return _SerPro; }
            set { _SerPro = value; }
        }
        private string _OrgLanguage;

        public string OrgLanguage
        {
            get { return _OrgLanguage; }
            set { _OrgLanguage = value; }
        }
        private string _ToLanguage;

        public string ToLanguage
        {
            get { return _ToLanguage; }
            set { _ToLanguage = value; }
        }
        
        private int _TxtCount;

        public int TxtCount
        {
            get { return _TxtCount; }
            set { _TxtCount = value; }
        }
        private string _TxtSCount;

        public string TxtSCount
        {
            get { return _TxtSCount; }
            set { _TxtSCount = value; }
        }

        private int _ispaiban;

        public int ispaiban
        {
            get { return _ispaiban; }
            set { _ispaiban = value; }
        }

        private int _ercijiaogao;

        public int ercijiaogao
        {
            get { return _ercijiaogao; }
            set { _ercijiaogao = value; }
        }

        private int _rungao;

        public int rungao
        {
            get { return _rungao; }
            set { _rungao = value; }
        }

        private DateTime _JiaojianTime;

        public DateTime JiaojianTime
        {
            get { return _JiaojianTime; }
            set { _JiaojianTime = value; }
        }

        private string _gongzuori;

        public string gongzuori
        {
            get { return _gongzuori; }
            set { _gongzuori = value; }
        }

        private string _zhuyicontent;

        public string zhuyicontent
        {
            get { return _zhuyicontent; }
            set { _zhuyicontent = value; }
        }


        private string _Annex;

        public string Annex
        {
            get { return _Annex; }
            set { _Annex = value; }
        }
        private DateTime _addTime;

        public DateTime addTime
        {
            get { return _addTime; }
            set { _addTime = value; }
        }
        private string _ip;

        public string ip
        {
            get { return _ip; }
            set { _ip = value; }
        }

        private int _Finish;

        public int Finish
        {
            get { return _Finish; }
            set { _Finish = value; }
        }


        public string Note { get; set; }

    }
}
