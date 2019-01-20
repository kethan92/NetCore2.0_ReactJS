using System.Collections.Generic;
using TA.Data;
using TA.Data.Interfaces;

namespace TA.Service.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IList<Category> GetCategories()
        {
            var repo = _unitOfWork.GetRepository<Category>();
            var categories = repo.GetList();
            return categories;
        }
    }
}
