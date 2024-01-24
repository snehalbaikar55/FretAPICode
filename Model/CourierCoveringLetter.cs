using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class CourierCoveringLetter
{
    public int CourierDocId { get; set; }

    public string? JobNo { get; set; }

    public DateTime? DocPreparedOn { get; set; }

    public int? DocPreparedbyId { get; set; }

    public string? DocPreparedbyName { get; set; }

    public int? CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public int? PicPersonId { get; set; }

    public string? PicPersonName { get; set; }

    public string? InvoiceNumber { get; set; }

    public bool? PrintSq { get; set; }

    public string? Sqnumber { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool? IsDeleted { get; set; }

    public int? Cargoid { get; set; }
}
