﻿namespace FormLiczniki.Dto
{
    public class LicznikiDto
    {
        public LicznikiDto()
        {
        }

        public LicznikiDto(int? id, string nazwa, string typ)
        {
            Id = id;
            Nazwa = nazwa;
            Typ = typ;
        }

        public int? Id { get; set; }

        public string Nazwa { get; set; }

        public string Typ { get; set; }
    }
}