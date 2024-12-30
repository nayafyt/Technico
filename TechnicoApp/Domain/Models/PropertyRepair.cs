using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicoApp.Domain.Models;

public class PropertyRepair
{
    public long Id { get; set; }
    public DateTime DateTime { get; set; }

    public RepairType RepairType { get; set; } = 1;

    public string RepairAddress { get; set; } = string.Empty;

    public RepairStatus RepairStatus { get; set; }
    public int RepairCost;
    public PropertyOwner PropertyOwner { get; set; }

}
