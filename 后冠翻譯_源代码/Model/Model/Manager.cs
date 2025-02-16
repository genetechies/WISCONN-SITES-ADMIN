namespace Model;

public class Manager
{
	private int? _id;

	private string _AdminName;

	private string _Password;

	public int? id
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

	public string AdminName
	{
		get
		{
			return _AdminName;
		}
		set
		{
			_AdminName = value;
		}
	}

	public string Password
	{
		get
		{
			return _Password;
		}
		set
		{
			_Password = value;
		}
	}
}
