using System;
//using System.Collections.Generic;
// System.ComponentModel;
//using System.Data;
using System.Diagnostics;
//using System.Drawing;
using System.Drawing;
using System.IO;
//using System.Linq;
//using System.Net;
using System.Net.NetworkInformation;
//using System.Text;
//using System.Threading;
//using System.Timers;
//using System.Text.RegularExpressions;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;

namespace SysinternalsGUI
{
    public partial class Form1 : Form
    {
        // Текущая версия проекта, доступная для всего проекта
        public Version RemoteVersion;
        public Version LocalVersion;
        private string _ip, _processPid, _processName;
        private string AppDataFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        //Координаты мышки
        private int x = 0; private int y = 0;
        //Тень от формы
        private const int CsDropshadow = 0x20000;

        public Form1()
        {
            InitializeComponent();

            /****buttons****/
            MyButtonObject btnCancel = new MyButtonObject();
            EventHandler myHandler = new EventHandler(btnCancel_Click);
            btnCancel.Click += myHandler;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.Location = new System.Drawing.Point(6, 5);
            btnCancel.Size = new System.Drawing.Size(15, 15);
            this.Controls.Add(btnCancel);

            MyButtonObject btnMinimize = new MyButtonObject();
            EventHandler myHandler2 = new EventHandler(btnMinimize_Click);
            btnMinimize.Click += myHandler2;
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.Location = new System.Drawing.Point(23, 5);
            btnMinimize.Size = new System.Drawing.Size(15, 15);
            this.Controls.Add(btnMinimize);

            MyButtonObject btnHelp = new MyButtonObject();
            EventHandler myHandlerbtnHelp = new EventHandler(btnHelp_Click);
            btnHelp.Click += myHandlerbtnHelp;
            btnHelp.BackColor = Color.Transparent;
            btnHelp.Location = new System.Drawing.Point(40, 5);
            btnHelp.Size = new System.Drawing.Size(15, 15);
            this.Controls.Add(btnHelp);
            /********/

            //this.Text += " " + System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString();
            lblVersion.Text = "Sysinternals GUI. ver. "+System.Reflection.Assembly.GetEntryAssembly().GetName().Version.ToString()+". Alexey Tereshchenko";
            timerPing.Enabled = false;
            timerPing.Stop();

            if (!Directory.Exists(AppDataFolder + "\\SysinternalsGUI"))
            {
                DirectoryInfo di = Directory.CreateDirectory(AppDataFolder + "\\SysinternalsGUI");
                AppDataFolder = di.FullName;
                //txtOutInfo.Text += AppDataFolder;
            }
            else
            {
                AppDataFolder = AppDataFolder + "\\SysinternalsGUI";
            }

            if (!File.Exists(AppDataFolder + "\\historylist.dat"))
            {
                FileStream fs = File.Create(AppDataFolder + "\\historylist.dat");
                fs.Close();
            }
        }
        
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CsDropshadow;
                return cp;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Form_Drag(sender, e);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ChekUpdate();
            ReadHIstoryList();
        }


        #region События контролов

        private void btnNetView_Click(object sender, EventArgs e)
        {
            if (txtNameComp.Text != "")
            {
                txtOutInfo.Text += Environment.NewLine + ConvertCP(866, 1251, ExecuteCommand("netview.exe"));
            }
            else
            {
                txtOutInfo.Text += Environment.NewLine + "Enter the Name or IP of the remote computer";
            }
        }

        private void lblVersion_MouseMove(object sender, MouseEventArgs e)
        {
            Form_Drag(sender, e);
        }

