namespace app_series.DIO.Series
{
    public abstract class EntidadeBase
    {
        public int ID { get; protected set; }

        public EntidadeBase(int id)
        {
            this.ID = id;
        }
    }
}