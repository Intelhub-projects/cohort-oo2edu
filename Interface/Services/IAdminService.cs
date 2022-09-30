using System.Collections.Generic;
using SwiftEd.Dtos;

namespace SwiftEd.Interface.Services
{
    public interface IAdminService
    {
        
        BaseResponse<AdminDto> CreateAdmin (CreateAdminRequestModel model);
        BaseResponse<AdminDto> UpdateAdmin (int id, UpdateAdminRequestModel model);
        BaseResponse<AdminDto> DeleteAdmin (int id);
        BaseResponse<IList<AdminDto>> GetAllAdmins ();
        BaseResponse<AdminDto> GetAdminDetails (int id);
        
    }
}