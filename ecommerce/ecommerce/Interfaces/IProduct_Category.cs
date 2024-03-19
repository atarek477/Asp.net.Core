using ecommerce.Dto;
using ecommerce.Model;

namespace ecommerce.Interfaces
{
    public interface IProduct_Category
    {

        Task<List<ResultDto>> GetAllByPNameOrCName(string pName);

    }
}
