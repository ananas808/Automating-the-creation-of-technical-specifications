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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            comboBoxContent3.Items.AddRange(new string[]
            {
                "Технология kotlin 1.9.10, от Android 8, ограничения отсутствуют.\n",
                "Требуемые технологии: , совместимость, ограничения:\n"
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxContent3.SelectedItem == null)
            {
                MessageBox.Show("Выберите элемент из ComboBox.");
                return;
            }
            // Получаем выбранный текст из ComboBox
            string selectedText = comboBoxContent3.SelectedItem.ToString();

            // Формируем итоговый текст
            string finalText = $"{"\t3) Узнать требуемые технологии, совместимость, ограничения у главного разработчика.\n\tИтог:"} {selectedText}";

            // Записываем в STRM.text по первому индексу
            STRM.text[2] = finalText;

            // Уведомляем пользователя
            MessageBox.Show($"Текст успешно записан в STRM.text[2]: {finalText}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void comboBoxContent3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void Form4_Shown(object sender, EventArgs e)
        {
            comboBoxContent3.Text = "Требования, совместимость, ограничения...";
        }
    }
}
