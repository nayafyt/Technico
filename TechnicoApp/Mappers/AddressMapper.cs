using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicoApp.Dtos;
using TechnicoApp.Models;

namespace TechnicoApp.Mappers;
/// <summary>
/// Implements the <see cref="IMapper{Address, AddressDto}"/> interface to convert between 
/// the <see cref="Address"/> entity and the <see cref="AddressDto"/>.
/// </summary>
public class AddressMapper : IMapper<Address, AddressDto>
{
    /// <summary>
    /// Converts an <see cref="Address"/> entity into an <see cref="AddressDto"/>.
    /// </summary>
    /// <param name="address">The <see cref="Address"/> entity to be converted.</param>
    /// <returns>An <see cref="AddressDto"/> that represents the input <see cref="Address"/> entity.</returns>
    public AddressDto? GetDto(Address address)
    {
        if (address == null)
        {
            return null;
        }

        return new AddressDto
        {
            Street = address.Street,
            City = address.City,
            PostalCode = address.PostalCode,
            Country = address.Country
        };
    }

    /// <summary>
    /// Converts an <see cref="AddressDto"/> back into an <see cref="Address"/> entity.
    /// </summary>
    /// <param name="addressDto">The <see cref="AddressDto"/> to be converted.</param>
    /// <returns>An <see cref="Address"/> entity that represents the input <see cref="AddressDto"/>.</returns>
    public Address? GetModel(AddressDto addressDto)
    {
        if (addressDto == null)
        {
            return null;
        }

        return new Address
        {
            Street = addressDto.Street,
            City = addressDto.City,
            PostalCode = addressDto.PostalCode,
            Country = addressDto.Country
        };
    }
}

