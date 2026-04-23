namespace кофейня
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || textBox1.Text == "0 тг.")
            {
                MessageBox.Show("Сначала выберите что-нибудь в меню!");
            }
            else
            {
                // Вывод сообщения об оплате в textBox2 (который снизу)
                textBox2.Text = "Спасибо за покупку! До свидания!";
                MessageBox.Show("Оплата прошла успешно!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double total = 0;

            if (checkBox1.Checked) total += 600;  // Американо
            if (checkBox2.Checked) total += 800;  // Капучино
            if (checkBox3.Checked) total += 900;  // Латте

            // --- Блок добавок (теперь тоже на CheckBox) ---
            if (checkBox4.Checked) total += 150; // Ореховый сироп
            if (checkBox5.Checked) total += 150; // Шоколадный сироп
            if (checkBox6.Checked) total += 150; // Банановый сироп
            if (checkBox7.Checked) total += 50;  // Сахар
            if (checkBox8.Checked) total += 200; // Маршмеллоу

            // Выводим результат в textBox1 (предположим, это поле для цены на 2 вкладке)
            textBox1.Text = total.ToString() + " тг.";

            // Переход на вторую вкладку (индекс 1)
            tabControl1.SelectedIndex = 1;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
