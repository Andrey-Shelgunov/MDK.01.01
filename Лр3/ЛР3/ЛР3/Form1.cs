using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР3
{
    public partial class Form1: Form
    {
           Dictionary<string, List<string>> ClotsGroups; // Словарь для хранения групп медикаментов и их списка 

            Dictionary<string, Dictionary<string, int>> ClotsSelected = new Dictionary<string, Dictionary<string, int>>();
        // Словарь для хранения выбранных медикоментов и их количества
        public Form1()
        {
            InitializeComponent();
            InitializeMedication();
            InitializeData();
        }

        private void InitializeMedication()
        {
            ClotsGroups = new Dictionary<string, List<string>>
            {
                { "Футболки", new List<string>{ "Abibas", "Спортивная", "Без рукавов" } },
                { "Ботинки", new List<string>{ "Туфли", "Кеды", "Кросовки" } },
                { "Штаны", new List<string>{ "Джинсы", "Спортивные", "Брюки" } }
            };

            foreach (var group in ClotsGroups.Keys)
            {
                ClotsSelected[group] = new Dictionary<string, int>();
            }
        }
        private void InitializeData()
        {
            foreach (var group in ClotsGroups.Keys)
            {
                listBox_groups.Items.Add(group);
            }

            listBox_groups.SelectedIndexChanged += listBox_groups_SelectedIndexChanged;
            button_AddToZakaz.Click += button_AddToZakaz_Click;
        }
        private void listBox_groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectionPanel_flowLayoutPanel.Controls.Clear();

            string SelectedGroup = listBox_groups.SelectedItem.ToString();

            foreach (var med in ClotsGroups[SelectedGroup])
            {
                CheckBox checkBox = new CheckBox { Text = med };
                NumericUpDown numericUpDown = new NumericUpDown { Minimum = 0, Maximum = 100, Width = 50 };

                if (ClotsSelected[SelectedGroup].ContainsKey(med))
                {
                    numericUpDown.Value = ClotsSelected[SelectedGroup][med];
                    checkBox.Checked = true;
                }
                // Обработчик изменения состояния CheckBox
                checkBox.CheckedChanged += (s, ev) =>
                {
                    if (checkBox.Checked)
                    {
                        ClotsSelected[SelectedGroup][med] = (int)numericUpDown.Value;
                    }
                    else
                    {
                        ClotsSelected[SelectedGroup].Remove(med);
                    }
                };

                // Обработчик изменения значения NumericUpDown
                numericUpDown.ValueChanged += (s, ev) =>
                {
                    if (checkBox.Checked)
                    {
                        ClotsSelected[SelectedGroup][med] = (int)numericUpDown.Value;
                    }
                };

                SelectionPanel_flowLayoutPanel.Controls.Add(checkBox);
                SelectionPanel_flowLayoutPanel.Controls.Add(numericUpDown);
            }

        }

        private void button_AddToZakaz_Click(object sender, EventArgs e)
        {
            string order = "";
            foreach (string group in ClotsGroups.Keys)
            {
                order += $"{group}:\n";
                if (ClotsSelected[group].Count > 0)
                {
                    foreach (var med in ClotsSelected[group])
                    {
                        order += $"- {med.Key} x {med.Value}\n";
                    }
                }
                else
                {

                    order += "- \n"; // Если блюда нет, то прочерк
                }

            }

            richTextBox1.Text = order;

        }
    }
}
