namespace src.Entities
{
    public class Marksman : Champion
    {
        public int AttackRange { get; set; }
        public Marksman(string Name, string Region, string Role, int AttackRange) : base(Name, Region, Role)
        {
            this.AttackRange = AttackRange;
        }
    }
}