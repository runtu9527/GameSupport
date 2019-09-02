using GA.BaseHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CloudTopSupport.Entity
{
    public enum HeroEnum
    {
        [Text("阿卡丽")]
        [Icon("Hero/阿卡丽.png")]
        [Hero(new[] { RaceEnum.renzhe }, new[] { ProfessionEnum.cike }, 4)]
        akali,
        [Text("阿狸")]
        [Icon("Hero/阿狸.png")]
        [Hero(new[] { RaceEnum.kuangye }, new[] { ProfessionEnum.fashi }, 2)]
        ali,
        [Text("圣枪游侠")]
        [Icon("Hero/奥巴马.png")]
        [Hero(new[] { RaceEnum.guizu }, new[] { ProfessionEnum.qiangshou }, 2)]
        aobama,
        [Text("豹女")]
        [Icon("Hero/豹女.png")]
        [Hero(new[] { RaceEnum.kuangye }, new[] { ProfessionEnum.huanxingshi }, 1)]
        baonv,
        [Text("冰霜女巫")]
        [Icon("Hero/冰女.png")]
        [Hero(new[] { RaceEnum.jidi }, new[] { ProfessionEnum.yuansushi }, 2)]
        bingnv,
        [Text("波比")]
        [Icon("Hero/波比.png")]
        [Hero(new[] { RaceEnum.yuedeerren }, new[] { ProfessionEnum.qishi }, 3)]
        bobi,
        [Text("布隆")]
        [Icon("Hero/布隆.png")]
        [Hero(new[] { RaceEnum.jidi }, new[] { ProfessionEnum.huwei }, 2)]
        bulong,
        [Text("船长")]
        [Icon("Hero/船长.png")]
        [Hero(new[] { RaceEnum.haidao }, new[] { ProfessionEnum.jianshi, ProfessionEnum.qiangshou }, 3)]
        chuanzhang,
        [Text("大虫子")]
        [Icon("Hero/大虫子.png")]
        [Hero(new[] { RaceEnum.xukong }, new[] { ProfessionEnum.doushi }, 4)]
        dachongzi,
        [Text("德莱文")]
        [Icon("Hero/德莱文.png")]
        [Hero(new[] { RaceEnum.diguo }, new[] { ProfessionEnum.jianshi }, 4)]
        delaiwen,
        [Text("凤凰")]
        [Icon("Hero/凤凰.png")]
        [Hero(new[] { RaceEnum.jidi }, new[] { ProfessionEnum.yuansushi }, 5)]
        fenghuang,
        [Text("盖伦")]
        [Icon("Hero/盖伦.png")]
        [Hero(new[] { RaceEnum.guizu }, new[] { ProfessionEnum.qishi }, 1)]
        gailun,
        [Text("狗熊")]
        [Icon("Hero/狗熊.png")]
        [Hero(new[] { RaceEnum.jidi }, new[] { ProfessionEnum.doushi }, 3)]
        gouxiong,
        [Text("寡妇")]
        [Icon("Hero/寡妇.png")]
        [Hero(new[] { RaceEnum.emo }, new[] { ProfessionEnum.cike }, 3)]
        guafu,
        [Text("寒冰")]
        [Icon("Hero/寒冰.png")]
        [Hero(new[] { RaceEnum.jidi }, new[] { ProfessionEnum.youxia }, 3)]
        hanbing,
        [Text("火男")]
        [Icon("Hero/火男.png")]
        [Hero(new[] { RaceEnum.emo }, new[] { ProfessionEnum.yuansushi }, 4)]
        huonan,
        [Text("机器人")]
        [Icon("Hero/机器人.png")]
        [Hero(new[] { RaceEnum.jiqiren }, new[] { ProfessionEnum.doushi }, 2)]
        jiqiren,
        [Text("剑姬")]
        [Icon("Hero/剑姬.png")]
        [Hero(new[] { RaceEnum.guizu }, new[] { ProfessionEnum.jianshi }, 1)]
        jianji,
        [Text("剑魔")]
        [Icon("Hero/剑魔.png")]
        [Hero(new[] { RaceEnum.emo }, new[] { ProfessionEnum.jianshi }, 3)]
        jianmo,
        [Text("劫")]
        [Icon("Hero/劫.png")]
        [Hero(new[] { RaceEnum.renzhe }, new[] { ProfessionEnum.cike }, 2)]
        jie,
        [Text("杰斯")]
        [Icon("Hero/杰斯.png")]
        [Hero(new[] { RaceEnum.haikesikeji }, new[] { ProfessionEnum.huanxingshi }, 2)]
        jiesi,
        [Text("金克斯")]
        [Icon("Hero/金克斯.png")]
        [Hero(new[] { RaceEnum.haikesikeji }, new[] { ProfessionEnum.qiangshou }, 4)]
        jinkesi,
        [Text("卡密尔")]
        [Icon("Hero/卡密尔.png")]
        [Hero(new[] { RaceEnum.haikesikeji }, new[] { ProfessionEnum.jianshi }, 1)]
        kamier,
        [Text("卡牌")]
        [Icon("Hero/卡牌.png")]
        [Hero(new[] { RaceEnum.haidao }, new[] { ProfessionEnum.fashi }, 2)]
        kapai,
        [Text("卡特")]
        [Icon("Hero/卡特.png")]
        [Hero(new[] { RaceEnum.diguo }, new[] { ProfessionEnum.cike }, 3)]
        kate,
        [Text("凯南")]
        [Icon("Hero/凯南.png")]
        [Hero(new[] { RaceEnum.renzhe, RaceEnum.yuedeerren }, new[] { ProfessionEnum.yuansushi }, 3)]
        kainan,
        [Text("卡萨丁")]
        [Icon("Hero/拉萨丁.png")]
        [Hero(new[] { RaceEnum.xukong }, new[] { ProfessionEnum.fashi }, 1)]
        kasading,
        [Text("狼人")]
        [Icon("Hero/狼人.png")]
        [Hero(new[] { RaceEnum.kuangye }, new[] { ProfessionEnum.doushi }, 1)]
        langren,
        [Text("雷克塞")]
        [Icon("Hero/雷克塞.png")]
        [Hero(new[] { RaceEnum.xukong }, new[] { ProfessionEnum.doushi }, 2)]
        leikesai,
        [Text("龙女")]
        [Icon("Hero/龙女.png")]
        [Hero(new[] { RaceEnum.@long }, new[] { ProfessionEnum.huanxingshi }, 3)]
        longnv,
        [Text("龙王")]
        [Icon("Hero/龙王.png")]
        [Hero(new[] { RaceEnum.@long }, new[] { ProfessionEnum.fashi }, 4)]
        longwang,
        [Text("璐璐")]
        [Icon("Hero/璐璐.png")]
        [Hero(new[] { RaceEnum.yuedeerren }, new[] { ProfessionEnum.fashi }, 2)]
        lulu,
        [Text("诺手")]
        [Icon("Hero/洛克.png")]
        [Hero(new[] { RaceEnum.diguo }, new[] { ProfessionEnum.qishi }, 1)]
        luoke,
        [Text("莫甘娜")]
        [Icon("Hero/莫甘娜.png")]
        [Hero(new[] { RaceEnum.emo }, new[] { ProfessionEnum.fashi }, 3)]
        moganna,
        [Text("纳尔")]
        [Icon("Hero/纳尔.png")]
        [Hero(new[] { RaceEnum.kuangye, RaceEnum.yuedeerren }, new[] { ProfessionEnum.huanxingshi }, 4)]
        naer,
        [Text("男枪")]
        [Icon("Hero/男枪.png")]
        [Hero(new[] { RaceEnum.haidao }, new[] { ProfessionEnum.qiangshou }, 1)]
        nanqiang,
        [Text("女枪")]
        [Icon("Hero/女枪.png")]
        [Hero(new[] { RaceEnum.haidao }, new[] { ProfessionEnum.qiangshou }, 5)]
        nvqiang,
        [Text("派克")]
        [Icon("Hero/派克.png")]
        [Hero(new[] { RaceEnum.haidao }, new[] { ProfessionEnum.cike }, 2)]
        paike,
        [Text("千珏")]
        [Icon("Hero/千珏.png")]
        [Hero(new[] { RaceEnum.anying }, new[] { ProfessionEnum.youxia }, 4)]
        qianjue,
        [Text("日女")]
        [Icon("Hero/日女.png")]
        [Hero(new[] { RaceEnum.guizu }, new[] { ProfessionEnum.huwei }, 4)]
        rinv,
        [Text("慎")]
        [Icon("Hero/慎.png")]
        [Hero(new[] { RaceEnum.renzhe }, new[] { ProfessionEnum.jianshi }, 2)]
        shen,
        [Text("狮子狗")]
        [Icon("Hero/狮子狗.png")]
        [Hero(new[] { RaceEnum.kuangye }, new[] { ProfessionEnum.cike }, 3)]
        shizigou,
        [Text("死歌")]
        [Icon("Hero/死歌.png")]
        [Hero(new[] { RaceEnum.anying }, new[] { ProfessionEnum.fashi }, 5)]
        sige,
        [Text("螳螂")]
        [Icon("Hero/螳螂.png")]
        [Hero(new[] { RaceEnum.xukong }, new[] { ProfessionEnum.cike }, 1)]
        tanglang,
        [Text("天使")]
        [Icon("Hero/天使.png")]
        [Hero(new[] { RaceEnum.guizu }, new[] { ProfessionEnum.qishi }, 5)]
        qianshi,
        [Text("铁男")]
        [Icon("Hero/铁男.png")]
        [Hero(new[] { RaceEnum.anying }, new[] { ProfessionEnum.qishi }, 1)]
        tienan,
        [Text("薇恩")]
        [Icon("Hero/薇恩.png")]
        [Hero(new[] { RaceEnum.guizu }, new[] { ProfessionEnum.youxia }, 1)]
        weien,
        [Text("韦鲁斯")]
        [Icon("Hero/韦鲁斯.png")]
        [Hero(new[] { RaceEnum.emo }, new[] { ProfessionEnum.youxia }, 2)]
        weilusi,
        [Text("蔚")]
        [Icon("Hero/蔚.png")]
        [Hero(new[] { RaceEnum.haikesikeji }, new[] { ProfessionEnum.doushi }, 3)]
        wei,
        [Text("乌鸦")]
        [Icon("Hero/乌鸦.png")]
        [Hero(new[] { RaceEnum.emo, RaceEnum.diguo }, new[] { ProfessionEnum.huanxingshi }, 5)]
        wuya,
        [Text("小法")]
        [Icon("Hero/小法.png")]
        [Hero(new[] { RaceEnum.yuedeerren }, new[] { ProfessionEnum.fashi }, 3)]
        xiaofa,
        [Text("小炮")]
        [Icon("Hero/小炮.png")]
        [Hero(new[] { RaceEnum.yuedeerren }, new[] { ProfessionEnum.qiangshou }, 1)]
        xiaopao,
        [Text("亚索")]
        [Icon("Hero/亚索.png")]
        [Hero(new[] { RaceEnum.langren }, new[] { ProfessionEnum.jianshi }, 5)]
        yasuo,
        [Text("蜘蛛")]
        [Icon("Hero/蜘蛛.png")]
        [Hero(new[] { RaceEnum.emo }, new[] { ProfessionEnum.huanxingshi }, 1)]
        zhizhu,
        [Text("猪妹")]
        [Icon("Hero/猪妹.png")]
        [Hero(new[] { RaceEnum.jidi }, new[] { ProfessionEnum.qishi }, 4)]
        zhumei,
    }

    public enum RaceEnum
    {
        [Text("暗影")]
        [Icon("Race/暗影.png")]
        anying,
        [Text("帝国")]
        [Icon("Race/帝国.png")]
        diguo,
        [Text("恶魔")]
        [Icon("Race/恶魔.png")]
        emo,
        [Text("贵族")]
        [Icon("Race/贵族.png")]
        guizu,
        [Text("海盗")]
        [Icon("Race/海盗.png")]
        haidao,
        [Text("海克斯科技")]
        [Icon("Race/海克斯科技.png")]
        haikesikeji,
        [Text("机器人")]
        [Icon("Race/机器人.png")]
        jiqiren,
        [Text("极地")]
        [Icon("Race/极地.png")]
        jidi,
        [Text("狂野")]
        [Icon("Race/狂野.png")]
        kuangye,
        [Text("浪人")]
        [Icon("Race/浪人.png")]
        langren,
        [Text("龙")]
        [Icon("Race/龙.png")]
        @long,
        [Text("忍者")]
        [Icon("Race/忍者.png")]
        renzhe,
        [Text("虚空")]
        [Icon("Race/虚空.png")]
        xukong,
        [Text("约德尔人")]
        [Icon("Race/约德尔人.png")]
        yuedeerren,
    }

    public enum ProfessionEnum
    {
        [Text("刺客")]
        [Icon("Profession/刺客.png")]
        cike,
        [Text("斗士")]
        [Icon("Profession/斗士.png")]
        doushi,
        [Text("法师")]
        [Icon("Profession/法师.png")]
        fashi,
        [Text("护卫")]
        [Icon("Profession/护卫.png")]
        huwei,
        [Text("换形师")]
        [Icon("Profession/换形师.png")]
        huanxingshi,
        [Text("剑士")]
        [Icon("Profession/剑士.png")]
        jianshi,
        [Text("骑士")]
        [Icon("Profession/骑士.png")]
        qishi,
        [Text("枪手")]
        [Icon("Profession/枪手.png")]
        qiangshou,
        [Text("游侠")]
        [Icon("Profession/游侠.png")]
        youxia,
        [Text("元素使")]
        [Icon("Profession/元素使.png")]
        yuansushi,
    }

    public class HeroAttribute : Attribute
    {
        public int Fee { get; set; }
        public RaceEnum[] Race { get; set; }
        public ProfessionEnum[] Profession { get; set; }
        public HeroAttribute(RaceEnum[] race, ProfessionEnum[] profession, int fee)
        {
            this.Race = race;
            this.Profession = profession;
            this.Fee = fee;
        }

    }

    public class IconAttribute : Attribute
    {
        public string IconPath { get; set; }
        public ImageSource ImgSource { get; set; }
        public IconAttribute(string path)
        {
            string url = $"pack://application:,,,/CloudTopSupport;component/Image/{path}";
            this.IconPath = url;
            ImgSource = ImageHelper.StringToImageSource(url);
        }
    }
}
