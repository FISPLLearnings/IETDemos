using _27DBAttributeLib;
namespace _26EmpLib
{
	//POCO - Plain Old CLR Object
	[Table(TableName ="Employee")]
	public class Emp
    {
		
		private int _ID;
		private string _Name;
		private string _Address;

        [Column(ColumnName = "EId", ColumnType = "int")]
        public int Id
        {
            get { return _ID; }
            set { _ID = value; }
        }
        [Column(ColumnName = "EName", ColumnType = "varchar(50)")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        [Column(ColumnName ="EAddress",ColumnType ="varchar(50)")]
		public string Address
		{
			get { return _Address; }
			set { _Address = value; }
		}
	}
}
