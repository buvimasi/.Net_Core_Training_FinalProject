using FinalProjectAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinalProjectAPI.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SkillMap>().HasKey(sc => new { sc.EmployeeId, sc.SkillId });

            modelBuilder.Entity<SkillMap>()
                .HasOne<Employees>(sc => sc.Employees)
                .WithMany(s => s.SkillMaps)
                .HasForeignKey(sc => sc.EmployeeId);


            modelBuilder.Entity<SkillMap>()
                .HasOne<Skills>(sc => sc.Skills)
                .WithMany(s => s.SkillMaps)
                .HasForeignKey(sc => sc.SkillId);

            //Employees has one to many relationship with SoftLock
            modelBuilder.Entity<SoftLock>()
               .HasOne(bc => bc.Employees)
               .WithMany(b => b.SoftLocks)
               .HasForeignKey(bc => bc.EmployeeId);

            modelBuilder.Entity<Employees>().HasData(
                new Employees
                {
                    EmployeeID=1,
                    Name = "Buvaneshwari",
                    Status = "Active",
                    Manager = "Karthik",
                    Wfm_Manager = "Arun",
                    Email = "buvimasi@gmail.com",
                    LockStatus = "not_requested",
                    Experience = 2,
                    ProfileId = 1

                },
                new Employees
                {
                    EmployeeID = 2,
                    Name = "Karthikeyan",
                    Status = "Active",
                    Manager = "Karthik",
                    Wfm_Manager = "Arun",
                    Email = "karthikeyan@gmail.com",
                    LockStatus = "requested",
                    Experience = 2,
                    ProfileId = 1

                },
                new Employees
                {
                    EmployeeID = 3,
                    Name = "Arunkumar",
                    Status = "Active",
                    Manager = "Karthik",
                    Wfm_Manager = "Guna",
                    Email = "arun@gmail.com",
                    LockStatus = "not_requested",
                    Experience = 2,
                    ProfileId = 1

                },
                new Employees
                {
                    EmployeeID = 4,
                    Name = "Rekha",
                    Status = "Active",
                    Manager = "Karthik",
                    Wfm_Manager = "Arun",
                    Email = "buvimasi@gmail.com",
                    LockStatus = "not_requested",
                    Experience = 2,
                    ProfileId = 1
                }

                );
            modelBuilder.Entity<Skills>().HasData(

                new Skills
                {
                    Id = 1, 
                    Name = "C#/.Net"
                },
                      new Skills
                      {
                          Id= 2,
                          Name = "Java"
                      },
                            new Skills
                            {
                                Id=3,
                                Name = "Azure"
                            },
                                  new Skills
                                  {
                                      Id=4,
                                      Name = "React"
                                  });


        }

        public DbSet<Employees> Employees { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<SkillMap> SkillMaps { get; set; }
        public DbSet<SoftLock> SoftLocks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
