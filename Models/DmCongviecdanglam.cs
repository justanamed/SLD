using System;
using System.Collections.Generic;

namespace khaosat_LDTB_HP.Models
{
    public partial class DmCongviecdanglam
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public long? Order { get; set; }
        public string Status { get; set; }
        public long? PortalId { get; set; }
    }
}
