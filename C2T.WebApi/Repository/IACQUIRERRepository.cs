
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C2T.WebApi
{
    public interface IACQUIRERRepository
    {
        Task<ACQUIRER> Find(string key);
        IEnumerable<ACQUIRER> GetAll();
    }
}
