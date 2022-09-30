using SwiftEd.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwiftEd.Interface.Services
{
    public interface IStudentService
    {
        BaseResponse<StudentDto> CreateStudent(CreateStudentRequestModel model);
        BaseResponse<StudentDto> UpdateAdmin(int id, UpdateStudentRequestModel model);
        BaseResponse<StudentDto> DeleteStudent(int id);
        BaseResponse<IList<StudentDto>> GetAllStudents();
        BaseResponse<StudentDto> GetStudentDetails(int id);
    }
}