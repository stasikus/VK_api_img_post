using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet.Net;
using xNet.Text;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Threading;
using System.IO;

namespace VK_api_img_post
{
    class LoginAndReq
    {
        public static List<string> friendsList = new List<string>();

        public static bool ValidationAuth(string clientID, string login, string pass)
        {
            using (HttpRequest req = new HttpRequest())
            {
                CookieDictionary cookie = new CookieDictionary(false);
                req.Cookies = cookie;
                req.Get(String.Format("https://login.vk.com/?act=login&email={0}&pass={1}", login, pass));

                string scope = "notify,friends,photos,audio,video,docs,notes,pages,status,offers,questions,wall,groups,messages,notifications,stats,ads,offline"; //permissions for user

                string data = req.Get("https://oauth.vk.com/authorize?client_id=" + clientID + "&scope=" + scope + "&redirect_uri=http://oauth.vk.com/blank.html&display=touch&response_type=token").ToString();
                req.AllowAutoRedirect = false;
                req.Get(data.Substring("<form method=\"post\" action=\"", "\">"));

                char[] symb = { '=', '&' };
                string[] splitData = req.Response.Location.Split(symb);

                if (splitData.Length > 5) // is user valid
                {
                    string token = splitData[1];
                    string userID = splitData[5];
                    return true;
                }
                else
                    return false;

            }
        }

        public static void Auth(string clientID, string login, string pass, string photoPath, int sleepFrom, int sleepTo, string msg, Label sendMsg_l, Label notSendMsg_l)
        {
            using (HttpRequest req = new HttpRequest())
            {
                int sendMsg = 0;
                int notSendMsg = 0;
                
                //req.UserAgent = HttpHelper.FirefoxUserAgent();
                CookieDictionary cookie = new CookieDictionary(false);
                req.Cookies = cookie;
                req.Get(String.Format("https://login.vk.com/?act=login&email={0}&pass={1}", login, pass));

                string scope = "notify,friends,photos,audio,video,docs,notes,pages,status,offers,questions,wall,groups,messages,notifications,stats,ads,offline";

                string data = req.Get("https://oauth.vk.com/authorize?client_id=" + clientID + "&scope=" + scope + "&redirect_uri=http://oauth.vk.com/blank.html&display=touch&response_type=token").ToString();
                req.AllowAutoRedirect = false;
                req.Get(data.Substring("<form method=\"post\" action=\"", "\">"));

                char[] symb = { '=', '&' };
                string[] splitData = req.Response.Location.Split(symb);

                string token = splitData[1]; //token for current user
                string userID = splitData[5]; //user_id for current user
                
                getFriends(req, token, userID); //get friens list

                string photosGetWallUploadServerString = photosGetWallUploadServer(userID, token, req); //get vk URL for upload img

                string photosUploadPhotoToURLString = photosUploadPhotoToURL(photosGetWallUploadServerString, photoPath).ToString(); //get data from upload img

                JObject jObject = JObject.Parse(photosUploadPhotoToURLString);
                string server = jObject["server"].ToString();
                string photo = jObject["photo"].ToString();
                string hash = jObject["hash"].ToString();

                string photosSaveWallPhotoString = photosSaveWallPhoto(server, photo, hash, req, token).ToString(); //save img to wall

                JObject jObject1 = JObject.Parse(photosSaveWallPhotoString);
                int owner_id = Convert.ToInt32(jObject1["response"]["owner_id"]);
                string attachments = jObject1["response"]["id"].ToString();

                string log = "ID юзера кем было отправленно: " + owner_id + "\r\nВсего друзей: " + friendsList.Count + "\r\nКому было отправленно:"; //topic at the file
                StreamWriter sw = new StreamWriter(@"F:\\outLog.txt", true, System.Text.Encoding.UTF8);
                sw.WriteLine(log);

                for (int i = 0; i < friendsList.Count; i++)
                {
                    string wallPostString = wallPost(Convert.ToInt32(friendsList[i]), 0, 0, msg, attachments, token, req); //post msg to wall
                    int randomNum;

                    if (wallPostString.Length < 150)
                    {
                        sendMsg_l.BeginInvoke((Action)delegate
                        {
                            sendMsg++;
                            sendMsg_l.Text = sendMsg.ToString();
                        });

                        log = friendsList[i] + " - отправленно";
                        sw.WriteLine(log);
                        //MessageBox.Show("Сообщение отправленно");
                    }
                    else
                    {
                        notSendMsg_l.BeginInvoke((Action)delegate
                        {
                            notSendMsg++;
                            notSendMsg_l.Text = notSendMsg.ToString();
                        });

                        log = friendsList[i] + " - не отправленно";
                        sw.WriteLine(log);
                        //MessageBox.Show("Сообщение не отправленно");
                    }

                    log = "";
                    Random random = new Random();
                    randomNum = random.Next(sleepFrom, sleepTo);

                    Thread.Sleep(randomNum*1000); //random thread sleep between posting the message
                }
                log = "\r\n---------------\r\n";
                sw.Close();

                
            }
        }

