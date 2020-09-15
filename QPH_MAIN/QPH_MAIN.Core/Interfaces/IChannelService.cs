using QPH_MAIN.Core.Entities;
using QPH_MAIN.Core.QueryFilters;
using QPH_MAIN.Core.CustomEntities;
using System.Threading.Tasks;

namespace QPH_MAIN.Core.Interfaces
{
    public interface IChannelService
    {
        PagedList<Chanel> GetChannels(ChannelQueryFilter filters);
        Task<Chanel> GetChannel(int id);
        Task InsertChannel(Chanel channel);
        Task<bool> UpdateChannel(Chanel channel);
        Task<bool> DeleteChannel(int id);
    }
}