using System;
using System.Collections.Generic;
using System.Text;

namespace ZeroStudio.Model
{
    public class News
    {
        public News()
        { }
        #region Model
        private int _n_id;
        private string _n_title;
        private int _n_classid;
        private string _n_content;
        private DateTime _n_datetime;
        private string _n_author;
        private string _n_source;
        private string _n_keyword;
        private string _n_description;
        private string _n_input;
        private int _n_hitnum;
        private int _n_state;
        private int _n_isshow;

        /// <summary>
        /// 
        /// </summary>
        public int N_Id
        {
            set { _n_id = value; }
            get { return _n_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string N_title
        {
            set { _n_title = value; }
            get { return _n_title; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int N_ClassID
        {
            set { _n_classid = value; }
            get { return _n_classid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string N_Content
        {
            set { _n_content = value; }
            get { return _n_content; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime N_DateTime
        {
            set { _n_datetime = value; }
            get { return _n_datetime; }
        }
        public string N_Author {
            set { _n_author = value; }
            get { return _n_author; }
        }
        public string N_Source {
            set { _n_source = value; }
            get { return _n_source; }
        }
        public string N_Keyword {
            set {
                _n_keyword = value;
            }
            get {
                return _n_keyword;
            }
        }
        public string N_Description {
            set { _n_description = value; }
            get { return _n_description; }
        }
        public string N_Input {
            set { _n_input = value; }
            get { return _n_input; }
        }
        public int N_HitNum {
            set { _n_hitnum = value; }
            get { return _n_hitnum; }
        }
        public int N_State {
            set { _n_state = value; }
            get { return _n_state; }
        }
        public int N_IsShow {
            set { _n_isshow = value; }
            get { return _n_isshow; }
        }

        public string N_Product { get; set; }
        #endregion Model
    }
}
