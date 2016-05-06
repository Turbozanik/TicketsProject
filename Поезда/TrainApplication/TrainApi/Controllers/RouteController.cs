using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using TrainApi.Database;
using TrainApi.Models;

namespace TrainApi.Controllers
{
    [System.Web.Http.Authorize]
    [System.Web.Http.RoutePrefix("api/route")]
    public class RouteController : ApiController
    {
        private TrainEntities db = new TrainEntities();

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("getall")]
        [ResponseType(typeof(List<RouteDto>))]
        public IHttpActionResult GetRoute()
        {
            var res = db.Routes.ToList();
            var result = res.Select(p => new RouteDto
            {
                Id = p.Id,
                Route = p.Distination.Departure + "-" + p.Distination.Arrive,
                DateStart = p.DateStart,
                Capacity = p.Train.Capacity,
                FreePlaces = p.Train.Capacity - p.Purchases.Count,
                DateEnd = p.DateEnd,
                Train = p.Train.GovId
            });
            return this.Ok(result);
        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("getbydate")]
        [ResponseType(typeof(List<RouteDto>))]
        public IHttpActionResult GetByDate(DateTime? from, DateTime? to)
        {
            var res = db.Routes.Where(p => p.DateStart >= from.Value && p.DateEnd <= to.Value).ToList();
            var result = res.Select(p => new RouteDto
            {
                Id = p.Id,
                Route = p.Distination.Departure + "-" + p.Distination.Arrive,
                DateStart = p.DateStart,
                Capacity = p.Train.Capacity,
                FreePlaces = p.Train.Capacity - p.Purchases.Count,
                DateEnd = p.DateEnd,
                Train = p.Train.GovId
            });
            return this.Ok(result);
        }


    }
}
