using Bonnie.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Bonnie
{
    public partial class Form1 : Form
    {
        public int maxConfig = 1;
        public int ExpBOMIndex = 0;
        public int ExpSideIndex = 0;
        public int ExpIDIndex = 0;

        public Form1()
        {
            InitializeComponent();

            //// Version Text
            string version = FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion.ToString();
            this.Text = "Bonnie " + version;
            this.lable_version.Text = version;

            pictureBox1.Image = Resources.cat100x100;

            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://angeloeyez.github.io/Bonnie-BOM-Management/";
            linkLabel_OfficialSite.Links.Add(link);

            // 把每個tabpage都跑一次，讓每個控制項都initialize
            for (int i = 0; i < tabControl1.TabCount; i++)
                tabControl1.SelectedIndex = i;
            tabControl1.SelectedIndex = 0;

            /// Option Management Actions
            comboBox_OMAction.Items.Add("Delete");
            comboBox_OMAction.Items.Add("Copy");
            comboBox_OMAction.Items.Add("Swap");
            comboBox_OMAction.SelectedIndex = 0;
            comboBox_OMAction.Enabled = false;

            resetAllControl();
        }

        private void resetAllControl()
        {
            /// 清空所有control 資料
            /// 

            //Config Management
            textBox_FilePathOM.Text = "";
            label_OM_Total.Text = "";
            label_OMAction.Visible = false;
            label_OMConfig.Enabled = false;
            comboBox_OMAction.SelectedIndex = 0;
            comboBox_OMAction.Enabled = false;
            comboBox_OM2.Visible = false;
            comboBox_OM1.Enabled = false;
            button_OM.Enabled = false;
            checkBox_OMSimplifySameConfig.Checked = false;
            checkBox_OMSimplifySameConfig.Enabled = false;

            // Import Side
            label_ISConfig.Text = "";
            textBox_ISFilePathEXP.Text = "";
            textBox_ISFilePathTXT.Text = "";
            button_ImportSide.Enabled = false;
            comboBox_ISConfig.Enabled = false;

            // Explode BOM
            textBox_EBFilePathBOM.Text = "";
            label_EBTotalConfig.Text = "";
            comboBox_EBConfig.Enabled = false;
            button_ExplodeBOM.Enabled = false;
        }

        private void button_OpenFile_Click(object sender, EventArgs e)
        {
            comboBox_EBConfig.Enabled = false;
            button_ExplodeBOM.Enabled = false;
            textBox_EBFilePathBOM.Text = "";
            comboBox_EBConfig.Items.Clear();
            label_EBTotalConfig.Text = "";

            OpenFileDialog f = new OpenFileDialog();
            f.Title = "Select BOM File";
            f.InitialDirectory = ".\\";
            f.Filter = "BOM File (*.BOM)|*.BOM";
            if (f.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            textBox_EBFilePathBOM.Text = f.FileName;
            GetConfig(f.FileName, comboBox_EBConfig);

            comboBox_EBConfig.Enabled = (comboBox_EBConfig.Items.Count > 0) ? true : false;
            button_ExplodeBOM.Enabled = true;
            label_EBTotalConfig.Text = $"Total {maxConfig} Configs found.";
        }

        public void GetConfig(string FileName, ComboBox cb1, ComboBox cb2 = null)
        {
            string str = "";
            maxConfig = 1;

            string fileExtention = FileName.Substring(FileName.LastIndexOf(".") + 1).ToLower();
            if (fileExtention == "bom")
            {
                using (StreamReader sr = new StreamReader(FileName))
                {
                    while ((str = sr.ReadLine()) != null)
                    {
                        string[] sArray = str.Split('\t');
                        if (sArray.Length == 15 || sArray.Length == 14)
                        {
                            string[] BOMArray = sArray[(sArray.Length == 15) ? 10 : 9].Split(',');
                            if (BOMArray.Length > 1)
                            {
                                maxConfig = Math.Max(BOMArray.Length, maxConfig);
                            }
                        }
                    }
                    sr.Close();
                }

                for (int i = 1; i <= maxConfig; i++)
                    cb1.Items.Add(i);
                cb1.SelectedIndex = 0;
            }
            else if (fileExtention == "exp")
            {
                int lcnt = 0;
                ExpBOMIndex = 0;
                ExpSideIndex = 0;
                string previousIDBOM = "";
                string previousIDSide = "";

                int maxCfgSide = 1;
                using (StreamReader sr = new StreamReader(FileName))
                {
                    while ((str = sr.ReadLine()) != null)
                    {
                        str = str.Replace("\"", "");
                        if (lcnt == 1)  // Get Header
                        {
                            string[] headerArray = str.Split('\t');
                            ExpBOMIndex = Array.IndexOf(headerArray, "BOM");
                            if (ExpBOMIndex == 0)
                            {
                                MessageBox.Show("Can't fine BOM column in EXP file!");
                                Log("Can't find BOM column in EXP file!");
                                return;
                            }
                            if (Array.IndexOf(headerArray, "BOM", ExpBOMIndex + 1) > 0)
                            {
                                MessageBox.Show("There are more then 1 BOM column in EXP file, please fix it!");
                                Log("There are more then 1 BOM column in EXP file, please fix it!");
                                return;
                            }

                            ExpSideIndex = Array.IndexOf(headerArray, "Side");
                            if (ExpSideIndex == 0)
                            {
                                MessageBox.Show("Can't fine Side column in EXP file!");
                                Log("Can't find Side column in EXP file!");
                                return;
                            }
                            if (Array.IndexOf(headerArray, "Side", ExpSideIndex + 1) > 0)
                            {
                                MessageBox.Show("There are more then 1 Side column in EXP file, please fix it!");
                                Log("There are more then 1 Side column in EXP file, please fix it!");
                                return;
                            }

                            ExpIDIndex = Array.IndexOf(headerArray, "ID");
                            if (ExpIDIndex == 0)
                            {
                                MessageBox.Show("Can't fine ID column in EXP file!");
                                Log("Can't find ID column in EXP file!");
                                return;
                            }
                        }
                        else if (lcnt > 1)
                        {
                            string[] sArray = str.Split('\t');
                            if (sArray.Length > Math.Max(ExpBOMIndex, ExpSideIndex))
                            {
                                string[] BOMArray = sArray[ExpBOMIndex].Split(',');
                                if (BOMArray.Length > 1)
                                {
                                    if (BOMArray.Length < maxConfig)
                                        Log($"{sArray[ExpIDIndex]} BOM property has only {BOMArray.Length} configs, please check for protential error.");
                                    else if (BOMArray.Length > maxConfig && previousIDBOM.Length > 0)
                                        Log($"{previousIDBOM} BOM property has only {maxConfig} configs, please check for protential error.");

                                    maxConfig = Math.Max(BOMArray.Length, maxConfig);
                                    previousIDBOM = sArray[ExpIDIndex];
                                }

                                string[] SideArray = sArray[ExpSideIndex].Split(',');
                                if (SideArray.Length > 1)
                                {
                                    if (SideArray.Length < maxConfig)
                                        Log($"{sArray[ExpIDIndex]} Side property has only {SideArray.Length} configs, please check for protential error.");
                                    else if (SideArray.Length > maxConfig && previousIDSide.Length > 0)
                                        Log($"{previousIDSide} Side property has only {maxConfig} configs, please check for protential error.");

                                    maxCfgSide = Math.Max(BOMArray.Length, maxCfgSide);
                                    previousIDSide = sArray[ExpIDIndex];
                                }

                            }
                        }

                        lcnt++;
                    }
                    sr.Close();

                    if (maxConfig != maxCfgSide)
                    {
                        Log($"BOM config ({maxConfig}) number is different to Side config ({maxCfgSide}).");
                        Log("Proceed Import and check error Log.");
                    }
                }

                for (int i = 1; i <= maxConfig; i++)
                    cb1.Items.Add(i);
                cb1.SelectedIndex = 0;

                if (cb2 != null)
                {
                    for (int i = 1; i <= maxConfig; i++)
                        cb2.Items.Add(i);
                    cb2.SelectedIndex = 0;
                }
            }
            else
                MessageBox.Show($"Invalid {fileExtention} file.");
        }

        private void button_Explode_Click(object sender, EventArgs e)
        {
            comboBox_EBConfig.Enabled = false;
            button_OpenFile1.Enabled = false;
            LogBox.Items.Clear();

            bool errflg = false;

            int fNameIdx = textBox_EBFilePathBOM.Text.LastIndexOf("\\");
            string outputFileName = textBox_EBFilePathBOM.Text.Substring(0, fNameIdx + 1) + $"(Cfg-{comboBox_EBConfig.SelectedItem.ToString()})" + textBox_EBFilePathBOM.Text.Substring(fNameIdx + 1);

            string str = "";
            using (StreamReader sr = new StreamReader(textBox_EBFilePathBOM.Text))
            using (StreamWriter sw = new StreamWriter(outputFileName))
            {
                int BOMColumn = 0, SideColumn = 0, type = 0;
                for (int i=0; i<14; i++)
                {
                    str = sr.ReadLine();
                    string[] sArray = str.Split('\t');

                    if (sArray.Length == 15) //正常格式15欄
                    {
                        BOMColumn = 10;
                        SideColumn = 12;
                        type = 1;

                        sw.WriteLine(string.Join("\t", sArray));
                    }
                    else if (sArray.Length == 14) //精簡格式去除std pn 14欄
                    {
                        BOMColumn = 9;
                        SideColumn = 11;
                        type = 2;

                        string result = string.Join("\t", sArray, 0, 2);
                        result = result + "\t" + ((sArray[0] == "Item") ? "STD PN" : sArray[1]);
                        sw.WriteLine(result + "\t" + string.Join("\t", sArray, 2, 12));
                    }
                    else
                        sw.WriteLine(str);
                }

                while ((str = sr.ReadLine()) != null)
                {

                    string[] sArray = str.Split('\t');

                    if (sArray.Length == 14 || sArray.Length == 15)
                    {
                        // 處理 BOM (欄位11)
                        // ==============================================================================================
                        string[] BOMArray = sArray[BOMColumn].Split(',');
                        if (BOMArray.Length > 1)
                        {
                            if (BOMArray.Length != maxConfig)
                            {
                                Log($"Item {sArray[0]} has {BOMArray.Length} configs for BOM.({sArray[(type == 1) ? 7 : 6]})");
                                errflg = true;
                            }
                            else
                            {
                                sArray[BOMColumn] = BOMArray[(int)comboBox_EBConfig.SelectedItem - 1];
                            }
                        }
                        //BOM簡碼轉換
                        switch (sArray[BOMColumn])
                        {
                            case "X":
                                sArray[BOMColumn] = "NI";
                                break;
                            case "M":
                                sArray[BOMColumn] = "MP";
                                break;
                            case "P":
                                sArray[BOMColumn] = "PROTO";
                                break;
                        }

                        // 處理 Side (欄位13)
                        // ==============================================================================================
                        string[] SideArray = sArray[SideColumn].Split(',');
                        if (SideArray.Length > 1)
                        {
                            if (SideArray.Length != maxConfig)
                            {
                                Log($"Item {sArray[0]} has {SideArray.Length} configs for Side.({sArray[(type == 1) ? 7 : 6]})");
                                errflg = true;
                            }
                            else
                            {
                                sArray[SideColumn] = SideArray[(int)comboBox_EBConfig.SelectedItem - 1];
                            }
                        }

                        //SIDE簡碼轉換
                        if (sArray[SideColumn] == "T")  //[Fix]暫時解決.BOM單行超長問題
                            sArray[SideColumn] = "TOP";
                        else if (sArray[SideColumn] == "B")
                            sArray[SideColumn] = "BOTTOM";
                    }

                    if (sArray.Length > 4 && type == 1)
                        sw.WriteLine(string.Join("\t", sArray));
                    else if (sArray.Length > 4)
                    {
                        string result = string.Join("\t", sArray, 0, 2);
                        result = result + "\t" + ((sArray[0] == "Item") ? "STD PN" : sArray[1]);
                        sw.WriteLine(result + "\t" + string.Join("\t", sArray, 2, sArray.Length-2));
                    }
                    else
                        sw.WriteLine(str);

                }
                sr.Close();
                sw.Close();
            }

            if (errflg)
                MessageBox.Show("Something Wrong!\r\nPlease check Log message.");
            else
            {
                Log($"Config {comboBox_EBConfig.SelectedItem.ToString()} output OK.");
                Log($"File: {outputFileName}");
            }

            comboBox_EBConfig.Enabled = true;
            button_OpenFile1.Enabled = true;
        }

        private void button_OpenFile2_Click(object sender, EventArgs e)
        {
            comboBox_ISConfig.Enabled = false;
            button_ImportSide.Enabled = false;
            textBox_ISFilePathEXP.Text = "";
            comboBox_ISConfig.Items.Clear();
            maxConfig = 1;
            label_ISConfig.Text = "";

            OpenFileDialog f = new OpenFileDialog();
            f.Title = "Select EXP File";
            f.InitialDirectory = ".\\";
            f.Filter = "EXP File (*.exp)|*.exp";
            if (f.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            textBox_ISFilePathEXP.Text = f.FileName;
            GetConfig(f.FileName, comboBox_ISConfig);

            comboBox_ISConfig.Enabled = true;
            button_ImportSide.Enabled = (textBox_ISFilePathEXP.Text.Length > 0 && textBox_ISFilePathTXT.Text.Length > 0) ? true : false;
            label_ISConfig.Text = $"Total {maxConfig} Configs found.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_ImportSide.Enabled = false;
            textBox_ISFilePathTXT.Text = "";

            OpenFileDialog f = new OpenFileDialog();
            f.Title = "Select EXP File";
            f.InitialDirectory = ".\\";
            f.Filter = "RPT File (*.txt;*.rpt)|*.txt;*.rpt|All Files (*.*)|*.*";
            if (f.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            textBox_ISFilePathTXT.Text = f.FileName;
            button_ImportSide.Enabled = (textBox_ISFilePathEXP.Text.Length > 0 && textBox_ISFilePathTXT.Text.Length > 0) ? true : false;
        }

        private void button_Import_Click(object sender, EventArgs e)
        {
            comboBox_ISConfig.Enabled = false;
            button_ISOpenFileEXP.Enabled = false;
            button_ISOpenFileTXT.Enabled = false;
            LogBox.Items.Clear();

            bool errflg = false;
            int config = (int)comboBox_ISConfig.SelectedItem;
            string side;
            int linecount = 0, itemupdated = 0;

            int fNameIdx = textBox_ISFilePathEXP.Text.LastIndexOf("\\");
            string outputFileName = textBox_ISFilePathEXP.Text.Substring(0, fNameIdx + 1) + $"(Cfg-{comboBox_ISConfig.SelectedItem.ToString()})" + textBox_ISFilePathEXP.Text.Substring(fNameIdx + 1);

            string str = "";
            Dictionary<string, string> dicSide = new Dictionary<string, string>();

            using (StreamReader sr = new StreamReader(textBox_ISFilePathTXT.Text))
            {
                while ((str = sr.ReadLine()) != null)
                {
                    string[] sArray = Helper.SplitCsv(str, ',');
                    if (sArray.Length == 9)
                    {
                        dicSide.Add(sArray[0], sArray[8].Equals("NO") ? "TOP" : "BOTTOM");
                    }
                }
                sr.Close();
            }
            Log($"Found {dicSide.Count} parts from component file.");


            using (StreamReader sr = new StreamReader(textBox_ISFilePathEXP.Text))
            using (StreamWriter sw = new StreamWriter(outputFileName))
            {
                while ((str = sr.ReadLine()) != null)
                {
                    string[] sArray = str.Replace("\"", "").Split('\t');
                    if (sArray.Length >= Math.Max(ExpSideIndex, ExpIDIndex) && linecount > 1)
                    {
                        // 處理 Side
                        string ID = sArray[ExpIDIndex]; //零件part reference

                        if (dicSide.ContainsKey(ID))    //有找到零件
                        {
                            side = dicSide[ID];
                            {
                                string[] SideArray = sArray[ExpSideIndex].Split(',');

                                if (SideArray.Length == 1)
                                {
                                    if (SideArray[0] != side)
                                    {
                                        StringBuilder sb = new StringBuilder();
                                        for (int c = 0; c < maxConfig; c++)
                                        {
                                            if (c != config - 1)
                                                sb.Append(SideArray[0]).Append(",");
                                            else
                                                sb.Append(side).Append(",");
                                        }

                                        sArray[ExpSideIndex] = $"\"{sb.ToString().TrimEnd(new char[] { ',' })}\"";
                                        sArray[ExpSideIndex] = sArray[ExpSideIndex].Replace("TOP", "T").Replace("BOTTOM", "B"); //[Fix]暫時解決.BOM單行超長問題
                                    }
                                }
                                else if (SideArray.Length == maxConfig)
                                {
                                    StringBuilder sb = new StringBuilder();
                                    for (int c = 0; c < SideArray.Length; c++)
                                    {
                                        if (c != config - 1)
                                            sb.Append(SideArray[c]).Append(",");
                                        else
                                            sb.Append(side).Append(",");
                                    }

                                    //比較每個side欄位是否都(與side)相同
                                    bool diff = false;
                                    foreach (var s in SideArray)
                                        if (s != side && s != side.Substring(0, 1))
                                            diff = true;

                                    //若相同就統一一個，不同才用config
                                    if (diff)
                                    {
                                        sArray[ExpSideIndex] = $"\"{sb.ToString().TrimEnd(new char[] { ',' })}\"";
                                        sArray[ExpSideIndex] = sArray[ExpSideIndex].Replace("TOP", "T").Replace("BOTTOM", "B"); //[Fix]暫時解決.BOM單行超長問題
                                    }
                                    else
                                        sArray[ExpSideIndex] = $"\"{side}\"";

                                    itemupdated++;
                                }
                                else
                                {
                                    Log($"{sArray[ExpIDIndex]} has different config count between BOM and Side.");
                                    Log(sArray[ExpBOMIndex]);
                                    Log(sArray[ExpSideIndex]);
                                    errflg = true;
                                }
                            }
                        }
                        else
                            Log($"Can't find {sArray[ExpIDIndex]} in component txt file.");

                        sw.WriteLine(string.Join("\t", sArray));
                    }
                    else
                        sw.WriteLine(str);

                    linecount++;
                }
                sr.Close();
                sw.Close();
            }

            if (errflg)
                MessageBox.Show("Something Wrong!\r\nPlease check Log message.");
            else
            {
                Log($"Update {itemupdated} parts in EXP file.");
                Log($"Side info updateded to Config {comboBox_ISConfig.SelectedItem.ToString()}, import EXP back to schematic.");
                Log(outputFileName);
            }

            comboBox_ISConfig.Enabled = true;
            button_ISOpenFileEXP.Enabled = true;
            button_ISOpenFileTXT.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("Item\\tHH PN\\tDescription\\tSupplier\\tSupplier PN\\tQty\\tLocation\\tCCL\\tRemark\\tBOM\\tPackage Type\\tSide\\tSub System\\tFunction");
            Log("Header data for BOM is copied to clipboard.");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Clipboard.SetText("{Item}\\t{Foxconn Part Number}\\t{Description}\\t{Mfg}\\t{Mfg Part Number}\\t{Quantity}\\t{Reference}\\t{CCL}\\t{Remark}\\t{BOM}\\t{Package Type}\\t{Side}\\t{Sub System}\\t{Function}");
            Log("Combined Property String for BOM is copied to clipboard.");
        }

        private void Log(string msg)
        {
            LogBox.Items.Add(msg);
            LogBox.SelectedIndex = LogBox.Items.Count - 1;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void button_OpenFileOM1_Click(object sender, EventArgs e)
        {
            comboBox_OMAction.Enabled = false;
            comboBox_OM1.Enabled = false;
            comboBox_OM2.Enabled = false;
            button_OM.Enabled = false;
            label_OMConfig.Enabled = false;
            textBox_FilePathOM.Text = "";
            comboBox_OM1.Items.Clear();
            comboBox_OM2.Items.Clear();
            label_OM_Total.Text = "";
            label_OMAction.Text = "";
            checkBox_OMSimplifySameConfig.Enabled = false;
            maxConfig = 1;

            OpenFileDialog f = new OpenFileDialog();
            f.Title = "Select EXP File";
            f.InitialDirectory = ".\\";
            f.Filter = "EXP File (*.exp)|*.exp";
            if (f.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            textBox_FilePathOM.Text = f.FileName;
            GetConfig(f.FileName, comboBox_OM1, comboBox_OM2);

            comboBox_OMAction.Enabled = true;
            comboBox_OM1.Enabled = true;
            label_OMConfig.Enabled = true;
            groupBox_OMAction.Enabled = true;
            button_OM.Enabled = (textBox_FilePathOM.Text.Length > 0) ? true : false;
            label_OM_Total.Text = $"Total {maxConfig} Configs found.";
            checkBox_OMSimplifySameConfig.Enabled = true;
            comboBox_OMAction_SelectedValueChanged(this, EventArgs.Empty);
        }

        private void comboBox_OMAction_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox_OMAction.SelectedIndex != -1)
            {
                string OMAction = (string)comboBox_OMAction.SelectedItem;

                switch (OMAction)
                {
                    case "Delete":
                        label_OMAction.Visible = false;
                        comboBox_OM2.Visible = false;
                        break;
                    case "Copy":
                        label_OMAction.Text = "To";
                        label_OMAction.Visible = true;

                        comboBox_OM2.Items.Clear();
                        for (int i = 1; i <= maxConfig + 1; i++)
                            comboBox_OM2.Items.Add(i);
                        comboBox_OM2.SelectedIndex = 0;

                        comboBox_OM2.Visible = true;
                        comboBox_OM2.Enabled = true;
                        break;
                    case "Swap":
                        label_OMAction.Text = "With";
                        label_OMAction.Visible = true;

                        comboBox_OM2.Items.Clear();
                        for (int i = 1; i <= maxConfig; i++)
                            comboBox_OM2.Items.Add(i);
                        comboBox_OM2.SelectedIndex = 0;

                        comboBox_OM2.Visible = true;
                        comboBox_OM2.Enabled = true;
                        break;
                }
            }
        }

        private void button_OM_Click(object sender, EventArgs e)
        {
            if (maxConfig == 1)
                return;

            button_OMOpenFile.Enabled = false;
            comboBox_OMAction.Enabled = false;
            comboBox_OM1.Enabled = false;
            comboBox_OM2.Enabled = false;
            button_OM.Enabled = false;
            label_OMConfig.Enabled = false;
            label_OMAction.Enabled = false;

            if (comboBox_OMAction.SelectedIndex != -1)
            {
                string OMAction = (string)comboBox_OMAction.SelectedItem;

                bool errflg = false;
                int config1 = (int)comboBox_OM1.SelectedItem;
                int config2 = (int)comboBox_OM2.SelectedItem;
                string LogMessage = "";
                int linecount = 0;
                string str = "";

                int fNameIdx = textBox_FilePathOM.Text.LastIndexOf("\\");

                string strOutFileNamePrefix = "";
                switch (OMAction)
                {
                    case "Delete":
                        strOutFileNamePrefix = $"(Delete {config1.ToString()})";
                        break;
                    case "Copy":
                        strOutFileNamePrefix = $"(Copy {config1.ToString()}-{config2.ToString()})";
                        break;
                    case "Swap":
                        strOutFileNamePrefix = $"(Swap {config1.ToString()}-{config2.ToString()})";
                        break;
                    default:
                        strOutFileNamePrefix = $"(Unknown)";
                        break;
                }
                string outputFileName = textBox_FilePathOM.Text.Substring(0, fNameIdx + 1) + strOutFileNamePrefix + textBox_FilePathOM.Text.Substring(fNameIdx + 1);

                using (StreamReader sr = new StreamReader(textBox_FilePathOM.Text))
                using (StreamWriter sw = new StreamWriter(outputFileName))
                {
                    while ((str = sr.ReadLine()) != null)
                    {
                        string[] sArray = str.Replace("\"", "").Split('\t');
                        if (sArray.Length >= Math.Max(ExpSideIndex, ExpIDIndex) && linecount > 1)
                        {
                            string ID = sArray[ExpIDIndex]; //零件part reference
                            string[] SideArray = sArray[ExpSideIndex].Split(',');   // Side
                            string[] BOMArray = sArray[ExpBOMIndex].Split(',');     //BOM

                            switch (OMAction)
                            {
                                case "Delete":
                                    if (SideArray.Length == maxConfig)
                                    {
                                        StringBuilder sb = new StringBuilder();
                                        for (int c = 0; c < SideArray.Length; c++)
                                        {
                                            if (c != config1 - 1)
                                                sb.Append(SideArray[c]).Append(",");
                                        }
                                        sArray[ExpSideIndex] = $"\"{sb.ToString().TrimEnd(new char[] { ',' })}\"";
                                        if (checkBox_OMSimplifySameConfig.Checked)
                                            sArray[ExpSideIndex] = Helper.MergeConfig(sArray[ExpSideIndex]);
                                    }
                                    if (BOMArray.Length == maxConfig)
                                    {
                                        StringBuilder sb = new StringBuilder();
                                        for (int c = 0; c < BOMArray.Length; c++)
                                        {
                                            if (c != config1 - 1)
                                                sb.Append(BOMArray[c]).Append(",");
                                        }
                                        sArray[ExpBOMIndex] = $"\"{sb.ToString().TrimEnd(new char[] { ',' })}\"";
                                        if (checkBox_OMSimplifySameConfig.Checked)
                                            sArray[ExpBOMIndex] = Helper.MergeConfig(sArray[ExpBOMIndex]);
                                    }
                                    LogMessage = $"Delete Config {config1}";
                                    break;

                                case "Copy":
                                    if (config2 - maxConfig > 1)
                                        break;
                                    if (SideArray.Length == maxConfig)
                                    {
                                        StringBuilder sb = new StringBuilder();
                                        string strSource = "";
                                        for (int c = 0; c < Math.Max(SideArray.Length, config2); c++)
                                        {
                                            if (c == config1 - 1) //Source
                                            {
                                                strSource = SideArray[c];
                                                sb.Append(strSource).Append(",");
                                            }
                                            else if (c == config2 - 1)  //Destination
                                                sb.Append(strSource).Append(",");
                                            else
                                                sb.Append(SideArray[c]).Append(",");
                                        }
                                        sArray[ExpSideIndex] = $"\"{sb.ToString().TrimEnd(new char[] { ',' })}\"";
                                        if (checkBox_OMSimplifySameConfig.Checked)
                                            sArray[ExpSideIndex] = Helper.MergeConfig(sArray[ExpSideIndex]);
                                    }
                                    if (BOMArray.Length == maxConfig)
                                    {
                                        StringBuilder sb = new StringBuilder();
                                        string strSource = "";
                                        for (int c = 0; c < Math.Max(BOMArray.Length, config2); c++)
                                        {
                                            if (c == config1 - 1) //Source
                                            {
                                                strSource = BOMArray[c];
                                                sb.Append(strSource).Append(",");
                                            }
                                            else if (c == config2 - 1)  //Destination
                                                sb.Append(strSource).Append(",");
                                            else
                                                sb.Append(BOMArray[c]).Append(",");
                                        }
                                        sArray[ExpBOMIndex] = $"\"{sb.ToString().TrimEnd(new char[] { ',' })}\"";
                                        if (checkBox_OMSimplifySameConfig.Checked)
                                            sArray[ExpBOMIndex] = Helper.MergeConfig(sArray[ExpBOMIndex]);
                                    }
                                    LogMessage = $"Copy Config {config1} to Config {config2}";
                                    break;

                                case "Swap":
                                    if (SideArray.Length == maxConfig)
                                    {
                                        string strbuffer = SideArray[config1-1];
                                        SideArray[config1-1] = SideArray[config2-1];
                                        SideArray[config2-1] = strbuffer;

                                        sArray[ExpSideIndex] = string.Join(",", SideArray);
                                        if (checkBox_OMSimplifySameConfig.Checked)
                                            sArray[ExpSideIndex] = Helper.MergeConfig(sArray[ExpSideIndex]);
                                    }
                                    if (BOMArray.Length == maxConfig)
                                    {
                                        string strbuffer = BOMArray[config1-1];
                                        BOMArray[config1-1] = BOMArray[config2-1];
                                        BOMArray[config2-1] = strbuffer;

                                        sArray[ExpBOMIndex] = string.Join(",", BOMArray);
                                        if (checkBox_OMSimplifySameConfig.Checked)
                                            sArray[ExpBOMIndex] = Helper.MergeConfig(sArray[ExpBOMIndex]);
                                    }
                                    LogMessage = $"Swap Config {config1} with Config {config2}";
                                    break;
                            }

                            sw.WriteLine(string.Join("\t", sArray));
                        }
                        else
                            sw.WriteLine(str);

                        linecount++;
                    }
                    sr.Close();
                    sw.Close();
                }

                if (errflg)
                    MessageBox.Show("Something Wrong!\r\nPlease check Log message.");
                else
                {
                    Log(" ");
                    Log($"{LogMessage} OK, import EXP back to schematic.");
                    Log(outputFileName);
                }
            }

            button_OMOpenFile.Enabled = true;
            comboBox_OMAction.Enabled = true;
            comboBox_OM1.Enabled = true;
            comboBox_OM2.Enabled = true;
            button_OM.Enabled = true;
            label_OMConfig.Enabled = true;
            label_OMAction.Enabled = true;
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///切換tab的時候清空所有tab內control 的資料
            ///
            resetAllControl();
        }


    }
}
