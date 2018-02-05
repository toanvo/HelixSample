using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelixSampl.Foundation.Core.Models
{
    public interface IBaseContent : IStandardItem
    {
        string Headline { get; set; }

        string ShortDescription { get; set; }

        string Body { get; set; }
    }
}
