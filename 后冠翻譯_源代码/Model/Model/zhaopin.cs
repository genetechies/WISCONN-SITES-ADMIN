using System;

namespace Model;

public class zhaopin
{
	private int _id;

	private string _gangwei;

	private string _xueli;

	private string _renshu;

	private string _didian;

	private string _daiyu;

	private string _qixian;

	private string _yaoqiu;

	private DateTime _time;

	private int _sort;

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

	public string gangwei
	{
		get
		{
			return _gangwei;
		}
		set
		{
			_gangwei = value;
		}
	}

	public string xueli
	{
		get
		{
			return _xueli;
		}
		set
		{
			_xueli = value;
		}
	}

	public string renshu
	{
		get
		{
			return _renshu;
		}
		set
		{
			_renshu = value;
		}
	}

	public string didian
	{
		get
		{
			return _didian;
		}
		set
		{
			_didian = value;
		}
	}

	public string daiyu
	{
		get
		{
			return _daiyu;
		}
		set
		{
			_daiyu = value;
		}
	}

	public string qixian
	{
		get
		{
			return _qixian;
		}
		set
		{
			_qixian = value;
		}
	}

	public string yaoqiu
	{
		get
		{
			return _yaoqiu;
		}
		set
		{
			_yaoqiu = value;
		}
	}

	public DateTime time
	{
		get
		{
			return _time;
		}
		set
		{
			_time = value;
		}
	}

	public int sort
	{
		get
		{
			return _sort;
		}
		set
		{
			_sort = value;
		}
	}
}
