using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaterProject.Models
{
    public interface IBookStoreRepo
    {
        IQueryable<Project> Projects { get; } // can only read from this data
    }
}
