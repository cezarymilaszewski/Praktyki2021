using Microsoft.AspNetCore.Mvc;
using System;

namespace Liczniki.Models
{
    public class Model
    {
        public class ModelDto
        {
            public int Id { get; set; }
            public float Liczba { get; set; }
            
            public float LicznikGazDom { get; set; }
            public float LicznikGazBiura { get; set; }
            
            public float LicznikWodaDom { get; set; }
            public float LicznikWodaBiura { get; set; }
            public float LicznikWodaZimnaAzmar { get; set; }
            public float LicznikWodaZimna { get; set; }
            public float LicznikWodaCieplaGlowny { get; set; }
            public float LicznikWodaCieplaAzmar { get; set; }
            public float LicznikWodaAzmar { get; set; }
            public float LicznikWodaWarsztat { get; set; }

            public float LicznikPradBiuroAzmar { get; set; }
            public float LicznikPradBiuroFollo { get; set; }
            public float LicznikPradWspolnyBiurowiec { get; set; }
            public float LicznikPradRobert { get; set; }
            public float LicznikPradSerwerownia { get; set; }
            public float LicznikPradKlimatyzacja { get; set; }
            public float LicznikPradIza_Sasiu { get; set; }
            public float LicznikPradAzmarHala { get; set; }
            public float LicznikPradDomGlowny { get; set; }
            public float LicznikPradGlownyElektro { get; set; }
            public float LicznikPradGlownyWaldek { get; set; }
            public float LicznikPradDom { get; set; }
        }
    }
}