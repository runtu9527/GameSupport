using GA.BaseHelper;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace CloudTopSupport.Entity
{
    public class HeroConfig
    {
        public List<Hero> Heros { set; get; } = new List<Hero>();
        public List<HeroRace> HeroRace { set; get; } = new List<HeroRace>();
        public List<HeroProfession> HeroProfession { set; get; } = new List<HeroProfession>();
    }

    public class HeroConfigHelper
    {
        private static string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");

        public static readonly HeroConfig Context = new HeroConfig();
        static HeroConfigHelper()
        {
            if (!File.Exists(configPath))
            {
                Context = InitTable();
            }
            else
            {
                try
                {
                    using (StreamReader sr = new StreamReader(configPath))
                    {
                        string jsonStr = sr.ReadToEnd();
                        Context = JsonConvert.DeserializeObject<HeroConfig>(jsonStr);
                    }
                }
                catch (System.Exception ex)
                {
                    Context = InitTable();
                }
            }
        }

        private static HeroConfig InitTable()
        {
            var context = new HeroConfig();
            context.HeroProfession = new List<HeroProfession>();
            context.HeroRace = new List<HeroRace>();
            context.Heros = new List<Hero>();
            List<Hero> heros = new List<Hero>();
            foreach (int item in Enum.GetValues(typeof(HeroEnum)))
            {
                Hero hero = new Hero();
                hero.Id = item;
                HeroAttribute attr = ((HeroEnum)item).GetAttribute<HeroAttribute>();
                if (attr != null)
                {
                    hero.RaceId = string.Join(",", attr.Race.Select(p => (int)p));
                    hero.ProfessionId = string.Join(",", attr.Profession.Select(p => (int)p));
                    hero.Fee = attr.Fee;
                }
                hero.Name = ((HeroEnum)item).GetText();
                hero.Icon = ((HeroEnum)item).GetAttribute<IconAttribute>().IconPath;
                heros.Add(hero);
            }
            context.Heros.AddRange(heros);

            List<HeroRace> heroRaces = new List<HeroRace>();
            foreach (int item in Enum.GetValues(typeof(RaceEnum)))
            {
                HeroRace hero = new HeroRace();
                hero.Id = item;
                hero.Name = ((RaceEnum)item).GetText();
                hero.Icon = ((RaceEnum)item).GetAttribute<IconAttribute>().IconPath;
                heroRaces.Add(hero);
            }
            context.HeroRace.AddRange(heroRaces);

            List<HeroProfession> heroProfessions = new List<HeroProfession>();
            foreach (int item in Enum.GetValues(typeof(ProfessionEnum)))
            {
                HeroProfession hero = new HeroProfession();
                hero.Id = item;
                hero.Name = ((ProfessionEnum)item).GetText();
                hero.Icon = ((ProfessionEnum)item).GetAttribute<IconAttribute>().IconPath;
                heroProfessions.Add(hero);
            }
            context.HeroProfession.AddRange(heroProfessions);

            using (StreamWriter sw = new StreamWriter(configPath, false))
            {
                string jsonStr = JsonConvert.SerializeObject(context);
                sw.Write(jsonStr);
            }

            return context;
        }
    }
}
