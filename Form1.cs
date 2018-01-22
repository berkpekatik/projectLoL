using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.Web.Script.Serialization;
using System.Web.Script;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Resources;
using System.Reflection;


//api key = ?api_key=RGAPI-d58dcb7c-a18f-47cb-8696-f4908b1aa373
//League Search https://tr1.api.riotgames.com/lol/league/v3/positions/by-summoner/642260?api_key=RGAPI-8fb6671b-56b9-4b9a-b31b-4f85e40b6e48
//Summoner Search https://tr1.api.riotgames.com/lol/summoner/v3/summoners/by-name/Vols?api_key=RGAPI-8fb6671b-56b9-4b9a-b31b-4f85e40b6e48
//https://tr1.api.riotgames.com/lol/league/v3/positions/by-summoner/2812929?api_key=RGAPI-8fb6671b-56b9-4b9a-b31b-4f85e40b6e48

namespace ProjectLoL
{
    public partial class Form1 : Form
    {
        string apikey = "?api_key=RGAPI-d58dcb7c-a18f-47cb-8696-f4908b1aa373";
        string aURL = "https://tr1.api.riotgames.com/lol/";
        string searchTypeSummoner = "summoner/v3/summoners/by-name/";
        string searchTypeLeague = "league/v3/positions/by-summoner/";
        public Form2 f2;
        JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(0, 31, 63);
            sumLabel.Text = f2.summonerName.ToString();
            foreach (Label l in Controls.OfType<Label>())
                l.BackColor = System.Drawing.Color.Transparent;
            sumSearch("Vols");
        }
        void sumSearch(string id)
        {
            var json = new WebClient().DownloadString(aURL + searchTypeSummoner + id + apikey);
            List<summonerSearch> listSumSearch = (List<summonerSearch>)javaScriptSerializer.Deserialize(json, typeof(List<summonerSearch>));
            foreach (var sumsearch in listSumSearch)
            {
                sumIcon(sumsearch.profileIconId);
                sumLeague(sumsearch.id);
            }
        }
        void sumIcon(int profileIconId)
        {
            var request = WebRequest.Create("http://opgg-static.akamaized.net/images/profile_icons/profileIcon" + profileIconId + ".jpg");
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox1.Image = Bitmap.FromStream(stream);
            }
        }
        void sumLeague(int id)
        {
            var jsun = new WebClient().DownloadString(aURL + searchTypeLeague + id + apikey);
            List<summonerLeague> listSumLeague = (List<summonerLeague>)javaScriptSerializer.Deserialize(jsun, typeof(List<summonerLeague>));
            foreach (summonerLeague sumleague in listSumLeague)
            {
                var request = WebRequest.Create("http://berkpekatik.com/rank/" + sumleague.tier + "_" + sumleague.rank + ".png");
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    pictureBox2.Image = Bitmap.FromStream(stream);
                }
                wText.Text = sumleague.wins.ToString();
                lText.Text = sumleague.losses.ToString();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

