using System.ComponentModel.DataAnnotations;

namespace TrackingVaccineClient.Models
{
    public class Vaccine
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Code Tidak boleh kosong")]
        public string code { get; set; }
        public string registered_number { get; set; }
        public

    }
}