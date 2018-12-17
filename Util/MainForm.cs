using LichKin.Utils.Security;
using System;
using System.Windows.Forms;

namespace Util
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            String primaryKey, publicKey;
            RSAUtils.Create(out primaryKey, out publicKey);
            primaryKeyXML.Text = primaryKey;
            publicKeyXML.Text = publicKey;
            primaryKeyPEM.Text = RSAUtils.XML2PEM(true, primaryKey);
            publicKeyPEM.Text = RSAUtils.XML2PEM(false, publicKey);

            publicKeyIn.Text = publicKey;
            primaryKeyIn.Text = primaryKey;
        }

        private void decryptTextIn_TextChanged(object sender, EventArgs e)
        {
            if ("".Equals(publicKeyIn.Text))
            {
                MessageBox.Show("没有输入公钥");
                decryptTextIn.Text = "";
                return;
            }
            encryptTextOut.Text = RSAUtils.Encrypt(publicKeyIn.Text, decryptTextIn.Text);
        }

        private void encryptTextIn_TextChanged(object sender, EventArgs e)
        {
            if ("".Equals(primaryKeyIn.Text))
            {
                MessageBox.Show("没有输入私钥");
                encryptTextIn.Text = "";
                return;
            }
            decryptTextOut.Text = RSAUtils.Decrypt(primaryKeyIn.Text, encryptTextIn.Text);
        }
    }
}
