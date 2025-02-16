using System;

namespace Model;

public class XunJia
{
	private int _id;

	private string _LinksName;

	private string _LinksTel;

	private string _LinksEmail;

	private string _SerPro;

	private string _OrgLanguage;

	private string _ToLanguage;

	private int _TxtCount;

	private string _TxtSCount;

	private int _ispaiban;

	private int _ercijiaogao;

	private int _rungao;

	private DateTime _JiaojianTime;

	private string _gongzuori;

	private string _zhuyicontent;

	private string _Annex;

	private DateTime _addTime;

	private string _ip;

	private int _Finish;

	public int id
	{
		get
		{
			return _id;
		}
		set
		{
			_id = value;
		}
	}

	public string LinksName
	{
		get
		{
			return _LinksName;
		}
		set
		{
			_LinksName = value;
		}
	}

	public string LinksTel
	{
		get
		{
			return _LinksTel;
		}
		set
		{
			_LinksTel = value;
		}
	}

	public string LinksEmail
	{
		get
		{
			return _LinksEmail;
		}
		set
		{
			_LinksEmail = value;
		}
	}

	public string SerPro
	{
		get
		{
			return _SerPro;
		}
		set
		{
			_SerPro = value;
		}
	}

	public string OrgLanguage
	{
		get
		{
			return _OrgLanguage;
		}
		set
		{
			_OrgLanguage = value;
		}
	}

	public string ToLanguage
	{
		get
		{
			return _ToLanguage;
		}
		set
		{
			_ToLanguage = value;
		}
	}

	public int TxtCount
	{
		get
		{
			return _TxtCount;
		}
		set
		{
			_TxtCount = value;
		}
	}

	public string TxtSCount
	{
		get
		{
			return _TxtSCount;
		}
		set
		{
			_TxtSCount = value;
		}
	}

	public int ispaiban
	{
		get
		{
			return _ispaiban;
		}
		set
		{
			_ispaiban = value;
		}
	}

	public int ercijiaogao
	{
		get
		{
			return _ercijiaogao;
		}
		set
		{
			_ercijiaogao = value;
		}
	}

	public int rungao
	{
		get
		{
			return _rungao;
		}
		set
		{
			_rungao = value;
		}
	}

	public DateTime JiaojianTime
	{
		get
		{
			return _JiaojianTime;
		}
		set
		{
			_JiaojianTime = value;
		}
	}

	public string gongzuori
	{
		get
		{
			return _gongzuori;
		}
		set
		{
			_gongzuori = value;
		}
	}

	public string zhuyicontent
	{
		get
		{
			return _zhuyicontent;
		}
		set
		{
			_zhuyicontent = value;
		}
	}

	public string Annex
	{
		get
		{
			return _Annex;
		}
		set
		{
			_Annex = value;
		}
	}

	public DateTime addTime
	{
		get
		{
			return _addTime;
		}
		set
		{
			_addTime = value;
		}
	}

	public string ip
	{
		get
		{
			return _ip;
		}
		set
		{
			_ip = value;
		}
	}

	public int Finish
	{
		get
		{
			return _Finish;
		}
		set
		{
			_Finish = value;
		}
	}

	public string Note { get; set; }
}
