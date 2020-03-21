using KeepTrack.Data;
using System.Threading.Tasks;

namespace KeepTrack.Components.Controllers
{
    public interface IAppContextManager
    {
        IKTAppContext Context { get; set; }

        Task LoadAsync();
        Task SaveAsync();
    }
}
