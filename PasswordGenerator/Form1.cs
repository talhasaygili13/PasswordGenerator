using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }




    
        public static string GetRandomString(int length, IEnumerable<char> characterSet)
        {
       
            var characterArray = characterSet.Distinct().ToArray();


            var bytes = new byte[length * 8];
            var result = new char[length];
            using (var cryptoProvider = new RNGCryptoServiceProvider())
            {
                cryptoProvider.GetBytes(bytes);
            }
            for (int i = 0; i < length; i++)
            {
                ulong value = BitConverter.ToUInt64(bytes, i * 8);
                result[i] = characterArray[value % (uint)characterArray.Length];
            }
            return new string(result);
        }
        private void passwordSix_Click(object sender, EventArgs e)
        {
            PassSix();
        }

    

        private void passwordEight_Click(object sender, EventArgs e)
        {
            PassEight();
        }


        private void passTwelve_Click(object sender, EventArgs e)
        {
            PassTwelve();
        }

        private void PassSix()
        {
            password.Text = "Your new password is : " + GetRandomString(6, "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "abcdefghijklmnopqrstuvwxyz" +
                "0123456789" + "!'^%&/=?_-");
        }
        private void PassEight()
        {
            password.Text = "Your new password is : " + GetRandomString(8, "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                            "abcdefghijklmnopqrstuvwxyz" +
                            "0123456789" + "!'^%&/=?_-");
        }
        private void PassTwelve()
        {
            password.Text = "Your new password is : " + GetRandomString(12, "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                            "abcdefghijklmnopqrstuvwxyz" +
                            "0123456789" + "!'^%&/=?_-");
        }
  
    }
}
