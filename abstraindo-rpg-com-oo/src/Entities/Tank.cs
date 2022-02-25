namespace src.Entities
{
    public class Tank:Champion
    {
        public int DefensePower { get; set; }
        public Tank(string Name, string Region, string Role, int DefensePower) : base(Name, Region, Role)
        {
            this.DefensePower = DefensePower;
        }
        public override string Fighting()
        {
            return this.Name + " is defending.";
        }
    }
}