namespace _27DBAttributeLib
{
	[AttributeUsage(AttributeTargets.Class)]
    public class Table :Attribute
    {
		private string _TableName;

		public string TableName
		{
			get { return _TableName; }
			set { _TableName = value; }
		}
	}
	[AttributeUsage(AttributeTargets.Property)]
	public class Column :Attribute
	{
		private string _ColumnName;
		private string _ColumnType;

		public string ColumnType
		{
			get { return _ColumnType; }
			set { _ColumnType = value; }
		}

		public string ColumnName
		{
			get { return _ColumnName; }
			set { _ColumnName = value; }
		}

	}
}
