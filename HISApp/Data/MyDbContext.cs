using HISApp.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace HISApp.Data
{
    public class MyDbContext : IdentityDbContext<User>
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        // Your DbSets for other entities
        public DbSet<Address> Addresses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<HospitalVisit> MedicalRecords { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<VitalSigns> VitalSigns { get; set; }

        public DbSet<Diagnosis> Diagnosis { get; set; }
        public DbSet<SickLeave> SickLeaves { get; set; }
        public DbSet<DrugOrders> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Address>()
                .HasOne(a => a.User)
                .WithOne(u => u.Address)
                .HasForeignKey<Address>(a => a.UserId);

            //builder.Entity<IdentityRole>().ToTable("Role"); // Rename AspNetRoles to Role
            //builder.Entity<IdentityUser>().ToTable("User"); // Rename AspNetUsers to User
            //builder.Entity<IdentityUserRole<string>>().ToTable("UserRole"); // Rename AspNetUserRoles to UserRole
            //builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaim"); // Rename AspNetUserClaims to UserClaim
            //builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogin"); // Rename AspNetUserLogins to UserLogin
            //builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaim"); // Rename AspNetRoleClaims to RoleClaim
            //builder.Entity<IdentityUserToken<string>>().ToTable("UserToken"); // Rename AspNetUserTokens to UserToken

            // Seed Cities
            builder.Entity<City>().HasData(
                new City { Id = 1, Name = "Amman" },
                new City { Id = 2, Name = "Irbid" },
                new City { Id = 3, Name = "Aqaba" },
                new City { Id = 4, Name = "Zarqa" },
                new City { Id = 5, Name = "Madaba" },
                new City { Id = 6, Name = "Salt" },
                new City { Id = 7, Name = "Mafraq" },
                new City { Id = 8, Name = "Tafilah" },
                new City { Id = 9, Name = "Karak" },
                new City { Id = 10, Name = "Jerash" }
            );

            // Seed Areas
            builder.Entity<Area>().HasData(
                // Amman
                new Area { Id = 1, Name = "Jabal Amman", CityId = 1 },
                new Area { Id = 2, Name = "Sweifieh", CityId = 1 },
                new Area { Id = 3, Name = "Dabouq", CityId = 1 },
                new Area { Id = 4, Name = "Al-Abdali", CityId = 1 },
                // Irbid
                new Area { Id = 5, Name = "Al-Hassan Industrial Estate", CityId = 2 },
                new Area { Id = 6, Name = "University District", CityId = 2 },
                new Area { Id = 7, Name = "Al-Sarih", CityId = 2 },
                // Aqaba
                new Area { Id = 8, Name = "North Beach", CityId = 3 },
                new Area { Id = 9, Name = "South Port", CityId = 3 },
                new Area { Id = 10, Name = "Ayla Oasis", CityId = 3 },
                // Zarqa
                new Area { Id = 11, Name = "New Zarqa", CityId = 4 },
                new Area { Id = 12, Name = "Al-Ghabawi", CityId = 4 },
                // Madaba
                new Area { Id = 13, Name = "Mount Nebo", CityId = 5 },
                new Area { Id = 14, Name = "Al-Rumaytha", CityId = 5 },
                // Other Cities
                new Area { Id = 15, Name = "Wadi Al-Seer", CityId = 6 },
                new Area { Id = 16, Name = "North Mafraq", CityId = 7 },
                new Area { Id = 17, Name = "Dana Reserve", CityId = 8 },
                new Area { Id = 18, Name = "Shihan", CityId = 9 },
                new Area { Id = 19, Name = "Souf", CityId = 10 }
            );

            // Seed Departments
            builder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Cardiology" },
                new Department { Id = 2, Name = "Neurology" },
                new Department { Id = 3, Name = "Pharmacy" },
                new Department { Id = 4, Name = "Oncology" },
                new Department { Id = 5, Name = "Pediatrics" },
                new Department { Id = 6, Name = "Radiology" },
                new Department { Id = 7, Name = "Surgery" },
                new Department { Id = 8, Name = "Emergency Medicine" },
                new Department { Id = 9, Name = "Dermatology" },
                new Department { Id = 10, Name = "Gastroenterology" }
            );


            builder.Entity<IdentityRole>().HasData(
                new IdentityRole
                {
                    Id = "1",
                    Name = "Doctor",
                    NormalizedName = "DOCTOR".ToUpper()
                },
                new IdentityRole
                {
                    Id = "2",
                    Name = "Nurse",
                    NormalizedName = "NURSE".ToUpper()
                },
                new IdentityRole
                {
                    Id = "3",
                    Name = "ManagementStaff",
                    NormalizedName = "MANAGEMENTSTAFF".ToUpper()
                },
                new IdentityRole
                {
                    Id = "4",
                    Name = "Pharmacist",
                    NormalizedName = "PHARMACIST".ToUpper()
                }
               
            );
        }

    
}
}