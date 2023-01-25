using Catalogo.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryDTO>> GetCategorys();
        Task<CategoryDTO> GetById(int? id);
        Task Add(CategoryDTO categorysDto);
        Task Update(CategoryDTO categorysDto);
        Task Remove(int? id);
    }
}
