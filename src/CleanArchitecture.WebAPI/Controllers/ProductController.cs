using CleanArchitecture.Application.CQRS.Product.RequestModel;
using CleanArchitecture.Application.DatabaseServices;
using CleanArchitecture.Application.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.WebAPI.Controllers
{
    public class ProductController : ControllerBase
    {
        private readonly IMediator _iMediator;
        public ProductController(IMediator mediator)
        {
            _iMediator = mediator;
        }
        [HttpPost("makeproduct")]
        public IActionResult MakeOrder([FromBody] ProductCommand requestModel)
        {
            var response = _iMediator.Send(requestModel);
            return Ok(response);
        }

        [HttpGet("product")]
        public IActionResult OrderDetails([FromQuery] ProductQuery requestModel)
        {
            var response = _iMediator.Send(requestModel);
            return Ok(response);
        }
    }
}
