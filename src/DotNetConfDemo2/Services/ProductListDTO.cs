namespace DotNetConfDemo2.Services
{
    public class ProductListDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Supplier { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public decimal? UnitPrice { get; set; }
        public bool Discontinued { get; set; }
        public short? ReorderLevel { get; set; }
        public string QuantityPerUnit { get; set; }
    }
}