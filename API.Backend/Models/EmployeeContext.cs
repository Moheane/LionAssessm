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
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=Employee;Trusted_Connection=True; Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EmployeeLeave>(entity =>
        {
            entity.HasKey(e => e.EmpId).HasName("PK__Employee__AFB3EC0D99EE0F82");

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
            entity.Property(e => e.Reason)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("reason");
            entity.Property(e => e.TotalLeavesLeft).HasColumnName("totalLeavesLeft");
            entity.Property(e => e.TotalLeavesTaken).HasColumnName("totalLeavesTaken");
            entity.Property(e => e.TypeofLeave)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("typeofLeave");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
