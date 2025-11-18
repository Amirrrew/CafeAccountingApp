using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Calendar
{
    class GetTime
    {
        PersianCalendar pc = new PersianCalendar();
         public string GetDay()
         {
            string day;
            day = pc.GetDayOfMonth(DateTime.Now).ToString();
            return day;
         }

        public string GetMonth()
        {
            string month;
            int monthNum;
            monthNum = pc.GetMonth(DateTime.Now);

            if (monthNum < 10)
            {
                month = "0" + pc.GetMonth(DateTime.Now).ToString();
            }
            else
            {
                month = pc.GetMonth(DateTime.Now).ToString();
            }

            return month;
        }

        public string GetYear()
        {
            string year;
            year = pc.GetYear(DateTime.Now).ToString();
            return year;
        }

        public string GetWeekTitle()
        {
            string dayW;
            dayW = pc.GetDayOfWeek(DateTime.Now).ToString();
            return dayW;
        }

        public string GetTimeNow()
        {
            string time;
            time = DateTime.Now.ToString("HH:mm:ss");
            return time;
        }

        public string GetTimeWithoutSeconds()
        {
            string time;
            time = DateTime.Now.ToString("HH:mm");
            return time;
        }

        public string GetDayTitle()
        {
            string daytitle = "";
            string day = "";
            daytitle = pc.GetDayOfWeek(DateTime.Now).ToString();
            switch(daytitle)
            {
                case "Saturday":
                    day = "شنبه";
                    break;
                case "Sunday":
                    day = "یکشنبه";
                    break;
                case "Monday":
                    day = "دوشنبه";
                    break;
                case "Tuesday":
                    day = "سه شنبه";
                    break;
                case "Wednesday":
                    day = "چهارشنبه";
                    break;
                case "Thursday":
                    day = "پنجشنبه";
                    break;
                case "Friday":
                    day = "جمعه";
                    break;
            }
            return day;
        }

        public string GetMonthName()
        {
            string monthText = "";

            switch (GetMonth())
            {
                case "01":
                    monthText = "Farvardin";
                    break;
                case "02":
                    monthText = "Ordibehesht";
                    break;
                case "03":
                    monthText = "Khordad";
                    break;
                case "04":
                    monthText = "Tir";
                    break;
                case "05":
                    monthText = "Mordad";
                    break;
                case "06":
                    monthText = "Shahrivar";
                    break;
                case "07":
                    monthText = "Mehr";
                    break;
                case "08":
                    monthText = "Aban";
                    break;
                case "09":
                    monthText = "Azar";
                    break;
                case "10":
                    monthText = "Dey";
                    break;
                case "11":
                    monthText = "Bahman";
                    break;
                case "12":
                    monthText = "Esfand";
                    break;
            }
            return monthText;
        }

        public string GetDayName()
        {
            string dayText = "";

            switch (GetDay())
            {
                case "1":
                    dayText = "First";
                    break;
                case "2":
                    dayText = "Second";
                    break;
                case "3":
                    dayText = "Third";
                    break;
                case "4":
                    dayText = "Forth";
                    break;
                case "5":
                    dayText = "Fifth";
                    break;
                case "6":
                    dayText = "Sixth";
                    break;
                case "7":
                    dayText = "Seventh";
                    break;
                case "8":
                    dayText = "Eighth";
                    break;
                case "9":
                    dayText = "Nineth";
                    break;
                case "10":
                    dayText = "Tenth";
                    break;
                case "11":
                    dayText = "Eleventh";
                    break;
                case "12":
                    dayText = "Twelveth";
                    break;
                case "13":
                    dayText = "Thirteenth";
                    break;
                case "14":
                    dayText = "Fourteenth";
                    break;
                case "15":
                    dayText = "Fifteenth";
                    break;
                case "16":
                    dayText = "Sixteenth";
                    break;
                case "17":
                    dayText = "Seventeenth";
                    break;
                case "18":
                    dayText = "Eighteenth";
                    break;
                case "19":
                    dayText = "Nineteenth";
                    break;
                case "20":
                    dayText = "Twentyth";
                    break;
                case "21":
                    dayText = "Twenty First";
                    break;
                case "22":
                    dayText = "Twenty Second";
                    break;
                case "23":
                    dayText = "Twenty Third";
                    break;
                case "24":
                    dayText = "Twenty Fourth";
                    break;
                case "25":
                    dayText = "Twenty Fifth";
                    break;
                case "26":
                    dayText = "Twenty Sixth";
                    break;
                case "27":
                    dayText = "Twenty Seventh";
                    break;
                case "28":
                    dayText = "Twenty Eighth";
                    break;
                case "29":
                    dayText = "Twenty Nineth";
                    break;
                case "30":
                    dayText = "Thirtyth";
                    break;
                case "31":
                    dayText = "Thirty First";
                    break;
            }

            return dayText;
        }



        //--------------------------date in english v ------------------------------//

        public string GetDayEng()
        {
            string dayeng;
            dayeng = DateTime.Now.ToString("dd");
            return dayeng;
        }

        public string GetMonthEng()
        {
            string montheng;
            montheng = DateTime.Now.ToString("MM");
            return montheng;
        }

        public string GetYearEng()
        {
            string yeareng;
            yeareng = DateTime.Now.ToString("yyyy");
            return yeareng;
        }

        public string GetEngMonthName()
        {
            string monthTexteng = "";

            switch (GetMonthEng())
            {
                case "01":
                    monthTexteng = "January";
                    break;
                case "02":
                    monthTexteng = "February";
                    break;
                case "03":
                    monthTexteng = "March";
                    break;
                case "04":
                    monthTexteng = "April";
                    break;
                case "05":
                    monthTexteng = "May";
                    break;
                case "06":
                    monthTexteng = "June";
                    break;
                case "07":
                    monthTexteng = "July";
                    break;
                case "08":
                    monthTexteng = "Augest";
                    break;
                case "09":
                    monthTexteng = "September";
                    break;
                case "10":
                    monthTexteng = "October";
                    break;
                case "11":
                    monthTexteng = "November";
                    break;
                case "12":
                    monthTexteng = "December";
                    break;
            }
            return monthTexteng;
        }

        public string GetEngDayName()
        {
            string dayTextEng = "";

            switch (GetDayEng())
            {
                case "01":
                    dayTextEng = "First";
                    break;
                case "02":
                    dayTextEng = "Second";
                    break;
                case "03":
                    dayTextEng = "Third";
                    break;
                case "04":
                    dayTextEng = "Forth";
                    break;
                case "05":
                    dayTextEng = "Fifth";
                    break;
                case "06":
                    dayTextEng = "Sixth";
                    break;
                case "07":
                    dayTextEng = "Seventh";
                    break;
                case "08":
                    dayTextEng = "Eighth";
                    break;
                case "09":
                    dayTextEng = "Nineth";
                    break;
                case "10":
                    dayTextEng = "Tenth";
                    break;
                case "11":
                    dayTextEng = "Eleventh";
                    break;
                case "12":
                    dayTextEng = "Twelveth";
                    break;
                case "13":
                    dayTextEng = "Thirteenth";
                    break;
                case "14":
                    dayTextEng = "Fourteenth";
                    break;
                case "15":
                    dayTextEng = "Fifteenth";
                    break;
                case "16":
                    dayTextEng = "Sixteenth";
                    break;
                case "17":
                    dayTextEng = "Seventeenth";
                    break;
                case "18":
                    dayTextEng = "Eighteenth";
                    break;
                case "19":
                    dayTextEng = "Nineteenth";
                    break;
                case "20":
                    dayTextEng = "Twentyth";
                    break;
                case "21":
                    dayTextEng = "Twenty First";
                    break;
                case "22":
                    dayTextEng = "Twenty Second";
                    break;
                case "23":
                    dayTextEng = "Twenty Third";
                    break;
                case "24":
                    dayTextEng = "Twenty Fourth";
                    break;
                case "25":
                    dayTextEng = "Twenty Fifth";
                    break;
                case "26":
                    dayTextEng = "Twenty Sixth";
                    break;
                case "27":
                    dayTextEng = "Twenty Seventh";
                    break;
                case "28":
                    dayTextEng = "Twenty Eighth";
                    break;
                case "29":
                    dayTextEng = "Twenty Nineth";
                    break;
                case "30":
                    dayTextEng = "Thirtyth";
                    break;
                case "31":
                    dayTextEng = "Thirty First";
                    break;

            }

            return dayTextEng;
        }



        public string generateFullDate()
        {
            string date_Full;
            date_Full = GetYear().ToString() + "/" +
                GetMonth().ToString() + "/" +
                GetDay().ToString();
            return date_Full;

        }
    }


}
