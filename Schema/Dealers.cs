namespace webapi.Schema

{
    public class Dealer1 : Car
    {
        public override string Status
        {
            get { return String.Equals(base.Status, "Active") ? "For Sale" : "Not for Sale"; }
            set { base.Status = value; }
        }
        public string DealerName { get; set; } = "Dealer 1";
    }

    public class Dealer2 : Car
    {
        public string DealerName { get; set; } = "Dealer 2";
    }
}
