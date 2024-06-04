using Medico.Data;
using Medico.Models;
using Microsoft.EntityFrameworkCore;

namespace Medico.Services
{
    public class MedicamentoService(ApplicationDbContext context) : IMedicamento
    {
        public async Task<Medicamento> RegistrarMedicamento(Medicamento medicamento)
        {
            context.Medicamentos.Add(medicamento);
            await context.SaveChangesAsync();
            return medicamento;
        }
        public async Task<List<Medicamento>> ListarMedicamentos()
        {
            List<Medicamento> medicamentos = new List<Medicamento>();
            medicamentos = await context.Medicamentos.ToListAsync();
            return medicamentos;
        }
    }
}