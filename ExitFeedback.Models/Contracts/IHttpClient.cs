using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ExitFeedback.Models.Contracts
{
    public interface IHttpClient<T>
    {
        Task<T> Get(int id);
    }
}
