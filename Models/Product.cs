namespace Bath_Remodel.Models
{
    public class Product
    {
        public Product() 
        {

        }

        public int idproduct { get; set; }
        public string productcode { get; set; }
        public string productname { get; set; }
        public string finishcode { get; set; }
        public string stylecode { get; set; }
        public string shapecode { get; set; }
        public string typecode { get; set; }
        public double price { get; set; }
        public IEnumerable<Category> Categories { get; set; }

    }
}
