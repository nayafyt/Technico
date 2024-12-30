using TechnicoApp.Domain.Models;
using TechnicoApp.Dtos;
using TechnicoApp.Models;


namespace TechnicoApp.Dtos;

public class PropertyItemDTO
{
    public string PropertyIdentificationNumber { get; set; } = string.Empty;
    public AddressDto AddressDto { get; set; } = new ();
    public int YearOfConstruction { get; set; }
    public PropertyType PropertyType { get; set; }
    public string OwnerVAT { get; set; } = string.Empty;
}
