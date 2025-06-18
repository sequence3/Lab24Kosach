
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Windows.Forms.VisualStyles;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_24
{
    public partial class Form1 : Form
    {
        private md3 md3Hasher;
        private khafre khafreEncryptor;
        private OngSchnorrShamir ongEncryptor;
        private CancellationTokenSource cancellationTokenSourceKHAFRE;
        private CancellationTokenSource cancellationTokenSourceMD3;
        private CancellationTokenSource cancellationTokenSourceONG;

        public Form1()
        {
            InitializeComponent();
            khafreEncryptor = new khafre();
            md3Hasher = new md3();
            ongEncryptor = new OngSchnorrShamir();
        }

        // ������ �� ������� ������ ����
        private async void button1_Click_1(object sender, EventArgs e)
        {
            cancellationTokenSourceKHAFRE = new CancellationTokenSource();
            await RunKHAFRE(textBox1.Text, cancellationTokenSourceKHAFRE.Token);
        }

        // ������ �� ������� ������ ����
        private void button2_Click(object sender, EventArgs e)
        {
            cancellationTokenSourceKHAFRE?.Cancel();
        }

        // ����� �� ������ ���������� ������
        private async Task RunKHAFRE(string input, CancellationToken cancellationToken)
        {
            try
            {
                AppendToStatus("������ ��������� KHAFRE...");

                while (!cancellationToken.IsCancellationRequested)
                {
                    await Task.Delay(1000, cancellationToken);

                    byte[] plaintextBytes = Encoding.UTF8.GetBytes(input);

                    byte[] ciphertext = khafreEncryptor.Encrypt(plaintextBytes);

                    string ciphertextHex = BitConverter.ToString(ciphertext).Replace("-", "");

                    textBox2.Text = ciphertextHex;
                }

                AppendToStatus("���������� ���������.");
            }
            catch (OperationCanceledException)
            {
                textBox2.Text = "�������� ��������.";
                AppendToStatus("");
            }
        }

        // �����,�� ���� ����������� ��� ������� ������
        private void AppendToStatus(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AppendToStatus), message);
                return;
            }
            textBox2.AppendText(message + Environment.NewLine);
        }

        // ������ �� ������� ������ ����
        private async void button3_Click(object sender, EventArgs e)
        {
            cancellationTokenSourceMD3 = new CancellationTokenSource();
            await RunMD3(textBox1.Text, cancellationTokenSourceMD3.Token);
        }

        // ������ �� ������� ������ ����
        private void button4_Click(object sender, EventArgs e)
        {
            cancellationTokenSourceMD3?.Cancel();
        }

        // ����� �� ������ ��������� ������ MD-3
        private async Task RunMD3(string input, CancellationToken cancellationToken)
        {
            try
            {
                AppendToStatus2("������ ��������� MD-3...");

                while (!cancellationToken.IsCancellationRequested)
                {
                    await Task.Delay(1000, cancellationToken);

                    byte[] inputBytes = Encoding.UTF8.GetBytes(input);

                    byte[] hash = md3Hasher.Hash(inputBytes);

                    string hashHex = BitConverter.ToString(hash).Replace("-", "");

                    textBox4.Text = hashHex;
                }

                AppendToStatus2("���������� ���������.");
            }
            catch (OperationCanceledException)
            {
                textBox4.Text = "�������� ��������.";
                AppendToStatus2("");
            }
        }

        // �����,�� ���� ����������� ��� ������� ������
        private void AppendToStatus2(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AppendToStatus2), message);
                return;
            }
            textBox4.AppendText(message + Environment.NewLine);
        }

        // ������, �� ������� ����� ������
        private async void button5_Click(object sender, EventArgs e)
        {
            cancellationTokenSourceKHAFRE = new CancellationTokenSource();
            await RunONG(textBox5.Text, cancellationTokenSourceKHAFRE.Token);
        }

        // �����, �� ������ ONG-Schnorr-Shamir ����������
        private async Task RunONG(string input, CancellationToken cancellationToken)
        {
            try
            {
                AppendToStatus3("������ ��������� ONG-Schnorr-Shamir...");

                while (!cancellationToken.IsCancellationRequested)
                {
                    // �������� �� 1000 �� ����� ������ ���������
                    await Task.Delay(1000, cancellationToken);

                    byte[] plaintextBytes = Encoding.UTF8.GetBytes(input);

                    byte[] ciphertext = ongEncryptor.Encrypt(plaintextBytes);

                    string ciphertextHex = BitConverter.ToString(ciphertext).Replace("-", "");

                    textBox6.Text = ciphertextHex;
                }

                AppendToStatus3("���������� ���������.");
            }
            catch (OperationCanceledException)
            {
                textBox6.Text = "�������� ��������.";
                AppendToStatus3(" ");
            }
        }

        // ������, �� ������� ����� ������
        private void button6_Click(object sender, EventArgs e)
        {
            cancellationTokenSourceONG?.Cancel();
        }

        // ����� �� ���� ����������� ��� �������� ������
        private void AppendToStatus3(string message)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<string>(AppendToStatus3), message);
                return;
            }
            textBox6.AppendText(message + Environment.NewLine);
        }

        // ������, �� ������� �� �������
        private async void button7_Click(object sender, EventArgs e)
        {
            cancellationTokenSourceKHAFRE = new CancellationTokenSource();
            cancellationTokenSourceMD3 = new CancellationTokenSource();
            cancellationTokenSourceONG = new CancellationTokenSource();

            var taskKHAFRE = RunKHAFRE(textBox1.Text, cancellationTokenSourceKHAFRE.Token);
            var taskMD3 = RunMD3(textBox1.Text, cancellationTokenSourceMD3.Token);
            var taskONG = RunONG(textBox5.Text, cancellationTokenSourceONG.Token);

            await Task.WhenAll(taskKHAFRE, taskMD3, taskONG);
        }

        // ������, �� ������� �� �������
        private void button8_Click(object sender, EventArgs e)
        {
            cancellationTokenSourceKHAFRE?.Cancel();
            cancellationTokenSourceMD3?.Cancel();
            cancellationTokenSourceONG?.Cancel();
        }
    }
}
