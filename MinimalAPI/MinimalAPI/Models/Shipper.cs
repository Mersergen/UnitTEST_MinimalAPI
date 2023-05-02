using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using MinimalAPI.Models;

namespace MinimalAPI.Models
{
    public partial class Shipper
    {
        public int ShipperId { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? Phone { get; set; }
    }
}
