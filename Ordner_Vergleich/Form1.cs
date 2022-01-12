using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ordner_Vergleich
{
    public partial class Form1 : Form
    {
        CancellationTokenSource tokenSource; 

        public Form1()
        {
            InitializeComponent();
        }

        private void browseA_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_A.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void browseB_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_B.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void browseCopy_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                tb_copy.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private async void btn_go_Click(object sender, EventArgs e)
        {
            setWorking();

            tokenSource = new CancellationTokenSource();
            var token = tokenSource.Token;
            IProgress<string> progress = new Progress<string>(value => lbl_status.Text = value);

            try
            {
                // Task generates a new thread to keep UI-Thread responsive
                await Task.Run(() => do_it(progress, token), token);
                lbl_status.Text = "Fertig.";

            }
            catch (OperationCanceledException)
            {
                // if User aborted
                lbl_status.Text = "Abgebrochen!";
            }
            finally
            {
                tokenSource.Dispose();
            }

            setReady();
        }

        private void do_it(IProgress<string> progress, CancellationToken ct)
        {

            // Get all inputs
            string path_A = tb_A.Text.TrimEnd('\\', '/');
            string path_B = tb_B.Text.TrimEnd('\\', '/');
            string file_filter = tb_filter.Text;
            string path_copy = tb_copy.Text.TrimEnd('\\', '/');

            // check if any action is selected
            if (!(cb_AandB.Checked || cb_AnotB.Checked || cb_BnotA.Checked || cb_write_log.Checked)) {
                MessageBox.Show("Keine Aktion ausgewählt", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // create array of all files in A and B
            string[] filepaths_A;
            string[] filepaths_B;
            try
            {
                var recursiveA = cb_subfolder_A.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
                var recursiveB = cb_subfolder_B.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

                filepaths_A = Directory.GetFiles(path_A, file_filter, recursiveA);
                filepaths_B = Directory.GetFiles(path_B, file_filter, recursiveB);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // create Dicts with {file name: file path}
            var A_dict = new Dictionary<string, string>();
            foreach (string entry in filepaths_A)
            {
                //ct.ThrowIfCancellationRequested();
                //Thread.Sleep(1000);
                A_dict[Path.GetFileName(entry).ToLower()] = entry;
            }

            var B_dict = new Dictionary<string, string>();
            foreach (string entry in filepaths_B)
            {
                B_dict[Path.GetFileName(entry).ToLower()] = entry;
            }

            // abort if task (thread) got cancelled
            ct.ThrowIfCancellationRequested();

            // create sets of file names
            var A_set = new HashSet<string>(A_dict.Keys.ToArray());
            var B_set = new HashSet<string>(B_dict.Keys.ToArray());
            
            // in A not B
            var diff_1 = new HashSet<string>(A_set);
            diff_1.ExceptWith(B_set);

            // in B not A
            var diff_2 = new HashSet<string>(B_set);
            diff_2.ExceptWith(A_set);

            // in A and B
            var diff_3 = new HashSet<string>(A_set);
            diff_3.IntersectWith(B_set);


            // write log file
            if (cb_write_log.Checked)
            {
                StringBuilder log = new System.Text.StringBuilder("");
                log.Append($"A = {path_A}\nB = {path_B}\n\n");
                log.Append("In A und nicht B:\n");
                foreach (string entry in diff_1)
                {
                    log.Append(entry + "\n");
                }
                log.Append("\n\nIn B und nicht A:\n");
                foreach (string entry in diff_2)
                {
                    log.Append(entry + "\n");
                }
                log.Append("\n\nIn A und B:\n");
                foreach (string entry in diff_3)
                {
                    log.Append(entry + "\n");
                }
                File.WriteAllText(path_A + @"\ _Ergebnis.txt", log.ToString());
            }


            // copy files if copy checkboxes are checked
            try
            {
                if ((cb_AnotB.Checked || cb_BnotA.Checked || cb_AandB.Checked) && String.IsNullOrEmpty(path_copy)) 
                { 
                    throw new NullReferenceException("Kopier-Ziel ist leer"); 
                }
                if (cb_AnotB.Checked)
                {
                    Directory.CreateDirectory(path_copy + @"\A_nicht_B\");
                    foreach (string entry in diff_1)
                    {
                        ct.ThrowIfCancellationRequested();
                        progress.Report(A_dict[entry]);
                        File.Copy(A_dict[entry], path_copy + @"\A_nicht_B\" + entry);
                    }
                }
                if (cb_BnotA.Checked)
                {
                    Directory.CreateDirectory(path_copy + @"\B_nicht_A\");
                    foreach (string entry in diff_2)
                    {
                        ct.ThrowIfCancellationRequested();
                        progress.Report(B_dict[entry]);
                        File.Copy(B_dict[entry], path_copy + @"\B_nicht_A\" + entry);
                    }
                }
                if (cb_AandB.Checked)
                {
                    Directory.CreateDirectory(path_copy + @"\A_und_B\");
                    foreach (string entry in diff_3)
                    {
                        ct.ThrowIfCancellationRequested();
                        progress.Report(A_dict[entry]);
                        File.Copy(A_dict[entry], path_copy + @"\A_und_B\" + entry);
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Fertig", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_abort_Click(object sender, EventArgs e)
        {
            tokenSource.Cancel();
        }

        private void setWorking()
        {   
            disableAllControls(this);
            lbl_status.Enabled = true;
            lbl_status.Text = "wird bearbeitet...";
        }

        private void setReady()
        {
            enableAllControls(this);
        }

        private void disableAllControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                c.Enabled = false;
            }
            btn_abort.Enabled = true;
        }

        private void enableAllControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                c.Enabled = true;
            }
            btn_abort.Enabled = false;
        }

        private void btn_info_Click(object sender, EventArgs e)
        {
            string ver = "v1.1.2";
            string anleitung = $"Dieses Programm erstellt eine Liste aller Dateien aus Ordner A und B, die dem Filter entsprechen (optional inkl. Dateien in Unterordnern) und bildet daraus die Mengen: \n\n - in A und nicht in B\n - in B und nicht in A\n - in A und in B \n\nDas Ergebnis lässt sich in eine \"_Ergebnis.txt\" schreiben.\n\nAuch lassen sich die entsprechenden Dateien an einen benutzerdefinierten Ort kopieren. Die Quelldateien bleiben dabei erhalten.\n\nDer Filter unterstützt kein Regex, jedoch die Wildcards:\n - * (>= 0)\n - ? (>=1)\n\n\n{ver}";

            MessageBox.Show(anleitung, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
