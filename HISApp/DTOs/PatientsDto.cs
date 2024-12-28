using HISApp.Domain;
using System.ComponentModel.DataAnnotations.Schema;

namespace HISApp.DTOs;

public class PatientsDto
{
    public int Id { set; get; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public int departmentId { set; get; }
    public string pcd { set; get; }
    public int age { set; get; }
    public string phoneNumber { set; get; }
    public bool gender { set; get; }
   
    public string bloodType { set; get; }
    public int Areaid { set; get; }
    public int CityId { set; get; }
    public string? legalGaurdainPhone { get; set; }
    public string? legalGaurdainName { get; set; }
   




}