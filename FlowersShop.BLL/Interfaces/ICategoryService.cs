namespace FlowersShop.BLL.Interfaces
{
    using FlowersShop.BLL.DTO;
    using System.Collections.Generic;

    public interface ICategoryService
    {
        CategoryDto GetCategory(int? id);
        IEnumerable<CategoryDto> GetCategories();
        void Create(CategoryDto category);
        void Delete(int id);
        void Update(CategoryDto category);
        void Dispose();
        IEnumerable<string> GetCategoryName();
    }
}
