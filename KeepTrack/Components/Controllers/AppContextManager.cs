using KeepTrack.Core;
using KeepTrack.Data;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Windows.Storage;

namespace KeepTrack.Components.Controllers
{
    public class AppContextManager : IAppContextManager
    {
        public const string APP_DB_PATH = "data.json";

        public JsonSerializerSettings SerializerSettings { get; set; }
        public IKTAppContext Context { get; set; }

        public AppContextManager()
        {
            SerializerSettings = new JsonSerializerSettings()
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                TypeNameHandling = TypeNameHandling.Objects,
                TypeNameAssemblyFormatHandling = TypeNameAssemblyFormatHandling.Simple,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
            };
        }

        public async Task LoadAsync()
        {
            var dbFile = await StorageFile.GetFileFromPathAsync(APP_DB_PATH);
            var seri = await FileIO.ReadTextAsync(dbFile);

            var context = await Task.Run(() =>
               {
                   IKTAppContext ctx = null;
                   try
                   {
                       ctx = JsonConvert.DeserializeObject<KTAppContext>(seri, SerializerSettings);
                   }
                   catch (Exception ex)
                   {
                       // TODO add error handling
                       Debug.WriteLine(ex);
                   }
                   return ctx;
               });

            Context = context ?? throw new KTException("APpContext is null.");
        }
        public async Task SaveAsync()
        {
            if (Context == null)
                return;

            var dbFile = await StorageFile.GetFileFromPathAsync(APP_DB_PATH);

            var seri = await Task.Run(() =>
            {
                string ctx = null;
                try
                {
                    ctx = JsonConvert.SerializeObject(Context, SerializerSettings);
                }
                catch (Exception ex)
                {
                    // TODO add error handling
                    Debug.WriteLine(ex);
                }
                return ctx;
            });

            if (seri == null)
                throw new KTException("Unable to serialize AppContext");

            await FileIO.WriteTextAsync(dbFile, seri);
        }
    }
}
