namespace Assignment_Lec_2_LINQ.Models2
{
	public class Order
	{
		public int OrderID { get; set; }
		public DateTime OrderDate { get; set; }
		public decimal Total { get; set; }
		public override string ToString() => $"{OrderID}: {OrderDate:d} for {Total:C2}";
	}
}