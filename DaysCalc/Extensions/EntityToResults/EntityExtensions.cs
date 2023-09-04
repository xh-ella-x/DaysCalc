using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysCalc.Extensions.EntityToResults;

public static class EntityExtensions
{
    public static EntityResultData ConvertToResult(this Entity entity)
    {
        var result = new EntityResultData
        {
            AmountOfDays = entity.AmountOfDays,
            ValidFrom = entity.ValidFrom.UtcDateTime,
            RemainingAmountOfDays = (entity.AmountOfDays - (int)(DateTime.Now.Date - entity.ValidFrom.Date).TotalDays) >= 0 ? (entity.AmountOfDays - (int)(DateTime.Now.Date - entity.ValidFrom.Date).TotalDays) : 0
        };
        return result;
    }
}