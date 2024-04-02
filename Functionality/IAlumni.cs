using System;
using finalPOCService.models;

namespace finalPOCService.functionality
{
    public interface IAlumni
    {
        public List<Alumni> GetAlumni();
        public int AddAlumni(Alumni alumni);

        public Alumni SearchAlumniByRollno(int rollno);

        public int DeleteAlumniByRollno(int rollno);
    }
}