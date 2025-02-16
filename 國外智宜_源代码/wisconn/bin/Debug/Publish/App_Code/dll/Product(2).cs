using System;
using System.Collections.Generic;
using System.Text;

namespace ZeroStudio.Model {
    public class Product {
        public Product() { }
        #region Model
        private int _p_id;
        private string _p_name;
        private string _p_name_en;
        private string _p_code;
        private string _p_model;
        private string _p_spec;
        private string _p_stock;
        private string _p_identity;
        private string _p_evinr;
        private int _p_classid;
        private int _p_parentid;
        private string _p_photourl;
        private string _p_doc;
        private DateTime _p_uptime;
        private int _p_state;


       
        public int P_ID {
            set { _p_id = value; }
            get { return _p_id; }
        }
        
        public string P_Name {
            set { _p_name = value; }
            get { return _p_name; }
        }
        public string P_Name_En {
            set { _p_name_en = value; }
            get { return _p_name_en; }
        }
        public string P_Code {
            set { _p_code = value; }
            get { return _p_code; }
        }
        public string P_Model {
            get { return _p_model; }
            set { _p_model = value; }
        }
        public string P_Spec {
            set { _p_spec = value; }
            get { return _p_spec; }
        }
        public string P_Stock {
            set { _p_stock = value; }
            get { return _p_stock; }
        }
        public string P_Identity {
            set { _p_identity = value; }
            get { return _p_identity; }
        }
        public string P_Evinr {
            set { _p_evinr = value; }
            get { return _p_evinr; }
        }
        public string P_Doc {
            set { _p_doc = value; }
            get { return _p_doc; }
        }
        
        public int P_ClassID {
            set { _p_classid = value; }
            get { return _p_classid; }
        }
        
        public int P_ParentID {
            set { _p_parentid = value; }
            get { return _p_parentid; }
        }

        public string P_PhotoUrl {
            set { _p_photourl = value; }
            get { return _p_photourl; }
        }

        public DateTime P_Uptime {
            set { _p_uptime = value; }
            get { return _p_uptime; }
        }
        public int P_State {
            set { _p_state = value; }
            get { return _p_state; }
        }

        public string Keywords { get; set; }
        public string Description { get; set; }

        public string UpKey { get; set; }
        public string DownKey { get; set; }
        #endregion Model
    }
}
