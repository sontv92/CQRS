using CleanArchitecture.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.CQRS.Product.ResponseModel
{
    public class ProductQueryResponseModel
    {
        public Guid ProductID { get; set; }
        public string ProductKey { get; set; }
        public string ProductName { get; set; }
        public string ProductImageUri { get; set; }
        public string ProductTypeName { get; set; }
        public RecordStatus RecordStatus { get; set; }
    }
}
