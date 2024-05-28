using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace PatEditTool
{
    
    public partial class Form1 : Form
    {
        FolderBrowserDialog filePathDialog = new FolderBrowserDialog();
        string fileContent = string.Empty;
        string filePath = string.Empty;
        string []patModifyDataArray = { "0", "0", "1", "1"};
        List<string> fileNameArray = new List<string>();
        string editPinName;
        int firstDataPosition;
        int editPinPosition;
        int editDataPosition;
        int symbolPosition;  //'>' position
        int modifyDataCount;
        bool flagFindEditPin;
        bool flagTSBEnable;
        string tsb;
        string configFilePath;
        string configFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_OpenFile_Click(object sender, EventArgs e)
        {
            filePathDialog.Description = "Please Select The Path";
            configFilePath = System.IO.Directory.GetCurrentDirectory();
            configFile = configFilePath + "\\Config.txt";
            StreamReader reader = new StreamReader(configFile);
            
            filePathDialog.SelectedPath = reader.ReadLine();
            //filePathDialog.SelectedPath = "E:\\MyWork\\Teradyne\\Project\\UniSoc\\K8\\pattern\\debug\\";
            if (filePathDialog.ShowDialog() == DialogResult.OK)
            {
                filecontext.Text = "";
                filePath = filePathDialog.SelectedPath;
                Failpath.Text = filePath;
                string[] textBoxFileName = Directory.GetFiles(filePath);
                fileNameArray.Clear();
                foreach (string file in textBoxFileName)
                {
                    if ((file.Contains(".atp") == true) && (file.Contains(".atp.gz") == false))
                    {
                        fileNameArray.Add(file);
                        filecontext.AppendText(file + "\r\n");
                    }
                }
            }
            reader.Close();
            reader.Dispose();
            StreamWriter writer = new StreamWriter(configFile);
            writer.WriteLine(filePath);
            writer.Close();
            writer.Dispose();
        }
        private void Func_EditATPFile(string file)
        {
            string path = System.IO.Path.GetDirectoryName(file);
            string name = System.IO.Path.GetFileName(file);
            StreamWriter fileBackup = new StreamWriter(path + "\\Output\\" + name);
            using (StreamReader reader = new StreamReader(file))
            {
                while ((fileContent = reader.ReadLine()) != null)
                {
                    try
                    {
                        if ((fileContent.Contains("vector") == true) && (fileContent.Contains("$tset") == true))
                        {   //find edit pin position
                            string[] allPins = fileContent.Split(',');
                            flagFindEditPin = false;
                            for (int i = 0; i < allPins.Length; i++)
                            {
                                if ((allPins[i] == (editPinName)) ||(allPins[i].Replace(" ","") == (editPinName)))
                                {
                                    editPinPosition = i;
                                    flagFindEditPin = true;
                                    editDataPosition = 0;
                                    modifyDataCount = 0;
                                    symbolPosition = 0;
                                    break;
                                }
                            }
                            if (flagFindEditPin == false)
                            {
                                filecontext.AppendText("Can't find the edit pin in pattern file,please check!" + "\r\n");
                                break;
                            }
                        }
                        else if ((fileContent.Contains(">") == true) && (fileContent.Contains(";") == true))
                        {//Complete pattern cycle
                         //*************************************************************
                            if (flagTSBEnable == true)
                                if (fileContent.Contains(tsb) == false)
                                    goto writelog;
                            if (symbolPosition != fileContent.IndexOf('>'))
                            {
                                Fun_GetFistVaildPatDataPosition(fileContent, ref firstDataPosition);
                                Fun_GetModifyPatDataPosition(fileContent, firstDataPosition, editPinPosition, ref editDataPosition);
                            }
                            Fun_ModifyPatData(ref fileContent, editDataPosition, patModifyDataArray[modifyDataCount]);
                            modifyDataCount++;
                            if (modifyDataCount >= patModifyDataArray.Length)
                                modifyDataCount = 0;
                        }
                        writelog:
                        fileBackup.WriteLine(fileContent);
                        filecontext.ScrollToCaret();    //auto capture cursor
                    }
                    catch (Exception) { }
                }
                reader.Close();
                reader.Dispose();
                if (flagFindEditPin == true)
                    filecontext.AppendText(name + " edit success!!!" + "\r\n");
                Application.DoEvents();
            }
            fileBackup.Close();
            fileBackup.Dispose();
        }
        private void Btn_run_Click(object sender, EventArgs e)
        {
            editPinName = PinName.Text;         //read edit pin name
            cB_PatDataMode_TextChanged(sender,e);
            cb_TSB_Enable_CheckedChanged(sender, e);
            if (fileNameArray.Count == 0)
            {
                filecontext.Text = "Please select the file!";
                return;
            }
            Btn_OpenFile.Enabled = false;
            Btn_run.Enabled = false;
            
            string filePath = System.IO.Path.GetDirectoryName(fileNameArray[0]);

            if (!Directory.Exists(filePath + "\\Output"))//create cache folder 
                Directory.CreateDirectory(filePath + "\\Output");
            filecontext.Text = "";  //clear the windows
            foreach (string file in fileNameArray)
            {
                Func_EditATPFile(file);
                //Thread.Sleep(1000);
            }
            Btn_OpenFile.Enabled = true;
            Btn_run.Enabled = true;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("编辑pattern专用\r\n对Atp文件有要求：pattern data的列必须对齐！\r\n不支持Pin Group");
        }

        private void cB_PatDataMode_TextChanged(object sender, EventArgs e)
        {
            patModifyDataArray = cB_PatDataMode.Text.Split('-');
        }
        private void Fun_GetFistVaildPatDataPosition(string  patCycleData,ref int position)
        {
            char flag = '>';
            for (int i = patCycleData.IndexOf('>') + 1; i < patCycleData.Length; i++)
            {
                switch (flag)
                {
                    case '>':
                        if ((patCycleData[i] != ' ')&& (patCycleData[i] != '\t'))
                            flag = 't'; //tsb
                        break;
                    case 't':
                        if ((patCycleData[i] == ' ') || (patCycleData[i] == '\t'))
                            flag = 'd'; //space
                        break;
                    case 'd':
                        if ((patCycleData[i] != ' ') && (patCycleData[i] != '\t'))
                            flag = 's'; //success
                            position = i;
                        break;
                }
                if (flag == 's')
                    break;      //find first pattern data position and return
            }
        }
        private void Fun_GetModifyPatDataPosition(string patCycleData, int firstDataPosition, int modifyDataPositionOffset, ref int modifyDataPosition)
        {
            int offset = 0;
            for (int i = firstDataPosition; i < patCycleData.Length; i++)
            {
                if ((patCycleData[i] != ' ') && (patCycleData[i] != '\t'))
                {
                    offset++;
                    if (offset == modifyDataPositionOffset)
                    {
                        modifyDataPosition = i;
                        break;
                    }
                }
            }
        }
        private void Fun_ModifyPatData(ref string patCycleData,int modifyDataPosition,string modifyData)
        {
            patCycleData = patCycleData.Replace(patCycleData.Substring(0, modifyDataPosition + 1), patCycleData.Substring(0, modifyDataPosition) + modifyData);
        }

        private void cb_TSB_Enable_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_TSB_Enable.Checked == true)
                cb_TSB_Array.Enabled = true;
            else
                cb_TSB_Array.Enabled = false;
            tsb = cb_TSB_Array.Text;
            flagTSBEnable = cb_TSB_Enable.Checked;
        }
    }
}
