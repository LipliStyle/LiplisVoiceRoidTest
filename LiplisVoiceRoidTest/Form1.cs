using Liplis.Msg;
using Liplis.Voice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiplisVoiceRoidTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ウインドウの名前
            string windowName = "VOICEROID＋ 東北ずん子 EX";

            //EXEのパス
            string exePath = "C:\\Program Files (x86)\\AHS\\VOICEROID+\\ZunkoEX\\VOICEROID.exe";

            //インスタンス化
            LpsVoiceRoid lvr = new LpsVoiceRoid(new msgVoiceRoid(windowName, exePath));

            //おしゃべり
            lvr.addMessage(textBox1.Text);
        }
    }
}
