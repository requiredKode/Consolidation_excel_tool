using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic.Devices;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace FolderWatcher
{
    public partial class Form1 : Form
    {
        string Path_monitor_folder = "";
        string Path_processed_folder = "";
        string Path_not_appl_folder = "";
        string Path_mb_route = "";

        string type = "file";

        Application app = new Application();
        Workbook curWorkBook = null;
        Workbook destWorkbook = null;
        Worksheet workSheet = null;
        Worksheet newWorksheet = null;
        Object defaultArg = Type.Missing;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {
            Getfiles();
        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {
            Getfiles();
        }

        private void fileSystemWatcher1_Deleted(object sender, FileSystemEventArgs e)
        {
            Getfiles();
        }

        private void fileSystemWatcher1_Renamed(object sender, RenamedEventArgs e)
        {
            Getfiles();
        }
        
        private void Getfiles()
        {

                string[] lst = Directory.GetFiles(Path_monitor_folder, "*.*", SearchOption.AllDirectories);

                Txt_Watcher.Text = "";

                foreach (var sfile in lst)
                {
                    //Txt_Watcher.Text += Path.GetFileNameWithoutExtension(sfile) + Environment.NewLine;
                    Txt_Watcher.Text += Path.GetFileName(sfile) + Environment.NewLine;
                }

        }
        
        private void btn_checkfiles_Click(object sender, EventArgs e)
        {
            string[] lst = Directory.GetFiles(Path_monitor_folder, "*.*", SearchOption.AllDirectories);
            
            Txt_Watcher.Text = "";

            foreach (var sfile in lst)
            {
                Txt_Watcher.Text += Path.GetFileNameWithoutExtension(sfile) + Environment.NewLine;
                Txt_Watcher.Text += Path.GetFileName(sfile) + Environment.NewLine;

                if (type == "file")
                {
                    string fileExt = Path.GetExtension(sfile);
                    if (fileExt != ".xlsx")
                    {
                        File.Move(Path_monitor_folder + "\\"+ Path.GetFileName(sfile), Path_not_appl_folder + "\\" + Path.GetFileName(sfile)); 
                    }
                    else
                    {
                        
                        try
                        {
                            // Copy the source sheet
                            curWorkBook = app.Workbooks.Open(Path_monitor_folder + "\\" + Path.GetFileName(sfile), defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg);
                            workSheet = (Worksheet)curWorkBook.Sheets[1];
                            workSheet.UsedRange.Copy(defaultArg);

                            // Paste on destination sheet
                            destWorkbook = app.Workbooks.Open(Path_mb_route, defaultArg, false, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg, defaultArg);
                            newWorksheet = (Worksheet)destWorkbook.Worksheets.Add(defaultArg, defaultArg, defaultArg, defaultArg);
                            newWorksheet.UsedRange._PasteSpecial(XlPasteType.xlPasteValues, XlPasteSpecialOperation.xlPasteSpecialOperationNone, false, false);
                        }
                        catch (Exception exc)
                        {
                            System.Windows.Forms.MessageBox.Show(exc.Message);
                        }
                        finally
                        {
                            if (curWorkBook != null)
                            {
                                curWorkBook.Save();
                                curWorkBook.Close(defaultArg, defaultArg, defaultArg);
                                File.Move(Path_monitor_folder + "\\" + Path.GetFileName(sfile), Path_processed_folder + "\\" + Path.GetFileName(sfile));
                            }

                            if (destWorkbook != null)
                            {
                                destWorkbook.Save();
                                destWorkbook.Close(defaultArg, defaultArg, defaultArg);
                            }
                        }
                        app.Quit();
                   
                

                    }
                    
                }

            }
        }

        private void btn_watch_Click(object sender, EventArgs e)
        {
            var result = fbd1.ShowDialog();
            
            if (result == DialogResult.OK) { txt_monitor_folder.Text = fbd1.SelectedPath; }

            Path_monitor_folder = txt_monitor_folder.Text;

            fileSystemWatcher1.Path = Path_monitor_folder;
            Getfiles();

        }

        private void btn_root_Click(object sender, EventArgs e)
        {
            var result = fbd3.ShowDialog();
            if (result == DialogResult.OK) { txt_processed.Text = fbd3.SelectedPath; }

            Path_processed_folder = txt_processed.Text;

        }

        private void btndest_Click(object sender, EventArgs e)
        {
            var result = fbd2.ShowDialog();
            if (result == DialogResult.OK) { txt_not_appl.Text = fbd2.SelectedPath; }

            Path_not_appl_folder = txt_not_appl.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = ofd.ShowDialog();
            if (result == DialogResult.OK) { txt_masterbook_route.Text = ofd.FileName; }

            Path_mb_route = txt_masterbook_route.Text;
        }
    }
}
