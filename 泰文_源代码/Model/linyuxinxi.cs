using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class linyuxinxi
    {
        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _title;

        public string title
        {
            get { return _title; }
            set { _title = value; }
        }
        private int _Sort;

        public int Sort
        {
            get { return _Sort; }
            set { _Sort = value; }
        }
        private int _linyuclassid;

        public int linyuclassid
        {
            get { return _linyuclassid; }
            set { _linyuclassid = value; }
        }
        private int _C_show;

        public int C_show
        {
            get { return _C_show; }
            set { _C_show = value; }
        }

    }
}
