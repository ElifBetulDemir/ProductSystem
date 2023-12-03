using HS11PR001.Application.Features.Products.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS11PR001.Application.Features.Products.Queries.GetProductList;

public class GetProductListQuery: IRequest<IEnumerable<ProductVM>>
{
}
