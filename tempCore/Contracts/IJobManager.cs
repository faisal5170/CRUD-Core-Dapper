using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tempCore.Models.POCO;

namespace tempCore.Contracts
{
    public interface IJobManager 
    {
        int Delete(int JobId);
        Job GetByJobId(int JobId);
        string Update(Job job);
        int Create(Job JobDetails);
        List<Job> ListAll();
    }
}
