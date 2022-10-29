﻿using EstimateAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RideSaver.Server.Controllers;
using RideSaver.Server.Models;
using System.ComponentModel.DataAnnotations;

namespace EstimateAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstimateController : EstimateApiController
    {
        private readonly IEstimateRepository _estimateRepository;
        public EstimateController(IEstimateRepository estimateRepository) => _estimateRepository = estimateRepository;

        public override IActionResult GetEstimates([FromQuery(Name = "startPioint"), Required] Location startPoint, [FromQuery(Name = "endPoint"), Required] Location endPoint, [FromQuery(Name = "services")] List<Guid> services, [FromQuery(Name = "seats")] int? seats)
        {
            return new OkObjectResult(_estimateRepository.GetRideEstimates(startPoint, endPoint, services, seats));
        }

        public override IActionResult RefreshEstimates([FromQuery(Name = "ids"), Required] List<object> ids)
        {
            return new OkObjectResult(_estimateRepository.GetRideEstimatesRefresh(ids));
        }
    }
}
