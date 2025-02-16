using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class guopic
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
        private int _guoclassid;

        public int guoclassid
        {
            get { return _guoclassid; }
            set { _guoclassid = value; }
        }
        private string _pic;

        public string pic
        {
            get { return _pic; }
            set { _pic = value; }
        }


    }
}
