using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLoL
{
    class api
    {
        public string apikey = "";
        public string aURL = "https://tr1.api.riotgames.com/lol/";
        public string searchTypeSummoner = "summoner/v3/summoners/by-name/";
        public string searchTypeLeague = "league/v3/positions/by-summoner";
    }
}
