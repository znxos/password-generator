using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using DocumentFormat.OpenXml;
using System.Text.RegularExpressions;

using Zxcvbn.Matcher;

// fix error where it says it won't save without a header for the datagridview
// work on the save to excel feature.
// P6G52Oc investigate why it has a score of 3

namespace password_generator
{
    public partial class Form1 : Form
    {
        public class CustomProgressBar : ProgressBar
        {
            public CustomProgressBar()
            {
                this.SetStyle(ControlStyles.UserPaint, true); // Allows custom drawing
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Rectangle rect = this.ClientRectangle;
                Graphics g = e.Graphics;

                ProgressBarRenderer.DrawHorizontalBar(g, rect); // Draw background

                // Calculate fill width based on value
                int fillWidth = (int)(rect.Width * ((double)Value / Maximum));
                rect.Width = fillWidth;

                System.Drawing.Color barColor = GetColorByValue(Value);
                using (SolidBrush brush = new SolidBrush(barColor))
                {
                    g.FillRectangle(brush, 0, 0, rect.Width, rect.Height);
                }

                base.OnPaint(e);
            }

            private System.Drawing.Color GetColorByValue(int value)
            {
                if (value <= 20) return System.Drawing.Color.Red;
                if (value <= 40) return System.Drawing.Color.Orange;
                if (value <= 60) return System.Drawing.Color.Yellow;
                if (value <= 80) return System.Drawing.Color.YellowGreen;
                return System.Drawing.Color.Green;
            }

            private CustomProgressBar progressBarStrength;

        }
        public Form1()
        {

            // code for the track bar
            InitializeComponent();

            


            trackBar1.Minimum = 1;
            trackBar1.Maximum = 20;
            trackBar1.SmallChange = 1;
            trackBar1.LargeChange = 1;
            trackBar1.TickFrequency = 1;

            textBox2.Text = $"{trackBar1.Value}";
            // end track bar code


            // code for the CustomProgressBar/PasswordStrength
            textBox1.TextChanged += textBox1_TextChanged;

            
            progressBarStrength = new CustomProgressBar
            {
                Location = new Point(142, 187),
                Size = new Size(236, 10),
                Maximum = 100,
                Minimum = 0

            };
            this.Controls.Add(progressBarStrength);
        }

        /*
        private int GetPasswordStrength(string password) {
            
            int score = 0;
            if(string.IsNullOrWhiteSpace(password)) return score;
            if (password.Length < 10) return (1*100)/8;

            if (password.Length >= 15 && password.Length <= 20) score += 1;
            else if (password.Length >= 10 && password.Length < 15) score += 1;
            
            else return 0;

            if (password.Any(char.IsUpper)) score++;
            if (password.Any(char.IsLower)) score++;
            if (password.Any(char.IsDigit)) score++;
            //if (Regex.IsMatch(password, @"[!@#$%^&*(),.?\:{ }|<>]")) score++;
            //if (Regex.IsMatch(password, @"[!@#$%^&*()-_+={}|;:'\,.<>?/~`]")) score++;
            if (Regex.IsMatch(password, @"[!@#$%^&*\(\)\-_+=\{\}\|;:'"",.<>?/~`]")) score++;
            return (score *100)/7;
            
        }
        */

        private int GetPasswordStrength(string password)
        {
            if(string.IsNullOrWhiteSpace(password)) return 0;
            var zxcbn = Zxcvbn.Core.EvaluatePassword(password);
            if (zxcbn.Score == 0) return 1*15;
            else
            return zxcbn.Score * 25;

            

        }

        private void UpdateProgressBar(int score)
        {
            progressBarStrength.Value = score;
            progressBarStrength.Invalidate(); // Refresh UI
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string password = textBox1.Text;
            int strength = GetPasswordStrength(password);
            UpdateProgressBar(strength);
        }

        // end code for the CustomProgressBar/PasswordStrength


        public class CustomToolStripDropDown : ToolStripDropDown
        {
            protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
            {
                base.SetBoundsCore(x, y, width, height, specified);

                if (this.DefaultDropDownDirection == ToolStripDropDownDirection.Default) { }


            }
        }




        /*
        protected override void WndProc(ref Message m) { // enables mouse dragging with custom nav bar ( the panel won't let you drag from the nav bar using this code)
            switch (m.Msg) {
                case 0x0084:
                    base.WndProc(ref m);
                    if ((int)m.Result == 1) {
                            m.Result = (IntPtr)2;
                    }
                    return;
            }
            base.WndProc(ref m);
        }
        */

