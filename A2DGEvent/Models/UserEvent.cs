using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A2DGEvent.Models
{
    public class UserEvent
    {
        public int Id { get; set; }
        public int UerId { get; set; }
        public int EventId { get; set; }
        public bool PresenceConfirm { get; set; }

        public virtual Event Event { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}