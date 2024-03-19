using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings;

public class CategoryMap : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.HasData( new Category {
                Id = Guid.Parse("77ebf623-09be-411f-9165-04dc3ba68d94"),
                Name = "dotnet core",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.UtcNow,
                isDeleted = false
            },
            new Category {
                Id = Guid.Parse("19f32511-de5a-4234-99a5-503417225df4"),
                Name = "visual studip core",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.UtcNow,
                isDeleted = false
            }
            );
    }
}
