namespace CityTraveler.Domain.Enums
{
    public class EntertaimentType : Enumeration
    {
        public static readonly EntertaimentType Event = new(1, "Event");
        public static readonly EntertaimentType Institution = new(2, "Institution");
        public static readonly EntertaimentType Landscape = new(3, "Landscape");

        protected EntertaimentType (int id, string name) : base(id, name) { }
    }
}
