using System;
using System.Collections.Generic;

namespace JaysDB.Models
{
    public partial class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Weight { get; set; }
        public string City { get; set; } = null!;
    }
}
