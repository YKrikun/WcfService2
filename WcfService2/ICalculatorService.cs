using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CalculatorService
{
    [ServiceContract]
    public interface IMyCalculatorService
    {

        // TODO: Add your service operations here
        [OperationContract]
        Int32 Add(Int32 Num1, Int32 Num2);

        [OperationContract]
        Int32 Subtract(Int32 Num1, Int32 Num2);

        [OperationContract]
        Int32 Multiply(Int32 Num1, Int32 Num2);

    }

}
