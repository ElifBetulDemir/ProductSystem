using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSystem.Application.Features.Products.Commands.ProductUpdate;

public class ProductUpdateCommand : IRequest<ProductUpdateCommand>
{
	public string Name { get; set; } = default!;
	public double Price { get; set; }
}
