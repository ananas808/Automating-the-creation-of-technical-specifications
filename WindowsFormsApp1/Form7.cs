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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            comboBoxContent7.Items.AddRange(new string[]
            {
                "Подготовил техническое задание _______ исполнитель Сидоров А.Н.\n"
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxContent7.SelectedItem == null)
            {
                MessageBox.Show("Выберите элемент из ComboBox.");
                return;
            }
            // Получаем выбранный текст из ComboBox
            string selectedText = comboBoxContent7.SelectedItem.ToString();

            // Формируем итоговый текст
            string finalText = $"{"\t7) Подготовить техническое задание.\n\tИтог:"} {selectedText}";

            // Записываем в STRM.text по первому индексу
            STRM.text[5] = finalText;

            // Уведомляем пользователя
            MessageBox.Show($"Текст успешно записан в STRM.text[5]: {finalText}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void comboBoxContent7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void Form7_Shown(object sender, EventArgs e)
        {
            comboBoxContent7.Text = "Подготовить технического задания...";
        }
    }
}
