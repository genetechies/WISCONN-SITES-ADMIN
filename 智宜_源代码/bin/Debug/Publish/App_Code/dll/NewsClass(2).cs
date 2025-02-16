using System;
using System.Collections.Generic;
using System.Text;

namespace ZeroStudio.Model
{
    public class NewsClass
    {
        public NewsClass()
        { }
        #region Model
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

        public string ArtListTitle { get; set; }
        public string ArtListDescription { get; set; }

        #endregion Model
    }
}
