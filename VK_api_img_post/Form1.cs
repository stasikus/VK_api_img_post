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

        private void Auth(string login, string pass)
        {
            using (var req = new HttpRequest())
            {
                //req.UserAgent = HttpHelper.FirefoxUserAgent();
                CookieDictionary cookie = new CookieDictionary(false);
                req.Cookies = cookie;
                req.Get(String.Format("https://login.vk.com/?act=login&email={0}&pass={1}", login, pass));

                string data = req.Get("https://oauth.vk.com/authorize?client_id=4588326&scope=notify,friends,photos,status,wall&redirect_uri=http://oauth.vk.com/blank.html&display=touch&response_type=token").ToString();
                req.AllowAutoRedirect = false;
                req.Get(data.Substring("<form method=\"post\" action=\"", "\">"));

                char[] symb = { '=', '&' };
                string[] splitData = req.Response.Location.Split(symb);

                string token = splitData[1];
                string userID = splitData[5];

                string friendsList = req.Get(String.Format("https://api.vk.com/method/friends.get?user_id={0}&v=5.25&access_token={1}", userID, token)).ToString();
                
                MessageBox.Show(token);
            }
        }

        private void load_btn_Click(object sender, EventArgs e)
        {
            Auth("+380631818725", "qazmko123123123");
        }
    }
}