        public static void getFriends(HttpRequest req, string token, string userID)
        {
            string friendsListJson = req.Get(String.Format("https://api.vk.com/method/friends.get?user_id={0}&v=5.25&access_token={1}", userID, token)).ToString();
            JObject jObjectItems = JObject.Parse(friendsListJson);
            string items = jObjectItems["response"]["items"].ToString();
            char[] symb = { ' ', ',' };
            string[] s = items.Split(symb);
            for (int i = 2; i < s.Length; i+=3)
            {
                if (i != Convert.ToInt32(s.Length-1))
                    friendsList.Add(s[i]);
                else
                {
                    s[i] = s[i].Substring(0, s[i].Length - 5); //remove extra symbols in the end of list
                    friendsList.Add(s[i]);
                }
            }

        }

        private static string photosGetWallUploadServer(string userID, string token, HttpRequest req)    //получить сервер для загрузки фото на стену (возвращает upload_url)
        {
            string request_path = "https://api.vk.com/method/photos.getWallUploadServer?";    //формируем ссылку с нужными параметрами для запроса к API
            request_path += "group_id" + userID;
            request_path += "&access_token=" + token;

            string responce = req.Get(request_path).ToString();
            var json = JObject.Parse(responce);     //json парсер
            return json["response"]["upload_url"].ToString();       //возвращает upload_url
        }

        private static JObject photosUploadPhotoToURL(string URL, string file_path)    //загрузка фото на сервер
        {
            WebClient myWebClient = new WebClient();
            byte[] responseArray = myWebClient.UploadFile(URL, file_path);
            var json = JObject.Parse(System.Text.Encoding.ASCII.GetString(responseArray));

            return json;
        }

        private static JObject photosSaveWallPhoto(string server, string photo, string hash, HttpRequest req, string token)
        {
            string request_path = "https://api.vk.com/method/photos.saveWallPhoto?";
            request_path += "server=" + server;
            request_path += "&photo=" + photo;
            request_path += "&hash=" + hash;
            request_path += "&access_token=" + token;

            string responce = req.Get(request_path).ToString();
            var json = JObject.Parse((responce.Replace("[", String.Empty)).Replace("]", String.Empty));       //сначала убираем '[' и ']' из ответа сервера, а зачем парсим
            return json;  //возвращаем объект класса JObject
        }

        private static string wallPost(int owner_id, int friends_only, int from_group, string message, string attachments, string token, HttpRequest req)                    //пост на стенку
        {
            if (message == "" && attachments == "") return "Error: message and attachments is empty!";                //не вызывать API, если msg and attach пустые

            string request_path = "https://api.vk.com/method/wall.post?";     //путь обращения к vk.api
            request_path += "owner_id=" + owner_id;
            request_path += "&access_token=" + token;
            if (message != string.Empty) request_path += "&message=" + message;
            if (attachments != string.Empty) request_path += "&attachments=" + attachments;

           // request_path += "&friends_only=" + friends_only;
           // request_path += "&from_group=" + from_group;                                                       //токен (задается в конструкторе)

            string responce = req.Get(request_path).ToString();
            return responce;
        }
    }
}
