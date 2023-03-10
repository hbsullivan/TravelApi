// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelApi.Models;

#nullable disable

namespace TravelApi.Migrations
{
    [DbContext(typeof(TravelApiContext))]
    partial class TravelApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelApi.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .HasColumnType("longtext");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<int>("DescriptionCount")
                        .HasColumnType("int");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            ReviewId = 1,
                            City = "Cabo San Lucas",
                            Country = "Mexico",
                            Description = "Great for spring break or empty nesters!",
                            DescriptionCount = 0,
                            Rating = 5
                        },
                        new
                        {
                            ReviewId = 2,
                            City = "Busan",
                            Country = "South Korea",
                            Description = "City meets country! Great hiking, beach views, all with the convenience of big city public transit.",
                            DescriptionCount = 0,
                            Rating = 5
                        },
                        new
                        {
                            ReviewId = 3,
                            City = "Barcelona",
                            Country = "Spain",
                            Description = "Delicious food!",
                            DescriptionCount = 0,
                            Rating = 5
                        },
                        new
                        {
                            ReviewId = 4,
                            City = "Cairns",
                            Country = "Australia",
                            Description = "Beautiful rainforest, but very hot!",
                            DescriptionCount = 0,
                            Rating = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
