
using System.Runtime.InteropServices;
namespace TBL_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public const int WM_NCLBUTTONDOWN = 0x00A1;
        public const int HT_CAPTION = 0x02;


        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel<Form2>();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;

            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }


        private void AbrirFormNoPanel<T>() where T : Form, new()
        {
            Form formulario = new T();
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            panelConteudo.Controls.Clear();
            panelConteudo.Controls.Add(formulario);
            formulario.Show();


        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new Formvendas());
        }




        private void AbrirForm(Form form)
        {
            panelConteudo.Controls.Clear();

            form.TopLevel = false;

            form.FormBorderStyle = FormBorderStyle.None;

            form.Dock = DockStyle.Fill;

            panelConteudo.Controls.Add(form);

            form.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            AbrirForm(new Formprodutos());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirForm(new Formrelatorio());
        }
    }

}