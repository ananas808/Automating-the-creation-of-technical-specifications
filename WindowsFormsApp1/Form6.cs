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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            comboBoxContent6.Items.AddRange(new string[]
            {
                "<Соответствие> _______ руководитель Иванов И.И.\n"
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxContent6.SelectedItem == null)
            {
                MessageBox.Show("Выберите элемент из ComboBox.");
                return;
            }
            // Получаем выбранный текст из ComboBox
            string selectedText = comboBoxContent6.SelectedItem.ToString();

            // Формируем итоговый текст
            string finalText = $"{"\t6) Уточнить соответствие всех полученных данных у руководителя отдела.\n\tИтог:"} {selectedText}";

            // Записываем в STRM.text по первому индексу
            STRM.text[4] = finalText;

            // Уведомляем пользователя
            MessageBox.Show($"Текст успешно записан в STRM.text[4]: {finalText}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void comboBoxContent6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void Form6_Shown(object sender, EventArgs e)
        {
            comboBoxContent6.Text = "Соответствие всем требованиям...";
        }
    }
}
