using System;
using System.Collections.Generic;

namespace JPMORGAN_LOANS_BusinessEntities.hotelmanagementModels;

public partial class Customer
{
    public int? CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? Email { get; set; }
}
