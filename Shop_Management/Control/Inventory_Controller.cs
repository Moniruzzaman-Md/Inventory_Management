using Inventory_Management.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory_Management.Control
{

    class Inventory_Controller
    {
        private Master _master;
        private DataAccess.DataAccess _dataAccess;

        public Inventory_Controller(Master master)
        {
            _master = master;
            _dataAccess = new(_master);
        }

        public bool AddInventory(Product product)
        {
            return _dataAccess.AddInventory(product);
        }

        public bool ProductExists(string name)
        {
            return _dataAccess.ProductExists(name);
        }

        public List<Product> GetUnapprovedProducts()
        {
            return _dataAccess.GetUnapprovedProducts();
        }

        public bool ApproveInventory(int id)
        {
            return _dataAccess.ApproveInventory(id);
        }

        public bool DeleteInventory(int id)
        {
            return _dataAccess.DeleteInventory(id);
        }

        public List<Product> getAllProducts()
        {
            return _dataAccess.GetAllProducts();
        }
    }
}
