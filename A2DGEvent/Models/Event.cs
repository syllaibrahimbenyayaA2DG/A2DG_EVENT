using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace A2DGEvent.Models
{
    public class Event
    {
        public int Id { get; set; }
        public String Ttile { get; set; }
        public string Description { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime BeginHour { get; set; }
        public DateTime EndHour { get; set; }
        public string Location { get; set; }

        public virtual ICollection<UserEvent> UserEvents { get; set; }
    }
}