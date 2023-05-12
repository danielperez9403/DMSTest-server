﻿using System;

namespace webapi.Schema

{
    public class Dealer1 : DealerBase
    {
        public Dealer1() : base() { }
        public override string GetStatusDisplayString()
        {
            return Status == "Active" ? "For Sale" : "Inactive";
        }
    }

    public class Dealer2 : DealerBase
    {
        public Dealer2() : base() { }
        public override string GetStatusDisplayString()
        {
            return Status == "Active" ? "Active" : "Inactive";
        }
    }

    
    public class DealerBase
    {
        public DealerBase() 
        {
            Id = 0;
            Name = "";
            Status = "Inactive";
            Cars = new List<Car>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public  List<Car> Cars { get; set; }
        public virtual string GetStatusDisplayString() { return "Inactive";  }
    }
}
