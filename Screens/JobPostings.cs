using Project_application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_application.Screens
{
    public class Job_posting
    {
        List<Job> job = new List<Job>();
        public void CreateJobs(string company_name, int yoe, string job_type, string location, string shift, string skillset)
        {
            job.Add(new Job(company_name, yoe, job_type, location, shift, skillset));
            Console.WriteLine("Job details are succesfully added to the portal");
        }

        public void DeleteJob(string c_name, string j_type)
        {
            if (job != null)
            {
                for (int i = job.Count - 1; i >= 0; i--)
                {
                    Job j = job[i];
                    if (c_name.Equals(j.company_name) && j_type.Equals(j.job_type))
                    {
                        job.Remove(j);
                        Console.WriteLine("The Job Notification is Deleted Successfully");
                    }
                    else if (c_name.Equals(j.company_name) && !j_type.Equals(j.job_type))
                    {
                        Console.WriteLine("No job type of the specified type is present in the company");
                    }
                }
            }
            else
                Console.WriteLine("No Jobs present at the moment");
        }
    }


}
