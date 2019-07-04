using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccessDetect.Models
{
    public class AccessMap
    {
        public AccessMap(EntityTypeBuilder<Access> entityBuilder)
        {
            entityBuilder.HasKey(t => t.Id);
            entityBuilder.Property(t => t.Ip).IsRequired();
            entityBuilder.Property(t => t.AccessTime).IsRequired();
        }
    }
}

