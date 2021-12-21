using DataAccessLayer.Mapping;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.EntityFramework.Contexts
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-STRIXV5; database=CoreBlog; integrated security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MessageMap());

            //modelBuilder.Entity<Message>()
            //       .HasOne(x => x.SenderUser)
            //       .WithMany(x => x.SenderMessage)
            //       .HasForeignKey(x => x.SenderId)
            //       .OnDelete(DeleteBehavior.ClientSetNull);

            //modelBuilder.Entity<Message>()
            //       .HasOne(x => x.ReceiverUser)
            //       .WithMany(x => x.ReceiverMessage)
            //       .HasForeignKey(x => x.ReceiverId)
            //       .OnDelete(DeleteBehavior.ClientSetNull);
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogRayting> BlogRaytings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Newsletter> Newsletters { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Writer> Writers { get; set; }
    }
}
