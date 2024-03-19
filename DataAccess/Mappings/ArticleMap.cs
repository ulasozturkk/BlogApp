using Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mappings;

public class ArticleMap : IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        builder.HasData(new Article {
            Id = Guid.NewGuid(),
            Title = "dotnet Deneme makalesi 1",
            Content = "lorem ipsum sdfngjksdfgmdfjsgnsdfglsdfngsdflşkgnsdlfkgnklsdifngşlksdfnglkşsdfngsşdlfkgnskldfgşsldfgsfgsdfgsdfg",
            ViewCount = 15,
            CategoryId = Guid.Parse("77ebf623-09be-411f-9165-04dc3ba68d94"),
            ImageId = Guid.Parse("bd316f53-95cb-48c9-931b-528d141e4e8e"),
            CreatedBy = "Admin Test",
            CreatedDate = DateTime.UtcNow,
            isDeleted = false
        });
        new Article {
            Id = Guid.NewGuid(),
            Title = "Visual studio Deneme makalesi 1",
            Content = "Visual Studio lorem ipsum sdfngjksdfgmdfjsgnsdfglsdfngsdflşkgnsdlfkgnklsdifngşlksdfnglkşsdfngsşdlfkgnskldfgşsldfgsfgsdfgsdfg",
            ViewCount = 15,
            CategoryId = Guid.Parse("19f32511-de5a-4234-99a5-503417225df4"),
            ImageId = Guid.Parse("14b15696-c3b9-4f50-b42e-64455b8ef0dc"),
            CreatedBy = "Admin Test",
            CreatedDate = DateTime.UtcNow,
            isDeleted = false
        };


    }
}
