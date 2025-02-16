namespace Model;

public class guopic
{
	private int _id;

	private string _title;

	private int _Sort;

	private int _guoclassid;

	private string _pic;

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

	public int guoclassid
	{
		get
		{
			return _guoclassid;
		}
		set
		{
			_guoclassid = value;
		}
	}

	public string pic
	{
		get
		{
			return _pic;
		}
		set
		{
			_pic = value;
		}
	}
}
