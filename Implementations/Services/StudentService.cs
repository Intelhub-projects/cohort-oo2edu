using SwiftEd.Dtos;
using SwiftEd.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SwiftEd.Implementations.Services
{
    public class StudentService : IStudentService
    {
        public BaseResponse<StudentDto> CreateStudent(CreateStudentRequestModel model)
        {
            throw new NotImplementedException();
        }

        public BaseResponse<StudentDto> DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }

        public BaseResponse<IList<StudentDto>> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public BaseResponse<StudentDto> GetStudentDetails(int id)
        {
            throw new NotImplementedException();
        }

        public BaseResponse<StudentDto> UpdateAdmin(int id, UpdateStudentRequestModel model)
        {
            throw new NotImplementedException();
        }
    }
}