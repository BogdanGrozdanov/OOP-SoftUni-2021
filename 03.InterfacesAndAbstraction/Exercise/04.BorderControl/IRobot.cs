using System;
using System.Collections.Generic;
using System.Text;

namespace _04.BorderControl
{
    interface IRobot : IIds
    {
        string Model { get; }
    }
}
