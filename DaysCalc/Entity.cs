using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysCalc;

public class Entity
{
    public DateTimeOffset ValidFrom { get; set; } = DateTimeOffset.MinValue;
    public int AmountOfDays { get; set; }
    public int RemainingAmountOfDays { get; set; }
}