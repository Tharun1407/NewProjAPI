﻿namespace NewProjApi.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }   
        
        public string Name { get; set; }
        public string Code { get; set; }

        public double area { get; set; }

        public double Lat { get; set; }
        public double Long { get; set; }

        public long Population { get; set; }



        //navigation Properties

        public IEnumerable<Walk> Walks { get; set; }
    }
}
