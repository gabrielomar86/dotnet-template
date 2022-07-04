using GuayaswestSample.core.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GuayaswestSample.infrastructure.data
{
    public class GuayaswestSampleSemilla : IEntityTypeConfiguration<GuayaswestSampleEntity>
    {
        public void Configure(EntityTypeBuilder<GuayaswestSampleEntity> builder)
        {
            builder.HasData(
                new GuayaswestSampleEntity
                {
                    Id = System.Guid.Parse("44ba65f8-ec30-4092-8beb-b952bf0c30df"),

                    Nombre = "mockData1",

                    Descripcion = "mockData1",

                    Valor = 123

                },
                new GuayaswestSampleEntity
                {
                    Id = System.Guid.Parse("ad1100bb-ee24-4444-8289-dfe712891324"),

                    Nombre = "mockData2",

                    Descripcion = "mockData2",

                    Valor = 456

                },
                new GuayaswestSampleEntity
                {
                    Id = System.Guid.Parse("0a696949-c4f3-4397-b330-b978ee48801d"),

                    Nombre = "mockData3",

                    Descripcion = "mockData3",

                    Valor = 678

                }
            );
        }
    }
}