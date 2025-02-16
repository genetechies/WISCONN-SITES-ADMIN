using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class TransTeam
    {
        private int _tid;

        public int tid
        {
            get { return _tid; }
            set { _tid = value; }
        }
        private string _tname;

        public string tname
        {
            get { return _tname; }
            set { _tname = value; }
        }
        private int _sort;

        public int sort
        {
            get { return _sort; }
            set { _sort = value; }
        }
        private int _typeid;

        public int typeid
        {
            get { return _typeid; }
            set { _typeid = value; }
        }
        private string _imgpath;

        public string imgpath
        {
            get { return _imgpath; }
            set { _imgpath = value; }
        }

        private string _home;
        /// <summary>
        /// 国家
        /// </summary>
        public string home
        {
            get { return _home; }
            set { _home = value; }
        }

        private int _avater;
        /// <summary>
        /// 性别
        /// </summary>
        public int avater
        {
            get { return _avater; }
            set { _avater = value; }
        }

        private string _xueli;
        /// <summary>
        /// 学历
        /// </summary>
        public string xueli
        {
            get { return _xueli; }
            set { _xueli = value; }
        }


        private string _descript;
        /// <summary>
        /// 介绍
        /// </summary>
        public string descript
        {
            get { return _descript; }
            set { _descript = value; }
        }


    }
}
