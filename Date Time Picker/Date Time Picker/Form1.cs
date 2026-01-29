using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Date_Time_Picker
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = Convert.ToDateTime("06 09 2003 02:00:00 PM"); // başlangıç tarihini belirleyebiliyorum bu şekilde
            dateTimePicker1.Value = DateTime.Now.AddDays(-5);  // şu anki günden 5 gün gerisini gösterir
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dateTimePicker1.Checked == true)
            {
                //veri tabanına ayrılma tarihi eklenebilir
                MessageBox.Show("Personel İşten Ayrılmıştır");
            }
        }
    }
}
