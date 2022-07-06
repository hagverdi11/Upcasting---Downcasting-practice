using System;
using System.Collections.Generic;
using System.Text;

namespace Upcasting___Downcasting.Models
{
    public class Child:Mother
    {
        public string Toy { get; set; }

       

        public override void Survive()
        {
            Console.WriteLine("Going to school");
        }
        
           
        
    }
}
