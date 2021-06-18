using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace InvokeAnsys
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            textBoxAnsysFile.Text = @"C:\Program Files\ANSYS Inc\v202\ansys\bin\winx64\ANSYS202.exe";
            textBoxAPDLFile.Text = @"C:\Users\Cratza\Desktop\C#\ANSYS_CSharp_Coding\ANSYS_CSharp_Coding\bin\Debug\ANSYS\demo.mac";
            textBoxJobName.Text = "demo";
            textBoxResultFile.Text = "result.out";
            textBoxOutputDic.Text = @"C:\Users\Cratza\Desktop\C#\ANSYS_CSharp_Coding\ANSYS_CSharp_Coding\bin\Debug\ANSYS";
        }

        private void buttonAnsysFileChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
           // openFileDialog.InitialDirectory = "E:\\";
            openFileDialog.Filter = "Text Document（*.txt）|*.txt|All Files|*.*|我要显示的文件类型（*.exe）|*.exe";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 3;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.textBoxAnsysFile.Text = openFileDialog.FileName;
            }
        }

        private void buttonAPDLFileChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            // openFileDialog.InitialDirectory = "E:\\";
            openFileDialog.Filter = "Mac Document（*.txt）|*.txt|All Files|*.*|我要显示的文件类型（*.exe）|*.exe";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.textBoxAPDLFile.Text = openFileDialog.FileName;
            }
        }

        private void buttonResultWorkDic_Click(object sender, EventArgs e)
        {
            //string localFilePath, fileNameExt, newFileName, FilePath;  
            string FilePath = String.Empty;
            string localFilePath = String.Empty;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            //设置文件类型  
            saveFileDialog1.Filter = " txt files(*.txt)|*.txt|All files(*.*)|*.*";
            //设置文件名称：
            saveFileDialog1.FileName = this.textBoxResultFile.Text.ToString();

            //设置默认文件类型显示顺序  
            saveFileDialog1.FilterIndex = 1;

            //保存对话框是否记忆上次打开的目录  
            saveFileDialog1.RestoreDirectory = true;

            //点了保存按钮进入  
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //获得文件路径  
                localFilePath = saveFileDialog1.FileName.ToString();
                //string filname = this.openFileDialog2.FileName;
                //获取文件名，不带路径  
                //fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1);  

                //获取文件路径，不带文件名  
                FilePath = localFilePath.Substring(0, localFilePath.LastIndexOf("\\"));  

                //给文件名前加上时间  
                //newFileName = DateTime.Now.ToString("yyyyMMdd") + fileNameExt;  

                //在文件名里加字符  
                //saveFileDialog1.FileName.Insert(1,"dameng");  

                //System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();//输出文件  

                //fs输出带文字或图片的文件，就看需求了  
                this.textBoxOutputDic.Text = FilePath;
            }
        }

        private void buttonExcuteAnsys_Click(object sender, EventArgs e)
        {
            string ansysPath = this.textBoxAnsysFile.Text;
            string apdlFilePath = this.textBoxAPDLFile.Text;
            string outFilePath = this.textBoxOutputDic.Text;
            string jobName = this.textBoxJobName.Text;
            string outFilePathName = outFilePath + "\\" + this.textBoxResultFile.Text.ToString() + ".txt"; 

            if (apdlFilePath != "")
            {
                try
                {
                    ProcessStartInfo startinfo = new ProcessStartInfo();
                  //  startinfo.Arguments = "-b list -p ansysds -runae -j temp -i " + filePath + " -o e:/out.dat";
                    string commond = String.Empty;
                    commond += "-b -p ";  //in batch mode  Defines which ANSYS product will run during the session (ANSYS Multiphysics, ANSYS Structural, etc.)
                    commond += "-j " + jobName; //jobName
                    commond += " -np " + 2.ToString();//Specifies the number of processors to use when running Distributed ANSYS or Shared-memory ANSYS
                    commond += " -db "; //Defines the portion of workspace (memory) to be used as the initial allocation for the database. This and -m are the two most important options. If you ever find that ANSYS is writing a *.PAGE file, up this number.
                    commond += " -m "; //Idefines the total memory to reserve for the program. It is always better to reserve it up front rather than letting ANSYS grab as it needs.
                    commond += " -i " + apdlFilePath;// 输入文件
                    commond += " -o " + outFilePathName; // 输出文件                  
                    startinfo.Arguments = commond;

                    //startinfo.Arguments = "-b -p -j " + jobName + " -i " + apdlFilePath + " -o " + outFilePath + this.textBoxResultFile + ".txt";
                //    startinfo.WindowStyle = ProcessWindowStyle.Hidden;
                    startinfo.WindowStyle = ProcessWindowStyle.Normal;
                 //   startinfo.CreateNoWindow = true;
                    //      startinfo.RedirectStandardOutput = true;
                    startinfo.FileName = ansysPath;
                    startinfo.WorkingDirectory = System.IO.Path.GetDirectoryName(outFilePathName);
                    System.Diagnostics.Process ProAnsys = System.Diagnostics.Process.Start(startinfo);
                    ProAnsys.WaitForExit();
                    ProAnsys.Close();
                    string path = @"C:\Users\Cratza\Desktop\C#\ANSYS_CSharp_Coding\ANSYS_CSharp_Coding\bin\Debug\ANSYS\demo.dat";
                    StreamReader sr = new StreamReader(path, Encoding.Default);
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Debug.WriteLine(line.ToString());
                    }
                }
                catch
                {
                    MessageBox.Show("错误！");
                }
            }
        }

    






    }

    

  


   
}
