using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API.Backend.Models;

public partial class EmployeeContext : DbContext
{
    public EmployeeContext()
    {
    }

    public EmployeeContext(DbContextOptions<EmployeeContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EmployeeLeave> EmployeeLeaves { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Employee;Trusted_Connection=True; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeeLeave>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PK__Employee__AFB3EC0DC9F2FEA1");

            entity.ToTable("EmployeeLeave");

            entity.Property(e => e.EmpId).HasColumnName("empId");
            entity.Property(e => e.FirstName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("lastName");
            entity.Property(e => e.LeaveEnd)
                .HasColumnType("datetime")
                .HasColumnName("leaveEnd");
            entity.Property(e => e.LeaveStart)
                .HasColumnType("datetime")
                .HasColumnName("leaveStart");
            entity.Property(e => e.TotalLeavesLeft).HasColumnName("totalLeavesLeft");
            entity.Property(e => e.TotalLeavesTaken).HasColumnName("totalLeavesTaken");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
