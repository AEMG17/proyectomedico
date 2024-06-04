using Medico.Models;

namespace Medico.Services
{
    public interface IMedicamento
    {
        Task<Medicamento> RegistrarMedicamento(Medicamento medicamento);

        Task<List<Medicamento>> ListarMedicamentos();

    }
}
