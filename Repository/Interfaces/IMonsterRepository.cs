using System.Collections.Generic;
using System.Threading.Tasks;
using TheCollection.Models;

namespace TheCollection.Repository.Interfaces
{
    public interface IMonsterRepository
    {
        Task<ICollection<Monsters>> GetMonsters();
        Task GetMonster(int monsterId);
        Task<Monsters> CreateMonster(Monsters monster);
        void UpdateMonster(Monsters monster);
        void DeleteMonster(Monsters monster);
    }
}