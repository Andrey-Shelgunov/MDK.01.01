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
           Dictionary<string, List<string>> medicationGroups; // Словарь для хранения групп медикаментов и их списка 

            Dictionary<string, Dictionary<string, int>> medicationsSelected = new Dictionary<string, Dictionary<string, int>>();
        // Словарь для хранения выбранных медикоментов и их количества
        public Form1()
        {
            InitializeComponent();
            InitializeMedication();
            InitializeData();
        }

        private void InitializeMedication()
        {
            medicationGroups = new Dictionary<string, List<string>>
            {
                { "Обезболы", new List<string>{ "Морфин", "Немисил", "Какой-то обезбол" } },
                { "От горла", new List<string>{ "пропосол", "фурацилин", "гексорал" } },
                { "Остальное", new List<string>{ "уголь активированный", "уголь не активированный", "уголь неправильно активированный" } }
            };

            foreach (var group in medicationGroups.Keys)
            {
                medicationsSelected[group] = new Dictionary<string, int>();
            }
        }
        private void InitializeData()
        {
            foreach (var group in medicationGroups.Keys)
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

            foreach (var med in medicationGroups[SelectedGroup])
            {
                CheckBox checkBox = new CheckBox { Text = med };
                NumericUpDown numericUpDown = new NumericUpDown { Minimum = 0, Maximum = 100, Width = 50 };

                if (medicationsSelected[SelectedGroup].ContainsKey(med))
                {
                    numericUpDown.Value = medicationsSelected[SelectedGroup][med];
                    checkBox.Checked = true;
                }
                // Обработчик изменения состояния CheckBox
                checkBox.CheckedChanged += (s, ev) =>
                {
                    if (checkBox.Checked)
                    {
                        medicationsSelected[SelectedGroup][med] = (int)numericUpDown.Value;
                    }
                    else
                    {
                        medicationsSelected[SelectedGroup].Remove(med);
                    }
                };

                // Обработчик изменения значения NumericUpDown
                numericUpDown.ValueChanged += (s, ev) =>
                {
                    if (checkBox.Checked)
                    {
                        medicationsSelected[SelectedGroup][med] = (int)numericUpDown.Value;
                    }
                };

                SelectionPanel_flowLayoutPanel.Controls.Add(checkBox);
                SelectionPanel_flowLayoutPanel.Controls.Add(numericUpDown);
            }

        }

        private void button_AddToZakaz_Click(object sender, EventArgs e)
        {
            string order = "";
            foreach (string group in medicationGroups.Keys)
            {
                order += $"{group}:\n";
                if (medicationsSelected[group].Count > 0)
                {
                    foreach (var med in medicationsSelected[group])
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
