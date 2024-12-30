using System.Runtime.InteropServices.ComTypes;
using HISApp.Data;
using HISApp.Domain;
using HISApp.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HISApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController (MyDbContext context): ControllerBase
    {
        [HttpGet]
        [Route("Departments")]
        //[Authorize(Roles = "Admin,Management Staff")]
        public async Task<IActionResult> GetDapartments()
        {
            var data = await context.Departments.ToListAsync();
            return Ok(data);
        }
        #region Address

        [HttpGet]
        [Route("Cities")]
        //[Authorize(Roles = "Admin,Management Staff")]
        public async Task<IActionResult> GetAllCities()
        {
            var data = await context.Cities.ToListAsync();
            return Ok(data);
        }
        [HttpGet]
        [Route("Areas/{CityId:int}")]
        //[Authorize(Roles = "Admin,Management Staff")]

        public async Task<IActionResult> GetAllAreas(int CityId)
        {
            var data = await context.Areas.Where(x => x.CityId == CityId).ToListAsync();
            return Ok(data);
        }

        #endregion

        #region Prescription
        [HttpGet]
        [Route("Precription")]
        //[Authorize(Roles = "Admin,Doctor,Nurse")]

        public async Task<IActionResult> getPrescription(int id)
        {
            var data =  context.Prescriptions.Include(x=>x.Patient).OrderByDescending(x => x.CreateAt).Where(x=>x.PatientId==id).Select(x=>new prescriptionDTO()
            {
                PatientName = x.Patient.FirstName + " " + x.Patient.LastName,
                Dosage = x.Dosage,
                Instructions =  x.Instructions,
                PatientId = x.PatientId,
                Medication = x.Medication,
                CreatedAt = x.CreateAt
            }).FirstOrDefault();
            
            return Ok(data);
        }
        [HttpGet]
        [Route("AllPrecription")]
        //[Authorize(Roles = "Admin,Doctor,Nurse")]

        public async Task<IActionResult> GetAllPrescription(int id)
        {
            var data = context.Patients.Include(x => x.Prescriptions).FirstOrDefault(x=>x.Id==id);
            var pres = data.Prescriptions.Select(x => new prescriptionDTO()
            {
                Dosage = x.Dosage,
                Instructions = x.Instructions,
                Medication = x.Medication,
                PatientId = x.PatientId,
                PatientName = x.Patient.FirstName + " "+ x.Patient.LastName,
                CreatedAt = x.CreateAt
            });
            return Ok(pres);
        }
        [HttpPost]
        [Route("Create-Precription")]
        //[Authorize(Roles = "Doctor")]

        public async Task<IActionResult> CreatePrescription(prescriptionDTO pres)
        {
            var press = new Prescription()
            {
                Dosage = pres.Dosage,
                Instructions = pres.Instructions,
                Medication = pres.Medication,
                PatientId = pres.PatientId
            };
            context.Prescriptions.Add(press);
           await context.SaveChangesAsync();
           return Ok();
        }


        #endregion

        #region VitalSigns
        [HttpGet]
        [Route("VitalSigns")]
        //[Authorize(Roles = "Admin,Doctor,Nurse")]
        public async Task<IActionResult> getVitalSigns(int id)
        {
            var data = context.Patients.Include(x => x.VitalSigns).First(x=>x.Id==id);
            var vital = data.VitalSigns.Select(x => new VitalSignsDto()
            {
                BloodPressure = x.BloodPressure,
                Breaths = x.Breaths,
                HeartRate = x.HeartRate,
                Temperature = x.Temperature,
                DateRecorded = x.DateRecorded,
               

            }).ToList();
            if (vital is not null)
            {
                vital[0].BreathsAVG = vital.Average(x => x.Breaths);
                vital[0].HeartRateAVG = vital.Average(x => x.HeartRate);
                vital[0].TemperatureAVG = vital.Average(x => x.Temperature);
            }
            return Ok(vital);

        }
        [HttpPost]
        [Route("create-VitalSigns")]
        //[Authorize(Roles = "Nurse")]

        public async Task<IActionResult> CreateVitalSigns(VitalsignDto vital)
        {
            var vitals = new VitalSigns()
            {
                PatientId = vital.PatientId,
                BloodPressure = vital.BloodPressure,
                Breaths = vital.Breaths,
                HeartRate = vital.HeartRate,
                Temperature = vital.Temperature,
                DateRecorded = DateTime.Now
            };
            context.VitalSigns.Add(vitals);
            context.SaveChanges();
            return Ok();
        }


        #endregion



        #region Diagnosis
        [HttpGet]
        [Route("Diagnosis")]
        //[Authorize(Roles = "Admin,Doctor,Nurse,Pharmacist")]

        public async Task<IActionResult> GetDiagnosis(int id)
        {
            var data = context.Patients.Include(x => x.Diagnoses).FirstOrDefault(x => x.Id == id);
            var dia = data.Diagnoses.OrderDescending().FirstOrDefault();
            return Ok(dia);
        }
        [HttpPost]
        [Route("Create-Diagnosis")]
        //[Authorize(Roles = "Doctor")]

        public async Task<IActionResult> Create(Diagnosis dia)
        {
            context.Diagnosis.Add(dia);
            context.SaveChanges();
            return Ok();
        }

        #endregion

        #region SickLeave

        [HttpGet]
        [Route("SickLeave")]
        //[Authorize(Roles = "Management Staff")]

        public async Task<IActionResult> GetSickLeave(int id)
        {
            var data = context.Patients.Include(x => x.Diagnoses).FirstOrDefault(x => x.Id == id);
            var sickleave = data.SickLeaves.OrderDescending().FirstOrDefault();
            return Ok(sickleave);
        }
        [HttpPost]
        [Route("create-SickLeave")]
        //[Authorize(Roles = "Management Staff")]

        public async Task<IActionResult> CreateSickLeave(SickLeave sic)
        {
            context.SickLeaves.Add(sic);
            context.SaveChanges();
            return Ok();
        }
        #endregion

        #region Drug
        [HttpPost]
        //[Authorize(Roles = "Pharmacist")]
        [Route("create-drug")]
        public async Task<IActionResult> AddDrug(Drug drg)//from logistics
        {
            context.Drugs.Add(drg);
            context.SaveChanges();
            return Ok();
        }
        [HttpGet]
        [Route("get-drug")]
        //[Authorize(Roles = "Pharmacist,Management Staff")]
        
        public async Task<IActionResult> GetAllDrug()//for inventory of hospital
        {
            var data = context.Drugs.ToList();
            return Ok(data);
        }

        [HttpGet]
        [Route("get-orders")]
        //[Authorize(Roles = "Management Staff")]

        public async Task<IActionResult> getAllorders()//for inventory of hospital
        {
            var data = context.Orders.ToList();
            return Ok(data);
        }

        [HttpPost]
        [Route("create-order")]//for pharmacist
        //[Authorize(Roles = "Pharmacist")]
        public async Task<IActionResult> createOrder(DrugOrders ord)
        {
            context.Orders.Add(ord);
            context.SaveChanges();
            return Ok();
        }
        #endregion
    }
}
