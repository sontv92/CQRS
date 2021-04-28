using CleanArchitecture.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.CQRS.Product.ResponseModel
{
    public class ProductCommandResponseModel
    {
        public bool IsSuccess { get; set; }
        public Guid ProductId { get; set; }
    }
}
