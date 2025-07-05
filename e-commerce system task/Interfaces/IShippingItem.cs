using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_commerce_system_task.Interfaces
{
    public interface IShippingItem
    {
        double GetWeight();
        string GetName();
        int GetQuantity();
    }
}
