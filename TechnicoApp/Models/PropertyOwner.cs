﻿using System;
using System.ComponentModel.DataAnnotations;
using TechnicoApp.Models;

/// <summary>
/// Represents a property owner in the system.
/// </summary>
public class PropertyOwner : IEntity<string>
{
    /// <summary>
    /// Gets or sets the unique id for the property owner, which is mapped to the VAT number.
    /// </summary>
    public string Id
    {
        get => VatNumber;
        set => VatNumber = value;
    }

    /// <summary>
    /// Gets or sets the VAT number of the property owner. This serves as the unique identifier.
    /// </summary>
    public string VatNumber { get; set; } = string.Empty;

    public string Name { get; set; } = string.Empty;

    public string Surname { get; set; } = string.Empty;

    public Address Address { get; set; } = new();

    public string PhoneNumber { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the type of user (User or Admin).
    /// </summary>
    public UserType UserType { get; set; }

    /// <summary>
    /// Gets or sets the list of properties owned by the property owner.
    /// A property owner can own multiple properties.
    /// </summary>
    public List<string> Properties { get; set; } = new(); 

    /// <summary>
    /// Gets or sets the list of repairs associated with the property owner's properties.
    /// A property owner can request multiple repairs for their properties.
    /// </summary>
    public List<string> Repairs { get; set; } = new(); 

}
