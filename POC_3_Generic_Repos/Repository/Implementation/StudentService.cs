using POC_3_Generic_Repos.Models;
using POC_3_Generic_Repos.Repository.Interface;

namespace POC_3_Generic_Repos.Repository.Implementation
{
    public class StudentService : IStudentService<Student>
    {
        List<Student> _students = new List<Student>();
        public StudentService() 
        { 
            //for (int i = 1;  i <= 9; i++) 
            //{
            //    _students.Add(new Student
            //    {
            //        StdId = i,
            //        Name = "Stu" + i,
            //        RollNo = "100" + i
            //    });
            //}
            _students.Add(new Student
            {
                StdId = 1,
                Name = "Rohan",
                RollNo = "101",
                Performance = "Good"
            });
            _students.Add(new Student
            {
                StdId = 2,
                Name = "Mohan",
                RollNo = "102",
                Performance = "Good"
            });
            _students.Add(new Student
            {
                StdId = 3,
                Name = "Ram",
                RollNo = "103",
                Performance = "Excellent"
            });
            _students.Add(new Student
            {
                StdId = 4,
                Name = "Tarun",
                RollNo = "104",
                Performance = "Average"
            });
            _students.Add(new Student
            {
                StdId = 5,
                Name = "Aman",
                RollNo = "105",
                Performance = "Average"
            });
            _students.Add(new Student
            {
                StdId = 6,
                Name = "Rommy",
                RollNo = "106",
                Performance = "Good"
            });
            _students.Add(new Student
            {
                StdId = 7,
                Name = "Navya",
                RollNo = "107",
                Performance = "Good"
            });
        }
        public List<Student> Delete(int id)
        {
            _students.RemoveAll(x=>x.StdId == id);
            return _students;
        }

        public List<Student> GetAll()
        {
            return _students;
        }

        public Student GetById(int id)
        {
            return _students.Where(x => x.StdId == id).SingleOrDefault();
        }

        public List<Student> Insert(Student item)
        {
            _students.Add(item); return _students;
        }

        public List<Student> Update(Student item)
        {
            var exItem = GetById((int)item.GetType().GetProperty("StdId")?.GetValue(item));
            if (exItem != null)
            {
                var properties = typeof(Student).GetProperties();
                foreach (var property in properties)
                {
                    property.SetValue(exItem, property.GetValue(item));
                }
            }
            return _students;
        }
    }
}
