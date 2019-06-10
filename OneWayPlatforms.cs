using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneWayPlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            //Put this in the Update
            //Added One Way Platform
            if (m_Grounded == true && gameObject.layer != 8)
                gameObject.layer = 8;


            if (m_Grounded == true && Input.GetKey(KeyCode.S))
            {
                gameObject.layer = 10;
            }
        }
    }
}
