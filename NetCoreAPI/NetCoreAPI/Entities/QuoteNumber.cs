using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using NetCoreAPI.Entities;

namespace NetCoreAPI.Entities
{
    
    [Table("VW_QuoteNumber")]
    
    public class QuoteNumber
    {
        
        public string QuoteNum { get; set; }
    }
}
