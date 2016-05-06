using System.Collections.Generic;
using TrainApi.Database;

namespace TrainApi.Models
{
    public class RouteDto
    {
        public int Id { get; set; }
        public string Train { get; set; }
        public int Capacity { get; set; }
        public int FreePlaces { get; set; } 
        public System.DateTime DateStart { get; set; }  
        public System.DateTime DateEnd { get; set; }
        public string Route { get; set; }
    }
}