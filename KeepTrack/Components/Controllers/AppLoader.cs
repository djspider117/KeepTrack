using GhostCore;
using KeepTrack.Components.ViewModels.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTrack.Components.Controllers
{
    public class AppLoader
    {
        #region Singleton

        private static volatile AppLoader _instance;
        private static object _syncRoot = new object();

        public static AppLoader Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_syncRoot)
                    {
                        if (_instance == null)
                            _instance = new AppLoader();
                    }
                }

                return _instance;
            }
        }
        private AppLoader()
        {
        }

        #endregion

        private IAppContextManager _contextManager;
        private KTRuntimeAppContext _runtimeAppContext;

        public async Task InitializeAsync()
        {
            _contextManager = new TestAppContextManager();
            await _contextManager.LoadAsync();

            _runtimeAppContext = new KTRuntimeAppContext(_contextManager.Context);

            ServiceLocator.Instance.Register(_contextManager);
            ServiceLocator.Instance.Register(_contextManager.Context);
            ServiceLocator.Instance.Register(_runtimeAppContext);
        }
    }
}
