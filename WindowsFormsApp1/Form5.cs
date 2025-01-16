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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            comboBoxContent5.Items.AddRange(new string[]
            {
                "Пять тысяч рублей.\n",
                "Десять тысяч рублей.\n"
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxContent5.SelectedItem == null)
            {
                MessageBox.Show("Выберите элемент из ComboBox.");
                return;
            }
            // Получаем выбранный текст из ComboBox
            string selectedText = comboBoxContent5.SelectedItem.ToString();

            // Формируем итоговый текст
            string finalText = $"{"\t4) Соглосовать стоимость необходимых ресурсов с руководителем финансового отдела.\n\tИтог:"} {selectedText}";

            // Записываем в STRM.text по первому индексу
            STRM.text[3] = finalText;

            // Уведомляем пользователя
            MessageBox.Show($"Текст успешно записан в STRM.text[3]: {finalText}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void comboBoxContent5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = (char)Keys.None;
        }

        private void Form5_Shown(object sender, EventArgs e)
        {
            comboBoxContent5.Text = "Стоимость необходимых ресурсов...";
        }
    }
}
