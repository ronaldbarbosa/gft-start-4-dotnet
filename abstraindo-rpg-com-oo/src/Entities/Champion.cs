namespace src.Entities;
public abstract class Champion
{
    public string Name { get; set; }
    public string Region { get; set; }
    public string Role{ get; set; }

    public Champion(string Name, string Region, string Role)
    {
        this.Name = Name;
        this.Region = Region;
        this.Role = Role;
    }
    public override string ToString()
    {
        return "Champion: " + this.Name + "\nRegion: " + this.Region + "\nRole: " + this.Role; 
    }
    public virtual string Fighting()
    {
        return this.Name + " is attacking!";
    }
}