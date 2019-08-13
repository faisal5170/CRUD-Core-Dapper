using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using tempCore.Contracts;
using tempCore.Models.POCO;

namespace tempCore.Concrete.Managers
{
    public class JobManager : IJobManager
    {
        private readonly IDapperHelper _dapperHelper;

        public JobManager(IDapperHelper dapperHelper)
        {
            this._dapperHelper = dapperHelper;
        }

        public int Create(Job job)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("JobTitle", job.JobTitle, DbType.String);
            dbPara.Add("JobImage", job.JobImage, DbType.String);
            dbPara.Add("CityId", job.CityId, DbType.Int32);
            dbPara.Add("IsActive", job.IsActive, DbType.String);
            dbPara.Add("CreatedBY", "1", DbType.String);
            dbPara.Add("CreatedDateTime", DateTime.Now, DbType.DateTime);
            dbPara.Add("UpdatedBY", "1", DbType.String);
            dbPara.Add("UpdatedDateTime", DateTime.Now, DbType.DateTime);

            var data = _dapperHelper.Insert<int>("[dbo].[SP_Add_Job]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;
        }

        public Job GetByJobId(int JobId)
        {
            var data = _dapperHelper.Get<Job>($"select * from job  where JobId={JobId}", null,
                    commandType: CommandType.Text);
            return data;
        }

        public int Delete(int JobId)
        {
            var data = _dapperHelper.Execute($"Delete [Job] where JObId={JobId}", null,
                    commandType: CommandType.Text);
            return data;
        }

        public List<Job> ListAll()
        {
            var data = _dapperHelper.GetAll<Job>("[dbo].[SP_Job_List]", null, commandType: CommandType.StoredProcedure);
            return data.ToList();

        }

        public string Update(Job job)
        {
            var dbPara = new DynamicParameters();
            dbPara.Add("JobTitle", job.JobTitle, DbType.String);
            dbPara.Add("JobId", job.JobID);
            dbPara.Add("JobImage", job.JobImage, DbType.String);
            dbPara.Add("CityId", job.CityId, DbType.Int32);
            dbPara.Add("IsActive", job.IsActive, DbType.String);
            dbPara.Add("UpdatedBY", "1", DbType.String);
            dbPara.Add("UpdatedDateTime", DateTime.Now, DbType.DateTime);


            var data = _dapperHelper.Update<string>("[dbo].[SP_Update_Job]",
                            dbPara,
                            commandType: CommandType.StoredProcedure);
            return data;


        }
    }
}
