using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings;

public class ImageMap : IEntityTypeConfiguration<Image>
{
    public void Configure(EntityTypeBuilder<Image> builder)
    {
        builder.HasData(
            new Image {
                Id = Guid.Parse("bd316f53-95cb-48c9-931b-528d141e4e8e"),
                FileName = "images/testimage",
                FileType = "jpg",
                CreatedBy = "Admin test",
                CreatedDate = DateTime.UtcNow,
                isDeleted = false,
            },
            new Image {
                Id = Guid.Parse("14b15696-c3b9-4f50-b42e-64455b8ef0dc"),
                FileName = "images/vstest",
                FileType = "jpg",
                CreatedBy = "Admin test",
                CreatedDate = DateTime.UtcNow,
                isDeleted = false,
            }

        );
    }
}
