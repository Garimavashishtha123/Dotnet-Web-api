using MedicalAPI.DataModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalAPI.Repositories
{
    public class SqlMedicineRepository : MedicineRepository
    {
        private readonly MedicineDbContext context;
        public SqlMedicineRepository(MedicineDbContext context)
        {
            this.context = context;

        }
       

        public async Task<List<Medicine>> GetMedicnesAsync()
        {
            return await context.Medicine.ToListAsync();
        }
    }
}
