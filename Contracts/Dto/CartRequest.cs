using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Models;

namespace Contracts.Dto
{
    public class CartRequest
    {
        public bool IsCheckout { get; set; }
        public List<Product> products { get; set; }
    }
}
