using System.Runtime.InteropServices;

namespace sign_verify
{
    public partial class signverify : Form
    {
        public signverify()
        {
            InitializeComponent();
        }

        [DllImport("sign.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern bool signPdf(string privateKeychar, string pdfchar, string signaturechar);
        [DllImport("sign.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern bool verifySignature(string privateKeychar, string pdfchar, string signaturechar);

        private void BT_key_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the initial directory and filter
            openFileDialog.InitialDirectory = Application.StartupPath;

            // Show the OpenFileDialog and check if a file was selected
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the textBox_enc_publicKey to the selected file path
                TB_key.Text = openFileDialog.FileName;
            }
        }

        private void BT_pdf_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the initial directory and filter
            openFileDialog.InitialDirectory = Application.StartupPath;

            // Show the OpenFileDialog and check if a file was selected
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the textBox_enc_publicKey to the selected file path
                TB_pdf.Text = openFileDialog.FileName;
            }
        }

        private void BT_signature_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set the initial directory and filter
            openFileDialog.InitialDirectory = Application.StartupPath;

            // Show the OpenFileDialog and check if a file was selected
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the textBox_enc_publicKey to the selected file path
                TB_sign.Text = openFileDialog.FileName;
            }
        }

        private void BT_sign_Click(object sender, EventArgs e)
        {
            LB_result.Text = "";
            if (TB_key.Text == "" || TB_pdf.Text == "")
            {
                rTB_log.Text += "ERROR: Public key or PDF file not selected\n";
                return;
            }
            string fileContent = File.ReadAllText(TB_key.Text);
            if (fileContent.StartsWith("-----BEGIN PUBLIC KEY-----"))
            {
                rTB_log.Text += "ERROR: Please select a private key not a public key\n";
                return;
            }
            string filesign = (TB_sign.Text == "") ? TB_pdf.Text + ".sign" : TB_sign.Text;
            try
            {
                if (signPdf(TB_key.Text, TB_pdf.Text, filesign))
                {
                    rTB_log.Text += "SUCCESS: Signature created\n";
                    LB_result.ForeColor = Color.Green;
                    LB_result.Text = "SUCCESS";
                }
                else
                {
                    rTB_log.Text += "FALSE: Signature creation failed\n";
                    LB_result.ForeColor = Color.Red;
                    LB_result.Text = "FAILED";
                }
            }
            catch (Exception ex)
            {
                rTB_log.Text += "ERROR: " + ex.Message + "\n";
            }
        }

        private void BT_verify_Click(object sender, EventArgs e)
        {
            LB_result.Text = "";
            if (TB_key.Text == "" || TB_pdf.Text == "" || TB_sign.Text == "")
            {
                rTB_log.Text += "ERROR: Private key or PDF file or Signature file not selected\n";
                return;
            }
            string fileContent = File.ReadAllText(TB_key.Text);
            if (fileContent.Contains("PRIVATE KEY-----"))
            {
                rTB_log.Text += "ERROR: Please select a public key not a private key\n";
                return;
            }
            FileInfo fileInfo = new FileInfo(TB_sign.Text);
            if (fileInfo.Length == 0)
            {
                rTB_log.Text += "ERROR: Signature file is empty\n";
                return;
            }
            try
            {
                if (verifySignature(TB_key.Text, TB_pdf.Text, TB_sign.Text))
                {
                    rTB_log.Text += "SUCCESS: Signature verified\n";
                    LB_result.ForeColor = Color.Green;
                    LB_result.Text = "SUCCESS";
                }
                else
                {
                    rTB_log.Text += "FALSE: Signature verification failed\n";
                    LB_result.ForeColor = Color.Red;
                    LB_result.Text = "FAILED";
                }
            }
            catch (Exception ex)
            {
                rTB_log.Text += "ERROR: " + ex.Message + "\n";
            }
        }
    }
}
