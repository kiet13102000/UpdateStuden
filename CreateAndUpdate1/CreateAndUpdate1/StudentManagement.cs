using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAndUpdate1
{
    class StudentManagement
    {
        OOPCSKEntities db = new OOPCSKEntities();
        public P13947[] GetStudent()
        {
            return db.P13947.ToArray();
        }
        public void GetStudent(int id)
        {
            db.P13947.Find(id);
            var oldClass = db.P13947.Find(id);
        }
        public void CreateStudent (string code , string name , Boolean gender , string hometown)
        {
        var newclass = new P13947();
            newclass.Code = code;
            newclass.Name = name;
            newclass.Hometown = hometown;
            newclass.Gender = gender;

        }
        public void UpdateStuden(int id , string code , string name , Boolean gender , string hometown)
        {
            db.P13947.Find(id);
            var oldclass = db.P13947.Find(id);

            oldclass.Code = code;
            oldclass.Name = name;
            oldclass.Gender = gender;
            oldclass.Hometown = hometown;
        }
        public void DeleteStudent (int id)
        {
            var classID = db.P13947.Find(id);
            db.P13947.Remove(classID);
            db.SaveChanges();
        }
        
    }
}
