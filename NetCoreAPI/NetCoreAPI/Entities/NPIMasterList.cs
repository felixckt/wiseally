using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using NetCoreAPI.Entities;

namespace NetCoreAPI.Entities
{

    [Table("InternalWeb.dbo.NPIMasterList")]
    public class NPIMasterList
    {
        public int Id { get; set; }
        public string ProjectID { get; set; }
    }
}
