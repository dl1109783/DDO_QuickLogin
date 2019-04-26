this.model.EldritchKnight = {  "dID": "EldritchKnight", "name": "奥秘骑士",  "index":"306","translate":"夜风",
    "x1": {
        "abil_name": "奥术打击",
        "required": 0,
        "prereq": null,
        "selected": 0,
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "类似于顺势斩,+1W,命中后造成力场爆,0-2/每施法者等级,伤害受力场法强影响.10SP 冷却15秒.</br>" +
                "被动效果:+1%双击,在此树中每花费1AP，+0.5通用法强。"
        }
    }, "x2": {
        "abil_name": "魔法武器I",
        "required": 5,
        "prereq": "x1",
        "selected": 0,
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
                "1": "给你的武器附加元素伤害,冰火电酸中任选一种,造成1d6元素伤害,6级2d4,12级3d4,18级4d4." +
                    "被动:-5%奥术失败率,+10力场法能"
        }
    }, "x3": {
        "abil_name": "魔法武器II",
        "required": 10,
        "prereq": "x2",
        "selected": 0,
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "给你的武器附加元素伤害,未选过的元素中任选选一种,造成1d6元素伤害,6级2d4,12级3d4,18级4d4." +
                "被动:-5%奥术失败率,+10力场法能"
        }
    }, "x4": {
        "abil_name": "魔法武器III",
        "required": 20,
        "prereq": "x3",
        "selected": 0,
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1":  "给你的武器附加元素伤害,未选过的元素中任选选一种,造成1d6元素伤害,6级2d4,12级3d4,18级4d4." +
                "被动:-5%奥术失败率,+10力场法能"
        }
    }, "x5": {
        "abil_name": "魔法武器IV",
        "required": 30,
        "prereq": "x4",
        "selected": 0,
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1":  "给你的武器附加元素伤害,未选过的元素中任选选一种,造成1d6元素伤害,6级2d4,12级3d4,18级4d4." +
                "被动:-5%奥术失败率,+10力场法能"
        }
    }, "x6": {
        "abil_name": "奥术切割",
        "required": 40,
        "prereq": "x5",
        "selected": 0,
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "奥术打击将能够获得能量点,消耗10颗能量点激活奥术切割,+10%近战伤害,+25通用法强." +
                "被动:+2魅力,+10力场伤害"
        }
    }, "1a": {
        "abil_name": "类法术:强化魔法盔甲",
        "required": 1,
        "prereq": null,
        "selected": 0,
        "passive": false,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "对自己施展魔法盔甲,并且增加总防御的3%,消耗8SP",
            "2": "对自己施展魔法盔甲,并且增加总防御的6%,消耗6SP",
            "3": "对自己施展魔法盔甲,并且增加总防御的10%,消耗4SP"
        }
    }, "1b": {
        "abil_name": "健壮",
        "required": 1,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+5HP",
            "2": "+10HP",
            "3": "+15HP"
        }

    }, "1d": {
        "abil_name": "保护物品",
        "required": 1,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+25%物品保护",
            "2": "+50%物品保护",
            "3": "+75%物品保护"
        }
    }, "1e": {
        "abil_name": "战斗法师",
        "required": 1,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+1专注,威吓,法术辨识技能",
            "2": "+2专注,威吓,法术辨识技能",
            "3": "+3专注,威吓,法术辨识技能"
        }
    }, "2a": {
        "abil_name": "类法术:强化魔法护盾",
        "required": 5,
        "prereq": "1a",
        "selected": 0,
        "passive": false,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "附加魔法护,并且+3物理抵抗,消耗8SP",
            "2": "附加魔法护,并且+6物理抵抗,消耗6SP",
            "3": "附加魔法护,并且+10物理抵抗,消耗4SP"
        }
    }, "2b": {
        "abil_name": "防护训练",
        "required": 5,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "你获得擅长盾牌专长(不包括塔盾),并且盾牌的魔法失败率-5%"
        }
    }, "2c": {
        "abil_name": "擅长轻甲",
        "required": 5,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "你获得擅长轻甲专长,并且护甲法术失败率-5%"
        }
    }, "2d": {
        "abil_name": "武术娴熟",
        "required": 5,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "擅长所有军用武器,并且+2%双击"
        }
    }, "2e": {
        "abil_name": "魔法物品使用大师",
        "required": 5,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "使用魔杖,卷轴,带有主动技能的魔法物品时+25%效果,使用攻击型魔杖时+1DC",
            "2": "使用魔杖,卷轴,带有主动技能的魔法物品时+50%效果,使用攻击型魔杖时+2DC",
            "3": "使用魔杖,卷轴,带有主动技能的魔法物品时+75%效果,使用攻击型魔杖时+3DC"
        }
    }, "3a": {
        "abil_name": "奥术屏障",
        "required": 10,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "当你的HP低于50%时,获得奥术屏障效果,在接下来的10秒内,减少25%受到的伤害,150秒内只可触发1次",
            "2": "当你的HP低于50%时,获得奥术屏障效果,在接下来的15秒内,减少25%受到的伤害,120秒内只可触发1次",
            "3": "当你的HP低于50%时,获得奥术屏障效果,在接下来的20秒内,减少25%受到的伤害,90秒内只可触发1次"
        }
    }, "3b": {
        "abil_name": "元素抵抗",
        "required": 10,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+2天生冰电火酸音抗性",
            "2": "+4天生冰电火酸音抗性",
            "3": "+6天生冰电火酸音抗性"
        }

    }, "3d": {
        "abil_name": "精准重击",
        "required": 10,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+1重击确认",
            "2": "+2重击确认",
            "3": "+3重击确认"
        }
    }, "3e": {
        "abil_name": "属性增强",
        "required": 10,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": {
                "1": "+1力量",
                "2": "+1敏捷",
                "3": "+1魅力"
            }
        }
    }, "4b": {
        "abil_name": "盾击",
        "required": 20,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "当装备盾牌并进行攻击时,增加+5%几率触发盾击",
            "2": "当装备盾牌并进行攻击时,增加+10%几率触发盾击",
            "3": "当装备盾牌并进行攻击时,增加+15%几率触发盾击"
        }
    }, "4c": {
        "abil_name": "擅长中甲",
        "required": 20,
        "prereq": "2c",
        "selected": 0,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "获得擅长中甲专长,并且减少护甲魔法失败率5%"
        }
    }, "4d": {
        "abil_name": "重击伤害",
        "required": 20,
        "prereq": "3d",
        "selected": 0,
        "passive": true,
        "ranks":3,
        "AP": 1,
        "abil": {
            "1": "+1重击伤害(倍数前)",
            "2": "+2重击伤害(倍数前)",
            "3": "+3重击伤害(倍数前)"
        }
    }, "4e": {
        "abil_name": "属性增强",
        "required": 20,
        "prereq": "3e",
        "selected": 0,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": {
                "1": "+1力量",
                "2": "+1敏捷",
                "3": "+1魅力"
            }
        }
    }, "5a": {
        "abil_name": "状态:谭森变形",
        "required": 30,
        "prereq": "3a",
        "selected": 0,
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "获得谭森变形术的效果,激活消耗25SP"
        }
    }, "5b": {
        "abil_name": "魔盾",
        "required": 30,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "当你装备盾牌时,每6秒获得一次暂时生命"
        }
    }, "5c": {
        "abil_name": "着甲施法",
        "required": 30,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "-5%魔法失败率",
            "2": "-10%魔法失败率",
            "3": "-15%魔法失败率"
        }
    }, "5d": {
        "abil_name": "双击",
        "required": 30,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+1%双击",
            "2": "+2%双击",
            "3": "+3%双击"
        }
    }, "5e": {
        "abil_name": "毁灭风暴",
        "required": 30,
        "prereq": null,
        "selected": 0,
        "passive": false,
        "ranks": 3,
        "AP": 2,
        "abil": {
            "1": "类似大顺势斩,+2W,摔绊周围敌人1秒,无豁免.施展消耗50SP,冷却60秒.</br>" +
                "被动:如果附件敌人受到毁灭风暴攻击, 你的武器将自动释放力场爆,造成周围敌人[1d6/角色等级]的力场伤害,受力场法强影响.",
            "2": "类似大顺势斩,+2W,摔绊周围敌人1秒,无豁免.施展消耗40SP,冷却45秒.</br>" +
                "被动:如果附件敌人受到毁灭风暴攻击, 你的武器将自动释放力场爆,造成周围敌人[1d6/角色等级]的力场伤害,受力场法强影响.",
            "3": "类似大顺势斩,+2W,摔绊周围敌人1秒,无豁免.施展消耗30SP,冷却30秒.</br>" +
                "被动:如果附件敌人受到毁灭风暴攻击, 你的武器将自动释放力场爆,造成周围敌人[1d6/角色等级]的力场伤害,受力场法强影响."
        }
    }}
