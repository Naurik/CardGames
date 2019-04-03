using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayCard
{
    public class Player<T> : Cards<T>
    {
        public int[,] deck { get; set; }
        public int[] players { get; set; }
    }
}
