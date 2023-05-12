using System;

namespace webapi.Schema

{
    public class Dealer1 : DealerBase
    {
        public Dealer1() : base() { }
        public override string Status
        {
            get { return base.Status == "Active" ? "For Sale" : "Inactive"; }
            set { base.Status = value; }
        }
    }

    public class Dealer2 : DealerBase
    {
        public Dealer2() : base() { }

        public override string Status
        {
            get { return base.Status == "Active" ? "Active" : "Inactive"; }
            set { base.Status = value; }
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
        public virtual string Status { get; set; }
        public  List<Car> Cars { get; set; }
    }
}
