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

        public static Dictionary<string, string> validUserDictionary = new Dictionary<string, string>();

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
            int validUsr = 0;
            int notValidUser = 0;
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
                bool valid;
                valid = LoginAndReq.ValidationAuth(4587698, LoadList.userDictionary.ElementAt(i).Key, LoadList.userDictionary.ElementAt(i).Value);

                if (valid)
                {
                    validUserDictionary.Add(LoadList.userDictionary.ElementAt(i).Key, LoadList.userDictionary.ElementAt(i).Value);
                    validUser_lbl.Text = (++validUsr).ToString();
                }
                else
                {
                    notValidUser_lbl.Text = (++notValidUser).ToString();
                }
                
            }
            MessageBox.Show("DONE");
        }

        private void start_bnt_Click(object sender, EventArgs e)
        {

        }
    }
}
