using System;
using System.Collections.Generic;
using System.Text;

namespace ZeroStudio.Model
{
    public class Manager
    {
        private int? _id;
        private string _AdminName;
        private string _Password;

        public int? id
        {
            set { _id = value; }
            get { return _id; }
        }

        public string AdminName
        {
            get { return _AdminName; }
            set { _AdminName = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
    }

}
