namespace Model;

public class linyuxinxi
{
	private int _id;

	private string _title;

	private int _Sort;

	private int _linyuclassid;

	private int _C_show;

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

	public string title
	{
		get
		{
			return _title;
		}
		set
		{
			_title = value;
		}
	}

	public int Sort
	{
		get
		{
			return _Sort;
		}
		set
		{
			_Sort = value;
		}
	}

	public int linyuclassid
	{
		get
		{
			return _linyuclassid;
		}
		set
		{
			_linyuclassid = value;
		}
	}

	public int C_show
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
}
