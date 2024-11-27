using BlazorMongoDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorMongoDB.IService
{
    public interface IStudentService
    {
        void SaveOrUpdate(Student student);
        Student GetStudent(string studentId);
        List<Student> GetStudents();
        string Delete(string studentId);
    }
}
