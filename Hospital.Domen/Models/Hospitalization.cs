using System.Security.Cryptography.X509Certificates;

namespace Hospital.Domen.Models;

public class Hospitalization : Base
{
    public int PatientId { get; set; }
    public Patient? Patient { get; set; } = null;

    public Guid Code { get; set; } = Guid.NewGuid();

    public DateTime BeginDate { get; set; }

    public DateTime EndDate { get; set; }

    public string Target { get; set; }


    public int DepartmentId { get; set; }

    public Department? Department { get; set; } = null;

    public string Condition { get; set; } = "free";//todo

    public string Description { get; set; }

    public string Status { get; set; } = "согласие";//todo


}
