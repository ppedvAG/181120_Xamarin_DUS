using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Navigation.MD
{

    public class MDPageMenuItem
    {
        public MDPageMenuItem(Type targetType)
        {
            TargetType = targetType;
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}