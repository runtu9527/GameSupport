using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudTopSupport.Entity
{
    [Table("Hero")]
    public class Hero
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int RaceId { get; set; }
        public int ProfessionId { get; set; }
        public int Fee { get; set; }
        public byte[] Icon { get; set; }
    }

    [Table("HeroRace")]
    public class HeroRace
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Icon { get; set; }
    }

    [Table("HeroProfession")]
    public class HeroProfession
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public byte[] Icon { get; set; }
    }

    public enum RaceEnum
    {
        anying,
        diguo,
        emo,
        guizu,
        haidao,
        jiqiren,
        jidi,
        langren,
        @long,
        renzhe,
        xukong,
    }

    public enum ProfessionEnum
    {
        cike,
        doushi,
        fashi,
        huwei,
        huanxingshi,
        jianshi,
        qishi,
        qiangshou,
        youxia,
        yuansushi,
    }

    public enum HeroEnum
    {
        akali,
        ali,
        aobama,
        baonv,
        bingnv,
        bobi,
        bulong,
        chuanzhang,
        dachongzi,
        delaiwen,
        fenghuang,
        gailun,
        gouxiong,
        guafu,
        hanbing,
        huonan,
        jiqiren,
        jianji,
        jianmo,
        jie,
        jiesi,
        jinkesi,
        kamier,
        kapai,
        kate,
        kainan,
        kasading,
        langren,
        leikesai,
        longnv,
        longwang,
        lulu,
        luoke,
        moganna,
        naer,
        nanqiang,
        nvqiang,
        paike,
        qianjue,
        rinv,
        shen,
        shizigou,
        sige,
        tanglang,
        qianshi,
        tienan,
        weien,
        weilusi,
        wei,
        wuya,
        xiaofa,
        xiaopao,
        yasuo,
        zhizhu,
        zhumei,
    }
}
