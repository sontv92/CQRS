using CleanArchitecture.Application.CQRS.ProductType.RequestModel;
using CleanArchitecture.Application.CQRS.ProductType.ResponseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.CQRS.Interfaces
{
    public interface IProductTypeCommandHandler
    {
        ProductTypeCommandResponseModel Handle(ProductTypeCommand request);
    }
}
