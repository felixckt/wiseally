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

using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace ModelEFCore
{
    /// <inheritdoc/>
    public partial class EFModel1 : DbContext
   {
      #region DbSets
      public virtual System.Data.Entity.DbSet<global::ModelEFCore.po> poes { get; set; }
      public virtual System.Data.Entity.DbSet<global::ModelEFCore.poItem> poItems { get; set; }
      public virtual System.Data.Entity.DbSet<global::ModelEFCore.vendor> vendors { get; set; }
      #endregion DbSets

      #region Constructors

      partial void CustomInit();

      #warning Default constructor not generated for EFModel1 since no default connection string was specified in the model

      /// <inheritdoc />
      public EFModel1(string connectionString) : base(connectionString)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<EFModel1>(new EFModel1DatabaseInitializer());
         CustomInit();
      }

      /// <inheritdoc />
      public EFModel1(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<EFModel1>(new EFModel1DatabaseInitializer());
         CustomInit();
      }

      /// <inheritdoc />
      public EFModel1(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<EFModel1>(new EFModel1DatabaseInitializer());
         CustomInit();
      }

      /// <inheritdoc />
      public EFModel1(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<EFModel1>(new EFModel1DatabaseInitializer());
         CustomInit();
      }

      /// <inheritdoc />
      public EFModel1(System.Data.Entity.Infrastructure.DbCompiledModel model) : base(model)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<EFModel1>(new EFModel1DatabaseInitializer());
         CustomInit();
      }

      /// <inheritdoc />
      public EFModel1(System.Data.Entity.Core.Objects.ObjectContext objectContext, bool dbContextOwnsObjectContext) : base(objectContext, dbContextOwnsObjectContext)
      {
         Configuration.LazyLoadingEnabled = true;
         Configuration.ProxyCreationEnabled = true;
         System.Data.Entity.Database.SetInitializer<EFModel1>(new EFModel1DatabaseInitializer());
         CustomInit();
      }

      #endregion Constructors

      partial void OnModelCreatingImpl(System.Data.Entity.DbModelBuilder modelBuilder);
      partial void OnModelCreatedImpl(System.Data.Entity.DbModelBuilder modelBuilder);

      /// <inheritdoc />
      protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
      {
         base.OnModelCreating(modelBuilder);
         OnModelCreatingImpl(modelBuilder);

         modelBuilder.HasDefaultSchema("dbo");

         modelBuilder.Entity<global::ModelEFCore.po>()
                     .ToTable("poes")
                     .HasKey(t => t.Id);
         modelBuilder.Entity<global::ModelEFCore.po>()
                     .Property(t => t.Id)
                     .IsRequired()
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
         modelBuilder.Entity<global::ModelEFCore.po>()
                     .HasOptional(x => x.poVendor)
                     .WithMany()
                     .Map(x => x.MapKey("poVendor_Id"));

         modelBuilder.Entity<global::ModelEFCore.poItem>()
                     .ToTable("poItems")
                     .HasKey(t => t.Id);
         modelBuilder.Entity<global::ModelEFCore.poItem>()
                     .Property(t => t.Id)
                     .IsRequired()
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
         modelBuilder.Entity<global::ModelEFCore.poItem>()
                     .HasRequired(x => x.po)
                     .WithMany(x => x.poItems)
                     .Map(x => x.MapKey("po_Id"));

         modelBuilder.Entity<global::ModelEFCore.vendor>()
                     .ToTable("vendors")
                     .HasKey(t => t.Id);
         modelBuilder.Entity<global::ModelEFCore.vendor>()
                     .Property(t => t.Id)
                     .IsRequired()
                     .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

         OnModelCreatedImpl(modelBuilder);
      }
   }
}
