using System;
namespace Model
{
	/// <summary>
	/// SubWeb:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SubWeb
	{
		public SubWeb()
		{}
		#region Model
		private int _swid;
		private string _swname;
		private string _swdomainname;
		private string _swdbservice;
		private string _swdbname;
		private string _swdbid;
		private string _swdbuser;
		private string _swdbuserpwd;
        private string _className;

        public string ClassName
        {
            get { return _className; }
            set { _className = value; }
        }
		/// <summary>
		/// 
		/// </summary>
		public int SWID
		{
			set{ _swid=value;}
			get{return _swid;}
		}
		/// <summary>
		/// 子网站名称
		/// </summary>
		public string SWName
		{
			set{ _swname=value;}
			get{return _swname;}
		}
		/// <summary>
		/// 子网站域名
		/// </summary>
		public string SWDomainName
		{
			set{ _swdomainname=value;}
			get{return _swdomainname;}
		}
		/// <summary>
		/// 数据库地址
		/// </summary>
		public string SWDBService
		{
			set{ _swdbservice=value;}
			get{return _swdbservice;}
		}
		/// <summary>
		/// 数据库名称
		/// </summary>
		public string SWDBName
		{
			set{ _swdbname=value;}
			get{return _swdbname;}
		}
		/// <summary>
		/// 数据库标识
		/// </summary>
		public string SWDBID
		{
			set{ _swdbid=value;}
			get{return _swdbid;}
		}
		/// <summary>
		/// 数据库登录名
		/// </summary>
		public string SWDBUser
		{
			set{ _swdbuser=value;}
			get{return _swdbuser;}
		}
		/// <summary>
		/// 密码
		/// </summary>
		public string SWDBUserPwd
		{
			set{ _swdbuserpwd=value;}
			get{return _swdbuserpwd;}
		}
		#endregion Model

	}
}

