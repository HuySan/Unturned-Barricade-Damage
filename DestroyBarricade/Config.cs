﻿using Rocket.API;
using System.Collections.Generic;
using DestroyBarricade.Types;

namespace BarricadeDamage
{
    public class Config : IRocketPluginConfiguration
    {
        public BarricadeSettings barricadeSettings;
        public void LoadDefaults()
        {
            barricadeSettings = new BarricadeSettings(true, 30, 50, new List<int>
            {
                288,
                289,
                290,
                291,
                292,
                293,
                294,
                295,
                1243,
                325,
                366,
                1202,
                1205,
                1223,
                1231,
                1235,
                1257,
                1245,
                1278,
                1329,
                1467,
                282,
                326,
                367,
                455,
                1246,
                1279,
                1330,
                283,
                327,
                368,
                456,
                1097,
                1225,
                1247,
                1280,
                378,
                379,
                284,
                286,
                287,
                328,
                457,
                1098,
                1220,
                1221,
                1226,
                1234,
                1238,
                1260,
                1248,
                1254,
                1281,
                1332,
                1413,
                1470,
                331,
                362,
                365,
                382,
                386,
                459,
                1158,
                1208,
                1219,
                1222,
                1227,
                1228,
                1229,
                1119,
                1130,
                1131,
                1249,
                1250,
                1255,
                1256,
                1282,
                1283,
                1296,
                1297,
                1298,
                1299,
                1327,
                1345,
                1408,
                1409,
                458,
                1230,
                1194,
                1050,
                1244,
                1261,
                1372,
                1373,
            });
        }
    }
}