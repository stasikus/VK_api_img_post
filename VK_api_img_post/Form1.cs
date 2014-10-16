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
       // String pathForLog = String.Empty;

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
            LoadList.userDictionary = new Dictionary<string, string>();
            validUserDictionary = new Dictionary<string, string>();
            validUser_lbl.Text = "0";
            notValidUser_lbl.Text = "0";
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

            Thread mainThread = new Thread((checkValidUser));
            mainThread.IsBackground = true;
            mainThread.SetApartmentState(ApartmentState.STA);
            mainThread.Start();           
        }

        private void start_bnt_Click(object sender, EventArgs e)
        {
            sendMsg_lbl.Text = "0";
            notSendMsg_lbl.Text = "0";

            if (fromSleep_tb.Text != "" && toSleep_tb.Text != "" && msgText_tb.Text != "" && appID_tb.Text != "")
            {
                Thread mainThread = new Thread((authValidUser));
                mainThread.IsBackground = true;
                mainThread.SetApartmentState(ApartmentState.STA);
                mainThread.Start();
            }
            else
            {
                MessageBox.Show("Не все поля заполенны");
            }
            
        }

        void checkValidUser() //check users if they are valid
        {
            int validUsr = 0;
            int notValidUser = 0;

            for (int i = 0; i < LoadList.userDictionary.Count; i++)
            {
                bool valid = false;
                valid = LoginAndReq.ValidationAuth(appID_tb.Text, LoadList.userDictionary.ElementAt(i).Key, LoadList.userDictionary.ElementAt(i).Value);

                if (valid)
                {
                    validUserDictionary.Add(LoadList.userDictionary.ElementAt(i).Key, LoadList.userDictionary.ElementAt(i).Value);
                    validUser_lbl.BeginInvoke((Action)delegate
                    {
                        validUser_lbl.Text = (++validUsr).ToString();
                    });
                    
                }
                else
                {
                    notValidUser_lbl.BeginInvoke((Action)delegate
                    {
                        notValidUser_lbl.Text = (++notValidUser).ToString();
                    });
                }
            }

            MessageBox.Show("Проверка юзеров закончена");
        }

        void authValidUser() //start the thread for posting the messages to wall by valid users
        {
            bool inputCaptchaType = true;
            if (captcha_manual.Checked != true)
                inputCaptchaType = false;

            for (int i = 0; i < validUserDictionary.Count; i++)
            {
                LoginAndReq.Auth(appID_tb.Text, validUserDictionary.ElementAt(i).Key, validUserDictionary.ElementAt(i).Value, photoPathLocation, Convert.ToInt32(fromSleep_tb.Text), Convert.ToInt32(toSleep_tb.Text), msgText_tb.Text, sendMsg_lbl, notSendMsg_lbl, inputCaptchaType, antigateKey_TB.Text);
            }

            MessageBox.Show("Все сообщения отправленно");
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
               // pathForLog = System.IO.Path.GetDirectoryName(photoPathLocation);
            }
            else
            {
                photoPathLocation = "";
                //pathForLog = "";
                loadedPic_lbl.Text = "не выбранно";
            }

        }

        private void captcha_manual_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void check_balance_btn_Click(object sender, EventArgs e)
        {
            balance_lbl.Text = "0";
            Thread tr = new Thread(checkBalance);
            tr.IsBackground = true;
            tr.Start();
        }

        void checkBalance()
        {
            try
            {
                balance_lbl.BeginInvoke((Action)delegate
                {
                    balance_lbl.Text = Anticaptcha.Balance(antigateKey_TB.Text) + " $";
                });
            }
            catch (Exception)
            {
                MessageBox.Show("Данный ключ не валидный");
            }

        }

        
    }
}
