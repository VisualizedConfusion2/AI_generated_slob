using AI_generated_slob.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_generated_slob.Repositories
{
    public interface ICartRepo
    {
        public void AddToCart();
        public void RemoveFromCart();
        public List<Book> SeeItemsInCart();
        public void CalculateTotal();
        public double GetTotal();
    }
}
