using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace furniture
{
    class DataBaseQuery
    {
        WorkWithBase Base = new WorkWithBase();
        public DataTable ShowShopProducts()
        {
           return Base.GetComments("Select DISTINCT p.product_id as ID, pt.type_name as Тип, p.product_name as Название, p.product_price as Цена, f.firm_name as Производитель, p.product_description as Описание from products p, products_types pt, firms f where p.product_type = pt.type_id and p.product_firm = f.firm_id and p.product_place = 1 order by p.product_id");
        }
        
        public DataTable ShowFirms()
        {
            return Base.GetComments("Select * from firms");
        }

        public DataTable GetOneProduct(string id)
        {
            //string query = "Select product_name, type_name, product_price from product where" + id + """;
            return Base.GetComments("Select product_name, product_type, product_price from products where product_id =" + id + "");
        }

        public DataTable GetFirmContacts()
        {
            return Base.GetComments("Select * from firms");
        }
    }
}
