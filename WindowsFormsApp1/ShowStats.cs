using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ShowStats : Form
    {
        DataContext dataContext = new DataContext();
        public ShowStats(string tabel)
        {
            InitializeComponent();
            if (tabel == "Units") 
            {
                var units = dataContext.Units.ToList();
                dataGridView1.Rows.Clear();
                foreach (var unit in units)
                {
                    dataGridView1.Rows.Add(unit.Name, unit.Ability, unit.Place, null);
                }
            }
            else if (tabel == "Traits")
            {
                var traits = dataContext.Traits.ToList();
                dataGridView1.Rows.Clear();
                foreach (var trait in traits)
                {
                    dataGridView1.Rows.Add(trait.Name, trait.Description, trait.Place, null);
                }
            }
            else if (tabel == "Silver Augments")
            {
                var augments = dataContext.SilverAugments.ToList();
                dataGridView1.Rows.Clear();
                foreach (var augment in augments)
                {
                    dataGridView1.Rows.Add(augment.Name, augment.Description, augment.Place, "Silver");
                }
            }
            else if (tabel == "Gold Augments")
            {
                var augments = dataContext.GoldAugments.ToList();
                dataGridView1.Rows.Clear();
                foreach (var augment in augments)
                {
                    dataGridView1.Rows.Add(augment.Name, augment.Description, augment.Place, "Gold");
                }
            }
            else if (tabel == "Prismatic Augments")
            {
                var augments = dataContext.PrismaticAugments.ToList();
                dataGridView1.Rows.Clear();
                foreach (var augment in augments)
                {
                    dataGridView1.Rows.Add(augment.Name, augment.Description, augment.Place, "Prismatic");
                }
            }
        }
        
        private void ShowStats_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
