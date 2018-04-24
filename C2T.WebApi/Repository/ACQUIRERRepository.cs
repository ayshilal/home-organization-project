using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C2T.WebApi.Repository
{
    public class ACQUIRERRepository : IACQUIRERRepository
    {
        private readonly ACQUIRERContext _context;
        public ACQUIRERRepository(ACQUIRERContext context)
        {
            _context = context;
        }
        public IEnumerable<ACQUIRER> GetAll()
        {
            return  _context.ACQUIRERList;
        }
        public async Task<ACQUIRER> Find(string key)
        {
            return await _context.ACQUIRERList.Where(e => e.ACQUIRER_ID.Equals(key))
                .SingleOrDefaultAsync();
        }
    }
}