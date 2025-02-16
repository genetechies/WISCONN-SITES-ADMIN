using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class PageClass
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
        private string _username;

        public string username
        {
            get { return _username; }
            set { _username = value; }
        }
        private int _ParentID;

        public int ParentID
        {
            get { return _ParentID; }
            set { _ParentID = value; }
        }
        private string _ParentPath;

        public string ParentPath
        {
            get { return _ParentPath; }
            set { _ParentPath = value; }
        }
        private int _Depth;

        public int Depth
        {
            get { return _Depth; }
            set { _Depth = value; }
        }
        private int _RootID;

        public int RootID
        {
            get { return _RootID; }
            set { _RootID = value; }
        }
        private int _Child;

        public int Child
        {
            get { return _Child; }
            set { _Child = value; }
        }
        private int _PrevID;

        public int PrevID
        {
            get { return _PrevID; }
            set { _PrevID = value; }
        }
        private int _NextID;

        public int NextID
        {
            get { return _NextID; }
            set { _NextID = value; }
        }
        private int _OrderID;

        public int OrderID
        {
            get { return _OrderID; }
            set { _OrderID = value; }
        }
        private int _Setting;

        public int Setting
        {
            get { return _Setting; }
            set { _Setting = value; }
        }
        private bool _C_show;

        public bool C_show
        {
            get { return _C_show; }
            set { _C_show = value; }
        }
        private string _D_Content;

        public string D_Content
        {
            get { return _D_Content; }
            set { _D_Content = value; }
        }
        private string _D_Keyword;

        public string D_Keyword
        {
            get { return _D_Keyword; }
            set { _D_Keyword = value; }
        }
        private string _D_Description;

        public string D_Description
        {
            get { return _D_Description; }
            set { _D_Description = value; }
        }

        private int _P_State;

        public int P_State
        {
            get { return _P_State; }
            set { _P_State = value; }
        }

        private DateTime _addtime;

        public DateTime addtime
        {
            get { return _addtime; }
            set { _addtime = value; }
        }

        private int _D_Count;

        public int D_Count
        {
            get { return _D_Count; }
            set { _D_Count = value; }
        }

        private string _Title;

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }






    }
}
