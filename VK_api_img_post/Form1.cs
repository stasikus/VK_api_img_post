using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
        String photoPathLocation = String.Empty;

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
                bool valid = false;
                valid = LoginAndReq.ValidationAuth(appID_tb.Text, LoadList.userDictionary.ElementAt(i).Key, LoadList.userDictionary.ElementAt(i).Value);
                //LoginAndReq.Auth(appID_tb.Text, LoadList.userDictionary.ElementAt(i).Key, LoadList.userDictionary.ElementAt(i).Value, photoPathLocation);

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
            //MessageBox.Show("DONE");
        }

        private void start_bnt_Click(object sender, EventArgs e)
        {
            if (photoPathLocation != "" && fromSleep_tb.Text != "" && toSleep_tb.Text != "" && msgText_tb.Text != "" && appID_tb.Text != "")
            {
                for (int i = 0; i < validUserDictionary.Count; i++)
                {
                    LoginAndReq.Auth(appID_tb.Text, validUserDictionary.ElementAt(i).Key, validUserDictionary.ElementAt(i).Value, photoPathLocation, Convert.ToInt32(fromSleep_tb.Text), Convert.ToInt32(toSleep_tb.Text), msgText_tb.Text, sendMsg_lbl, notSendMsg_lbl);

                    // Thread tr = new Thread(() => LoginAndReq.Auth(appID_tb.Text, validUserDictionary.ElementAt(i).Key, validUserDictionary.ElementAt(i).Value, photoPathLocation, Convert.ToInt32(fromSleep_tb.Text), Convert.ToInt32(toSleep_tb.Text)));
                    //tr.IsBackground = true;
                    // tr.Start();
                    // Thread.Sleep(1000);
                }
                MessageBox.Show("DONE");
            }
            else
            {
                MessageBox.Show("Не все поля заполенны");
            }
            
        }

        private void load_pic_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog frm = new OpenFileDialog();
            frm.InitializeLifetimeService();
            frm.Filter = "Config Files (*.jpg, *.jpeg, *.png)|*.jpg; *.jpeg; *.png";
            frm.Title = "Browse Config file";
            DialogResult dialRes = STAShowDialog(frm);

            if (dialRes == DialogResult.OK)
            {
                photoPathLocation = frm.FileName;
                loadedPic_lbl.Text = frm.FileName;
            }
            else
            {
                photoPathLocation = "";
                loadedPic_lbl.Text = "не выбранно";
            }

        }

        
    }
}
