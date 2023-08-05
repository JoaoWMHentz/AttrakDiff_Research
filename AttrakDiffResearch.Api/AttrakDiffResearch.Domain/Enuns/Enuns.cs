using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttrakDiffResearch.Domain.Enuns
{
    public enum UserRule
    {
        [Description("Administrator")]
        Admin,
        [Description("Researcher")]
        Researcher,
        [Description("Voluntary")]
        Voluntary
    }
}