        public void CreateRegistry()
        {
            string keyName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            string keyValue = System.Reflection.Assembly.GetExecutingAssembly().Location;

            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            key.SetValue(keyName, keyValue + " -hide"); //app starts on windows startup and gets hidden to the icon tray


        }

        public void CheckIfappInstanceIsRunning()
        {
            string appName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            Process[] processes = Process.GetProcessesByName(appName);

            if (processes.Length > 1)
            {
                MessageBox.Show("Another instance if the app is already running");
                Application.Exit();
                return;
            }

        }



        Random rnd = new Random();

        char[] letters_lower = "abcdefghijklmnopqrstuvwxyz".ToArray();
        char[] letters_upper = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        char[] letters_special = "!@#$%^&*()-_+=[]{}|;:'\",.<>?/\\~`".ToCharArray();
        char[] numbers = "0123456789".ToCharArray();

        string output;
        int max = 20;

        /*

        private void ExportToExcel()
        {
            Form2 form2 = new Form2();

            // Create a new Excel workbook
            using (SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.Create("C:\\Users\\Tino\\Downloads\\one", SpreadsheetDocumentType.Workbook))
            {
                // Add a new worksheet to the workbook
                WorkbookPart workbookPart = spreadsheetDocument.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();

                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet(new SheetData());

                Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.AppendChild(new Sheets());
                Sheet sheet = new Sheet
                {
                    Id = spreadsheetDocument.WorkbookPart.GetIdOfPart(worksheetPart),
                    SheetId = 1,
                    Name = "Sheet1"
                };
                sheets.Append(sheet);

                // Get the worksheet data
                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

                // Set the column headers in the first row
                Row headerRow = new Row();
                foreach (DataGridViewColumn column in form2.DataGridView1.Columns)
                {
                    headerRow.AppendChild(CreateCell(column.HeaderText));
                }
                sheetData.AppendChild(headerRow);

                // Set the cell values from the DataGridView
                foreach (DataGridViewRow dgvRow in form2.DataGridView1.Rows)
                {
                    Row newRow = new Row();
                    foreach (DataGridViewCell cell in dgvRow.Cells)
                    {
                        if (cell.Value != null)
                        {
                            newRow.AppendChild(CreateCell(cell.Value.ToString()));
                        }
                    }
                    sheetData.AppendChild(newRow);
                }

                // Save the workbook
                workbookPart.Workbook.Save();
            }

            MessageBox.Show("Excel file saved successfully.");
        }

        private Cell CreateCell(string value)
        {
            Cell cell = new Cell();
            cell.CellValue = new CellValue(value);
            cell.DataType = new EnumValue<CellValues>(CellValues.String);
            return cell;
        }
        */
        void generate(int numOfLetters)
        {
            output = null;

            //the case where a single variation of the checkbox is ticked

            // lowercase letters
            if (Convert.ToInt32(textBox2.Text) <= max && checkBox2.Checked && checkBox1.Checked != true && checkBox3.Checked != true && checkBox4.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    output += letters_lower[rnd.Next(0, letters_lower.Length)];
                }
                textBox1.Text = output;

                //uppercase
            }
            else if (Convert.ToInt32(textBox2.Text) <= max && checkBox1.Checked && checkBox2.Checked != true && checkBox3.Checked != true && checkBox4.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    output += letters_upper[rnd.Next(0, letters_upper.Length)];
                }
                textBox1.Text = output;

