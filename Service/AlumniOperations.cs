using System;
using finalPOCService.database;
using finalPOCService.functionality;
using finalPOCService.models;

namespace finalPOCService.service
{
    public class AlumniOperations : IAlumni
    {
        DatabaseContext db;
        List<Alumni> alumlist;
        public AlumniOperations(DatabaseContext _db)
        {
            db = _db;
            alumlist = new List<Alumni>();
        }
        List<Alumni> IAlumni.GetAlumni()
        {
            var res = db.alumnis;
            foreach(var alum in res)
            {
                alumlist.Add(alum);
            }
            return alumlist;
        }

        int IAlumni.AddAlumni(Alumni alumni)
        {
            db.alumnis.Add(alumni);
            return db.SaveChanges();
        }

        Alumni IAlumni.SearchAlumniByRollno(int rollno)
        {
            var res = db.alumnis.Find(rollno);
            return res;
        }

        int IAlumni.DeleteAlumniByRollno(int rollno)
        {
            var res = db.alumnis.Find(rollno);
            if (res == null)
            {
                return 0;
            }
            db.alumnis.Remove(res);
            return db.SaveChanges();
        }
    }
}