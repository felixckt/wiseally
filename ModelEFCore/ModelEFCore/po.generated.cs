//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor v
//     Source:                    https://github.com/msawczyn/EFDesigner
//     Visual Studio Marketplace: https://marketplace.visualstudio.com/items?itemName=michaelsawczyn.EFDesigner
//     Documentation:             https://msawczyn.github.io/EFDesigner/
//     License (MIT):             https://github.com/msawczyn/EFDesigner/blob/master/LICENSE
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ModelEFCore
{
   public partial class po
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public po()
      {
         poItems = new System.Collections.Generic.HashSet<global::ModelEFCore.poItem>();

         Init();
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Identity, Indexed, Required
      /// </summary>
      [Key]
      [Required]
      public int Id { get; protected set; }

      public DateTime? poDate { get; set; }

      public string poDescription { get; set; }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

      public virtual global::ModelEFCore.vendor poVendor { get; set; }

      public virtual ICollection<global::ModelEFCore.poItem> poItems { get; protected set; }

   }
}

