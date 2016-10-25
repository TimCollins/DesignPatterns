using System.Data.SqlClient;

namespace BlackWasp.Facade
{
    public class Product
    {
        private SqlConnection _conn;
        private string _itemNumber;

        /// <summary>
        /// This class is presented as a useful candidate for a facade to simplify various operations.
        /// To determine if the product has reached a low stock level there are multiple method SQL connections and method calls required.
        /// There isn't a simple LowStockLevel check, instead the following steps are required:
        /// Connect to the database
        /// Create an instance of Product, passing the database connection and item number
        /// Retrieve the current physical stock level
        /// Retrieve the number of items that are on order
        /// Get the currently allocated stock using StockAllocator
        /// Compare current stock to low stock level
        /// </summary>
        public Product(SqlConnection conn, string itemNumber)
        {
            _conn = conn;
            _itemNumber = itemNumber;
        }

        public int PhysicalStock
        {
            // Retrieve stock level from databsae
            get { return 10; }
        }

        public int StockOnOrder
        {
            // Retrieve incoming ordered stock from database
            get { return 2; }
        }

        public int LowStockLevel
        {
            // Retrieve low stock level from database
            get { return 4; }
        }
    }

    public static class StockAllocator
    {
        /// <summary>
        /// Retrieve allocated stock for product from database
        /// </summary>
        public static int GetAllocation(string itemNumber, SqlConnection conn)
        {
            return 1;
        }
    }

    public class StockFacade
    {
        public bool IsLowStock(string itemNumber)
        {
            SqlConnection conn = GetConnection();
            Product product = new Product(conn, itemNumber);

            int physical = product.PhysicalStock;
            int onOrder = product.StockOnOrder;
            int lowStock = product.LowStockLevel;
            int allocations = StockAllocator.GetAllocation(itemNumber, conn);

            int available = physical + onOrder - allocations;

            return available <= lowStock;
        }

        private SqlConnection GetConnection()
        {
            return null;
        }
    }
}
