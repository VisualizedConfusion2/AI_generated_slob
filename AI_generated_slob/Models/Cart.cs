using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI_generated_slob.Models
{
    public class Cart
    {
        public User TheUser { get; set; }
        public List<Book> Items { get; set;}
        public double TotalPrice { get; set; }

        public Cart(User theUser, double totalPrice, List<Book> items) 
        {
            TheUser = theUser;
            TotalPrice = totalPrice;
            Items = items;
        }

        
    }
}
