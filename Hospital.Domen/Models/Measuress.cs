namespace Hospital.Domen.Models;

public class Measuress : Base
{
    public int PacientId { get; set; }
    public Patient? Patient { get; set; } = null;
    public DateTime Date { get; set; }
    public int DoctorId { get; set; }
    public Doctor? Doctor { get; set; } = null;
    public int MeasuresTypeId { get; set; }
    public MeasureType? MeasureType { get; set; } = null;
    public string Name { get; set; }
    public string Result { get; set; }
    public string Recommendation { get; set; }

}
