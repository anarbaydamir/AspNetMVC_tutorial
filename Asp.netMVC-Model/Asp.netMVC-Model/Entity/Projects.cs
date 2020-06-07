using System;
namespace Asp.netMVCModel.Entity
{
    public class Projects
    {
        public int id { get; set; }
        public string projectName { get; set; }

        public Projects(int id,string projectName)
        {
            this.id = id;
            this.projectName = projectName;
        }
    }
}
