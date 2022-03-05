using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace hl2005wonlauncher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
			foreach (var pr in Enum.GetNames(typeof(ProcessPriorityClass)))
                priority.Items.Add(pr);

            if(!Directory.Exists(Environment.ExpandEnvironmentVariables("%localappdata%/HL WON 2005 Launcher"))) 
                Directory.CreateDirectory(Environment.ExpandEnvironmentVariables("%localappdata%/HL WON 2005 Launcher"));
            if (File.Exists(Environment.ExpandEnvironmentVariables("%localappdata%/HL WON 2005 Launcher") + "/save"))
            {
                var sr = new StreamReader(File.OpenRead(Environment.ExpandEnvironmentVariables("%localappdata%/HL WON 2005 Launcher") + "/save"));
                var p = sr.ReadToEnd().Split("\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                path.Text = p[0];
                parametres.Text = p[1];
                bxtCheck.Checked = bool.Parse(p[2]);
                riCheck.Checked = bool.Parse(p[3]);
                close.Checked = bool.Parse(p[4]);
                priority.SelectedItem = p[4];
                sr.Close();
            }
            else
            {
                File.CreateText(Environment.ExpandEnvironmentVariables("%localappdata%/HL WON 2005 Launcher") + "/save").Close();
                priority.SelectedItem = "Normal";
            }
            priority.SelectedItem = "fzdgzdgzdg";
        }

        private void lauchhl(object sender, EventArgs e)
        {
            var hlPath = path.Text;
			bool isLaunched;
			try
			{
                var p = Process.Start(Path.Combine(hlPath, "Half-Life/hl.exe"), parametres.Text);
                if (!Enum.TryParse((string)priority.SelectedItem, out ProcessPriorityClass ppc)) ppc = ProcessPriorityClass.Normal;
                p.PriorityClass = ppc;
                isLaunched = true;
				try
				{
                    var save = File.CreateText(Environment.ExpandEnvironmentVariables("%localappdata%/HL WON 2005 Launcher") + "/save");
                    save.WriteLine(hlPath);
                    save.WriteLine(string.IsNullOrEmpty(parametres.Text) ? " " : parametres.Text);
                    save.WriteLine(bxtCheck.Checked);
                    save.WriteLine(riCheck.Checked);
                    save.WriteLine(close.Checked);
                    save.WriteLine(ppc.ToString());
                    save.Close();
				}
                catch
				{
                    showDialog("Скорее всего, файл с сохранением конфигурации не найден. Введёные параметры не сохранятся.");
				}
            }
			catch
			{
                showDialog("Произошла ошибка, скорее всего HL в указанной папке отсутствует.");
                return;
            }
            if (bxtCheck.Checked)
            {
				try
				{
                    Process.Start(Path.Combine(hlPath, "Bunnymod XT/Injector.exe"));
				}
                catch
				{
                    if(!showDialog("Произошла ошибка, скорее всего BXT в указанной папке отсутствует. Продолжить?")) return;
                }
            }
            if (riCheck.Checked)
            {
                try
                { 
                    Process.Start(new ProcessStartInfo() { FileName = Path.Combine(hlPath, "RInput/RInput.exe"), Arguments = "hl.exe" });
                }
                catch
                {
                    if (!showDialog("Произошла ошибка, скорее всего RInput в указанной папке отсутствует. Продолжить?")) return;
                }
            }
            if(close.Checked && isLaunched) Close();
        }



        private void bxtup(object sender, EventArgs e)
        {
			try 
            {
                Process.Start(Path.Combine(path.Text, "Bunnymod XT/update.bat"));
            }
            catch
		    {
                showDialog("Произошла ошибка, скорее всего update.bat для BXT в указанной папке отсутствует.");
            }
        }

        private void selectHlPath(object sender, EventArgs e)
        {
            var f = new FolderBrowserDialog();
            f.ShowDialog();
            path.Text = f.SelectedPath;
            f.Dispose();
        }

        private bool showDialog(string text)
		{
            Form prompt = new Form()
            {
                Width = 400,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Ошибка",
                StartPosition = FormStartPosition.CenterScreen
            };
            //MessageBox.Show(text, )
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text, Width = 300, Height = 100 };
            Button confirmation = new Button() { Text = "Ok", Left = 250, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK;
        }
	}
}
