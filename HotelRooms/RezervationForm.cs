using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelRooms
{
    public partial class RezervationForm : Form
    {
        private Reception reception = new Reception();

        public RezervationForm()
        {
            InitializeComponent();
        }

        private void btnShowEmptyRooms_Click(object sender, EventArgs e)
        {
            dgvEmptyRooms.DataSource = reception.GetEmptyRooms(dtpRezervationDate.Value.Date);
        }

        private void btnMakeRezervation_Click(object sender, EventArgs e)
        {
            reception.MakeReservation(dgvEmptyRooms.CurrentRow.DataBoundItem as HotelRoom, dtpRezervationDate.Value.Date);

            dgvEmptyRooms.DataSource = reception.GetEmptyRooms(dtpRezervationDate.Value.Date);
        }
    }
}
