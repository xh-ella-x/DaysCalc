using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DaysCalc;

public class EntityResultData
{
    [Required]
    [JsonPropertyName("valid_from")]
    public DateTime ValidFrom { get; set; }

    [Required]
    [JsonPropertyName("amount_of_days")]
    public int AmountOfDays { get; set; }

    [Required]
    [JsonPropertyName("remaining_amount_of_days")]
    public int RemainingAmountOfDays
    {
        get; set;

    }
}
