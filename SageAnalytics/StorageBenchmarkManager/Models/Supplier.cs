using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace StorageBenchmarkManager.Models
{
    public class Supplier
    {
        [Key]
        public string Key { get; set; }
        public string Name { get; set; }
    }
}