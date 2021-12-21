using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Mapping
{
    public class MessageMap : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(x => x.MessageId);
            builder.Property(x => x.MessageId).UseIdentityColumn();
            builder.Property(x => x.MessageId).ValueGeneratedOnAdd();

            builder.HasOne(x => x.SenderUser)
                   .WithMany(x => x.SenderMessage)
                   .HasForeignKey(x => x.SenderId)
                   .OnDelete(DeleteBehavior.ClientSetNull);


            builder.HasOne(x => x.ReceiverUser)
                   .WithMany(x => x.ReceiverMessage)
                   .HasForeignKey(x => x.ReceiverId)
                   .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
