namespace TinhCanChiNam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] canArr = { "Giáp", "Ất", "Bính", "Đinh", "Mậu", "Kỷ", "Canh", "Tân", "Nhâm", "Quý" };
            string[] chiArr = { "Tý", "Sửu", "Dần", "Mão", "Thìn", " Tỵ", "Ngọ", "Mùi", "Thân", "Dậu", "Tuất", "Hợi" };
            for (int i = 1900; i < 3000; i++) { list.Items.Add(i + ":" + canArr[i % 10] + " " + chiArr[i % 12]); }
        }
    }
}