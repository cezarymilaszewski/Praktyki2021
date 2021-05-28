using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoUniversity.Data;
using ContosoUniversity.Dto;


namespace ContosoUniversity.Serwis
{
    interface IServiceLicznikDane
    {
        int Add(LicznikiDaneDto dto);
            LicznikiDaneDto Get(int licznikId);
            void Update(int licznikId, LicznikiDaneDto dane);
            void Delete(int licznikId);

        }
    
}