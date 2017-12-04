using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XFApp
{

    public class XAppMasterMenuItem
    {
        public XAppMasterMenuItem()
        {
            TargetType = typeof(XAppMasterDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}