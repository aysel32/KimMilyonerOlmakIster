namespace UserForms
{
    public partial class FrmUserAdd : Form
    {
        public FrmUserAdd()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtNickName.Text=="")
            {
                MessageBox.Show("Nick Name boþ geçilemez");
            }
            else
            {
                MessageBox.Show(txtNickName.Text);
            }


            lblUyariNick.Visible = true;
            lblUyariSoyad.Visible = true;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}