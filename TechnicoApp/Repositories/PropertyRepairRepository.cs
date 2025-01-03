﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TechnicoApp.Context;
using TechnicoApp.Models;

namespace TechnicoApp.Repositories;

public class PropertyRepairRepository : IRepository<PropertyRepair, long>, IPropertyRepository<PropertyRepair,long>
{
    private readonly TechnicoDbContext _context;

    public PropertyRepairRepository(TechnicoDbContext context)
    {
        _context = context;
    }
    public async Task<PropertyRepair?> CreateAsync(PropertyRepair propertyRepair)
    {
        await _context.PropertyRepairs.AddAsync(propertyRepair);
        await _context.SaveChangesAsync();
        return propertyRepair;
    }

    public async Task<PropertyRepair?> GetAsync(long id)
    {
        return await _context.PropertyRepairs
        .AsNoTracking()
        .FirstOrDefaultAsync(p => p.Id == id);
    }

    public async Task<List<PropertyRepair>> GetAsync()
    {
        return await _context.PropertyRepairs.ToListAsync();
    }

    public async Task<PropertyRepair?> UpdateAsync(PropertyRepair propertyRepair)
    {
        _context.PropertyRepairs.Update(propertyRepair);
        await _context.SaveChangesAsync();
        return propertyRepair;
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var propertyRepair = await _context.PropertyRepairs.FindAsync(id);
        if (propertyRepair == null) return false;

        _context.PropertyRepairs.Remove(propertyRepair);
        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<PropertyRepair?> DeactivateAsync(long id)
    {
        var propertyRepair = await _context.PropertyRepairs.FindAsync(id);
        if (propertyRepair == null) return default;
        propertyRepair.IsActive = false;
        _context.PropertyRepairs.Update(propertyRepair);
        await _context.SaveChangesAsync();

        return propertyRepair;
    }

    public async Task<List<PropertyRepair>> GetByOwnerVatNumberAsync(string vatNumber)
    {
        return await _context.Set<PropertyRepair>()
           .Where(item => item.PropertyOwner.VatNumber == vatNumber)
           .ToListAsync();
    }
}
