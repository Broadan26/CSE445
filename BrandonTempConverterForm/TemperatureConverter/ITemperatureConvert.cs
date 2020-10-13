using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TemperatureConverter
{
    [ServiceContract]
    public interface ITemperatureConvert
    {
        [OperationContract]
        int c2f(int celsius);

        [OperationContract]
        int f2c(int fahreneheit);
    }
}
