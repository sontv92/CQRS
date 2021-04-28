using CleanArchitecture.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.CQRS.ProductType.ResponseModel
{
    public class ProductTypeCommandResponseModel
    {
        public bool IsSuccess { get; set; }
        public Guid ProductId { get; set; }
    }
}
