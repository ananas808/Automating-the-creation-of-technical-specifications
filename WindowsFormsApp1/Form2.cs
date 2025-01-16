using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            comboBoxContent.Items.AddRange(new string[]
            {
                "Реализовать программу, выполняющую весь необходимый функционал, исключая проблем подключения к серверу.\n",
                "Цель: , результат: ,проблема:\n"
            });
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxContent.SelectedItem == null)
            {
                MessageBox.Show("Выберите элемент из ComboBox.");
                return;
            }
            // Получаем выбранный текст из ComboBox
            string selectedText = comboBoxContent.SelectedItem.ToString();

            // Формируем итоговый текст
            string finalText = $"{"\t\tВсе способы связи указаны в соответствующих формах!\n\n\t1) Узнать цель, ожидаемый результат, проблемы при разработке у руководителя отдела.\n\tИтог:"} {selectedText}";

            // Записываем в STRM.text по первому индексу
            STRM.text[0] = finalText;

            // Уведомляем пользователя
            MessageBox.Show($"Текст успешно записан в STRM.text[0]: {finalText}");
        }
    

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxContent_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            comboBoxContent.Text = "Цель, результат, проблема...";
        }

    }
}
