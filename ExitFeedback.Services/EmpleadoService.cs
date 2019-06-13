using ExitFeedback.Models.Contracts;
using ExitFeedback.Models.Entities;
using System.Threading.Tasks;

namespace ExitFeedback.Services
{
    public class EmpleadoService : BaseService<Empleado>
    {
        private readonly IHttpClient<Empleado> _httpClient;

        public EmpleadoService(IRepository<Empleado> repository, IHttpClient<Empleado> httpClient) : base(repository)
        {
            _httpClient = httpClient;
        }

        public override async Task<Empleado> GetById(int id)
        {
            if (base.GetById(id).Result != null)
            {
                return await base.GetById(id);
            }
            else
            {
                var empl = await _httpClient.Get(id);
                await base.Create(empl);
                return empl;
            }
        }

    }
}
