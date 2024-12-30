﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechnicoApp.Models;

namespace TechnicoApp.Dtos;

/// <summary>
/// Represents the data transfer object (DTO) for a PropertyOwner.
/// This class is used to transfer the essential details of a property owner
/// between the front-end and back-end for operations such as registration, 
/// viewing, and updating property owner information.
/// </summary>
public class PropertyOwnerDto
{
    public string VatNumber { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public AddressDto AddressDto { get; set; } = new ();
    public string PhoneNumber { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the type of user (User or Admin).
    /// </summary>
    public UserType UserType { get; set; }
}

