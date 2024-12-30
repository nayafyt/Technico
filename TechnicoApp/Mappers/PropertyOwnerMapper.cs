﻿using TechnicoApp.Dtos;
using TechnicoApp.Models;

namespace TechnicoApp.Mappers;

/// <summary>
/// Implements the <see cref="IMapper{PropertyOwner, PropertyOwnerDto}"/> interface to convert between 
/// the <see cref="PropertyOwner"/> entity and the <see cref="PropertyOwnerDto"/>.
/// </summary>
public class PropertyOwnerMapper : IMapper<PropertyOwner, PropertyOwnerDto>
{
    /// <summary>
    /// Converts a <see cref="PropertyOwner"/> entity into a <see cref="PropertyOwnerDto"/>.
    /// </summary>
    /// <param name="propertyOwner">The <see cref="PropertyOwner"/> entity to be converted.</param>
    /// <returns>A <see cref="PropertyOwnerDto"/> that represents the input <see cref="PropertyOwner"/> entity.</returns>
    public PropertyOwnerDto? GetDto(PropertyOwner propertyOwner)
    {
        if (propertyOwner == null)
        {
            return null;
        }

        return new PropertyOwnerDto
        {
            VatNumber = propertyOwner.VatNumber,
            Name = propertyOwner.Name,
            Surname = propertyOwner.Surname,
            AddressDto = new AddressDto() {
                City = propertyOwner.Address.City,
                Street = propertyOwner.Address.Street,
                PostalCode = propertyOwner.Address.PostalCode,
                Country = propertyOwner.Address.Country
            }, 
            PhoneNumber = propertyOwner.PhoneNumber,
            Email = propertyOwner.Email,
            Password = propertyOwner.Password, // Consider whether the password should be included here
            UserType = propertyOwner.UserType
        };
    }

    /// <summary>
    /// Converts a <see cref="PropertyOwnerDto"/> back into a <see cref="PropertyOwner"/> entity.    /// </summary>
    /// <param name="propertyOwnerDto">The <see cref="PropertyOwnerDto"/> to be converted.</param>
    /// <returns>A <see cref="PropertyOwner"/> entity that represents the input <see cref="PropertyOwnerDto"/>.</returns>
    public PropertyOwner? GetModel(PropertyOwnerDto propertyOwnerDto)
    {
        if (propertyOwnerDto == null)
        {
            return null;
        }

        return new PropertyOwner
        {
             VatNumber = propertyOwnerDto.VatNumber,
            Name = propertyOwnerDto.Name,
            Surname = propertyOwnerDto.Surname,
            Address = new Address() { 
                Street = propertyOwnerDto.AddressDto.Street,
                City = propertyOwnerDto.AddressDto.City,
                PostalCode = propertyOwnerDto.AddressDto.PostalCode,
                Country = propertyOwnerDto.AddressDto.Country
            }, // Assuming Address class has its own mapping logic
            PhoneNumber = propertyOwnerDto.PhoneNumber,
            Email = propertyOwnerDto.Email,
            Password = propertyOwnerDto.Password, // Consider whether the password should be handled securely
            UserType = propertyOwnerDto.UserType

        };
    }
}
