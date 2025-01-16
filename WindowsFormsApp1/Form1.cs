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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        Form2 newForm2 = new Form2();

        private void button1_Click(object sender, EventArgs e)
        {
            newForm2.ShowDialog();
            changeButtonEnable2();
        }

        private void changeButtonEnable2()
        {
            button2.Enabled = true;
        }
        Form3 newForm3 = new Form3();

        private void button2_Click(object sender, EventArgs e)
        {
            newForm3.ShowDialog();
            changeButtonEnable3();
        }
        private void changeButtonEnable3()
        {
            button3.Enabled = true;
        }
        Form4 newForm4 = new Form4();

        private void button3_Click(object sender, EventArgs e)
        {
            newForm4.ShowDialog();
            changeButtonEnable4();
        }
        private void changeButtonEnable4()
        {
            button4.Enabled = true;
        }
        Form5 newForm5 = new Form5();
        private void button4_Click(object sender, EventArgs e)
        {
            newForm5.ShowDialog();
            changeButtonEnable5();
        }
        private void changeButtonEnable5()
        {
            button5.Enabled = true;
        }
        Form6 newForm6 = new Form6();
        private void button5_Click(object sender, EventArgs e)
        {
            newForm6.ShowDialog();
            changeButtonEnable6();
        }
        private void changeButtonEnable6()
        {
            button6.Enabled = true;
        }
        Form7 newForm7 = new Form7();
        private void button6_Click(object sender, EventArgs e)
        {
            newForm7.ShowDialog();
            changeButtonEnable7();
        }
        private void changeButtonEnable7()
        {
            button7.Enabled = true;
        }
        Form8 newForm8 = new Form8();
        private void button7_Click(object sender, EventArgs e)
        {
            newForm8.ShowDialog();
            changeButtonEnable9();
        }
        private void changeButtonEnable9()
        {
            button10.Enabled = true;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Вызов метода сохранения с выбором пути
            FileHandler.SaveSTRMWithDialog();
        }
        public void SetValue(int index, string value)
        {
            if (index >= 0 && index < STRM.text.Length)
            {
                STRM.text[index] = value;
            }
            else
            {
                MessageBox.Show("Индекс выходит за пределы массива");
            }
        }

        // Метод для отображения содержимого массива
        public void ShowArray()
        {
            string arrayContents = string.Join(", ", STRM.text.Select(x => x ?? "null"));
            MessageBox.Show($"Текущий массив: {arrayContents}");
        }
        public static class FileHandler
        {
            public static void SaveSTRMToFile(string filePath)
            {
                try
                {
                    // Заменяем null на "Пусто" и записываем каждую строку в файл
                    File.WriteAllLines(filePath, STRM.text.Select(item => item ?? "Пусто"));
                    MessageBox.Show($"Содержимое STRM успешно сохранено в файл: {filePath}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}");
                }
            }
            public static void SaveSTRMWithDialog()
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Text Files (*.doc)|*.doc|All Files (*.*)|*.*";
                    saveFileDialog.DefaultExt = "doc";
                    saveFileDialog.Title = "Сохранить содержимое STRM";
                    saveFileDialog.FileName = "STRM_Output.doc";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        SaveSTRMToFile(saveFileDialog.FileName);
                    }
                }
            }
        }
    }
    class STRM
    {
        static public string[] text = new string[7];
    }
}
