using DataGridAvto.Framework.Contracts.Models;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace DataGridAvto
{
    public partial class AvtoForm : Form
    {
        private Avto avto;
        public AvtoForm(Avto avto = null)
        {
            this.avto = avto == null
                ? DataGenerator.CreateAvto(x =>
                {
                    x.Id = Guid.NewGuid();
                    x.Mark = Mark.Hunday_Creta;
                })
                : new Avto
                {
                    Id = avto.Id,
                    Number = avto.Number,
                    Probeg = avto.Probeg,
                    AvgFuelCons = avto.AvgFuelCons,
                    CurrFuel = avto.CurrFuel,
                    CostRent = avto.CostRent,
                    FuelReserve = avto.FuelReserve,
                    RentalAmount = avto.RentalAmount,
                };

            InitializeComponent();

            foreach (var item in Enum.GetValues(typeof(Mark)))
            {
                comboBox1.Items.Add(item);
            }
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }

            comboBox1.AddBinding(x => x.SelectedItem, this.avto, x => x.Mark);
            textBox1.AddBinding(x => x.Text, this.avto, x => x.Number, errorProvider1);
            textBox2.AddBinding(x => x.Text, this.avto, x => x.Probeg, errorProvider1);
            textBox3.AddBinding(x => x.Text, this.avto, x => x.AvgFuelCons, errorProvider1);
            textBox4.AddBinding(x => x.Text, this.avto, x => x.CurrFuel, errorProvider1);
            textBox5.AddBinding(x => x.Text, this.avto, x => x.CostRent, errorProvider1);
            textBox6.AddBinding(x => x.Text, this.avto, x => x.FuelReserve, errorProvider1);
            textBox7.AddBinding(x => x.Text, this.avto, x => x.RentalAmount, errorProvider1);
        }

        public Avto Avto => avto;

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.Graphics.FillEllipse(Brushes.Red,
                new Rectangle(e.Bounds.X + 2, e.Bounds.Y + 2, e.Bounds.Height - 4, e.Bounds.Height - 4));
            if (e.Index > -1)
            {
                var value = (Mark)(sender as ComboBox).Items[e.Index];
                e.Graphics.DrawString(GetDisplayValue(value),
                    e.Font,
                    new SolidBrush(e.ForeColor),
                    e.Bounds.X + 20,
                    e.Bounds.Y);
            }
        }

        private string GetDisplayValue(Mark value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attributes = field.GetCustomAttributes<DescriptionAttribute>(false);
            return attributes.FirstOrDefault()?.Description ?? "ММ";
        }

        private void AvtoForm_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(Pens.Silver, 0, 0, Width, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if

            DialogResult= DialogResult.OK;
            Close();
        }
    }
}
