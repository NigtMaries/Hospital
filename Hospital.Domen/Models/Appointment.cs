using System.Reflection.Metadata;

namespace Hospital.Domen.Models;

public class Appointment:Base
{
    public DateTime Date { get; set; }

    public int PatientId { get; set; }

    public Patient? Patient { get; set; } = null;

    public int DoctorId { get; set; }

    public Doctor? Doctor { get; set; } = null;

    public int MedicalCardId { get; set; }

    public MedicalCard? MedicalCard { get; set; } = null;

    public string Result { get; set; } // Todo

    public string Recipes { get; set; }

    public int ReferralToDoctorId { get; set; }

    public ReferralToDoctor? ReferralToDoctor { get; set; } = null;

    public int MeasureId { get; set; }

    public Measuress? Measuress { get; set; } = null;


}