        private void lblVersion_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X; y = e.Y;
        }

        public void btnMinimize_Click(Object sender, System.EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        public void btnCancel_Click(Object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnPing_Click(object sender, EventArgs e)
        {
            if (txtNameComp.Text != "")
            {
                WriteHIstoryList(txtNameComp.Text);
                if (timerPing.Enabled == false)
                {
                    ButtonEnabled(false);
                    txtOutInfo.Text += Environment.NewLine + "Обмен пакетами с " + txtNameComp.Text + " [" + _ip + "]" +
                                       Environment.NewLine;
                    timerPing.Enabled = true;
                    timerPing.Start();
                    btnPing.Text = "Stop Ping";
                }
                else
                {
                    ButtonEnabled(true);
                    timerPing.Enabled = false;
                    timerPing.Stop();
                    btnPing.Text = "Ping";
                }
            }
            else
            {
                txtOutInfo.Text += Environment.NewLine + "Enter the Name or IP of the remote computer";
            }
        }

        private void btnSystemInfo_Click(object sender, EventArgs e)
        {
            if (txtNameComp.Text != "")
            {
                txtOutInfo.Text += Environment.NewLine + ExecuteCommand("psinfo.exe", "-s -d");
            }
            else
            {
                txtOutInfo.Text += Environment.NewLine + "Enter the Name or IP of the remote computer";
            }
        }

        private void btnPsLoggedon_Click(object sender, EventArgs e)
        {
            if (txtNameComp.Text != "")
            {
                txtOutInfo.Text += Environment.NewLine + ConvertCP(855, 1251, ExecuteCommand("psloggedon.exe", "-l"));
            }
            else
            {
                txtOutInfo.Text += Environment.NewLine + "Enter the Name or IP of the remote computer";
            }
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            if (txtNameComp.Text != "")
            {
                txtOutInfo.Text += Environment.NewLine + ConvertCP(866, 1251, ExecuteCommand("vosfiles.exe"));
            }
            else
            {
                txtOutInfo.Text += Environment.NewLine + "Enter the Name or IP of the remote computer";
            }
        }

        private void btnListKill_Click(object sender, EventArgs e)
        {
            if (txtNameComp.Text != "")
            {
                txtOutInfo.Text += Environment.NewLine + ExecuteCommand("pslist.exe");
            }
            else
            {
                txtOutInfo.Text += Environment.NewLine + "Enter the Name or IP of the remote computer";
            }
        }

        private void btnPsexec_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNameComp.Text != "")
                {
                    ProcessStartInfo psi = new ProcessStartInfo(@"tools\\PsExec.exe",
                        @"\\" + txtNameComp.Text + " cmd -accepteula");
                    Process.Start(psi);
                }
                else
                {
                    txtOutInfo.Text += Environment.NewLine + "Enter the Name or IP of the remote computer";
                }
            }
            catch (Exception ex)
            {
                txtOutInfo.Text += "Void Psexec_Click(): " + ex.Message;
                txtOutInfo.SelectionStart = txtOutInfo.Text.Length;
                txtOutInfo.ScrollToCaret();
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            txtOutInfo.Text = "";
        }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            if (txtNameComp.Text != "")
            {
                txtOutInfo.Text += ExecuteCommand("psshutdown.exe", "-r -f");
            }
            else
            {
                txtOutInfo.Text += Environment.NewLine + "Enter the Name or IP of the remote computer";
            }
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            if (txtNameComp.Text != "")
            {
                txtOutInfo.Text += Environment.NewLine + ExecuteCommand("psshutdown.exe", "-k -f");
            }
            else
            {
                txtOutInfo.Text += Environment.NewLine + "Enter the Name or IP of the remote computer";
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ProcessStartInfo psi = new ProcessStartInfo(Application.StartupPath + "\\SysinternalGUI.chm");
            Process.Start(psi);
        }

        private void txtNameComp_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPing.Focus();
        }

        private void timerPing_Tick(object sender, EventArgs e)
        {
            Ping();
        }

        private void toolStripStatusLabel_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("http://achrome.ddns.net/index.php/soft/10-sysinternals-gui");
            }
            catch (Exception ex)
            {
                txtOutInfo.Text += "Void toolStripStatusLabel_Click(): " + ex.Message;
            }
        }

        private void txtOutInfo_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //contextMenuStrip1.Show(this, new Point(e.X, e.Y));

                if (txtOutInfo.SelectionLength > 0)
                {
                    //Получаем индекс нажатого знака
                    int charIndex = txtOutInfo.GetCharIndexFromPosition(e.Location);

                    //Получаем номер строки по знаку
                    int lineIndex = txtOutInfo.GetLineFromCharIndex(charIndex);

                    //Получаем номер индекса, который стоит 1-м в строке
                    int startFromIndex = txtOutInfo.GetFirstCharIndexFromLine(lineIndex);

                    //Получаем длину строки
                    int lineLength = txtOutInfo.Lines[lineIndex].Length;

                    //Выделяем текст с первого символа строки до конца строки
                    txtOutInfo.Select(startFromIndex, lineLength);
                    string Text = txtOutInfo.SelectedText;
                    string[] words = Text.Split(new[] {' ', ',', ':', '?', '!'}, StringSplitOptions.RemoveEmptyEntries);

                    //проверка является ли числом значение массива
                    int number;
                    try
                    {
                        bool result = Int32.TryParse(words[1], out number);
                        if (result)
                        {
                            _processName = words[0];
                            _processPid = words[1];
                            //MessageBox.Show("pid процесса " + words[1]);
                            string message = "Процесс: " + _processName + "\nPID: " + _processPid +
                                             "\nЗавершить работу данного процесса?";
                            string caption = "Завершение процесса " + _processName;
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult rslt;
                            rslt = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Warning,
                                MessageBoxDefaultButton.Button2);
                            if (rslt == System.Windows.Forms.DialogResult.Yes)
                            {
                                ExecuteCommand("pskill.exe", _processPid);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        txtOutInfo.Text += "Void btnKill_Click(): " + ex.Message;
                        txtOutInfo.SelectionStart = txtOutInfo.Text.Length;
                        txtOutInfo.ScrollToCaret();
                    }
                    txtOutInfo.DeselectAll();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (
                MessageBox.Show("You want to close the application?", "Sysinternals GUI", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        #endregion

        #region Мои Функции

        /// <summary>
        /// Перемещение формы не имеющей заголовка
        /// </summary>
        /// <param name="sender">Обьект object sender</param>
        /// <param name="e">Данные для событий MouseEventArgs e</param>
        public void Form_Drag(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Location = new System.Drawing.Point(this.Location.X + (e.X - x), this.Location.Y + (e.Y - y));

            }
        }

        /// <summary>
        /// Запуск процесса без параметров.
        /// </summary>
        /// <param name="programm">Имя программы</param>
        /// <returns>Результат выполненной команды</returns>
        public string ExecuteCommand(string programm)
        {
            ProcessStartInfo procStartInfo = new ProcessStartInfo(@"tools\\" + programm,
                @"\\" + txtNameComp.Text + " -accepteula")
            {
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process proc = new Process())
            {
                proc.StartInfo = procStartInfo;
                proc.Start();

                string output = proc.StandardOutput.ReadToEnd();

                if (string.IsNullOrEmpty(output))
                    output = proc.StandardError.ReadToEnd();

                return output;
            }
        }

        /// <summary>
        /// Запуск процесса c параметрами.
        /// </summary>
        /// <param name="programm">запускаемый файл</param>
        /// <param name="arg">аргумент командной строки</param>
        /// <returns>Результат выполненной команды</returns>
        public string ExecuteCommand(string programm, string arg)
        {
            ProcessStartInfo procStartInfo = new ProcessStartInfo(@"tools\\" + programm,
                @"\\" + txtNameComp.Text + " " + arg + " -accepteula")
            {
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process proc = new Process())
            {
                proc.StartInfo = procStartInfo;
                proc.Start();

                string output = proc.StandardOutput.ReadToEnd();

                if (string.IsNullOrEmpty(output))
                    output = proc.StandardError.ReadToEnd();

                return output;
            }
        }

        /// <summary>
        /// Состояние кнопок Enabled или Disabled
        /// </summary>
        /// <param name="state">bool Cостяние</param>
        private void ButtonEnabled(bool state)
        {
            btnListKill.Enabled = state;
            btnPsLoggedon.Enabled = state;
            btnPsexec.Enabled = state;
            btnReboot.Enabled = state;
            btnShutdown.Enabled = state;
            btnSystemInfo.Enabled = state;
            btnFile.Enabled = state;
        }

        /// <summary>
        /// Метод проверки связи
        /// </summary>
        private void Ping()
        {
            try
            {
                Ping ping = new Ping();
                PingReply pingReply = null;
                pingReply = ping.Send(txtNameComp.Text);
                if (pingReply.Status != IPStatus.TimedOut)
                {
                    txtOutInfo.Text += "Ответ от "
                                       + pingReply.Address
                                       + ": число байт="
                                       + pingReply.Buffer.Length
                                       + " время="
                                       + pingReply.RoundtripTime
                                       + "мс TTL="
                                       + pingReply.Options.Ttl
                                       + Environment.NewLine;
                    _ip = pingReply.Address.ToString();
                }
                else
                {
                    txtOutInfo.Text += pingReply.Status + Environment.NewLine;
                }
                txtOutInfo.SelectionStart = txtOutInfo.Text.Length;
                txtOutInfo.ScrollToCaret();
            }
            catch (Exception ex)
            {
                ButtonEnabled(true);
                txtOutInfo.Text += "При проверке связи не удалось обнаружить узел "
                                   + txtNameComp.Text
                                   + Environment.NewLine
                                   + "Проверьте имя узла и повторите попытку. "
                                   + ex.Message
                                   + Environment.NewLine;
                timerPing.Enabled = false;
                timerPing.Stop();
                btnPing.Text = "Ping";
            }
        }

        /// <summary>
        /// Записываем в historylist значение из txtNameComp. Проверяем на дубляж
        /// </summary>
        /// <param name="message">txtNameComp.text</param>
        private void WriteHIstoryList(string message)
        {
            //Массив исходных строк
            string[] InputLines;
            //Объявляем переменную - флаг
            bool flag = false;
            //Читаем в массив строки из файла
            InputLines = System.IO.File.ReadAllLines(AppDataFolder + "\\historylist.dat");
            //Для каждой строки в массиве cравниваем значения из txtNameComp с значениями в файле
            foreach (string line in InputLines)
            {
                if (IsHistoryLine(line, message) == 0)
                {
                    //Нашли. Больше нам тут нечего делат. Выходим из цыкла.
                    flag = true;
                    break;
                }
                else
                {
                    //Продолжаем искать далее
                    flag = false;
                }
            }

            //Если таки нет значения из txtNameComp в файле, то записываем это значение в файл.
            if (flag == false)
            {
                string appendText = message + Environment.NewLine;
                File.AppendAllText(AppDataFolder + "\\historylist.dat", appendText, Encoding.UTF8);
                ReadHIstoryList();
            }
        }

        /// <summary>
        /// Сравниваем два строковых значения
        /// </summary>
        /// <param name="strA">Первая сравниваемая строка</param>
        /// <param name="strB">Вторая сравниваемая строка</param>
        /// <returns>System.Int32 -1 || 0 || 1</returns>
        private static int IsHistoryLine(string strA, string strB)
        {
            return String.Compare(strA, strB, true);
        }

        /// <summary>
        /// Считываем строки из historylist для свойства AutoComplete
        /// </summary>
        private void ReadHIstoryList()
        {
            try
            {
                if (File.Exists(AppDataFolder + "\\historylist.dat"))
                {
                    txtNameComp.AutoCompleteMode = AutoCompleteMode.Suggest;
                    txtNameComp.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    txtNameComp.AutoCompleteCustomSource.AddRange(
                        System.IO.File.ReadAllLines(AppDataFolder + "\\historylist.dat"));
                }
                else
                {
                    FileStream fs = File.Create(AppDataFolder + "\\historylist.dat");
                    fs.Close();
                }
            }
            catch (Exception ex)
            {
                txtOutInfo.Text += Environment.NewLine + ex.Message;
            }
        }

        /// <summary>
        /// Проверка обновления приложения
        /// </summary>
        private void ChekUpdate()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(@"http://achrome.ddns.net/version.xml");
                RemoteVersion = new Version(doc.GetElementsByTagName("sysinternalsgui")[0].InnerText);
                LocalVersion = new Version(Application.ProductVersion);

                if (LocalVersion < RemoteVersion)
                {
                    //toolStripStatusLabel.Text = "Доступна новая версия программы";
                }
                else
                {
                    //toolStripStatusLabel.Text = "Версия программы актуальна";
                }
            }
            catch (Exception ex)
            {
                //toolStripStatusLabel.Text += "Ошибка проверки обновления";
            }
        }

        /// <summary>
        /// Проверка введенных или полученных данных на соответствие формату ip адреса, 
        /// с использованием регулярных выражений.
        /// </summary>
        /// <param name="Address">IP address</param>
        /// <returns>bool true</returns>
        private static bool IsIpAddress(string Address)
        {
            //Инициализируем новый экземпляр класса System.Text.RegularExpressions.Regex
            //для указанного регулярного выражения.
            System.Text.RegularExpressions.Regex IpMatch =
                new System.Text.RegularExpressions.Regex(@"\b(?:\d{1,3}\.){3}\d{1,3}\b");
            //Выполняем проверку обнаружено ли в указанной входной строке 
            //соответствие регулярному выражению, заданному в
            //конструкторе System.Text.RegularExpressions.Regex.
            //если да то возвращаем true, если нет то false
            return IpMatch.IsMatch(Address);
        }

        private string ConvertCP(int inCodepage, int outCodepage, string inStr)
        {
            return Encoding.GetEncoding(inCodepage).GetString(Encoding.GetEncoding(outCodepage).GetBytes(inStr));
        }

        public string Test(string command)
        {
            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + command)
            {
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process proc = new Process())
            {
                proc.StartInfo = procStartInfo;
                proc.Start();

                string output = proc.StandardOutput.ReadToEnd();

                if (string.IsNullOrEmpty(output))
                    output = proc.StandardError.ReadToEnd();

                return output;
            }
        }

        #endregion        
    }
}
