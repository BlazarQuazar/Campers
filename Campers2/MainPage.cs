using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Campers2
{  
    public partial class MainPage : Form
    {
        private string activeUser = string.Empty;
        private bool isAdmin = false;
        private Fleet fleet = new Fleet();
        private DateTime[] bookedDays;
        private int vanIndex = -1;
        private string[] currentBooking;

        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            this.activeUser = LogIn.user;
            this.isAdmin = LogIn.isAdmin;
            lblWelcome.Text = "Welcome " + activeUser;
            this.PopulateListBox();

            this.startUpProcedure();
        }

        private void startUpProcedure() { 

            if (fleet.UserHasTwoOrMoreBookings(activeUser))
            {
                btnSaveDates.Enabled = false;                
                MessageBox.Show("You already have 2 weekends booked\nPlease talk to an admin if you wish to change your bookings");
            }


            if (LogIn.isAdmin)
            {
                comboBoxVans.Items.Clear();
                foreach (string van in fleet.RetrunAllVanNames())
                {
                    comboBoxVans.Items.Add(van);
                }

                Users users = new Users();
                foreach(string user in users.ReturnAllUsers())
                {
                    comboBoxUsers.Items.Add(user);
                }
                comboBoxUsers.Text = activeUser;

            }
            else
            {
                AdminPanel.Visible = false;
                AdminPanel.Enabled = false;
            }

            btnAmend.Enabled = false;
            btnDelete.Enabled = false;
            
            if (AdminPanel.Enabled)
            {
                datePickerStart.MinDate = DateTime.Now.Date;
                datePickerStart.MaxDate = DateTime.Now.AddDays(42).Date;

                datePickerEnd.MinDate = DateTime.Now.Date;
                datePickerEnd.MaxDate = DateTime.Now.AddDays(42).Date;
            }
        }

        private void RefreshCalender()
        {
            vanIndex = listBox1.SelectedIndex;
            monthCalendarCamper.RemoveAllBoldedDates();

            bookedDays = fleet.ReturnBookedDaysByVanIndex(vanIndex);
            foreach (DateTime date in bookedDays)
            {
                monthCalendarCamper.AddBoldedDate(date);
            }
            monthCalendarCamper.UpdateBoldedDates();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.RefreshCalender();
            if (AdminPanel.Enabled)
            {
                comboBoxVans.SelectedIndex = listBox1.SelectedIndex;
            }
            
        }

        private void PopulateListBox()
        {
            monthCalendarCamper.MinDate = DateTime.Now;
            monthCalendarCamper.MaxDate = DateTime.Now.AddDays(42);

            listBox1.Items.Clear();
            listBox1.BeginUpdate();
            foreach (string van in fleet.RetrunAllVanNames())
            {
                listBox1.Items.Add(van);
            }
            listBox1.EndUpdate();
        }

        private void btnSaveDates_Click(object sender, EventArgs e)
        {
            DateTime bookingStart = monthCalendarCamper.SelectionStart.Date;
            DateTime bookingEnd = monthCalendarCamper.SelectionEnd.Date;
            
            if (vanIndex.Equals(-1))
            {
                MessageBox.Show("Please select van first");
            }
            else
            {
                bool doesABookingExist = fleet.ReturnVanNameFromUserBooked(activeUser) != string.Empty;
                bool doesInputVanEqualBookedVan = fleet.ReturnVanNameFromUserBooked(activeUser) == fleet.VanNameFromIndex(vanIndex);

                if (doesABookingExist && doesInputVanEqualBookedVan.Equals(false))
                {
                    string outString = "You've already booked ";
                    outString += fleet.ReturnVanNameFromUserBooked(activeUser);
                    outString += "\nCan only book one van a a time.\nPlease select ";
                    outString += fleet.ReturnVanNameFromUserBooked(activeUser);
                    outString += " and book again.";
                    MessageBox.Show(outString);
                }
                else if (bookedDays.Contains(bookingStart) || bookedDays.Contains(bookingEnd))
                {
                    MessageBox.Show("These dates have alread been booked");
                }
                else
                {
                    fleet.AddBooking(vanIndex, activeUser, bookingStart, bookingEnd);
                    MessageBox.Show("Booking successful");

                    this.RefreshCalender();
                }

                if (fleet.UserHasTwoOrMoreBookings(activeUser))
                {
                    btnSaveDates.Enabled = false;
                    MessageBox.Show("You now have 2 weekends booked\nPlease talk to an admin if you wish to change your bookings");
                }
            }
           

        }

        private void monthCalendarCamper_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (AdminPanel.Visible)
            {
                if (vanIndex.Equals(-1))
                {
                    MessageBox.Show("Please select van first");
                }
                else
                {
                    DateTime selection = monthCalendarCamper.SelectionStart.Date;



                    if (bookedDays.Contains(selection))
                    {
                        currentBooking = fleet.ReturnBookingWithVanIndexAndDate(vanIndex, selection);
                        btnAddBooking.Enabled = false;
                        this.UpdateAdminPanel();                        
                    }
                    else
                    {
                        datePickerStart.Value = monthCalendarCamper.SelectionStart;
                        datePickerEnd.Value = monthCalendarCamper.SelectionEnd;
                        btnAmend.Enabled = false;
                        btnDelete.Enabled = false;
                        btnAddBooking.Enabled = true;
                    }

                }
            }
        }

        private void AdminPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UpdateAdminPanel()
        {
            comboBoxVans.Text = currentBooking[0];
            comboBoxUsers.Text = currentBooking[1];
            datePickerStart.Value = Convert.ToDateTime(currentBooking[2]);
            datePickerEnd.Value = Convert.ToDateTime(currentBooking[3]);
            btnDelete.Enabled = true;
            btnAmend.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int oVanIndex = comboBoxVans.SelectedIndex;

            string oUser = currentBooking[1];
            DateTime oStartDate = Convert.ToDateTime(currentBooking[2]).Date;
            DateTime oEndDate = Convert.ToDateTime(currentBooking[3]).Date;

            if (fleet.DoesBookingExist(oVanIndex, oUser, oStartDate, oEndDate))
            {
                fleet.DeleteBooking(oVanIndex, oUser, oStartDate, oEndDate);
                MessageBox.Show("Booking deleted");
            }
            else
            {
                MessageBox.Show("Booking doesn't exist, please select again");
            }

            this.RefreshCalender();
        }

        private void comboBoxVans_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnAmend.Enabled = true;
        }

        private void datePickerStart_ValueChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnAmend.Enabled = true;
        }

        private void datePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnAmend.Enabled = true;
        }

        private DateTime[] RemoveCurrentBookingFromDateCheck(DateTime[] iDateCheck)
        {
            List<DateTime> datesInCurrentBooking = new List<DateTime>();
            HashSet<DateTime> hDateCheck = new HashSet<DateTime>(iDateCheck);

            DateTime startDate = Convert.ToDateTime(currentBooking[2]).Date;
            DateTime endDate = Convert.ToDateTime(currentBooking[3]).Date;
            int days = (endDate - startDate).Days;

            for (int i = 0; i <= days; i++)
            {
                datesInCurrentBooking.Add(startDate.AddDays(i));
            }

            HashSet<DateTime> hDatesInCurrentBooking = new HashSet<DateTime>(datesInCurrentBooking);

            hDateCheck.ExceptWith(hDatesInCurrentBooking);

            return hDateCheck.ToArray();
        }

        private void btnAmend_Click(object sender, EventArgs e)
        {
            DateTime[] oDateCheck = fleet.ReturnBookedDaysByVanIndex(comboBoxVans.SelectedIndex);
            DateTime[] dateCheck = this.RemoveCurrentBookingFromDateCheck(oDateCheck);
            DateTime newStartDate = datePickerStart.Value.Date;
            DateTime newEndDate = datePickerEnd.Value.Date;
            int daysBooking = (newEndDate - newStartDate).Days;

            // need to check if a different booking exists

            if(dateCheck.Contains(newStartDate) || dateCheck.Contains(newEndDate))
            {
                MessageBox.Show("Booking already exists");
            }
            else if (daysBooking > 7)
            {
                MessageBox.Show("7 days is the max you can book for");
            }
            else if (daysBooking < 0)
            {
                MessageBox.Show("Start date needs to be before end date");
            }
            else
            {
                string cVanName = currentBooking[0];
                string cUser = currentBooking[1];
                DateTime cStartDate = Convert.ToDateTime(currentBooking[2]).Date;
                DateTime cEndDate = Convert.ToDateTime(currentBooking[3]).Date;

                int nVanIndex = comboBoxVans.SelectedIndex;
                string nUser = comboBoxUsers.Text;

                fleet.DeleteBookingWithVanName(cVanName, cUser, cStartDate, cEndDate);
                fleet.AddBooking(nVanIndex, nUser, newStartDate, newEndDate);
                MessageBox.Show("Booking amended");
                this.RefreshCalender();
            }
        }

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnAmend.Enabled = true;
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            if (vanIndex.Equals(-1))
            {
                MessageBox.Show("Please select a van first");
                return;
            }

            DateTime[] oDateCheck = fleet.ReturnBookedDaysByVanIndex(comboBoxVans.SelectedIndex);
            DateTime[] dateCheck = this.RemoveCurrentBookingFromDateCheck(oDateCheck);
            DateTime newStartDate = datePickerStart.Value.Date;
            DateTime newEndDate = datePickerEnd.Value.Date;
            int daysBooking = (newEndDate - newStartDate).Days;

            if (dateCheck.Contains(newStartDate) || dateCheck.Contains(newEndDate))
            {
                MessageBox.Show("Booking already exists");
            }
            else if (daysBooking > 7)
            {
                MessageBox.Show("7 days is the max you can book for");
            }
            else if (daysBooking < 0)
            {
                MessageBox.Show("Start date needs to be before end date");
            }
            else if (comboBoxVans.Text.Equals(string.Empty))
            {
                MessageBox.Show("Please select a van first");
            }
            else
            {
                int nVanIndex = comboBoxVans.SelectedIndex;
                string nUser = comboBoxUsers.Text;

                fleet.AddBooking(nVanIndex, nUser, newStartDate, newEndDate);

                MessageBox.Show("Booking added");
                this.RefreshCalender();
            }
        }

        private void btnVanDetails_Click(object sender, EventArgs e)
        {
            VanDetails vanDetails = new VanDetails();

            // var used so that MainPage is frozen
            if (vanIndex != -1)
            {
                vanDetails.VanIndex = vanIndex;
            }            

            vanDetails.ShowDialog();
            int tVanIndex = comboBoxVans.SelectedIndex;
            string[] tempCurrentBooking = currentBooking;

            fleet = new Fleet();
            this.Refresh();
            this.PopulateListBox();
            this.startUpProcedure();

            if (tVanIndex >= comboBoxVans.Items.Count)
            {
                tVanIndex = comboBoxVans.Items.Count - 1;
            }
            comboBoxVans.SelectedIndex = tVanIndex;
            vanIndex = -1;
            

            btnAddBooking.Enabled = false;
            btnDelete.Enabled = false;
            btnAmend.Enabled = false;

            currentBooking = tempCurrentBooking;
        }
    }
}
