namespace Model;

public class NewsClass
{
	private int _classid;

	private string _ClassName;

	private int _OrderID;

	private int _ParentID;

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

	public string Keyword { get; set; }

	public string Desciption { get; set; }
    public string ArtListTitle { get; set; }
    public string ArtListDescription { get; set; }
}
