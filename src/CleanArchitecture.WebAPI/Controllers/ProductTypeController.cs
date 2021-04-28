using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CleanArchitecture.Application.CQRS.ProductType.RequestModel;
using CleanArchitecture.Application.DatabaseServices;
using CleanArchitecture.Application.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductTypeController : ControllerBase
    {
        private readonly IMediator _iMediator;
        public ProductTypeController(IMediator mediator)
        {
            _iMediator = mediator;
        }

        [HttpPost("makeproducttype")]
        public IActionResult MakeOrder([FromBody] ProductTypeCommand requestModel)
        {
            var response = _iMediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet("producttype")]
        public IActionResult OrderDetails([FromQuery] ProductTypeQuery requestModel)
        {
            var response = _iMediator.Send(requestModel);
            return Ok(response);
        }
    }
}