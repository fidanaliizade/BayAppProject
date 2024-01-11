using BayApp.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BayApp.Core.Entities
{
    public class Featured:BaseEntity
    {
        public string  Title { get; set; }
        public string Description { get; set; }
        public string? Icon  { get; set; }
    }
}
