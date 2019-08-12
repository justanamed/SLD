using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace khaosat_LDTB_HP.Models
{
    public partial class sldDbContext : DbContext
    {
        public sldDbContext()
        {
        }

        public sldDbContext(DbContextOptions<sldDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bieu01> Bieu01 { get; set; }
        public virtual DbSet<Bieu02> Bieu02 { get; set; }
        public virtual DbSet<Bieu03> Bieu03 { get; set; }
        public virtual DbSet<DmBieutonghop> DmBieutonghop { get; set; }
        public virtual DbSet<DmChuyendichuyenden> DmChuyendichuyenden { get; set; }
        public virtual DbSet<DmChuyenmonkithuat> DmChuyenmonkithuat { get; set; }
        public virtual DbSet<DmCongviecdanglam> DmCongviecdanglam { get; set; }
        public virtual DbSet<DmDanToc> DmDanToc { get; set; }
        public virtual DbSet<DmGioitinh> DmGioitinh { get; set; }
        public virtual DbSet<DmLamconganluong> DmLamconganluong { get; set; }
        public virtual DbSet<DmLinhVucDaoTao> DmLinhVucDaoTao { get; set; }
        public virtual DbSet<DmLoaiThatnghiep> DmLoaiThatnghiep { get; set; }
        public virtual DbSet<DmLoaihinhkinhte> DmLoaihinhkinhte { get; set; }
        public virtual DbSet<DmNganhnghekinhdoanh> DmNganhnghekinhdoanh { get; set; }
        public virtual DbSet<DmNguyennhanKhdkt> DmNguyennhanKhdkt { get; set; }
        public virtual DbSet<DmQuanhechuho> DmQuanhechuho { get; set; }
        public virtual DbSet<DmTrinhdoGdpt> DmTrinhdoGdpt { get; set; }

        // Unable to generate entity type for table 'TableCity_2009'. Please see the warning messages.
        // Unable to generate entity type for table 'TableCity_2010'. Please see the warning messages.
        // Unable to generate entity type for table 'TableCity_2011'. Please see the warning messages.
        // Unable to generate entity type for table 'TableCity_2012'. Please see the warning messages.
        // Unable to generate entity type for table 'TableCity_2013'. Please see the warning messages.
        // Unable to generate entity type for table 'TableCity_2014'. Please see the warning messages.
        // Unable to generate entity type for table 'TableCity_2015'. Please see the warning messages.
        // Unable to generate entity type for table 'TableCity_2016'. Please see the warning messages.
        // Unable to generate entity type for table 'TableCity_2017'. Please see the warning messages.
        // Unable to generate entity type for table 'TableCity_2018'. Please see the warning messages.
        // Unable to generate entity type for table 'TableCity_2019'. Please see the warning messages.
        // Unable to generate entity type for table 'TableCity_2020'. Please see the warning messages.
        // Unable to generate entity type for table 'tbl_thongtincauhinh'. Please see the warning messages.
        // Unable to generate entity type for table 'Tonghop_Covieclam_theotrinhdoCMKT'. Please see the warning messages.
        // Unable to generate entity type for table 'Tonghop_Covieclam_theotrinhdohocvan'. Please see the warning messages.
        // Unable to generate entity type for table 'Tonghop_KhongthamgiaHDKT'. Please see the warning messages.
        // Unable to generate entity type for table 'Tonghop_Thatnghiep_theotrinhdoCMKT'. Please see the warning messages.
        // Unable to generate entity type for table 'Tonghop_Thatnghiep_theotrinhdohocvan'. Please see the warning messages.
        // Unable to generate entity type for table 'Tonghop_tren15tuoi_theotrinhdoCMKT'. Please see the warning messages.
        // Unable to generate entity type for table 'Tonghop_tren15tuoi_theotrinhdohocvan'. Please see the warning messages.
        // Unable to generate entity type for table 'tbl_Hogiadinh_2018'. Please see the warning messages.
        // Unable to generate entity type for table 'tbl_Thanhvien_2018'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("Datasource=C:\\sldDb.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Bieu01>(entity =>
            {
                entity.ToTable("Bieu_01");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ngaytonghop).HasColumnType("Datetime");
            });

            modelBuilder.Entity<Bieu02>(entity =>
            {
                entity.ToTable("Bieu_02");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ngaytonghop).HasColumnType("Datetime");
            });

            modelBuilder.Entity<Bieu03>(entity =>
            {
                entity.ToTable("Bieu_03");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ngaytonghop).HasColumnType("Datetime");
            });

            modelBuilder.Entity<DmBieutonghop>(entity =>
            {
                entity.ToTable("DM_BIEUTONGHOP");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Ngaytonghop).HasColumnType("Datetime");
            });

            modelBuilder.Entity<DmChuyendichuyenden>(entity =>
            {
                entity.ToTable("DM_Chuyendichuyenden");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Status).HasColumnType("BOOLEAN");
            });

            modelBuilder.Entity<DmChuyenmonkithuat>(entity =>
            {
                entity.ToTable("DM_Chuyenmonkithuat");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Status).HasColumnType("BOOLEAN");
            });

            modelBuilder.Entity<DmCongviecdanglam>(entity =>
            {
                entity.ToTable("DM_Congviecdanglam");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Status).HasColumnType("BOOLEAN");
            });

            modelBuilder.Entity<DmDanToc>(entity =>
            {
                entity.ToTable("DM_DanToc");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Status).HasColumnType("BOOLEAN");
            });

            modelBuilder.Entity<DmGioitinh>(entity =>
            {
                entity.ToTable("DM_Gioitinh");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Status).HasColumnType("BOOLEAN");
            });

            modelBuilder.Entity<DmLamconganluong>(entity =>
            {
                entity.ToTable("DM_Lamconganluong");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Status).HasColumnType("BOOLEAN");
            });

            modelBuilder.Entity<DmLinhVucDaoTao>(entity =>
            {
                entity.ToTable("DM_LinhVucDaoTao");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Status).HasColumnType("BOOLEAN");
            });

            modelBuilder.Entity<DmLoaiThatnghiep>(entity =>
            {
                entity.ToTable("DM_LoaiThatnghiep");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Status).HasColumnType("BOOLEAN");
            });

            modelBuilder.Entity<DmLoaihinhkinhte>(entity =>
            {
                entity.ToTable("DM_Loaihinhkinhte");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Status).HasColumnType("BOOLEAN");
            });

            modelBuilder.Entity<DmNganhnghekinhdoanh>(entity =>
            {
                entity.ToTable("DM_Nganhnghekinhdoanh");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Status).HasColumnType("BOOLEAN");
            });

            modelBuilder.Entity<DmNguyennhanKhdkt>(entity =>
            {
                entity.ToTable("DM_NguyennhanKHDKT");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Status).HasColumnType("BOOLEAN");
            });

            modelBuilder.Entity<DmQuanhechuho>(entity =>
            {
                entity.ToTable("DM_Quanhechuho");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Status).HasColumnType("BOOLEAN");
            });

            modelBuilder.Entity<DmTrinhdoGdpt>(entity =>
            {
                entity.ToTable("DM_TrinhdoGDPT");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Status).HasColumnType("BOOLEAN");
            });
        }
    }
}
