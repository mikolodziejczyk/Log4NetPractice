using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Log4NetPractice
{
    class Invoice
    {

        public void Issue()
        {

            for (int i = 0; i < 20; i++)
            {


                try
                {
                    if (i == 10) throw new InvalidOperationException("An error ocurred when issuing an item.");
                }
                catch (InvalidOperationException e)
                {

                }
            }

        }
    }
}
