﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptosPOO
{
    public class Date
    {
        private int _day;
        private int _month;
        private int _year;

        public Date(int day, int month, int year)
        {
            _day = CheckDay(day,month,year);
            _month = CheckMonth(month);
            _year = year;

        }

        private int CheckDay(int day, int month, int year)
        {
            if (month ==  2 && day == 29 && IsLeapYear(year))
            {
                return day;
            }

            int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if(day >= 1 && day <= daysPerMonth[month])
            {
                return day;
            }

            throw new DayException("Invalid Day");
        }

        private bool IsLeapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;

            //if(year % 4 == 0)
            //{
            //    if(year % 100 == 0)
            //    {
            //        if(year % 400 == 0)
            //        {
            //            return true;
            //        }
            //        else
            //            return false;
            //    }
            //    else
            //        return true;
            //}
            //else
            //    return false;
        }

        private int CheckMonth(int month)
        {
            if(month >=0 && month <= 12)
            {
                return month;
            }

            throw new MonthException("invalid month");
        }

        public override string ToString()
        {
            return $"{_day:00}/{_month:00}/{_year}" ;
        }

    }
}
