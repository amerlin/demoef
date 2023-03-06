namespace ef_demo.Model
{
    using Microsoft.Identity.Client;
    using System.ComponentModel.DataAnnotations;

    public class City
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public int Edicole { get; set; }
    }
}
