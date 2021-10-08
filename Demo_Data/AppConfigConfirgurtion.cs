using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Data
{
    public class AppConfigConfirgurtion : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            builder.ToTable("App_Config_VinhNQ");
            builder.HasKey(x => new { x.id });
            builder.Property(x => x.id).UseIdentityColumn(1,2);
        }
    }
}
