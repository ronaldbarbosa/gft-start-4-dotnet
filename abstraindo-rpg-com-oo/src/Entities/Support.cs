namespace src.Entities
{
    public class Support:Champion
    {
        public string SupportType { get; set; }
        public Support(string Name, string Region, string Role, string SupportType) : base(Name, Region, Role)
        {
            this.SupportType = SupportType;
        }
        public override string Fighting()
        {
            return this.Name + " is " + this.SupportType ;
        }
    }
}