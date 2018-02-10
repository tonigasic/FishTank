using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace ASP.NetCoreProjekt.Models
{
    public partial class Tank
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Species { get; set; }
        public string Agressivity { get; set; }
        public string Size { get; set; }
        public string CareLevel { get; set; }
    }
}
