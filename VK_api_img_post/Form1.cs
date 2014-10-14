using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet.Net;
using xNet.Text;

namespace VK_api_img_post
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DialogResult STAShowDialog(FileDialog dialog)
        {
            DialogState state = new DialogState();
            state.dialog = dialog;
            System.Threading.Thread t = new System.Threading.Thread(state.ThreadProcShowDialog);
            t.SetApartmentState(System.Threading.ApartmentState.STA);
            t.Start();
            t.IsBackground = true;
            t.Join();
            return state.result;
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            String pathLocation = String.Empty;
            OpenFileDialog frm = new OpenFileDialog();
            frm.InitializeLifetimeService();
            frm.Filter = "Config Files (*.txt)|*.txt";
            frm.Title = "Browse Config file";
            DialogResult dialRes = STAShowDialog(frm);

            if (dialRes == DialogResult.OK)
                pathLocation = frm.FileName;

            string path;
            if (pathLocation != "")
            {
                path = pathLocation;
                LoadList.loadUsersList(path);
            }

            for (int i = 0; i < LoadList.userDictionary.Count; i++)
            {
                LoginAndReq.Auth(4587698, LoadList.userDictionary.ElementAt(i).Key, LoadList.userDictionary.ElementAt(i).Value);
                MessageBox.Show("DONE");
            }
        }
    }
}
