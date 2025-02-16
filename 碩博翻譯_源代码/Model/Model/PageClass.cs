using System;

namespace Model;

public class PageClass
{
	private int _classid;

	private string _ClassName;

	private string _username;

	private int _ParentID;

	private string _ParentPath;

	private int _Depth;

	private int _RootID;

	private int _Child;

	private int _PrevID;

	private int _NextID;

	private int _OrderID;

	private int _Setting;

	private bool _C_show;

	private string _D_Content;

	private string _D_Keyword;

	private string _D_Description;

	private int _P_State;

	private DateTime _addtime;

	private int _D_Count;

	private string _Title;

	public int classid
	{
		get
		{
			return _classid;
		}
		set
		{
			_classid = value;
		}
	}

	public string ClassName
	{
		get
		{
			return _ClassName;
		}
		set
		{
			_ClassName = value;
		}
	}

	public string username
	{
		get
		{
			return _username;
		}
		set
		{
			_username = value;
		}
	}

	public int ParentID
	{
		get
		{
			return _ParentID;
		}
		set
		{
			_ParentID = value;
		}
	}

	public string ParentPath
	{
		get
		{
			return _ParentPath;
		}
		set
		{
			_ParentPath = value;
		}
	}

	public int Depth
	{
		get
		{
			return _Depth;
		}
		set
		{
			_Depth = value;
		}
	}

	public int RootID
	{
		get
		{
			return _RootID;
		}
		set
		{
			_RootID = value;
		}
	}

	public int Child
	{
		get
		{
			return _Child;
		}
		set
		{
			_Child = value;
		}
	}

	public int PrevID
	{
		get
		{
			return _PrevID;
		}
		set
		{
			_PrevID = value;
		}
	}

	public int NextID
	{
		get
		{
			return _NextID;
		}
		set
		{
			_NextID = value;
		}
	}

	public int OrderID
	{
		get
		{
			return _OrderID;
		}
		set
		{
			_OrderID = value;
		}
	}

	public int Setting
	{
		get
		{
			return _Setting;
		}
		set
		{
			_Setting = value;
		}
	}

	public bool C_show
	{
		get
		{
			return _C_show;
		}
		set
		{
			_C_show = value;
		}
	}

	public string D_Content
	{
		get
		{
			return _D_Content;
		}
		set
		{
			_D_Content = value;
		}
	}

	public string D_Keyword
	{
		get
		{
			return _D_Keyword;
		}
		set
		{
			_D_Keyword = value;
		}
	}

	public string D_Description
	{
		get
		{
			return _D_Description;
		}
		set
		{
			_D_Description = value;
		}
	}

	public int P_State
	{
		get
		{
			return _P_State;
		}
		set
		{
			_P_State = value;
		}
	}

	public DateTime addtime
	{
		get
		{
			return _addtime;
		}
		set
		{
			_addtime = value;
		}
	}

	public int D_Count
	{
		get
		{
			return _D_Count;
		}
		set
		{
			_D_Count = value;
		}
	}

	public string Title
	{
		get
		{
			return _Title;
		}
		set
		{
			_Title = value;
		}
	}
}
