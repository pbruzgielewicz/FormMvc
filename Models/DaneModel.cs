using System.ComponentModel.DataAnnotations;
namespace FormMvc.Models;

public class DaneModel
{
    
    [Required(ErrorMessage = "Proszę podaj Imię")]
    [MinLength(2)]
    public string Imie { get; set; }
    [Required(ErrorMessage = "Proszę podaj nazwisko")]
    [MinLength(2)]
    public string Nazwisko { get; set; }
    [Required(ErrorMessage = "Proszę podaj Email")]
    [RegularExpression(".+\\@.+\\.[a-z]{2,3}")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Proszę podaj hasło")]
    [RegularExpression("^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{8,}$")]
    public string Haslo { get; set; }
    public string PotwierdzenieHasla { get; set; }
    [Required(ErrorMessage = "Proszę podaj Nr Telefonu")]
    [Phone]
    public string NumerTelefonu { get; set; }
    public int Wiek { get; set; }
    [Required(ErrorMessage = "Proszę podaj miasto")]
    [MinLength(10), MaxLength(50)]
    public string Miasto { get; set; }
    public enum Miasta { Zgierz, Pabianice, Radzionków, Świecie, Wilkowyje}
    
    public DaneModel()
    {
    }
}
