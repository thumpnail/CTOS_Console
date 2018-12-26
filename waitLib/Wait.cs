using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaitLib {
    public class Wait {
        public static void waitSec(int x) {
            DateTime t = DateTime.Now;
            DateTime tf = DateTime.Now.AddSeconds(x);
            while (t < tf) {
                t = DateTime.Now;
            }
        }

        public static void waitMilsec(int x) {
            DateTime t = DateTime.Now;
            DateTime tf = DateTime.Now.AddMilliseconds(x);
            while (t < tf) {
                t = DateTime.Now;
            }
        }

        public static void waitMin(int x) {
            DateTime t = DateTime.Now;
            DateTime tf = DateTime.Now.AddMinutes(x);
            while (t < tf) {
                t = DateTime.Now;
            }
        }

        public static void waitHour(int x) {
            DateTime t = DateTime.Now;
            DateTime tf = DateTime.Now.AddHours(x);
            while (t < tf) {
                t = DateTime.Now;
            }
        }

        public static void waitDay(int x) {
            DateTime t = DateTime.Now;
            DateTime tf = DateTime.Now.AddDays(x);
            while (t < tf) {
                t = DateTime.Now;
            }
        }

        public static void waitMonth(int x) {
            DateTime t = DateTime.Now;
            DateTime tf = DateTime.Now.AddMonths(x);
            while (t < tf) {
                t = DateTime.Now;
            }
        }

        public static void waitYears(int x) {
            DateTime t = DateTime.Now;
            DateTime tf = DateTime.Now.AddYears(x);
            while (t < tf) {
                t = DateTime.Now;
            }
        }
    }
}