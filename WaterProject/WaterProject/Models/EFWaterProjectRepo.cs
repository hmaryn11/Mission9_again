using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaterProject.Models
{
    public class EFWaterProjectRepo : IBookStoreRepo
    {
        private WaterProjectContext context { get; set; }
        
        public EFWaterProjectRepo (WaterProjectContext temp)
        {
            context = temp;
        }
        public IQueryable<Project> Projects => context.Projects;
    }
}
