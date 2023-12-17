using System.Windows.Forms;
using System;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_ShowStats(object sender, EventArgs e)
        {
            var selected = listView1.SelectedItems[0].Text;
            using (DataContext conect = new DataContext())
            {
                ShowStats stats = new ShowStats(selected);
                stats.Show();
            }
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            DataContext conect = new DataContext();
            string name = textBox1.Text;
            string description_ability = textBox2.Text;
            int place = Int16.Parse(textBox3.Text);
            if (listBox2.SelectedIndex == 0)
            {
                if (listBox1.SelectedIndex == 0)
                {
                    Silver_Augment silver = new Silver_Augment();
                    silver.Name = name;
                    silver.Description = description_ability;
                    silver.Place = place;
                    silver.IsSilver = true;
                    conect.SilverAugments.Add(silver);
                }
                else if (listBox1.SelectedIndex == 1)
                {
                    Gold_Augment gold = new Gold_Augment();
                    gold.Name = name;
                    gold.Description = description_ability;
                    gold.Place = place;
                    gold.IsGold = true;
                    conect.GoldAugments.Add(gold);
                }
                else if (listBox1.SelectedIndex == 2)
                {
                    Prismatic_Augment prismatic = new Prismatic_Augment();
                    prismatic.Name = name;
                    prismatic.Description = description_ability;
                    prismatic.Place = place;
                    prismatic.IsPrismatic = true;
                    conect.PrismaticAugments.Add(prismatic);
                }
            }
            else if (listBox2.SelectedIndex == 1)
            {
                Unit unit = new Unit();
                unit.Name = name;
                unit.Ability = description_ability;
                unit.Place = place;
                conect.Units.Add(unit);
            }
            else if (listBox2.SelectedIndex == 2)
            {
                Trait trait = new Trait();
                trait.Name = name;
                trait.Description = description_ability;
                trait.Place = place;
                conect.Traits.Add(trait);
            }

            conect.SaveChanges();
            MessageBox.Show("Succesvol toegevoegd aan database!");
        }
    }
}
