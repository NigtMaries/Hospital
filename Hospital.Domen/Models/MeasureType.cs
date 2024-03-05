using System.Security.Cryptography.X509Certificates;

namespace Hospital.Domen.Models;

public class MeasureType:Base
{
    public string Type {  get; set; }
    public decimal Cost { get; set; } = 0;
}
