using CleanArchitecture.Application.CQRS.Product.ResponseModel;
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
    public class ProductTypeQueryHandler : IRequestHandler<ProductTypeQuery, ProductTypeQueryResponseModel>
    {
        private readonly IMediator _mediator;
        public ProductTypeQueryHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<ProductTypeQueryResponseModel> Handle(ProductTypeQuery request, CancellationToken cancellationToken)
        {
            return new ProductTypeQueryResponseModel();
        }
    }
}
