using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyWebApp.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category>Categories { get; }
        //Category GetCategoryById(int CategoryId);
    }
}
