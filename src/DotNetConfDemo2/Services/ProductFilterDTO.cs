namespace DotNetConfDemo2.Services
{
    public class ProductFilterDTO
    {

        public string SearchText { get; set; }

        public bool AllowDiscontinued { get; set; }

        public int? CategoryId { get; set; }

    }
}