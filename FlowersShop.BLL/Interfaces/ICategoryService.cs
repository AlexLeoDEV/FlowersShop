using FlowersShop.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowersShop.BLL.Interfaces
{
    public interface ICategoryService
    {
        CategoryDTO GetCategory(int? id);
        IEnumerable<CategoryDTO> GetCategories();
        void Create(CategoryDTO category);
        void Delete(int id);
        void Update(CategoryDTO category);
        void Dispose();
        IEnumerable<string> GetCategoryName();
    }
}
