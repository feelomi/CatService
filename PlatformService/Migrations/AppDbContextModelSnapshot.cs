using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlatformService.Data;

namespace PlatformService.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PlatformService.Models.Platform", b =>
                {
                     b.Property<int>("Id")
                         .ValueGeneratedOnAdd()
                         .HasColumnType("int")
                         .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                     b.Property<string>("Breed")
                         .IsRequired()
                         .HasColumnType("nvarchar(max)");

                     b.Property<string>("Age")
                     .IsRequired()
                     .HasColumnType("int)");

                     b.Property<string>("CatName")
                         .IsRequired()
                         .HasColumnType("nvarchar(max)");

                     b.Property<string>("Description")
                         .IsRequired()
                         .HasColumnType("nvarchar(max)");

                     b.HasKey("Id");

                     b.ToTable("Platforms");
                 });
#pragma warning restore 612, 618
            }
    }
}