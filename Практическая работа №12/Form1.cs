using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практическая_работа__12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
                DateTime dateTime = DateTime.Now;
                statusStrip1.Items[0].Text = Convert.ToString(10);
                statusStrip1.Items[1].Text = dateTime.ToString("dd:MM:yyyy");
                statusStrip1.Items[2].Text = dateTime.ToString("HH:mm");
            
            
        }

        Zadanie zadanie = new Zadanie();

        //Кнопка найти
        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                double A = Convert.ToInt32(txtA.Text);
                double B = Convert.ToInt32(txtB.Text);
                double C = Convert.ToInt32(txtC.Text);
                txtCountAC.Text = Convert.ToString(zadanie.LengthOtrAC(A, C));
                txtCountBC.Text = Convert.ToString(zadanie.LengthOtrBC(B, C));
                txtSum.Text = Convert.ToString(zadanie.SumOtr(A, B, C));
            }
            catch
            {
                MessageBox.Show("Введите числа",caption: "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            txtA.Focus();

            // очищать результаты при изменении исход
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtCountAC.Clear();
            txtCountBC.Clear();
            txtSum.Clear();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                int N = Convert.ToInt32(txtSecond.Text);
                txtMinute.Text = Convert.ToString(zadanie.Time(N));
            }
            catch
            {
                MessageBox.Show("Введите секунды", caption: "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            txtSecond.Focus();
        }

        private void btnClearTime_Click(object sender, EventArgs e)
        {
            txtSecond.Clear();
            txtMinute.Clear();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Даны три точки A, B, C на числовой оси. \n" +
         "Найти длины отрезков AC и BC и их сумму.\n" +
         "2. С начала суток прошло N секунд (N — целое).\n" +
         "Найти количество полных минут, прошедших сначала последнего часа.\n", caption: "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtA_TextChanged(object sender, EventArgs e)
        {
            txtCountAC.Clear();
            txtCountBC.Clear();
            txtSum.Clear();
        }

        private void TxtSecond_TextChanged(object sender, EventArgs e)
        {
            txtMinute.Clear();
        }


        //Для размещения двух заданий в одной программе использовать панель закладок.
        //8. Разбить форму на 2 группы: исходные данные, результат.  
        //9. Предусмотреть в программе две кнопки «Выход» и «О программе». 
        //10. Использовать меню. 
        //11. Создать строку статуса 3 элемента: номер задачи, дата и время.
        //12. Использовать контекстное меню для блоков «Исходные данные» и «Результат». 
        //13. При наличии кнопки «Рассчитать», она должна передавать фокус первому элементу блока «Исходные данные».
        //14. !!!При изменении исходных данных очищать поле результата.  
        //15. При отсутствии исходных данных при расчете вывести уведомление.
        //16. Оформить: заголовок, подсказки, иконки на форму и значок файла. 
        //17. Обеспечить неизменяемость границ основного окна. 
        //Реализовать расчет задачи: 
        //1. Даны три точки A, B, C на числовой оси. 
        //Найти длины отрезков AC и BC и их сумму. 
        //2. С начала суток прошло N секунд (N — целое). 
        //Найти количество полных минут, прошедших сначала последнего часа. 
    }
}
