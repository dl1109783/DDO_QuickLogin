this.model.grandmaster_of_flowers={  "dID": "grandmaster_of_flowers", "name": "百花大师", "autogrants": [
    {
        "abil_name": "内在专注",
        "img": "innerfocus-taken",
        "abil": "(冷却: 5 分钟) 立刻恢复25-125ki被动能力:你得到10点ki上限,1法抗每百花大师等级（最高在等级6获得60ki上限和6SR）",
        "passive": false
    },
    {
        "abil_name": "专注思维",
        "img": "slipperymind",
        "abil": "(等级 1) 获得灵活心智(Slippery Mind)专长，提供额外对投掷物的豁免并且提供1战术DC",
        "passive": "passive"
    },
    {
        "abil_name": "身心合一",
        "img": "innerfocus-taken",
        "abil": "(等级 2) (冷却: 5 分钟)对自己施展一个医疗术并去除所有属性伤害和负向等级，消耗30ki",
        "passive": false
    },
    {
        "abil_name": "不变之道",
        "img": "immunitytoslipperysurfaces",
        "abil": "(等级 3) 免疫光滑平面并且获得1战术DC",
        "passive": "passive"
    },
    {
        "abil_name": "无所不在",
        "img": "ubiquity",
        "abil": "(等级 4) 你获得翻滚穿越效果.",
        "passive": "passive"
    },
    {
        "abil_name": "万物之衡",
        "img": "immunitytoknockdown",
        "abil": "(等级 5)免疫大部分击倒效果, +1ki恢复和1战术DC",
        "passive": "passive"
    }
], "1a": {
    "abil_name": "拈花指",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "kiprojection",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "(冷却: 6秒)施放 一个气波造成80-120+(8-12)/角色等级,消耗10ki"
    }
}, "1b": {
    "abil_name": "完美平衡",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "perfectbalance",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "+2 平衡, 跳跃,翻滚,额外1% 闪避 ",
        "2": "+4 平衡, 跳跃,翻滚,额外2% 闪避 ",
        "3": "+6 平衡, 跳跃,翻滚,额外3% 闪避 "
    }
}, "1c": {
    "abil_name": "启蒙",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "enlightenment",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "+15Ki和+2专注 ",
        "2": "+30Ki和+4专注 ",
        "3": "+45Ki和+6专注.获得1ki被动恢复."
    }
}, "1d": {
    "abil_name": "花之舞",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "improvedmartialarts",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "Centered时+0.5[w]武器伤害",
        "2": "Centered时+1[w]武器伤害",
        "3": "Centered时+1.5[w]武器伤害"
    }
}, "1e": {
    "abil_name": "敏捷或感知",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "dexwis",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 敏捷",
            "2": "+1 感知"
        }
    }
}, "2a": null, "2b": {
    "abil_name": "御风而行",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "runningwithwind",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "雷电抗性4,+10%和尚并且在风形态下（附魔加值）+1%双击几率",
        "2": "雷电抗性8,+20%和尚并且在风形态下（附魔加值）+2%双击几率",
        "3": "雷电抗性12,+30%和尚并且在风形态下（附魔加值）+3%双击几率"
    }
}, "2c": {
    "abil_name": "宁静",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "serenity",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "+3 法术抗性 ",
        "2": "+6 法术抗性 ",
        "3": "+9 法术抗性 "
    }
}, "2d": {
    "abil_name": "风击",
    "required": 4,
    "prereq": "1d",
    "selected": 0,
    "img": "improvedflurryofblows",
    "multi": false,
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "+3%近战双击几率",
        "2": "+6%近战双击几率",
        "3": "+9%近战双击几率"
    }
}, "2e": {
    "abil_name": "敏捷或感知",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "dexwis",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 敏捷",
            "2": "+1 感知"
        }
    }
}, "3a": {
    "abil_name": "兰花指",
    "required": 8,
    "prereq": "1a",
    "selected": 0,
    "img": "kiblast",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "(冷却: 12秒)打出一波气，对面前的敌人造成[80-120+(8-12)/角色等级]的伤害R成功的反射豁免一半伤害(DC10+人物等级+1/2感知调整).消耗20ki"
    }
}, "3b": {
    "abil_name": "凌波微步",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "walkingwithwaves",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "获得4点冰抗 +2 防御.处于和尚水形态时+1% 闪避",
        "2": "获得8点冰抗 +4 防御.处于和尚水形态时+2% 闪避",
        "3": "获得12点冰抗 +6 防御.处于和尚水形态时+3% 闪避"
    }
}, "3c": {
    "abil_name": "轻如鸿毛",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "lightasafeather",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "免疫跌落伤害,获得羽落效果"
    }
}, "3d": {
    "abil_name": "完美身躯",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "perfectionofbody",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 2,
    "abil": {
        "1": "+2 强韧,强韧 Roll1不会自动失败",
        "2": "+4 强韧, 强韧Roll1不会自动失败,+4对抗疾病,毒素,恶心",
        "3": "+6 强韧, 强韧Roll1不会自动失败,+6对抗疾病,毒素,恶心"
    }
}, "3e": {
    "abil_name": "敏捷或感知",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "dexwis",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 敏捷",
            "2": "+1 感知"
        }
    }
}, "4a": null, "4b": {
    "abil_name": "立如磐石",
    "required": 12,
    "prereq": null,
    "selected": 0,
    "img": "standingwithstone",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "酸抗性 4, +5 最大生命. 处于土形态时+5物理抗性",
        "2": "酸抗性 8, +10 最大生命. 处于土形态时+10物理抗性",
        "3": "酸抗性 12, +15 最大生命. 处于土形态时+15物理抗性"
    }
}, "4c": {
    "abil_name": "通透",
    "required": 12,
    "prereq": null,
    "selected": 0,
    "img": "piercingclarity",
    "multi": false,
    "passive": "passive",
    "ranks": 2,
    "AP": 1,
    "abil": {
        "1": "无视5%护命,你的攻击有幽冥效果",
        "2": "无视10%护命,你的攻击有幽冥效果,如果你有真视你可以攻击隐藏敌人"
    }
}, "4d": {
    "abil_name": "完美心智",
    "required": 12,
    "prereq": null,
    "selected": 0,
    "img": "perfectionofmind",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "+2 意志豁免, 增加的 +2 豁免对抗 附魔法术,幻术, 恐惧",
        "2": "+4 意志豁免, 增加的 +4 豁免对抗 附魔法术,幻术, 恐惧",
        "3": "+6 意志豁免, 增加的 +6 豁免对抗 附魔法术,幻术, 恐惧,意志Roll1不失败"
    }
}, "4e": {
    "abil_name": "敏捷或感知",
    "required": 12,
    "prereq": null,
    "selected": 0,
    "img": "dexwis",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 敏捷",
            "2": "+1 感知"
        }
    }
}, "5a": {
    "abil_name": "飞舞之莲",
    "required": 16,
    "prereq": "3a",
    "selected": 0,
    "img": "kiburst",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "对附近的敌人造成[(80-120)+(8-12)/角色等级]伤害。反射豁免成功伤害减半(DC=10+人物等级+1/2wismod).豁免失败被击倒.消耗25ki"
    }
}, "5b": {
    "abil_name": "炎舞",
    "required": 16,
    "prereq": null,
    "selected": 0,
    "img": "dancingwithflame",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "获得4火抗.+1攻击和伤害,处于和尚火形态时增加 0.25[w]武器伤害",
        "2": "获得8火抗.+2攻击和伤害,处于和尚火形态时增加 0.5[w]武器伤害",
        "3": "获得12火抗.+3攻击和伤害,处于和尚火形态时增加 0.75[w]武器伤害"
    }
}, "5c": null, "5d": {
    "abil_name": "完美灵魂",
    "required": 16,
    "prereq": null,
    "selected": 0,
    "img": "perfectionofsoul",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "+2 反射豁免, +1 唬骗, 交涉,还价, 威吓 ",
        "2": "+4 反射豁免, +2 唬骗, 交涉,还价, 威吓 ",
        "3": "+6 反射豁免, +3 唬骗, 交涉,还价, 威吓 ,反射Roll1不失败"
    }
}, "5e": {
    "abil_name": "敏捷或感知",
    "required": 16,
    "prereq": null,
    "selected": 0,
    "img": "dexwis",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 敏捷",
            "2": "+1 感知"
        }
    }
}, "6a": {
    "abil_name": "落花舞",
    "required": 20,
    "prereq": "5a",
    "selected": 0,
    "img": "scatteringofpetals",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "所有在附近的敌人必须进行强韧豁免(DC20+人物等级+1/2wismod)失败目盲.在接下来的12秒内，+25%闪避消耗30ki"
    }
}, "6b": null, "6c": {
    "abil_name": "万物归尘",
    "required": 20,
    "prereq": null,
    "selected": 0,
    "img": "ceasethemoment",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "消耗50ki宁静升起，使用25次震撼拳，颤抖掌，六脉神剑，兰花指，飞莲之舞或者落瓣后，你可以使用一次万物归尘。在你附近的敌人要进行一次强韧鉴定(DC20+characterlevel+1/2wismod)失败会从此位面消失，成功会被瘫痪6秒，6秒后受到1000点伤害（强韧豁免成功受到1半）BOSS对此伤害免疫"
    }
}, "6d": null, "6e": {
    "abil_name": "敏捷或感知",
    "required": 20,
    "prereq": null,
    "selected": 0,
    "img": "dexwis",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 敏捷",
            "2": "+1 感知"
        }
    }
}};
