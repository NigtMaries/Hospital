using Hospital.Domen.Models;

namespace Hospital.Domen.Interfaces;

public interface IPatientRepository
{
    void Create(Patient p);
}