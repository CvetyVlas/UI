namespace Data.Model
{
    /// <summary>
    /// Product Entity
    /// </summary>
    public class Car
    {
        public int Id { get; set; }

        public string Category { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int ProductionYear { get; set; }

        public string Engine { get; set; }

        public string GearBox { get; set; }

        public int Power { get; set; }

        public string Color { get; set; }

        public decimal Price { get; set; }
        
    }
}
