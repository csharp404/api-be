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
        public DbSet<EmergencyCode> Codes{ get; set; }
        public DbSet<Emergencies> Emergencies { get; set; }
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

            builder.Entity<City>().HasData(
      new City { Id = 1, Name = "Amman" },
      new City { Id = 2, Name = "Irbid" },
      new City { Id = 3, Name = "Aqaba" },
      new City { Id = 4, Name = "Zarqa" },
      new City { Id = 5, Name = "Madaba" },
      new City { Id = 6, Name = "Albalqa" },
      new City { Id = 7, Name = "Mafraq" },
      new City { Id = 8, Name = "Tafilah" },
      new City { Id = 9, Name = "Karak" },
      new City { Id = 10, Name = "Jerash" },
      new City { Id = 11, Name = "Ma'an" },
      new City { Id = 12, Name = "Ajloun" }



  );

            // Seed Areas
            builder.Entity<Area>().HasData(
      // Amman
      new Area { Id = 1, Name = "Abdoun", CityId = 1 },
      new Area { Id = 2, Name = "Jabal Al-Weibdeh", CityId = 1 },
      new Area { Id = 3, Name = "Sweifieh", CityId = 1 },
      new Area { Id = 4, Name = "Dabouq", CityId = 1 },

      // Irbid
      new Area { Id = 5, Name = "Al-Husn", CityId = 2 },
      new Area { Id = 6, Name = "Al-Ramtha", CityId = 2 },
      new Area { Id = 7, Name = "Downtown", CityId = 2 },
      new Area { Id = 8, Name = "Bani Kinana", CityId = 2 },

      // Aqaba
      new Area { Id = 9, Name = "Aqaba City Center", CityId = 3 },
      new Area { Id = 10, Name = "Industrial Zone", CityId = 3 },
      new Area { Id = 11, Name = "Southern Beach", CityId = 3 },
      new Area { Id = 12, Name = "Wadi Rum", CityId = 3 },

      // Zarqa
      new Area { Id = 13, Name = "New Zarqa", CityId = 4 },
      new Area { Id = 14, Name = "Al-Ruseifa", CityId = 4 },
      new Area { Id = 15, Name = "Al-Dhuleil", CityId = 4 },
      new Area { Id = 16, Name = "Hashemiyah", CityId = 4 },

      // Madaba
      new Area { Id = 17, Name = "Madaba Center", CityId = 5 },
      new Area { Id = 18, Name = "Mount Nebo", CityId = 5 },
      new Area { Id = 19, Name = "Al-Faisaliah", CityId = 5 },
      new Area { Id = 20, Name = "Ma'in", CityId = 5 },

      // Albalqa
      new Area { Id = 21, Name = "Salt City Center", CityId = 6 },
      new Area { Id = 22, Name = "Fuheis", CityId = 6 },
      new Area { Id = 23, Name = "Ain Al-Basha", CityId = 6 },
      new Area { Id = 24, Name = "Mahes", CityId = 6 },

      // Mafraq
      new Area { Id = 25, Name = "Mafraq City Center", CityId = 7 },
      new Area { Id = 26, Name = "Al-Khalidiya", CityId = 7 },
      new Area { Id = 27, Name = "Ruwaished", CityId = 7 },
      new Area { Id = 28, Name = "Um Al-Jimal", CityId = 7 },

      // Tafilah
      new Area { Id = 29, Name = "Tafilah City Center", CityId = 8 },
      new Area { Id = 30, Name = "Busaira", CityId = 8 },
      new Area { Id = 31, Name = "Al-Hasa", CityId = 8 },
      new Area { Id = 32, Name = "Dana", CityId = 8 },

      // Karak
      new Area { Id = 33, Name = "Karak City Center", CityId = 9 },
      new Area { Id = 34, Name = "Al-Qasr", CityId = 9 },
      new Area { Id = 35, Name = "Mu'tah", CityId = 9 },
      new Area { Id = 36, Name = "Al-Mazar", CityId = 9 },

      // Jerash
      new Area { Id = 37, Name = "Jerash City Center", CityId = 10 },
      new Area { Id = 38, Name = "Souf", CityId = 10 },
      new Area { Id = 39, Name = "Sakib", CityId = 10 },
      new Area { Id = 40, Name = "Al-Kitta", CityId = 10 },

      // Ma'an
      new Area { Id = 41, Name = "Ma'an City Center", CityId = 11 },
      new Area { Id = 42, Name = "Petra", CityId = 11 },
      new Area { Id = 43, Name = "Shobak", CityId = 11 },
      new Area { Id = 44, Name = "Al-Husseinieh", CityId = 11 },

      // Ajloun
      new Area { Id = 45, Name = "Ajloun City Center", CityId = 12 },
      new Area { Id = 46, Name = "Anjara", CityId = 12 },
      new Area { Id = 47, Name = "Al-Wahadneh", CityId = 12 },
      new Area { Id = 48, Name = "Kufranjah", CityId = 12 }
  );

            // Seed Departments
            builder.Entity<Department>().HasData(
                new Department { Id = 1, Name = "Cardiology" },
                new Department { Id = 2, Name = "Neurology" },
                new Department { Id = 3, Name = "Oncology" },
                new Department { Id = 4, Name = "Pediatrics" },
                new Department { Id = 5, Name = "Radiology" },
                new Department { Id = 6, Name = "Surgery" },
                new Department { Id = 7, Name = "Dermatology" },
                new Department { Id = 8, Name = "Pharmacy" },
                new Department { Id = 9, Name = "Management" }
            );

            builder.Entity<Patient>()
                .HasOne(p => p.Area)
                .WithMany()
                .HasForeignKey(p => p.AreaId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Patient>()
                .HasOne(p => p.City)
                .WithMany()
                .HasForeignKey(p => p.CityId)
                .OnDelete(DeleteBehavior.Restrict);


            builder.Entity<Patient>()
                .HasOne(p => p.Department)
                .WithMany()
                .HasForeignKey(p => p.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);
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
                },new IdentityRole
                {
                    Id = "5",
                    Name = "Admin",
                    NormalizedName = "ADMIN".ToUpper()
                }
               
            );
            builder.Entity<EmergencyCode>().HasData(
                new EmergencyCode()
                {
                    Id = 1,
                    Title = "Medical Emergency",
                    Description = "Represents a critical medical emergency, such as cardiopulmonary arrest, requiring immediate medical intervention.",
                    Color = "#2A7DCE",
                    Code = "Code BLUE"
                },
                new EmergencyCode()
                {
                    Id =2,
                    Title = "Fire",
                    Description = "Indicates a fire emergency, necessitating fire safety protocols and evacuation procedures",
                    Color = "#D94141",
                    Code = "Code RED"
                },
                new EmergencyCode()
                {
                    Id = 3,
                    Title = "Radioactive Accident",
                    Description = "indicates radioactive contamination or incidents, requiring specialized radiology and safety teams",
                    Color = "#808080",
                    Code = "Code GREY"
                },
                new EmergencyCode()
                {
                    Id = 4,
                    Title = "Chemical or Biological spillage",
                    Description = "Denotes a chemical or biological spill, requiring specialized cleanup and safety measures",
                    Color = "#49B06C",
                    Code = "Code GREEN"
                },
                new EmergencyCode()
                {
                    Id = 5,
                    Title = "Mass casualties",
                    Description = "Refers to mass casualty incidents, involving coordination for large-scale emergency medical response",
                    Color = "#F28C3A",
                    Code = "Code ORANGE"
                }


            );
        }

    
}
}