using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Backend.Services.Interfaces
{
    public interface IServiceCoursHoraire : IService
    {
        CoursHoraire Get(int id);
        CoursHoraire Add(CoursHoraire coursHoraire);
        void Update(CoursHoraire coursHoraire);
        void Delete(int id);
    }
}
