this.model.draconic_incarnation={  "dID": "draconic_incarnation", "name": "龙脉化身", "autogrants": [
    {
        "abil_name": "龙族血统 I",
        "img": "bloodline",
        "abil": "+50 蓝,所有奥术施法者等级+1",
        "passive": "passive"
    },
    {
        "abil_name": "龙族血统 II",
        "img": "bloodline",
        "abil": "(等级 1) +50 蓝,所有奥术施法者等级+1",
        "passive": "passive"
    },
    {
        "abil_name": "龙族血统 III",
        "img": "bloodline",
        "abil": "(等级 2) +50 蓝,所有奥术施法者等级+1",
        "passive": "passive"
    },
    {
        "abil_name": "龙族血统 IV",
        "img": "bloodline",
        "abil": "(等级 3) +50 蓝,所有奥术施法者等级+1",
        "passive": "passive"
    },
    {
        "abil_name": "龙族血统 V",
        "img": "bloodline",
        "abil": "(等级 4) +50 蓝,所有奥术施法者等级+1",
        "passive": "passive"
    },
    {
        "abil_name": "龙族怒火",
        "img": "fury",
        "abil": "(等级 5) (冷却: 4 分钟) 20秒内+20%法能",
        "passive": false
    }
], "1a": {
    "abil_name": "能量吸收",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "energysheath_fire",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "(冷却: 1分钟) 2分钟内，+50%元素吸收。如被攻击，敌人受到1d3+10指定元素伤害，有小几率受到4d20+100该元素伤害。消除冰火盾。",
        "2": "(冷却: 1分钟) 2分钟内，+50%元素吸收。如被攻击，敌人受到2d3+10指定元素伤害，有小几率受到4d20+100该元素伤害。消除冰火盾。",
        "3": "(冷却: 1分钟) 2分钟内，+50%元素吸收。如被攻击，敌人受到3d3+10指定元素伤害，有小几率受到4d20+100该元素伤害。消除冰火盾。"
    }
}, "1b": {
    "abil_name": "龙族附身",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "draconicpresence",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "+2威吓，+2豁免恐惧 +1 DC  恐惧法术.",
        "2": "+4威吓，+4豁免恐惧 +2 DC  恐惧法术.",
        "3": "+6 威吓, +6豁免恐惧 +3 DC  恐惧法术. 免疫恐惧"
    }
}, "1c": {
    "abil_name": "龙皮",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "dragonhide",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "+1 自然护甲 ,+2 强韧豁免.",
        "2": "+2 自然护甲 ,+4 强韧豁免.",
        "3": "+3 自然护甲 ,+6 强韧豁免. Roll1不自动失败强韧豁免"
    }
}, "1d": {
    "abil_name": "龙族视野",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "perception",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "+2 侦查 ,+2 反射",
        "2": "+4 侦查 ,+4 反射",
        "3": "+6 侦查 ,+6 反射,获得幽暗视觉"
    }
}, "1e": {
    "abil_name": "智力 或 魅力",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "chaint",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 智力",
            "2": "+1 魅力"
        }
    }
}, "2a": {
    "abil_name": "英雄就义",
    "required": 4,
    "prereq": "1a",
    "selected": 0,
    "img": "gooutwithabang_fire",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "(冷却: 4分钟) 只能在你的血少于50%时使用。附近敌人受到(2d6/施法等级)元素伤害，然后激发一个交涉技能，对自己施放高级隐身。",
        "2": "",
        "3": ""
    }
}, "2b": null, "2c": {
    "abil_name": "龙皮屏障",
    "required": 4,
    "prereq": "1c",
    "selected": 0,
    "img": "barrierofscales",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "(冷却: 2分钟)[60]物理伤害吸收，和石肤，技师的消融盔甲叠加。持续30秒",
        "2": "(冷却: 2分钟)[80]物理伤害吸收，和石肤，技师的消融盔甲叠加。持续30秒",
        "3": "(冷却: 2分钟)[100]物理伤害吸收，和石肤，技师的消融盔甲叠加。持续30秒"
    }
}, "2d": {
    "abil_name": "精确施法",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "precise_casting",
    "multi": false,
    "passive": "passive",
    "ranks": 2,
    "AP": 1,
    "abil": {
        "1": "+1素能DC",
        "2": "+2素能DC"
    }
}, "2e": {
    "abil_name": "智力 或 魅力",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "chaint",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 智力",
            "2": "+1 魅力"
        }
    }
}, "3a": null, "3b": {
    "abil_name": "龙威",
    "required": 8,
    "prereq": "1b",
    "selected": 0,
    "img": "dauntingroar",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "(冷却: 2分钟) 范围内的敌人受到无助恐惧，未通过意志豁免将被无助,通过的也将受到动摇。"
    }
}, "3c": {
    "abil_name": "龙脉传承",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "heritage_red",
    "multi": false,
    "passive": "passive",
    "ranks": "3",
    "AP": 1,
    "abil": {
        "1": "挑一头五色龙，该系元素法术+10法能。",
        "2": "挑一头五色龙，该系元素法术+20法能。",
        "3": "挑一头五色龙，该系元素法术+30法能。"
    }
}, "3d": {
    "abil_name": "法术穿透",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "piercingspellcraft",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "+1法穿",
        "2": "+2法穿",
        "3": "+3法穿"
    }
}, "3e": {
    "abil_name": "智力 或 魅力",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "chaint",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 智力",
            "2": "+1 魅力"
        }
    }
}, "4a": {
    "abil_name": "能量爆",
    "required": 12,
    "prereq": "2a",
    "selected": 0,
    "img": "energyburst_fire",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "(冷却: 30 秒)引爆该系元素,对周围的敌人造成(3d6每施法者等级)的伤害。",
        "2": "",
        "3": ""
    }
}, "4b": {
    "abil_name": "次系元素精通",
    "required": 12,
    "prereq": "4c",
    "selected": 0,
    "img": "spellpower_red",
    "multi": false,
    "passive": "passive",
    "ranks": 2,
    "AP": 1,
    "abil": {
        "1": "另选一个元素系别，该系元素法术伤害+10法能,+1施法等级",
        "2": "另选一个元素系别，该系元素法术伤害+20法能,+2施法等级"
    }
}, "4c": {
    "abil_name": "龙脉法术知识",
    "required": 12,
    "prereq": "3c",
    "selected": 0,
    "img": "spellpower_red",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "所选龙系的元素法术：+1法术施法等级，+1最大施法者等级",
        "2": "所选龙系的元素法术：+2法术施法等级，+2最大施法者等级",
        "3": "所选龙系的元素法术：+3法术施法等级，+3最大施法者等级"
    }
}, "4d": {
    "abil_name": "龙脉法术增强",
    "required": 12,
    "prereq": "4c",
    "selected": 0,
    "img": "spellaugment_fire",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "给你的龙系法术添加额外效果：火系：有小几率+3d6光系伤害",
        "2": "",
        "3": ""
    }
}, "4e": {
    "abil_name": "智力 或 魅力",
    "required": 12,
    "prereq": null,
    "selected": 0,
    "img": "chaint",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 智力",
            "2": "+1 魅力"
        }
    }
}, "5a": null, "5b": {
    "abil_name": "龙族冲撞",
    "required": 16,
    "prereq": "5c",
    "selected": 0,
    "img": "flyby_fire",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "(冷却: 1分钟) 激发飞跃技能（类似和尚的飞跃技能），飞过的敌人受到(2d6/施法者等级)元素系伤害，过强韧豁免,失败将被推倒"
    }
}, "5c": {
    "abil_name": "龙息",
    "required": 16,
    "prereq": "4c",
    "selected": 0,
    "img": "breath_red",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "冷却: 1分钟)对敌吐龙息60d6元素伤害，反射豁免减半，每天5次"
    }
}, "5d": {
    "abil_name": "龙息增强",
    "required": 16,
    "prereq": "5c",
    "selected": 0,
    "img": "breathaugment_fire",
    "multi": false,
    "passive": "passive",
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "增加龙息额外效果[15% 造成目标睡眠,15% 造成目前减速10秒,15% 造成目标麻痹4秒,15% 造成目标2d8的力量伤害]"
    }
}, "5e": {
    "abil_name": "智力 或 魅力",
    "required": 16,
    "prereq": null,
    "selected": 0,
    "img": "chaint",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 智力",
            "2": "+1 魅力"
        }
    }
}, "6a": {
    "abil_name": "能量漩涡",
    "required": 20,
    "prereq": "4a",
    "selected": 0,
    "img": "energyvortex_fire",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 2分钟) 你身边产生能量漩涡，敌人每2秒受到(1d6/施法者等级)的元素伤害,持续16秒"
    }
}, "6b": {
    "abil_name": "龙之吞噬",
    "required": 20,
    "prereq": null,
    "selected": 0,
    "img": "hunger",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "每当你杀死一个敌人你有10%几率获得15点临时生命，10%几率获得15点临时SP，如果你在龙族怒火影响下该几率调制50%"
    }
}, "6c": {
    "abil_name": "恐惧的刀枪不入",
    "required": 20,
    "prereq": null,
    "selected": 0,
    "img": "fearsomeinvuln",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 1sec)当你在龙族怒火状态下使用素能法术伤害到敌人，你获得1点能量点。20点后，你可以激发恐惧的刀枪不入形态。激发威吓，30秒内DR100，冰火电酸元素抗200，外加快速回血。"
    }
}, "6d": null, "6e": {
    "abil_name": "智力 或 魅力",
    "required": 20,
    "prereq": null,
    "selected": 0,
    "img": "chaint",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 智力",
            "2": "+1 魅力"
        }
    }
}};
