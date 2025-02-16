namespace Model;

public class linyuclass
{
	private int _id;

	private string _ClassName;

	private int _Sort;

	private int _guoclassid;

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
}
