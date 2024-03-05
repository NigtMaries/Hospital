

namespace Hospital.Domen.Models;

public class MedicalCard:Base
{
    public string Number { get; set; }

    public DateTime BeginDate { get; set; }
    public int PacientId { get; set; }
    public Patient? Patient { get; set; } = null;
    public IEnumerable<Appointment> Appointments { get; set; } = null!;
}
