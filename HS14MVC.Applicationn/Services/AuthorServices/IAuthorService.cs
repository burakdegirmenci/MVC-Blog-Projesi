using HS14MVC.Applicationn.DTOs.AuthorDTOs;
using HS14MVC.Applicationn.DTOs.SubjectDTOs;
using HS14MVC.Domain.Utilities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS14MVC.Applicationn.Services.AuthorServices
{
    public interface IAuthorService
    {
        Task<IDataResult<AuthorDTO>> AddAsync(AuthorCreateDTO authorCreateDTO);
        Task<IDataResult<AuthorDTO>> UpdateAsync(AuthorUpdateDTO authorUpdateDTO);
        Task<IDataResult<AuthorDTO>> GetByIdAsync(Guid id);
        Task<IResult> DeleteAsync(Guid id);
        Task<IDataResult<List<AuthorListDTO>>> GetAllAsync();
        Task<Guid> GetAuthorIdByIdentityId(string identityId);
    }
}
