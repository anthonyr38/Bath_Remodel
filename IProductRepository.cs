using Bath_Remodel.Models;

namespace Bath_Remodel
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        public void UpdateProduct (Product product);
        public void InsertProduct(Product productToInsert);
        public IEnumerable<Category> GetCategories();
        public Product AssignCategory();
        public void DeleteProduct(Product product);

        //

        public IEnumerable<Product> BathRem();
        public IEnumerable<Product> BathRemR026();
        public IEnumerable<Product> BathRemR015();
        public IEnumerable<Product> BathRemR040();
        public IEnumerable<Product> BathRemR004();
        public IEnumerable<Product> BathRemS026();
        public IEnumerable<Product> BathRemS015();
        public IEnumerable<Product> BathRemS040();
        public IEnumerable<Product> BathRemS004();

    }

}
