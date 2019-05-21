using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campers
{
    public partial class MainPage : Form
    {
        public string ActiveUser = string.Empty;
        public bool isAdmin = false;
        private CamperVans allVans = new CamperVans();
        DateTime[] bookedDays;

        public MainPage()
        {

            InitializeComponent();
        }

        private void Campers_Load(object sender, EventArgs e)
        {
            monthCalendarCamper.MinDate = DateTime.Now; ;
            monthCalendarCamper.MaxDate = DateTime.Now.AddDays(42);

            listBox1.BeginUpdate();
            string[] vanList = allVans.ReturnAllVanNames();
            foreach (string van in vanList)
            {
                listBox1.Items.Add(van);
            }
            listBox1.EndUpdate();

            lblWelcome.Text = "Welcome " + LandingPage.user;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshCalender();
        }

        private void RefreshCalender()
        {
            int index = listBox1.SelectedIndex;
            // MessageBox.Show(index.ToString());
            // MessageBox.Show(allVans.ReturnVanNameByIndex(index));

            monthCalendarCamper.RemoveAllBoldedDates();
            bookedDays = allVans.ReturnBookedDaysByVanIndex(index);
            foreach (DateTime date in bookedDays)
            {
                monthCalendarCamper.AddBoldedDate(date);

            }
            monthCalendarCamper.UpdateBoldedDates();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            RefreshCalender();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime bookingStart = monthCalendarCamper.SelectionStart.Date;
            DateTime bookingEnd = monthCalendarCamper.SelectionEnd.Date;
            
            
            // if date in bold selection then output error.
            // selection is for one van
            
        }

        private void btnSaveDates_Click(object sender, EventArgs e)
        {
            DateTime bookingStart = monthCalendarCamper.SelectionStart.Date;
            DateTime bookingEnd = monthCalendarCamper.SelectionEnd.Date;

            if (listBox1.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("please select van first");
            }
            else
            {
                if (bookedDays.Contains(bookingStart) || bookedDays.Contains(bookingEnd))
                {
                    // already been booked
                    MessageBox.Show("Already booked");
                }
                else
                {
                    // add booking
                    string vanName = allVans.ReturnVanNameByIndex(listBox1.SelectedIndex);
                    allVans.SaveBooking(listBox1.SelectedIndex, LandingPage.user, bookingStart, bookingEnd);
                    MessageBox.Show("Booking successful");


                    // refresh calender
                    RefreshCalender();
                }
            }            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panelAdminPanel_Paint(object sender, PaintEventArgs e)
        {
            string[] SelectedBooking = new string[4];


        }
    }
}




/* can't change date color individually so this is useless
 
/ if to display 2 month or 3
// if remaining days + days nexy month < 42
DateTime firstDayOfTheMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
DateTime startOfNextMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, 1);
DateTime maxDate;

int remainingDaysInMonth = (startOfNextMonth - DateTime.Today).Days;
int daysInNextMonth = (startOfNextMonth.AddMonths(1) - startOfNextMonth).Days;
int rentalRange = 42;

if(rentalRange> remainingDaysInMonth + daysInNextMonth)
{
    // if this case all date cannot be displayed in 2 months
    maxDate = startOfNextMonth.AddMonths(2).AddDays(-1);
}
else
{
    maxDate = startOfNextMonth.AddMonths(1).AddDays(-1);
}
*/
