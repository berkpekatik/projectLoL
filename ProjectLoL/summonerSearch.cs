using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLoL
{
    //https://tr1.api.riotgames.com/lol/summoner/v3/summoners/by-name/Vols?api_key=RGAPI-8fb6671b-56b9-4b9a-b31b-4f85e40b6e48
    class summonerSearch
    {
            public int id { get; set; }
            public int accountId { get; set; }
            public string name { get; set; }
            public int profileIconId { get; set; }
            public long revisionDate { get; set; }
            public int summonerLevel { get; set; }
    }
}
