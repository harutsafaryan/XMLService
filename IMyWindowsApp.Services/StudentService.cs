using IMyWindowsApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlManager;

namespace IMyWindowsApp.Services
{
    public class StudentService : IStudentService
    {
        private readonly IXmlManager<Student> _studentXml;
        private const string _path = @"C:\University\student.xml";

        public StudentService(IXmlManager<Student> studentXml)
        {
            _studentXml = studentXml;
        }
        public void Add(Student model)
        {
            List<Student> students = _studentXml.Read(_path);
            students.Add(model);
            _studentXml.Write(students, _path);
        }

        public Student Get(Guid id)
        {
            return _studentXml.Read(_path).FirstOrDefault(t => t.Id == id);
        }

        public List<Student> GetAll()
        {
            return _studentXml.Read(_path);
        }
        public List<Student> GetAllByTeacher(Guid id)
        {
            return _studentXml.Read(_path).Where(s => s.teacherId == id).ToList();
        }
        public void Remove(Guid id)
        {
            List<Student> students = _studentXml.Read(_path);
            Student student = students.FirstOrDefault(t => t.Id == id);
            students.Remove(student);
            _studentXml.Write(students, _path);
        }

        public void Update(Student model)
        {
            List<Student> students = _studentXml.Read(_path);
            Student student = students.FirstOrDefault(t => t.Id == model.Id);
            int index = students.IndexOf(student);
            students[index] = model;
            _studentXml.Write(students, _path);
        }
    }
}
