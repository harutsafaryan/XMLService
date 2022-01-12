using IMyWindowsApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using XmlManager;

namespace IMyWindowsApp.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly IXmlManager<Teacher> _teacherXml;
        private const string _path = @"C:\University\teacher.xml";

        public TeacherService(IXmlManager<Teacher> teacherXml)
        {
            _teacherXml = teacherXml;
        }
        public void Add(Teacher model)
        {
            List<Teacher> teachers = _teacherXml.Read(_path);
            teachers.Add(model);
            _teacherXml.Write(teachers, _path);
        }
        public Teacher Get(Guid id)
        {
            return _teacherXml.Read(_path).FirstOrDefault(t => t.Id == id);
        }
        public List<Teacher> GetAll()
        {
            return _teacherXml.Read(_path);
        }
        public void Remove(Guid id)
        {
            List<Teacher> teachers = _teacherXml.Read(_path);
            Teacher teacher = teachers.FirstOrDefault(t => t.Id == id);
            teachers.Remove(teacher);
            _teacherXml.Write(teachers, _path);
        }
    
        public void Update(Teacher model) 
        {
            List<Teacher> teachers = _teacherXml.Read(_path);
            Teacher teacher = teachers.FirstOrDefault(t => t.Id == model.Id);
            int index = teachers.IndexOf(teacher);
            teachers[index] = model;
            _teacherXml.Write(teachers, _path);
        }
    }
}
