using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentProcessing.BusinessRules.Rules
{
    public interface IRule
    {
        bool IsApplicable();
        void Execute();
    }
}
