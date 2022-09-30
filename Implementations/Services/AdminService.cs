using System.Collections.Generic;
using AutoMapper;
using SwiftEd.Dtos;
using SwiftEd.Interface.Repository;
using SwiftEd.Interface.Services;
using SwiftEd.Models;

namespace SwiftEd.Implementations.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public AdminService(IAdminRepository adminRepository, IMapper mapper, IUserRepository userRepository)
        {
            _adminRepository = adminRepository;
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public BaseResponse<AdminDto> CreateAdmin(CreateAdminRequestModel model)
        {
            var user = _mapper.Map<User>(model);
            var admin = _mapper.Map<Admin>(model);
            admin.UserId = user.Id;

           var adminInfo =  _adminRepository.Create(admin);
           return new BaseResponse<AdminDto>{
                Message = "Admin successfully created",
                Data = _mapper.Map<AdminDto>(adminInfo),
                Success = true

            };
        }

        public BaseResponse<AdminDto> DeleteAdmin(int id)
        {
            var admin = _adminRepository.Get(id);
            if(admin == null)return new BaseResponse<AdminDto>{Message = $"Admin not found" , Success = false};
            _adminRepository.Delete(admin);
            return new BaseResponse<AdminDto> { Message = $"Admin with ID {id} succesfully deleted", Success = true };
        }

        public BaseResponse<AdminDto> GetAdminDetails(int id)
        {
            var admin = _adminRepository.Get(id);
            if (admin == null) return new BaseResponse<AdminDto> { Message = $"Admin   not found", Success = false };
            return new BaseResponse<AdminDto> { Message = $"Admin with ID {id} succesfully deleted", Success = true, Data = _mapper.Map<AdminDto>(admin) };
        }

        public BaseResponse<IList<AdminDto>> GetAllAdmins()
        {
            var admin = _adminRepository.GetAll();
            if (admin == null) return new BaseResponse<IList<AdminDto>> { Message = $"Admins not found", Success = false };
            return new BaseResponse<IList<AdminDto>> { Message = $"Admin succesfully retrieved", Success = true, Data = _mapper.Map<IList<AdminDto>>(admin) };
        }

        public BaseResponse<AdminDto> UpdateAdmin(int id, UpdateAdminRequestModel model)
        {
            var admin = _adminRepository.Get(id);
            //var adminUserInfo = _userRepository.Get(admin.UserId); remove comment when userRepo is implemented
            if (admin == null) return new BaseResponse<AdminDto> { Message = $"Admin not found", Success = false };
            //adminUserInfo.Email = model.Email;
            //adminUserInfo.PassWord = model.Email;
            admin.FirstName = model.FirstName;
            admin.LastName = model.LastName;
            var adminInfo = _adminRepository.Update(admin);
            return new BaseResponse<AdminDto> { Message = $"Admin succesfully updated", Success = true, Data = _mapper.Map<AdminDto>(adminInfo) };
        }
    }
}