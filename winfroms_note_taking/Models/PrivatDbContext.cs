using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace winfroms_note_taking.Models;

public partial class PrivatDbContext : DbContext
{
    public PrivatDbContext()
    {
    }

    public PrivatDbContext(DbContextOptions<PrivatDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Note> Notes { get; set; }

    public virtual DbSet<NoteTag> NoteTags { get; set; }

    public virtual DbSet<Tag> Tags { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=privat1.database.windows.net;Initial Catalog=privat-db;User ID=gyurina_bercel;Password=MakkaMikka2004");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Note>(entity =>
        {
            entity.HasKey(e => e.NoteId).HasName("PK__Notes__EACE357FDE28DD49");

            entity.Property(e => e.NoteId).HasColumnName("NoteID");
            entity.Property(e => e.CreatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.UpdatedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.User).WithMany(p => p.Notes)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__Notes__UserID__5FB337D6");
        });

        modelBuilder.Entity<NoteTag>(entity =>
        {
            entity.HasKey(e => e.NoteTagId).HasName("PK__NoteTags__ABF1BDD076FC9C95");

            entity.Property(e => e.NoteTagId).HasColumnName("NoteTagID");
            entity.Property(e => e.NoteId).HasColumnName("NoteID");
            entity.Property(e => e.TagId).HasColumnName("TagID");

            entity.HasOne(d => d.Note).WithMany(p => p.NoteTags)
                .HasForeignKey(d => d.NoteId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__NoteTags__NoteID__6754599E");

            entity.HasOne(d => d.Tag).WithMany(p => p.NoteTags)
                .HasForeignKey(d => d.TagId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__NoteTags__TagID__68487DD7");
        });

        modelBuilder.Entity<Tag>(entity =>
        {
            entity.HasKey(e => e.TagId).HasName("PK__Tags__657CFA4CEF787E7C");

            entity.HasIndex(e => e.TagName, "UQ__Tags__BDE0FD1DA938642D").IsUnique();

            entity.Property(e => e.TagId).HasColumnName("TagID");
            entity.Property(e => e.TagName).HasMaxLength(50);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCACA77F6CEC");

            entity.HasIndex(e => e.Username, "UQ__Users__536C85E46AF9EE51").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Password).HasMaxLength(255);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
