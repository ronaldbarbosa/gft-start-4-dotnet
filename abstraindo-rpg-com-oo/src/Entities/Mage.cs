namespace src.Entities
{
    public class Mage:Champion
    {
        int AbillityPower = 9;
        public Mage(string Name, string Region, string Role, int AbillityPower) : base(Name, Region, Role)
        {
            this.AbillityPower = AbillityPower;
        }
    }
}