using Bath_Remodel.Models;
using Dapper;
using System.Data;

namespace Bath_Remodel
{
    public class ProductRepository : IProductRepository
    {
        private readonly IDbConnection _conn;

        public ProductRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM product;");
        }

        public Product GetProduct(int id)
        {
            return _conn.QuerySingle<Product>("SELECT * FROM product WHERE idproduct = @id", new { id = id });
        }

        public void UpdateProduct(Product product)
        {
            _conn.Execute("UPDATE product SET productcode = @productcode, productname = @productname, finishcode = @finishcode, stylecode = @stylecode , shapecode = @shapecode, typecode = @typecode, price = @price WHERE idproduct = @id",
             new { productcode = product.productcode, productname = product.productname, finishcode = product.finishcode, stylecode = product.stylecode, shapecode = product.shapecode, typecode = product.typecode, price = product.price, id = product.idproduct });
        }

        public void InsertProduct(Product productToInsert)
        {
            _conn.Execute("INSERT INTO product (productcode, productname, finishcode, stylecode, shapecode, typecode, price) VALUES (@productcode, @productname, @finishcode, @stylecode, @shapecode, @typecode, @price);",
                new { productcode = productToInsert.productcode, productname = productToInsert.productname, finishcode = productToInsert.finishcode, stylecode = productToInsert.stylecode, shapecode = productToInsert.shapecode, typecode = productToInsert.typecode, price = productToInsert.price });
        }

        public IEnumerable<Category> GetCategories()
        {
            return _conn.Query<Category>("SELECT * FROM type;");
        }

        public Product AssignCategory()
        {
            var categoryList = GetCategories();
            var product = new Product();
            product.Categories = categoryList;
            return product;
        }

        public void DeleteProduct(Product product)
        {
            _conn.Execute("DELETE FROM REVIEWS WHERE ProductID = @id;", new { id = product.idproduct });
            _conn.Execute("DELETE FROM Sales WHERE ProductID = @id;", new { id = product.idproduct });
            _conn.Execute("DELETE FROM Products WHERE ProductID = @id;", new { id = product.idproduct });
        }

        public IEnumerable<Product> BathRem()
        {
            return _conn.Query<Product>("SELECT * FROM product;");
        }

        public IEnumerable<Product> BathRemR026()
        {
            return _conn.Query<Product>("SELECT * FROM product WHERE finishcode = '026' && shapecode = 'R';");
        }

        public IEnumerable<Product> BathRemR015()
        {
            return _conn.Query<Product>("SELECT * FROM product WHERE finishcode = '015' && shapecode = 'R';");
        }

        public IEnumerable<Product> BathRemR040()
        {
            return _conn.Query<Product>("SELECT * FROM product WHERE finishcode = '040' && shapecode = 'R';");
        }

        public IEnumerable<Product> BathRemR004()
        {
            return _conn.Query<Product>("SELECT * FROM product WHERE finishcode = '004' && shapecode = 'R';");
        }

        public IEnumerable<Product> BathRemS026()
        {
            return _conn.Query<Product>("SELECT * FROM product WHERE finishcode = '026' && shapecode = 'S';");
        }

        public IEnumerable<Product> BathRemS015()
        {
            return _conn.Query<Product>("SELECT * FROM product WHERE finishcode = '015' && shapecode = 'S';");
        }

        public IEnumerable<Product> BathRemS040()
        {
            return _conn.Query<Product>("SELECT * FROM product WHERE finishcode = '040' && shapecode = 'S';");
        }

        public IEnumerable<Product> BathRemS004()
        {
            return _conn.Query<Product>("SELECT * FROM product WHERE finishcode = '004' && shapecode = 'S';");
        }
    }
}
