using System;
using System.Collections.Generic;

namespace JPMORGAN_LOANS_BusinessEntities.hotelmanagementModels;

public partial class UserRole
{
    public int Id { get; set; }

    public int? RoleId { get; set; }

    public int? UserId { get; set; }

    public DateTime? CreatedDate { get; set; }
}
