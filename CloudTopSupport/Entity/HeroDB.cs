using GA.BaseHelper;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.IO;
using System.Linq;

namespace CloudTopSupport.Entity
{
    public class RetailContext : DbContext
    {
        public RetailContext()
            : base("Hero")
        {
        }
        public DbSet<Hero> Heros { set; get; }
        public DbSet<HeroRace> HeroRace { set; get; }
        public DbSet<HeroProfession> HeroProfession { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
    public class HeroDB : DropCreateDatabaseIfModelChanges<RetailContext>
    {
        private static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "hero.db");
        private static SQLiteDBHelper db = new SQLiteDBHelper(dbPath);

        protected override void Seed(RetailContext context)
        {
            base.Seed(context);
        }
        static HeroDB()
        {
            if (!File.Exists(dbPath))
            {
                db.CreateDb(dbPath);

                db.CreateTable(@"CREATE TABLE [Hero] (
                              [Id] INTEGER NOT NULL PRIMARY KEY, 
                              [Name] VARCHAR(50) NOT NULL, 
                              [RaceId] VARCHAR(50) NOT NULL, 
                              [ProfessionId] VARCHAR(50) NOT NULL, 
                              [Fee] INTEGER NOT NULL, 
                              [Icon] VARCHAR(50));");

                db.CreateTable(@"CREATE TABLE [HeroRace] (
                              [Id] INTEGER NOT NULL PRIMARY KEY, 
                              [Name] VARCHAR(50) NOT NULL, 
                              [Icon] VARCHAR(50));");

                db.CreateTable(@"CREATE TABLE [HeroProfession] (
                              [Id] INTEGER NOT NULL PRIMARY KEY, 
                              [Name] VARCHAR(50) NOT NULL, 
                              [Icon] VARCHAR(50));");

                InitTable();
            }
        }

        private static void InitTable()
        {
            using (RetailContext context = new RetailContext())
            {
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
                    hero.Name = Enum.GetName(typeof(HeroEnum), item);
                    heros.Add(hero);
                }
                context.Heros.AddRange(heros);

                List<HeroRace> heroRaces = new List<HeroRace>();
                foreach (int item in Enum.GetValues(typeof(RaceEnum)))
                {
                    HeroRace hero = new HeroRace();
                    hero.Id = item;
                    hero.Name = Enum.GetName(typeof(RaceEnum), item);
                    heroRaces.Add(hero);
                }
                context.HeroRace.AddRange(heroRaces);

                List<HeroProfession> heroProfessions = new List<HeroProfession>();
                foreach (int item in Enum.GetValues(typeof(ProfessionEnum)))
                {
                    HeroProfession hero = new HeroProfession();
                    hero.Id = item;
                    hero.Name = Enum.GetName(typeof(ProfessionEnum), item);
                    heroProfessions.Add(hero);
                }
                context.HeroProfession.AddRange(heroProfessions);

                context.SaveChanges();
            }
        }
    }
}
