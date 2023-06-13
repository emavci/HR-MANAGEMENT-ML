using IK.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IK.Domain.Concrete.Gnl
{
    public class Gnl_LobbyDashboard : BaseEntity
    {
        public string Title { get; set; }
        public string LangKey { get; set; }
        public ICollection<Gnl_PersonConDashboard> PersonConDashboards { get; set; }
    }
}