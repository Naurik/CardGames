using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayCard
{
    public class Cards<T>
    {
        public string[] suits;
        public T[] cardsNumber { get; set; }
    }
}
