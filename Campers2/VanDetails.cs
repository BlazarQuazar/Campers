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
    public partial class VanDetails : Form
    {
        Bookings bookings = new Bookings();
        Fleet vansInFleet = new Fleet();
        public int VanIndex = 0;
        int maxVanIndex;

        public VanDetails()
        {
            InitializeComponent();
        }

        private void VanDetails_Load(object sender, EventArgs e)
        {
            this.UpdateTextBoxes();

        }

        private void UpdateTextBoxes()
        {
            maxVanIndex = vansInFleet.RetrunNumberOfVansInFleet()-1;
            string[] tempVanDetails = vansInFleet.ReturnVanInfoFromIndex(VanIndex).Split('\t'); ;
            txtBoxVanName.Text = tempVanDetails[0];
            txtBoxRegistration.Text = tempVanDetails[1];
            txtBoxNoOfOccupants.Text = tempVanDetails[2];

            if(VanIndex.Equals(0))
            {
                btnNext.Enabled = true;
                btnPrevious.Enabled = false;
                
            }
            else if (VanIndex.Equals(maxVanIndex))
            {
                btnNext.Enabled = false;
                btnPrevious.Enabled = true;
            }
            else
            {
                btnNext.Enabled = true;
                btnPrevious.Enabled = true;
            }

            BtnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (vansInFleet.ContainsVan(txtBoxVanName.Text, txtBoxRegistration.Text))
            {
                MessageBox.Show("Van with these details already exists");
            }
            else
            {
                vansInFleet.AddVan(txtBoxVanName.Text, txtBoxRegistration.Text, Convert.ToInt32(txtBoxNoOfOccupants.Text));
                VanIndex = maxVanIndex + 1;
                UpdateTextBoxes();
                MessageBox.Show("Van added!");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (bookings.DoesVanHaveBookings(txtBoxVanName.Text))
            {
                MessageBox.Show("Van has bookings, cannot delete van that has bookings");
            }
            else
            {
                vansInFleet.DeleteVan(VanIndex);
                MessageBox.Show("Van deleted");
                if (VanIndex > 0)
                {
                    VanIndex--;
                }
                this.UpdateTextBoxes();
            }

        }

        private void btnAmend_Click(object sender, EventArgs e)
        {
            bookings.ChangeBookingsVanName(vansInFleet.VanNameFromIndex(VanIndex), txtBoxVanName.Text);
            vansInFleet.AmendVan(VanIndex, txtBoxVanName.Text, txtBoxRegistration.Text, Convert.ToInt32(txtBoxNoOfOccupants.Text));
            MessageBox.Show("Van name amended successfully");
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            VanIndex--;
            this.UpdateTextBoxes();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            VanIndex++;
            this.UpdateTextBoxes();
        }

        private void txtBoxVanName_TextChanged(object sender, EventArgs e)
        {
            BtnDelete.Enabled = false;
        }

        private void txtBoxRegistration_TextChanged(object sender, EventArgs e)
        {
            BtnDelete.Enabled = false;
        }

        private void txtBoxNoOfOccupants_TextChanged(object sender, EventArgs e)
        {
            BtnDelete.Enabled = false;
        }
    }
}
