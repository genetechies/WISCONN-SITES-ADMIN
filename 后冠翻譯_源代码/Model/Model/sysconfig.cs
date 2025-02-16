namespace Model;

public class sysconfig
{
	private int _id;

	private string _sys_Title;

	private string _searchkey;

	private string _sys_description;

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

	public string sys_Title
	{
		get
		{
			return _sys_Title;
		}
		set
		{
			_sys_Title = value;
		}
	}

	public string searchkey
	{
		get
		{
			return _searchkey;
		}
		set
		{
			_searchkey = value;
		}
	}

	public string sys_description
	{
		get
		{
			return _sys_description;
		}
		set
		{
			_sys_description = value;
		}
	}
}
