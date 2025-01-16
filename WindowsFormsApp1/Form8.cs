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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            comboBoxContent8.Items.AddRange(new string[]
            {
                "<Утверждение> _______ руководитель Иванов И.И.\n"
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxContent8.SelectedItem == null)
            {
                MessageBox.Show("Выберите элемент из ComboBox.");
                return;
            }
            // Получаем выбранный текст из ComboBox
            string selectedText = comboBoxContent8.SelectedItem.ToString();

            // Формируем итоговый текст
            string finalText = $"{"\t8) Утвердить техническое задание у руководителя.\n\tИтог:"} {selectedText}";

            // Записываем в STRM.text по первому индексу
            STRM.text[6] = finalText;

            // Уведомляем пользователя
            MessageBox.Show($"Текст успешно записан в STRM.text[6]: {finalText}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void comboBoxContent8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void Form8_Shown(object sender, EventArgs e)
        {
            comboBoxContent8.Text = "Утверждение ТЗ...";
        }
    }
}
