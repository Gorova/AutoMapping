using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product{Name = "coffe", Price = 40, Id = 100};
            Mapper.CreateMap<Product, ProductViewModel>();
            var productViewModel = Mapper.Map<Product, ProductViewModel>(product);
            Console.WriteLine(productViewModel.Name);
        }
    }
}
