using MedicalAPI.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalAPI.Repositories
{
    public interface MedicineRepository
    {
        Task<List<Medicine>> GetMedicnesAsync();
    }
}
