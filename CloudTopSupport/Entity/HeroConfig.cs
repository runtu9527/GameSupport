using GA.BaseHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudTopSupport.Entity
{
    public class HeroConfig
    {
        public List<Hero> Heros { set; get; }
        public List<HeroRace> HeroRace { set; get; }
        public List<HeroProfession> HeroProfession { set; get; }
    }

    public class HeroConfigHelper
    {
        private static string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");

        public static readonly HeroConfig Context = new HeroConfig();
        public HeroConfigHelper()
        {
            InitTable();
        }

        private static void InitTable()
        {
            HeroConfig context = new HeroConfig();
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

            using(StreamWriter sw=new StreamWriter(configPath,false))
            {
                string jsonStr=
            }
        }
    }
}
