using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HS11PR001.Application.Features.Products.Commands.ProductCreate;

public class ProductCreateCommand : IRequest<bool>
{
    public string Name { get; set; } = default!;
    public double Price { get; set; }
}
