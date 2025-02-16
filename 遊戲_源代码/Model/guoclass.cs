using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class guoclass
    {
        private int nc_id;
        private string nc_classname;
        private int nc_sort;
        /// <summary>
        /// 
        /// </summary>
        public int Id
        {
            set { nc_id = value; }
            get { return nc_id; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ClassName
        {
            set { nc_classname = value; }
            get { return nc_classname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int Sort
        {
            set { nc_sort = value; }
            get { return nc_sort; }
        }
        public string Keywords { get; set; }

        public string Description { get; set; }
    }
}
