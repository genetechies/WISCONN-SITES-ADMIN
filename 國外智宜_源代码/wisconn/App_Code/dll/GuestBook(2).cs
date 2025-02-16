using System;
using System.Collections.Generic;
using System.Text;

namespace ZeroStudio.Model
{
    public class GuestBook
    {
        public GuestBook()
        { }
        #region Model
        private int _g_id;
        private string _g_title;
        private string _g_username;
        private string _g_email;
        private string _g_content;
        private DateTime _g_datetime;

        
        public int G_Id
        {
            set { _g_id = value; }
            get { return _g_id; }
        }
        
        public string G_Title
        {
            set { _g_title = value; }
            get { return _g_title; }
        }
        
        
        public string G_Username
        {
            set { _g_username = value; }
            get { return _g_username; }
        }
       
        
        public string G_Email
        {
            set { _g_email = value; }
            get { return _g_email; }
        }
        
        public string G_Content
        {
            set { _g_content = value; }
            get { return _g_content; }
        }
        
       
        public DateTime G_Datetime
        {
            set { _g_datetime = value; }
            get { return _g_datetime; }
        }
        #endregion Model
    }
}
