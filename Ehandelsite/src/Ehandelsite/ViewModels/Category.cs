using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ehandelsite.ViewModels
{
    public class Category
    {
        public Category(string name)
        {
            Name = name;

            ProdcutList = new List<Product>();
            SubCategoryList = new List<Category>();
        }
        public string Name { get; set; }
        public List<Product> ProdcutList { get; set; }
        public List<Category> SubCategoryList { get; set; }
    }
}
