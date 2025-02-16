using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class sysconfig
    {
        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _sys_Title;

        public string sys_Title
        {
            get { return _sys_Title; }
            set { _sys_Title = value; }
        }
        private string _searchkey;

        public string searchkey
        {
            get { return _searchkey; }
            set { _searchkey = value; }
        }
        private string _sys_description;

        public string sys_description
        {
            get { return _sys_description; }
            set { _sys_description = value; }
        }


    }
}
