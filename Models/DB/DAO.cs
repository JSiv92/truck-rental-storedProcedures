using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace JonathanSivananthanDADPartB.Models.DB
{
    public class DAO
    {
        //question 1 - top 5 individual trucks
        public static List<TopFive> getTopFiveTrucks()
        {
            using(DAD_JonathanContext ctx = new DAD_JonathanContext())
            {
                //get name of stored procedure
                return ctx.TopFive.FromSqlRaw("topFiveIndividualTrucks").ToList();
            }
        }

        //question 2 - least 5 models
        public static List<BottomFive> getBottomFiveModels()
        {
            using(DAD_JonathanContext ctx = new DAD_JonathanContext())
            {
                return ctx.BottomFive.FromSqlRaw("BottomFiveTruckModels").ToList();
            }
        }

        //question 3 - sales per month  
        public static List<SalesByMonth> getSalesByMonth(int monthvalue, int yearvalue)
        {
            using(DAD_JonathanContext ctx = new DAD_JonathanContext())
            {
                return ctx.SalesByMonth.FromSqlRaw("getSalesbyMonth @p0, @p1", monthvalue, yearvalue).ToList();   
            }
        }

        //question 4 - sales between 2 dates
        public static List<TotalBetweenDates> getBetweenDates(DateTime date1, DateTime date2)
        {
            using(DAD_JonathanContext ctx = new DAD_JonathanContext())
            {
                return ctx.TotalBetweenDates.FromSqlRaw("getRentalsBetweenTwoDates @p0, @p1", date1, date2).ToList();
            }
        }

    }
}
 