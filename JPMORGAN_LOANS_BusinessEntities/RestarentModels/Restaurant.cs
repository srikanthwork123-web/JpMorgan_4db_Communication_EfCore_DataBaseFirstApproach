using System;
using System.Collections.Generic;

namespace JPMORGAN_LOANS_BusinessEntities.RestarentModels;

public partial class Restaurant
{
    public int Id { get; set; }

    public string? RestaurantName { get; set; }

    public string? RestaurantLocation { get; set; }

    public DateTime? CreationDate { get; set; }
}
