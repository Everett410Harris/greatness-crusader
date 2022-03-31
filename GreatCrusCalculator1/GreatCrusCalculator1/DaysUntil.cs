using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreatCrusCalculator1
{
    public partial class DaysUntil : Form
    {
        private static readonly object DaysU;

        public DaysUntil()
        {
            InitializeComponent();
        }

        private void DaysUntil_Load(object sender, EventArgs e)
        {
            textToday.Text = DateTime.Now.ToString();
            textTotal.Text = 


        }

        public static void Dates()
        {

            DateTime firstDate = DateTime.Now;
            DateTime secondDate = TextBox.DaysU;

            TimeSpan diff = firstDate - secondDate;

            Console.WriteLine("Days : " + diff.TotalDays.ToString());
            Console.WriteLine("Hours : " + diff.TotalHours.ToString());
            Console.WriteLine("Minutes : " + diff.TotalMinutes.ToString());


        }

        //public static void DateTimeDiff(DateTime dateTime,  DateTime DaysU, out int years, out int months, out int days)
        //{
        //    DateTime start = DateTime.Now;
        //    DateTime end = DaysU > DateTime.Now ? DaysU : DateTime.Now;

        //    years = 0;
        //    months = 0;
        //    days = 0;

        //    while (start.AddYears(1) < end)
        //    {
        //        start = start.AddYears(1);
        //        years++;
        //    }

        //    while (start.AddMonths(1) < end)
        //    {
        //        start = start.AddMonths(1);
        //        months++;
        //    }

        //    while (start.AddDays(1) < end)
        //    {
        //        start = start.AddDays(1);
        //        days++;
        //    }
        //}
    }
}
