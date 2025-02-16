namespace Model;

public class guoclass
{
	private int nc_id;

	private string nc_classname;

	private int nc_sort;

	public int Id
	{
		get
		{
			return nc_id;
		}
		set
		{
			nc_id = value;
		}
	}

	public string ClassName
	{
		get
		{
			return nc_classname;
		}
		set
		{
			nc_classname = value;
		}
	}

	public int Sort
	{
		get
		{
			return nc_sort;
		}
		set
		{
			nc_sort = value;
		}
	}

	public string Keywords { get; set; }

	public string Description { get; set; }
}
