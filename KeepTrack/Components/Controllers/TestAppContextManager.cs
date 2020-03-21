using KeepTrack.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepTrack.Components.Controllers
{

    public class TestAppContextManager : IAppContextManager
    {
        public IKTAppContext Context { get; set; }

        public Task LoadAsync()
        {
            var ctx = new KTAppContext();
            int globalIndex = 0;


            ctx.Icons = new List<KTIcon>()
            {
                new KTIcon { Id = 0, Name = "devtools", Type = KTIconType.MDLFontIcon, IconString = "\uEC7A;" },
                new KTIcon { Id = 0, Name = "design", Type = KTIconType.MDLFontIcon, IconString = "\uEB3C;" },
                new KTIcon { Id = 0, Name = "manage", Type = KTIconType.MDLFontIcon, IconString = "\uE178;" },
                new KTIcon { Id = 0, Name = "insider", Type = KTIconType.MDLFontIcon, IconString = "\uF1AD;" },
                new KTIcon { Id = 0, Name = "project1", Type = KTIconType.MDLFontIcon, IconString = "\uEDA8;" }, 
                new KTIcon { Id = 0, Name = "project2", Type = KTIconType.MDLFontIcon, IconString = "\uEBC6;" },
                new KTIcon { Id = 0, Name = "project3", Type = KTIconType.MDLFontIcon, IconString = "\uEC06;" },
            };

            ctx.Activities = new List<KTActivityType>()
            {
                new KTActivityType { Id = 0, ActivityName = "Development", Icon = FindIcon("devtools") },
                new KTActivityType { Id = 0, ActivityName = "Design", Icon = FindIcon("design") },
                new KTActivityType { Id = 0, ActivityName = "Management", Icon = FindIcon("manage") },
                new KTActivityType { Id = 0, ActivityName = "RnD", Icon = FindIcon("insider") }
            };

            ctx.Projects = new List<KTProject>()
            {
                new KTProject { Id = 0, Name = "Demo Project 1", Icon = FindIcon("project1"), Tasks = CreateFakeTasks(), Description = "This is a demo project description. A bit more text so we can see how long it goes." },
                new KTProject { Id = 0, Name = "Demo Project 2", Icon = FindIcon("project2"), Tasks = CreateFakeTasks(), Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum." }
            };

            KTIcon FindIcon(string name) => ctx.Icons.FirstOrDefault(x => x.Name == name);
            KTActivityType FindActivity(string name) => ctx.Activities.FirstOrDefault(x => x.ActivityName == name);
            List<KTTask> CreateFakeTasks()
            {
                var rv = new List<KTTask>
                {
                    new KTTask
                    {
                        Id = globalIndex++,
                        Name = "Doing something",
                        ActivityTypes = new List<KTActivityType> { FindActivity("Development"), FindActivity("RnD") }
                    },
                    new KTTask
                    {
                        Id = globalIndex++,
                        Name = "Doing something else",
                        ActivityTypes = new List<KTActivityType> { FindActivity("Management"), FindActivity("Design") }
                    },
                };

                foreach (var x in rv)
                {
                    ctx.Tasks.Add(x);
                }

                return rv;
            }

            foreach (var x in ctx.Icons)
            {
                x.Id = globalIndex++;
            }

            foreach (var x in ctx.Activities)
            {
                x.Id = globalIndex++;
            }

            foreach (var x in ctx.Projects)
            {
                x.Id = globalIndex++;
            }

            Context = ctx;

            return Task.CompletedTask;
        }

        public Task SaveAsync()
        {
            // do nothing
            return Task.CompletedTask;
        }
    }
}
