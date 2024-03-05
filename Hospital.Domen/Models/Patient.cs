using System.Globalization;

namespace Hospital.Domen.Models;

public class Patient : Base
{

    public byte[] Photo { get; set; }

    public string SurName { get; set; }

    public string Name { get; set; }

    public string? Patronymic { get; set; }

    public string PassportSerial { get; set; }

    public string PassportNumber { get; set; }

    public DateTime DateBorn { get; set; }

    public string Gender { get; set; }

    public string Address { get; set; }

    public string? PlaceOfWork { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public IEnumerable <MedicalCard> MedicalCards { get; set; } = null!; //p.MedicalCard

    public DateTime LastVisit { get; set; }

    public DateTime? NextVisit { get; set; }

    public IEnumerable<Policy>? Policies { get; set; } = null!; //p.MedicalCard

    public string Diagnosis {get;set;}
    
    public string History {  get; set; }

}
