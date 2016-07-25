//Made by: God_Tenshi
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Reflection;
//Made by: God_Tenshi


/* TODO:
 * -update patch (half done)
 * -check for update (half done)
 * -client UI design (Done)
 * -all buttons function (ok)
 * -Download update ingame file (Haven't done)
 * -Run mhconnect using client (Not yet)
 * -Client Icon (Done)
*/
namespace 天魔墨香登入器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
           
            //以下代码是拿来检查当前程序是否还在执行当中，以防多开此程序
            /*if (System.Windows.Forms.Application.MessageLoop) 
            {
                // WinForms app
                MessageBox.Show("请先关闭当前程序。");
                System.Windows.Forms.Application.Exit();
            }*/
        }
        bool resolution = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            //File.SetAttributes(@path, File.GetAttributes(@path) & ~FileAttributes.ReadOnly);
            var di = new DirectoryInfo(path);
            di.Attributes &= ~FileAttributes.ReadOnly;

            webBrowser1.Navigate("http://127.0.0.1/news.html"); //公告显示网址
            
            //string downloadUrl = "";
            Version newVersion = null;
            //string xmlUrl = "http://www.tmmso.com/update.xml"; //服务器的xml档案地址
            string xmlUrl = "http://127.0.0.1/update.xml";
            XmlTextReader reader = null;
            try
            {
                reader = new XmlTextReader(xmlUrl);
                reader.MoveToContent();
                string elementName = "";
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "TMMS"))
                {
                    while(reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            elementName = reader.Name;
                        }
                        else
                        {
                            if((reader.NodeType == XmlNodeType.Text) && (reader.HasValue))
                            {
                                switch(elementName)
                                {
                                    case "client_version":
                                        newVersion = new Version(reader.Value);
                                        break;
                                }
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {

                MessageBox.Show("无法连接伺服器, 請聯繫管理員。", "单机墨香吧");
               // System.Windows.Forms.Application.Exit();
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
            Version applicationVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            if(applicationVersion.CompareTo(newVersion)< 0)
            {
                MessageBox.Show("侦测到有新版本的登入器，请打开 \"单机墨香吧登入器更新程序\" \n进行更新。 ", "单机墨香吧", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   System.Windows.Forms.Application.Exit();
                   

                
              /*  else
                {
                    MessageBox.Show("目前最新版本", newVersion.ToString());
                    System.Windows.Forms.Application.Exit();
                }*/
                
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //不知道要做什么
        }     
        private void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString()); //进度条变动
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("补丁已经下载完毕。");
            System.Diagnostics.Process.Start("C:/TMMS_Patch/game_update.exe"); //直接打开下载过后的档案, 只能在固定的途径打开
        }

        //以下都是关于登入器的按钮图案操作
        private void officialWeb_button_MouseEnter(object sender, EventArgs e)
        {
            officialWeb_button.Image = Properties.Resources.home1;
        }

        private void officialWeb_button_MouseLeave(object sender, EventArgs e)
        {
            officialWeb_button.Image = Properties.Resources.home2;
        }
        private void facebook_button_MouseEnter(object sender, EventArgs e)
        {
            facebook_button.Image = Properties.Resources.facebook2;
        }

        private void facebook_button_MouseLeave(object sender, EventArgs e)
        {
            facebook_button.Image = Properties.Resources.facebook1;
        }
        private void facebook_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://127.0.0.1");
        }
        private void officialWeb_button_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://newtmms.no-ip.info/");
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("此功能即将开放。", "单机墨香吧", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("http://newtmms.no-ip.info/index_reg.asp");
        }

        private void register_button_MouseEnter(object sender, EventArgs e)
        {
            register_button.Image = Properties.Resources.member2;
        }

        private void register_button_MouseLeave(object sender, EventArgs e)
        {
            register_button.Image  = Properties.Resources.member1;
        }

        private void reload_button_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("此功能即将开放。", "单机墨香吧", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Diagnostics.Process.Start("http://newtmms.no-ip.info/pay.asp");
        }

        private void reload_button_MouseEnter(object sender, EventArgs e)
        {
            reload_button.Image = Properties.Resources.reload2;
        }

        private void reload_button_MouseLeave(object sender, EventArgs e)
        {
            reload_button.Image = Properties.Resources.reload1;
        }

        private void update_button_MouseEnter(object sender, EventArgs e)
        {
            update_button.Image = Properties.Resources.update2;
        }

        private void update_button_MouseLeave(object sender, EventArgs e)
        {
            update_button.Image = Properties.Resources.update1;
        }
        private void update_button_Click(object sender, EventArgs e)
        {


            string revision = ""; 
            string current_revision = "";
            //string xmlUrl = "http://newtmms.no-ip.info/update.xml"; //目前服务器的xml档案位置
            string xmlUrl = "http://127.0.0.1/update.xml";
                XmlTextReader reader = null;
                XmlTextReader server_reader = null;
                string current_xml = "update.xml";
                //StringReader s = new StringReader(单机墨香吧.Properties.Resources.update);
                //XmlTextReader r = new XmlTextReader(s);
                try
                {
                    reader = new XmlTextReader(current_xml);
                    reader.MoveToContent();
                    server_reader = new XmlTextReader(xmlUrl);
                    server_reader.MoveToContent();
                    string elementName = "";
                    string server_elementName = "";
                    if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "TMMS"))
                    {
                        while (reader.Read())
                        {
                            if (reader.NodeType == XmlNodeType.Element)
                            {
                                elementName = reader.Name;
                            }
                            else
                            {
                                if ((reader.NodeType == XmlNodeType.Text) && (reader.HasValue))
                                {
                                    switch (elementName)
                                    {
                                        case "patch":
                                            current_revision = reader.Value;
                                            break;
                                    }
                                }
                            }
                        }
                    }
                    while (server_reader.Read())
                    {
                        if (server_reader.NodeType == XmlNodeType.Element)
                        {
                            server_elementName = server_reader.Name;
                        }
                        else
                        {
                            if ((server_reader.NodeType == XmlNodeType.Text) && (server_reader.HasValue))
                            {
                                switch (server_elementName)
                                {
                                    case "patch":
                                        revision = server_reader.Value;
                                        break;
                                }
                            }
                        }
                    }
                }

                catch (Exception)
                {
                    MessageBox.Show("无法连接伺服器。请检查本机网络服务。", "单机墨香吧", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    if (reader != null)
                        reader.Close();
                    if (server_reader != null)
                        server_reader.Close();
                }
                //Version applicationVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
               // if (applicationVersion.CompareTo(newVersion) < 0)
                
                if(current_revision.CompareTo(revision) <0) //当程序内的xml某个版本与服务器xml的某个版本号不同的话...
                {
                    if (MessageBox.Show("发现游戏更新，要更新吗？", "单机墨香吧", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //System.Diagnostics.Process.Start(current_revision);
                        string folder = "TMMS_Patch";
                        if (!Directory.Exists(@"C:/"+folder))
                        Directory.CreateDirectory(@"C:/"+folder);

                        WebClient client = new WebClient();
                        client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChanged);
                        client.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                        client.DownloadFileAsync(new Uri("http://127.0.0.1/game_update.exe"), @"C:/" + folder + "/game_update.exe");
                        //WebClient game_client = new WebClient();
                        
                        //game_client.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                        //game_client.DownloadFileAsync(new Uri("http://www.tmmso.com/update.xml"), @"E:\newtmms\update.xml");
                    }    

                }
                else
                {
                    MessageBox.Show("无任何更新。", "单机墨香吧", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            //MessageBox.Show("此功能尚未完成。", "单机墨香吧", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void login_button_MouseEnter(object sender, EventArgs e)
        {
            login_button.Image = Properties.Resources.login_2;
        }

        private void login_button_MouseLeave(object sender, EventArgs e)
        {
            login_button.Image = Properties.Resources.login_1;
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("无任何更新。", "单机墨香吧", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Process process = new Process();
            string revision = "";
            string current_revision = "";
            //string xmlUrl = "http://newtmms.no-ip.info/update.xml"; //目前服务器的xml档案位置
            string xmlUrl = "http://127.0.0.1/update.xml";
            XmlTextReader reader = null;
            XmlTextReader server_reader = null;
            string current_xml = "update.xml";
            //StringReader s = new StringReader(单机墨香吧.Properties.Resources.update);
            //XmlTextReader r = new XmlTextReader(s);
            try
            {
                reader = new XmlTextReader(current_xml);
                reader.MoveToContent();
                server_reader = new XmlTextReader(xmlUrl);
                server_reader.MoveToContent();
                string elementName = "";
                string server_elementName = "";
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "TMMS"))
                {
                    while (reader.Read())
                    {
                        if (reader.NodeType == XmlNodeType.Element)
                        {
                            elementName = reader.Name;
                        }
                        else
                        {
                            if ((reader.NodeType == XmlNodeType.Text) && (reader.HasValue))
                            {
                                switch (elementName)
                                {
                                    case "patch":
                                        current_revision = reader.Value;
                                        break;
                                }
                            }
                        }
                    }
                }
                while (server_reader.Read())
                {
                    if (server_reader.NodeType == XmlNodeType.Element)
                    {
                        server_elementName = server_reader.Name;
                    }
                    else
                    {
                        if ((server_reader.NodeType == XmlNodeType.Text) && (server_reader.HasValue))
                        {
                            switch (server_elementName)
                            {
                                case "patch":
                                    revision = server_reader.Value;
                                    break;
                            }
                        }
                    }
                }
            }

            catch (Exception)
            {
                MessageBox.Show("无法连接伺服器。请检查本机网络服务。", "单机墨香吧", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
                if (server_reader != null)
                    server_reader.Close();
            }
            
            if (resolution != false)
            {
                if (current_revision.CompareTo(revision) <0)
                {
                    MessageBox.Show("请先更新游戏！", "单机墨香吧", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //string path = Directory.GetCurrentDirectory();
                    //File.SetAttributes(@path, File.GetAttributes(@path) & ~FileAttributes.ReadOnly);
                    /*if (File.Exists(path))
                    {
                        File.SetAttributes(@"E:\testMS\Do_Not_Press.exe", FileAttributes.Normal);
                        File.WriteAllBytes(@"E:\testMS\Do_Not_Press.exe", 单机墨香吧.Properties.Resources.Do_Not_Press);

                        Process.Start(@"E:\testMS\Do_Not_Press.exe");
                        File.SetAttributes(@"E:\testMS\Do_Not_Press.exe", File.GetAttributes(@"E:\testMS\Do_Not_Press.exe") | FileAttributes.Hidden);
                        System.Windows.Forms.Application.Exit();
                        //File.Delete("Do_Not_Press.exe");
                    }
                   else
                    {
                        //MessageBox.Show("请务必把客户端放在C盘，别乱更改客户端文件名字否则系统无法侦测到。", "单机墨香吧", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                       // File.SetAttributes(path,File.GetAttributes(path) | ~FileAttributes.ReadOnly);
                        
                        File.WriteAllBytes(path, 单机墨香吧.Properties.Resources.Do_Not_Press);
                    }*/
                    try
                    { 
                        Process.Start("TMMS.exe");
                        System.Windows.Forms.Application.Exit();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("无法开启游戏，请稍后尝试。如果问题还是存在，请联系客服。", "单机墨香吧", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }
            else
            {
                MessageBox.Show("请选择视窗大小!", "单机墨香吧", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void close_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void close_button_MouseEnter(object sender, EventArgs e)
        {
            close_button.Image = Properties.Resources.close1;
        }

        private void close_button_MouseLeave(object sender, EventArgs e)
        {
            close_button.Image = Properties.Resources.close;
        }

        private void resolution_back_Click(object sender, EventArgs e)
        {
            resolution_800.Visible = true;
            resolution_1024.Visible = true;
            resolution_full.Visible = true;
            
        }

        private void resolution_800_Click(object sender, EventArgs e)
        {
            resolution_back.Image = Properties.Resources.re_800;
            resolution_800.Visible = false;
            resolution_1024.Visible = false;
            resolution_full.Visible = false;
            resolution = true;

            string path = "AutopatchOption.opt";
            File.WriteAllText(path, "#WINDOWMODE 1" + Environment.NewLine + "#RESOLUTION 800 600");

        }

        private void resolution_1024_Click(object sender, EventArgs e)
        {
            resolution_back.Image = Properties.Resources.re_1024;
            resolution_800.Visible = false;
            resolution_1024.Visible = false;
            resolution_full.Visible = false;
            resolution = true;

            string path = "AutopatchOption.opt";
            File.WriteAllText(path, "#WINDOWMODE 1" + Environment.NewLine + "#RESOLUTION 1024 768");
        }

        private void resolution_full_Click(object sender, EventArgs e)
        {
            resolution_back.Image = Properties.Resources.re_full;
            resolution_800.Visible = false;
            resolution_1024.Visible = false;
            resolution_full.Visible = false;
            resolution = true;

            string path = "AutopatchOption.opt";
            File.WriteAllText(path, "#WINDOWMODE 0" + Environment.NewLine + "#RESOLUTION 1024 768");
        }

      
        

       
        
        //以上按钮操作到此结束
      
    }
}
