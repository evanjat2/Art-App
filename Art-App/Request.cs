using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Request
    {
        public double vipupgrade;
        public int mastery;
        public int duration;
        public int count;
        public double fee;
        public Request(string mastery, int count, string vip)
        {
            this.count = count;
            if ( mastery == "Expert")
            {
                this.mastery = 8;
            }
            else if (mastery =="Advanced")
            {
                this.mastery = 6;
            }
            else if ( mastery =="Intermediate")
            {
                this.mastery = 4;
            }
            else if (mastery =="Beginner")
            {
                this.mastery = 2;
            }
            
            if (vip == "Gold")
            {
                this.vipupgrade = 2;
                this.duration = 1;
            }
            else if (vip == "Silver")
            {
                this.vipupgrade = 1.5;
                this.duration = 2;
            }
            else if( vip =="Bronze")
            {
                this.vipupgrade = 1;
                this.duration = 3;
            }
        }
        public static void freedownload(ref int token)
        {
            token = token - 1;
        }

        public double calculate_fee()
        {
            double fee = (mastery * 10000 + 25000) * vipupgrade * count;
            return fee;
        }

        public void ShowRequestInformation()
        {
            fee = calculate_fee();
            Console.WriteLine("Please pay {0} to proceed", fee);
            Console.WriteLine("Thanks for buying");
           
        }
    }
}
