using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Dmitri16
{
    public partial class Work16 : Form
    {
        public Work16()
        {
            InitializeComponent(); // Инициализация компонентов формы
        }

        public int Vvodtext = 1; // Флаг для контроля первого изменения текста в InputText

        // Обработчик клика по пункту меню "отображатьтекст"
        private void отображатьтекстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                // Переключение состояния пункта меню (флажок)
                отображатьтекстToolStripMenuItem.Checked = !отображатьтекстToolStripMenuItem.Checked;
                // Отображение или скрытие label1 в зависимости от состояния пункта меню
                label1.Visible = отображатьтекстToolStripMenuItem.Checked;
            }
        }

        // Обработчик клика по label1 (пустой, не реализован)
        private void label1_Click(object sender, EventArgs e)
        {

        }

        // Обработчик клика по пункту меню "отображатьВвод"
        private void отображатьВводToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Переключение состояния пункта меню
            отображатьВводToolStripMenuItem.Checked = !отображатьВводToolStripMenuItem.Checked;
            // Отображение или скрытие элемента InputText в зависимости от состояния пункта меню
            InputText.Visible = отображатьВводToolStripMenuItem.Checked;
        }

        // Обработчик изменения текста в InputText
        private void InputText_TextChanged(object sender, EventArgs e)
        {
            if (Vvodtext == 1)
            {
                InputText.Text = ""; // Очищает поле ввода при первом изменении
                Vvodtext = 0; // Снимает флаг, чтобы очистка происходила только один раз
            }
        }

        // Обработчик события загрузки формы (пустой, не реализован)
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Обработчик изменения состояния radioButton3
        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            видимостьToolStripMenuItem.Visible = true; // Показывает пункт меню "видимость"
        }

        // Обработчик клика по пункту меню "видимость" (пустой, не реализован)
        private void видимостьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        // Обработчик изменения состояния radioButton4
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            видимостьToolStripMenuItem.Visible = false; // Скрывает пункт меню "видимость"
        }

        // Обработчик клика по пункту меню "отображатьКнопкиУправления"
        private void отображатьКнопкиУправленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Переключает состояние пункта меню с флажком
            отображатьКнопкиУправленияToolStripMenuItem.Checked = !отображатьКнопкиУправленияToolStripMenuItem.Checked;
            // Показывает или скрывает radioButton3 и radioButton4 согласно состоянию пункта меню
            radioButton3.Visible = отображатьКнопкиУправленияToolStripMenuItem.Checked;
            radioButton4.Visible = отображатьКнопкиУправленияToolStripMenuItem.Checked;
        }

        // Обработчик изменения состояния checkBox1
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Application.Exit(); // Завершение работы приложения при изменении состояния чекбокса
        }

    }
}