                // numbers
            }
            else if (Convert.ToInt32(textBox2.Text) <= max && checkBox3.Checked && checkBox1.Checked != true && checkBox2.Checked != true && checkBox4.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    output += numbers[rnd.Next(0, numbers.Length)];
                }
                textBox1.Text = output;
            }
            else if (Convert.ToInt32(textBox2.Text) <= max && checkBox4.Checked && checkBox1.Checked != true && checkBox2.Checked != true && checkBox3.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    output += letters_special[rnd.Next(0, letters_special.Length)];
                }
                textBox1.Text = output;

                // all 4 checkboxes -- to do with other scenarios later
            }
            else if (Convert.ToInt32(textBox2.Text) <= max && checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    int choice = rnd.Next(4); // Randomly choose a character type: 0 for lowercase, 1 for uppercase, 2 for special, 3 for number
                    switch (choice)
                    {
                        case 0:
                            output += letters_lower[rnd.Next(0, letters_lower.Length)];
                            break;
                        case 1:
                            output += letters_upper[rnd.Next(0, letters_upper.Length)];
                            break;
                        case 2:
                            output += letters_special[rnd.Next(0, letters_special.Length)];
                            break;
                        case 3:
                            output += numbers[rnd.Next(0, numbers.Length)];
                            break;
                    }
                }
                textBox1.Text = output;
            }
            //Uppercase and Lowercase checked
            if (Convert.ToInt32(textBox2.Text) <= max && checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked != true && checkBox4.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    int choice = rnd.Next(2); // Randomly choose a character type: 0 for lowercase, 1 for uppercase, 2 for special, 3 for number
                    switch (choice)
                    {
                        case 0:
                            output += letters_lower[rnd.Next(0, letters_lower.Length)];
                            break;
                        case 1:
                            output += letters_upper[rnd.Next(0, letters_upper.Length)];
                            break;
                    }
                    textBox1.Text = output;
                }
            }
   

            //Uppercase and Numbers checked
            if (Convert.ToInt32(textBox2.Text) <= max && checkBox1.Checked == true && checkBox3.Checked == true && checkBox2.Checked != true && checkBox4.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    int choice = rnd.Next(2); // Randomly choose a character type: 0 for lowercase, 1 for uppercase, 2 for special, 3 for number
                    switch (choice)
                    {
                        case 0:
                            output += letters_upper[rnd.Next(0, letters_upper.Length)];
                            break;
                        case 1:
                            output += numbers[rnd.Next(0, numbers.Length)];
                            break;
                    }
                    textBox1.Text = output;
                }
            }

            //Uppercase and Symbols (Special Characters) checked
            if (Convert.ToInt32(textBox2.Text) <= max && checkBox1.Checked == true && checkBox4.Checked == true && checkBox2.Checked != true && checkBox3.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    int choice = rnd.Next(2); // Randomly choose a character type: 0 for lowercase, 1 for uppercase, 2 for special, 3 for number
                    switch (choice)
                    {
                        case 0:
                            output += letters_upper[rnd.Next(0, letters_upper.Length)];
                            break;
                        case 1:
                            output += letters_special[rnd.Next(0, letters_special.Length)];
                            break;
                    }
                    textBox1.Text = output;
                }
            }
            //Lowercase and Numbers checked
            if (Convert.ToInt32(textBox2.Text) <= max && checkBox2.Checked == true && checkBox3.Checked == true && checkBox1.Checked != true && checkBox4.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    int choice = rnd.Next(2); // Randomly choose a character type: 0 for lowercase, 1 for uppercase, 2 for special, 3 for number
                    switch (choice)
                    {
                        case 0:
                            output += letters_lower[rnd.Next(0, letters_lower.Length)];
                            break;
                        case 1:
                            output += numbers[rnd.Next(0, numbers.Length)];
                            break;
                    }
                    textBox1.Text = output;
                }
            }
            //Lowercase and Symbols checked
            if (Convert.ToInt32(textBox2.Text) <= max && checkBox2.Checked == true && checkBox4.Checked == true && checkBox1.Checked != true && checkBox3.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    int choice = rnd.Next(2); // Randomly choose a character type: 0 for lowercase, 1 for uppercase, 2 for special, 3 for number
                    switch (choice)
                    {
                        case 0:
                            output += letters_lower[rnd.Next(0, letters_lower.Length)];
                            break;
                        case 1:
                            output += letters_special[rnd.Next(0, letters_special.Length)];
                            break;
                    }
                    textBox1.Text = output;
                }
            }
            //Numbers and Symbols checked
            if (Convert.ToInt32(textBox2.Text) <= max && checkBox3.Checked == true && checkBox4.Checked == true && checkBox1.Checked != true && checkBox2.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    int choice = rnd.Next(2); // Randomly choose a character type: 0 for lowercase, 1 for uppercase, 2 for special, 3 for number
                    switch (choice)
                    {
                        case 0:
                            output += numbers[rnd.Next(0, numbers.Length)];
                            break;
                        case 1:
                            output += letters_special[rnd.Next(0, letters_special.Length)];
                            break;
                    }
                    textBox1.Text = output;
                }
            }
            //Uppercase, Lowercase and Numbers checked
            if (Convert.ToInt32(textBox2.Text) <= max && checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    int choice = rnd.Next(3); // Randomly choose a character type: 0 for lowercase, 1 for uppercase, 2 for special, 3 for number
                    switch (choice)
                    {
                        case 0:
                            output += letters_upper[rnd.Next(0, letters_upper.Length)];
                            break;
                        case 1:
                            output += letters_lower[rnd.Next(0, letters_lower.Length)];
                            break;
                        case 2:
                            output += numbers[rnd.Next(0, numbers.Length)];
                            break;
                    }
                    textBox1.Text = output;
                }
            }
            //Uppercase, Lowercase and Symbols checked
            if (Convert.ToInt32(textBox2.Text) <= max && checkBox1.Checked == true && checkBox2.Checked == true && checkBox4.Checked == true && checkBox3.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    int choice = rnd.Next(3); // Randomly choose a character type: 0 for lowercase, 1 for uppercase, 2 for special, 3 for number
                    switch (choice)
                    {
                        case 0:
                            output += letters_upper[rnd.Next(0, letters_upper.Length)];
                            break;
                        case 1:
                            output += letters_lower[rnd.Next(0, letters_lower.Length)];
                            break;
                        case 2:
                            output += letters_special[rnd.Next(0, letters_special.Length)];
                            break;
                    }
                    textBox1.Text = output;
                }
            }
            //Uppercase, Numbers and Symbols checked
            if (Convert.ToInt32(textBox2.Text) <= max && checkBox1.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox2.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    int choice = rnd.Next(3); // Randomly choose a character type: 0 for lowercase, 1 for uppercase, 2 for special, 3 for number
                    switch (choice)
                    {
                        case 0:
                            output += letters_upper[rnd.Next(0, letters_upper.Length)];
                            break;
                        case 1:
                            output += numbers[rnd.Next(0, numbers.Length)];
                            break;
                        case 2:
                            output += letters_special[rnd.Next(0, letters_special.Length)];
                            break;
                    }
                    textBox1.Text = output;
                }
            }
            //Lowercase, Numbers and Symbols checked
            if (Convert.ToInt32(textBox2.Text) <= max && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox1.Checked != true)
            {
                for (int i = 0; i < numOfLetters; i++)
                {
                    int choice = rnd.Next(3); // Randomly choose a character type: 0 for lowercase, 1 for uppercase, 2 for special, 3 for number
                    switch (choice)
                    {
                        case 0:
                            output += letters_lower[rnd.Next(0, letters_lower.Length)];
                            break;
                        case 1:
                            output += numbers[rnd.Next(0, numbers.Length)];
                            break;
                        case 2:
                            output += letters_special[rnd.Next(0, letters_special.Length)];
                            break;
                    }
                    textBox1.Text = output;
                }
            }
            if (Convert.ToInt32(textBox2.Text) > 20)
            {
                MessageBox.Show("Password Max Length is 20");
            }
            int charactercount = textBox1.Text.Length;
            label2.Text = Convert.ToString(charactercount);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //string max_length = textBox2.Text;

            generate(Convert.ToInt32(textBox2.Text));
            //UpdateProgressBar(score);

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = $"{trackBar1.Value}";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        public Form2 Form2F1 = new Form2();

        private void button2_Click(object sender, EventArgs e) // copy button
        {
            textBox1.SelectAll();
            textBox1.Copy();
            

            // The following saves the copied passsword to the DataGridView in Form2
            string savePassword = textBox1.Text;
            if (textBox1.Text == string.Empty) return;
            else
            Form2F1.DataGridView1.Rows.Add(savePassword); 
        }

        private void PSG_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void Open_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckIfappInstanceIsRunning();
            CreateRegistry();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
                PSG.Visible = true;

            }
        }

        private void PSG_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            this.Activate();
        }

        

        private void button4_MouseClick(object sender, MouseEventArgs e) // this is the hamburger menu
        {
            if (e.Button == MouseButtons.Left)
            { //this allows you to left click a button and the context menu will appear instead of right click.
                contextMenuStrip1.Show(this, new Point(450, 0));
            }
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form2F1.Show();
        }



        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void contextMenuStrip1_Opening(object sender, EventArgs e)
        {

        }

        private void Help_MouseHover(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
