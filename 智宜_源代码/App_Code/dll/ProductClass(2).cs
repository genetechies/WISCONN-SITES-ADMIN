using System;
using System.Collections.Generic;
using System.Text;

namespace ZeroStudio.Model {
    public class ProductClass {
        public ProductClass() { }
        #region Model
        private int _pc_id;
        private string _pc_classname;
        private string _pc_classnameen;
        private string _pc_imageurl;
        private int _pc_parentid;
        private int _pc_sortkey;


        public int PC_Id {
            set { _pc_id = value; }
            get { return _pc_id; }
        }

        public string PC_ClassName {
            set { _pc_classname = value; }
            get { return _pc_classname; }
        }
        public string PC_ClassNameEn {
            set { _pc_classnameen = value; }
            get { return _pc_classnameen; }
        }
        public string PC_ImageUrl {
            set { _pc_imageurl = value; }
            get { return _pc_imageurl; }
        }
        public int PC_ParentID {
            set { _pc_parentid = value; }
            get { return _pc_parentid; }
        }

        public int PC_SortKey {
            set { _pc_sortkey = value; }
            get { return _pc_sortkey; }
        }
        #endregion Model
        public string Keywords { get; set; }
        public string Description { get; set; }
        public int PC_ParentID_Zh { get; set; }
        public int PC_Id_Zh { get; set; }

    }
}