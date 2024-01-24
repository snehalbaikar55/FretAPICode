using System;
using System.Collections.Generic;

namespace FretAPI.Model;

public partial class WebReportMaster
{
    public int WebReportId { get; set; }

    public string WebReportName { get; set; } = null!;

    public string WebReportQuery { get; set; } = null!;

    public int? CreatedBy { get; set; }

    public DateTime? DateCreated { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? DateModified { get; set; }

    public int? DeletedBy { get; set; }

    public DateTime? DateDeleted { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<WebReportAccess> WebReportAccesses { get; } = new List<WebReportAccess>();

    public virtual ICollection<WebReportFilter> WebReportFilters { get; } = new List<WebReportFilter>();
}
