using System.Collections.Generic;
using TA.Data;
using TA.Data.Interfaces;

namespace TA.Service
{
    public interface ICategoryService
    {
        IList<Category> GetCategories();
    }
}
