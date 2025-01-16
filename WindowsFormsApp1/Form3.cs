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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            comboBoxContent2.Items.AddRange(new string[]
            {
                "Использование широким кругом лиц, обозревать новости, иметь возможность включить выпадающие субтитры.\n",
                "Использование: , функции: , требования:\n"
            });
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (comboBoxContent2.SelectedItem == null)
            {
                MessageBox.Show("Выберите элемент из ComboBox.");
                return;
            }
            // Получаем выбранный текст из ComboBox
            string selectedText = comboBoxContent2.SelectedItem.ToString();

            // Формируем итоговый текст
            string finalText = $"{"\t2) Cогласовать использование, функции, требования со специалистом обслуживания.\n\tИтог:"} {selectedText}";

            // Записываем в STRM.text по первому индексу
            STRM.text[1] = finalText;

            // Уведомляем пользователя
            MessageBox.Show($"Текст успешно записан в STRM.text[1]: {finalText}");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxContent2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void Form3_Shown(object sender, EventArgs e) 
        {
            comboBoxContent2.Text = "Использование, функции, требования...";
        }
    }
}
