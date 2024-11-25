namespace WinFormsArray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] student = new string[5];
            student[0] = "บิว";
            student[1] = "ต้นกล้วย";
            student[2] = "เอ็ม";
            student[3] = "เต๋า";
            student[4] = "แฟรงค์";
            string test = "";
            int n = student.Length; //หาขนาดของ อาร์เรย์
            for (int i = 0; i < n; i++)
            {
                test += student[i] + Environment.NewLine;// เขียนชื่อ พร้อมขึ้นบรรทัดใหม่ 

            }
            MessageBox.Show(test);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] Fruits = { "ส้ม", "กล้วย", "แอปเปิ้ล", "มะม่วง", "ทุเรียน", "องุ่น" };
            string myFruits = "";
            foreach (string str in Fruits)
            {
                myFruits += str + "  ,  ";
            }
            MessageBox.Show(myFruits, "ผลไม้ของฉัน");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines;//ในข้อมูลแต่ละบรรทัดไปใส่ในอาร์เรย์
            string result = "";
            foreach (string str in data)
            {
                if (str != "")
                {
                    result += str + Environment.NewLine;
                }

            }
            label1.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] data = textBox1.Lines;
            string result = "";
            int sum = 0;
            foreach (var str in data)
            {
                int x = 0;


                if (int.TryParse(str, out x))
                {
                    sum += x;
                    result += x.ToString() + Environment.NewLine;
                }
            }
            label1.Text = result;
            MessageBox.Show(sum.ToString(), "ผลรวมของตัวเลข");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[,] student = new string[3, 2];
            student[0, 0] = "บิว";
            student[0, 1] = "อุดรธานี";
            student[1, 0] = "เอ็ม";
            student[1, 1] = "สกลนคร";
            student[2, 0] = "โอปอ";
            student[2, 1] = "บึงกาฬ";
            string ResultData = "";
            int m = student.GetLength(0);
            int n = student.GetLength(1);
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    ResultData += student[i, j];
                    if (j < n - 1)
                    {
                        ResultData += "-";
                    }



                }
                ResultData += Environment.NewLine;

            }
            MessageBox.Show(ResultData, "แสดงข้อมูลใน Array 2 มิติ");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] Fruits = { "ส้ม", "กล้วย", "แอปเปิ้ล", "มะม่วง", "ทุเรียน", "องุ่น" };
            comboBox1.Items.AddRange(Fruits);
            listBox1.Items.AddRange(Fruits);
            checkedListBox1.Items.AddRange(Fruits);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = comboBox1.SelectedIndex.ToString() + "-";
            str += comboBox1.SelectedItem;
            MessageBox.Show(str);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = listBox1.SelectedIndex.ToString() + "-";
            str += listBox1.SelectedItem;
            MessageBox.Show(str);
        }
    }
}
