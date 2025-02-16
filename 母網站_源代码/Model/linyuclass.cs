using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class linyuclass
    {
        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _ClassName;

        public string ClassName
        {
            get { return _ClassName; }
            set { _ClassName = value; }
        }
        private int _Sort;

        public int Sort
        {
            get { return _Sort; }
            set { _Sort = value; }
        }
        private int _guoclassid;

        public int guoclassid
        {
            get { return _guoclassid; }
            set { _guoclassid = value; }
        }

        public string Keywords { get; set; }
        public string Description { get; set; }
    }
}
