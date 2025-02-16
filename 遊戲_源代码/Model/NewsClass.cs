using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class NewsClass
    {
        private int _classid;

        public int classid
        {
            get { return _classid; }
            set { _classid = value; }
        }
        private string _ClassName;

        public string ClassName
        {
            get { return _ClassName; }
            set { _ClassName = value; }
        }
        private int _OrderID;

        public int OrderID
        {
            get { return _OrderID; }
            set { _OrderID = value; }
        }

        private int _ParentID;

        public int ParentID
        {
            get { return _ParentID; }
            set { _ParentID = value; }
        }



        public string Keywords { get; set; }

        public string Description { get; set; }

        public string ArtListTitle { get; set; }
        public string ArtListDescription { get; set; }

    }
}
