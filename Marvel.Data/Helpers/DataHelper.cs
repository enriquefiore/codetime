using Marvel.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Marvel.Data.Helpers
{
    public class DataHelper
    {
        public async Task<Character> RetrieveCharacterById(DataContext context, int characterId)
        {
            return await context.Characters
                    .AsNoTracking()
                    .FirstOrDefaultAsync(x => x.Id.Equals(characterId));
        }
    }
}