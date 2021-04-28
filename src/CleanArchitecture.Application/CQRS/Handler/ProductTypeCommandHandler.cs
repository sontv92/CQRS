using CleanArchitecture.Application.CQRS.ProductType.RequestModel;
using CleanArchitecture.Application.CQRS.ProductType.ResponseModel;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.CQRS.Handler
{
    public class ProductTypeCommandHandler : IRequestHandler<ProductTypeCommand, ProductTypeCommandResponseModel>
    {
        private readonly IMediator _mediator;
        public ProductTypeCommandHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<ProductTypeCommandResponseModel> Handle(ProductTypeCommand request, CancellationToken cancellationToken)
        {
            var result = new ProductTypeCommandResponseModel();
            result.IsSuccess = true;
            // Your logic here

            return result;
        }
    }
}
