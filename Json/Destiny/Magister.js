this.model.magister={  "dID": "magister", "name": "魔导师", "autogrants": [
    {
        "abil_name": "奥术学习 I",
        "img": "arcanestudy_i",
        "abil": "+50 蓝,所有奥术施法者等级+1",
        "passive": "passive"
    },
    {
        "abil_name": "奥术学习 II",
        "img": "arcanestudy_ii",
        "abil": "(等级 1) +50 蓝,所有奥术施法者等级+1",
        "passive": "passive"
    },
    {
        "abil_name": "奥术学习 III",
        "img": "arcanestudy_iii",
        "abil": "(等级 2) +50 蓝,所有奥术施法者等级+1",
        "passive": "passive"
    },
    {
        "abil_name": "奥术学习 IV",
        "img": "arcanestudy_iv",
        "abil": "(等级 3) +50 蓝,所有奥术施法者等级+1",
        "passive": "passive"
    },
    {
        "abil_name": "奥术学习 V",
        "img": "arcanestudy_v",
        "abil": "(等级 4) +50 蓝,所有奥术施法者等级+1",
        "passive": "passive"
    },
    {
        "abil_name": "奥术潮汐",
        "img": "arcanespellsurge-taken",
        "abil": "(等级 5) (冷却: 4 分钟) 所有法术DC+5 ,持续20 秒.",
        "passive": false
    }
], "1a": {
    "abil_name": "守护印记",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "sigil_spellwarding",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "(冷却: 30 秒)空中书写一个印记为时 60秒，给所有附近的友人叠加的1dr/- 和5物理抗性。每人只能同时拥有一个印记。20SP ",
        "2": "(冷却: 30 秒)空中书写一个印记为时 60秒，给所有附近的友人叠加的2dr/- 和10物理抗性。每人只能同时拥有一个印记。20SP ",
        "3": "(冷却: 30 秒)空中书写一个印记为时 60秒，给所有附近的友人叠加的3dr/- 和15物理抗性。每人只能同时拥有一个印记。20SP "
    }
}, "1b": {
    "abil_name": "静默施法",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "imperceptiblecasting",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "(冷却: 1分钟) 之后10秒，你的法术威胁降低到原来的 5%。 "
    }
}, "1c": {
    "abil_name": "超常的反应",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "unearthlyreactions",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "+1 闪避, +2 反射",
        "2": "+2 闪避, +4 反射",
        "3": "+3 闪避, +6 反射,获得翻滚穿越效果"
    }
}, "1d": {
    "abil_name": "坚定的意志",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "impregnablemind",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "+2 集中, +2 意志",
        "2": "+4 集中, +4 意志",
        "3": "+6 集中, +6 意志,意志豁免Roll1不失败"
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
    "abil_name": "生命护盾印记",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "sigil_lifeshielding",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "(冷却: 30 秒) 空中书写一个印记为时60秒，给所有附近的友人死亡守护，范围内的不死受到每2秒1d6光系伤害，每人只能同时拥有一个印记。20SP",
        "2": "(冷却: 30 秒) 空中书写一个印记为时60秒，给所有附近的友人死亡守护，范围内的不死受到每2秒2d6光系伤害，每人只能同时拥有一个印记。20SP",
        "3": "(冷却: 30 秒) 空中书写一个印记为时60秒，给所有附近的友人死亡守护，范围内的不死受到每2秒3d6光系伤害，每人只能同时拥有一个印记。20SP"
    }
}, "2b": {
    "abil_name": "消失在奥术中",
    "required": 4,
    "prereq": "1b",
    "selected": 0,
    "img": "fadeintotheweave",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "(冷却: 2 分钟) 施放一个交涉技能然后你将隐身10 秒 (施法或攻击不会破坏隐身)"
    }
}, "2c": null, "2d": {
    "abil_name": "法术学派专精",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "specialist_school",
    "multi": "multi",
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": {
            "1": "+1 防护系DC,需要前置专长:Abjuration",
            "2": "+1 咒法系DC,需要前置专长:Conjuration",
            "3": "+1 附魔系DC,需要前置专长:Enchantment",
            "4": "+1 素能系DC,需要前置专长:Evocation",
            "5": "+1 幻术系DC,需要前置专长:Illusion",
            "6": "+1 死灵系DC,需要前置专长:Necromancy",
            "7": "+1 变化系DC,需要前置专长:Transmutation"
        },
        "2": "+2 法术学派DC",
        "3": "+3 法术学派DC"
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
}, "3a": {
    "abil_name": "能量消除印记",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "sigil_energynegation",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "(冷却: 30 秒) 空中书写一个印记为时60秒，给所有附近的友人叠加20火，冰，电，酸抗，每人只能同时拥有一个印记。20SP",
        "2": "(冷却: 30 秒) 空中书写一个印记为时60秒，给所有附近的友人叠加40火，冰，电，酸抗，每人只能同时拥有一个印记。20SP",
        "3": "(冷却: 30 秒) 空中书写一个印记为时60秒，给所有附近的友人叠加60火，冰，电，酸抗，每人只能同时拥有一个印记。20SP"
    }
}, "3b": {
    "abil_name": "多重变换元素抗",
    "required": 8,
    "prereq": "3a",
    "selected": 0,
    "img": "variableresistance",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "每当你受到元素伤害，你获得+10该系可叠加元素抗，可以叠加3次。如果你受到它系元素伤害，先前的抗会被清除。持续1分钟",
        "2": "每当你受到元素伤害，你获得+10该系可叠加元素抗，可以叠加3次。如果你受到它系元素伤害，先前的抗会被清除。持续2分钟",
        "3": "每当你受到元素伤害，你获得+10该系可叠加元素抗，可以叠加3次。如果你受到它系元素伤害，先前的抗会被清除。持续3分钟"
    }
}, "3c": {
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
}, "3d": {
    "abil_name": "法系增强",
    "required": 8,
    "prereq": "2d",
    "selected": 0,
    "img": "augmentation_school",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "该法系法术对目标有5%几率-10<XX>豁免（不同系别减的豁免不同）持续10秒",
        "2": "该法系法术对目标有10%几率-10<XX>豁免（不同系别减的豁免不同）持续20秒",
        "3": "该法系法术对目标有15%几率-10<XX>豁免（不同系别减的豁免不同）持续30秒"
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
    "abil_name": "法强印记",
    "required": 12,
    "prereq": null,
    "selected": 0,
    "img": "sigil_batteringspellcraft",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "空中书写一个印记为时60秒，给所有附近的友人叠加[15]法能，每人只能同时拥有一个印记。20SP",
        "2": "空中书写一个印记为时60秒，给所有附近的友人叠加[30]法能，每人只能同时拥有一个印记。20SP",
        "3": "空中书写一个印记为时60秒，给所有附近的友人叠加[45]法能，每人只能同时拥有一个印记。20SP"
    }
}, "4b": {
    "abil_name": "反魔守护",
    "required": 12,
    "prereq": null,
    "selected": 0,
    "img": "nullmagic_guard",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "当你受到伤害，有2%几率释放反魔爆：消除敌人身上的附魔，防止他们在10秒内使用魔法,并且-2法抗。每30秒内只能爆一次。",
        "2": "当你受到伤害，有4%几率释放反魔爆：消除敌人身上的附魔，防止他们在20秒内使用魔法,并且-3法抗。每30秒内只能爆一次。",
        "3": "当你受到伤害，有6%几率释放反魔爆：消除敌人身上的附魔，防止他们在30秒内使用魔法,并且-4法抗。每30秒内只能爆一次。"
    }
}, "4c": {
    "abil_name": "召唤血亲",
    "required": 12,
    "prereq": "4d",
    "selected": 0,
    "img": "summon_school",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "召唤一只传奇怪来帮助你（品种看法系,素能:活化陨石,死灵:巫妖）"
    }
}, "4d": {
    "abil_name": "法系熟悉",
    "required": 12,
    "prereq": "3d",
    "selected": 0,
    "img": "familiarity_school",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "减低该法系法术CD5%",
        "2": "减低该法系法术CD10%",
        "3": "减低该法系法术CD15%"
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
    "abil_name": "反魔攻击",
    "required": 16,
    "prereq": "4b",
    "selected": 0,
    "img": "nullmagic_strike",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "你的法术攻击有5%几率消除敌人身上的附魔，防止他们在10秒内使用魔法,并且-2法抗。",
        "2": "你的法术攻击有10%几率消除敌人身上的附魔，防止他们在20秒内使用魔法,并且-3法抗。",
        "3": "你的法术攻击有15%几率消除敌人身上的附魔，防止他们在30秒内使用魔法,并且-4法抗。"
    }
}, "5c": {
    "abil_name": "大召唤使",
    "required": 16,
    "prereq": "4c",
    "selected": 0,
    "img": "grandsummoner",
    "multi": false,
    "passive": "passive",
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "你的召唤物获得+4属性，增加生命，+50%护命，+40%移动速度,这和强化召唤专长叠加。"
    }
}, "5d": {
    "abil_name": "法系大师",
    "required": 16,
    "prereq": "4d",
    "selected": 0,
    "img": "master_school",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "该法系法术的施法等级+1，最大施法等级等级+1",
        "2": "该法系法术的施法等级+2，最大施法等级等级+2",
        "3": "该法系法术的施法等级+3，最大施法等级等级+3"
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
    "abil_name": "奥术风暴",
    "required": 20,
    "prereq": "4a",
    "selected": 0,
    "img": "arcanetempest",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 3分钟) 范围伤害攻击对敌人造成(2d6/施法者等级),每2秒一次伤害，为时8秒。30SP"
    }
}, "6b": {
    "abil_name": "反魔光环",
    "required": 20,
    "prereq": "5b",
    "selected": 0,
    "img": "nullmagic_aura",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 1秒) 每激活一次反魔守护获得1能量,当获得30能量可激活反魔光环,光环内20秒内免疫有害的魔法"
    }
}, "6c": null, "6d": {
    "abil_name": "奥术娴熟",
    "required": 20,
    "prereq": null,
    "selected": 0,
    "img": "arcaneadept",
    "multi": false,
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "所有法术减低SP消耗10%"
    }
}, "6e": {
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
