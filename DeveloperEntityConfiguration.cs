using CreateDatabaseFromModel_CodeFirstApproach.DataLayer.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CreateDatabaseFromModel_CodeFirstApproach.DataLayer
{
    public class DeveloperEntityConfiguration
        : IEntityTypeConfiguration<Developer>
    {

        public void Configure(EntityTypeBuilder<Developer> developerConfiguration)
        {
            developerConfiguration.Property(b => b.DeveloperId)
                .UseIdentityColumn();

            developerConfiguration.Ignore(b => b.Skills);

            developerConfiguration.Property(b => b.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            developerConfiguration.HasOne(o => o.Country)
              .WithMany()
              .IsRequired(true)
              .HasForeignKey("CountryId");

        }
    }
}
