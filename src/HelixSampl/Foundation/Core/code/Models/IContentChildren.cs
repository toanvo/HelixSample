using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixSampl.Foundation.Core.Models
{
    public interface IContentChildren
    {
        IEnumerable<IStandardItem> Children { get; set; }
    }
}
