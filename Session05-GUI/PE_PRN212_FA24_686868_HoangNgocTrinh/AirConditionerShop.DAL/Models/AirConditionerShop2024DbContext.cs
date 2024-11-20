using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace AirConditionerShop.DAL.Models;

public partial class AirConditionerShop2024DbContext : DbContext
{
    public AirConditionerShop2024DbContext()
    {
    }

    public AirConditionerShop2024DbContext(DbContextOptions<AirConditionerShop2024DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AirConditioner> AirConditioners { get; set; }

    public virtual DbSet<StaffMember> StaffMembers { get; set; }

    public virtual DbSet<SupplierCompany> SupplierCompanies { get; set; }

    //chuỗi kết nối csdl - connection string phải đc di dời qua tập tin lẻ bên ngoài để đảm bảo tính bảo mật của thông tin server
    //thường cất trong 1 tập tin json tên là appsettings.json
    //ta cần làm những việc sau:
    //1. tạo file json, move connection string qua file đó
    //2. viết hàm để đọc chuỗi này
    //3. truyền chuỗi vào hàm
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(GetConnectionString());

    private string GetConnectionString()

    {

        IConfiguration config = new ConfigurationBuilder()

        .SetBasePath(Directory.GetCurrentDirectory())

        .AddJsonFile("appsettings.json", true, true)

        .Build();

        var strConn = config["ConnectionStrings:DefaultConnectionStringDB"];


        return strConn;

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AirConditioner>(entity =>
        {
            entity.HasKey(e => e.AirConditionerId).HasName("PK__AirCondi__EE2EB739E133E64F");

            entity.ToTable("AirConditioner");

            entity.Property(e => e.AirConditionerId).ValueGeneratedNever();
            entity.Property(e => e.AirConditionerName).HasMaxLength(200);
            entity.Property(e => e.FeatureFunction).HasMaxLength(250);
            entity.Property(e => e.SoundPressureLevel).HasMaxLength(80);
            entity.Property(e => e.SupplierId).HasMaxLength(20);
            entity.Property(e => e.Warranty).HasMaxLength(60);

            entity.HasOne(d => d.Supplier).WithMany(p => p.AirConditioners)
                .HasForeignKey(d => d.SupplierId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__AirCondit__Suppl__3C69FB99");
        });

        modelBuilder.Entity<StaffMember>(entity =>
        {
            entity.HasKey(e => e.MemberId).HasName("PK__StaffMem__0CF04B384CE1A425");

            entity.ToTable("StaffMember");

            entity.HasIndex(e => e.EmailAddress, "UQ__StaffMem__49A14740C0FE0C59").IsUnique();

            entity.Property(e => e.MemberId)
                .ValueGeneratedNever()
                .HasColumnName("MemberID");
            entity.Property(e => e.EmailAddress).HasMaxLength(60);
            entity.Property(e => e.FullName).HasMaxLength(60);
            entity.Property(e => e.Password).HasMaxLength(40);
        });

        modelBuilder.Entity<SupplierCompany>(entity =>
        {
            entity.HasKey(e => e.SupplierId).HasName("PK__Supplier__4BE666B4174E98D0");

            entity.ToTable("SupplierCompany");

            entity.Property(e => e.SupplierId).HasMaxLength(20);
            entity.Property(e => e.PlaceOfOrigin).HasMaxLength(60);
            entity.Property(e => e.SupplierDescription).HasMaxLength(250);
            entity.Property(e => e.SupplierName).HasMaxLength(80);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
