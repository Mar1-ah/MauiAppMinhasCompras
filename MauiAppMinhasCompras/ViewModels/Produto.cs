using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppMinhasCompras.ViewModels
{
    internal class ProductsViewModel
    {
    }
}

public class Product
{
    public required string Name { get; set; }
    public string Description { get; set; }
}