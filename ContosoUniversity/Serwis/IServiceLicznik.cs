using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Dto;

namespace ContosoUniversity.Serwis
{
    interface IServiceLicznik
    {
        int Add(string nazwa, string typ);
        LicznikiDto Get(int id);
        void Update(int id, LicznikiDto dto);
        void Delete(int id);

    }
}
