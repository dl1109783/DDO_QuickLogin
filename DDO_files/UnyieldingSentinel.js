this.model.unyielding_sentinel={  "dID": "unyielding_sentinel", "name": "不屈卫士", "autogrants": [
    {
        "abil_name": "战斗勇气",
        "img": "vigorofbattle",
        "abil": "+50 血. 卫士姿势 (激活 冷却: 20秒): 10%治疗放大,+50 血. 攻击到的敌人受到医疗之触状态持续3秒，他们攻击的目标获得临时10HP.击.",
        "passive": false
    },
    {
        "abil_name": "Unbreakable坚韧不断",
        "img": "unbreakable-taken",
        "abil": "(等级 1) +5神圣自然AC,你获得Diehard专长,卫士姿势 (激活冷却: 20秒): 你获得DR 10/Epic",
        "passive": false
    },
    {
        "abil_name": "Stand Against the Tide中流砥柱形态",
        "img": "standagainstthetide-taken",
        "abil": "(等级 2) +2 攻击.卫士姿势 (激活 冷却: 20秒) : +1 近战伤害, 20%仇恨, +5% 护命, +1 豁免. 站立不动可叠加,最大叠加4次",
        "passive": false
    },
    {
        "abil_name": "Stalwart Guardian坚毅守卫",
        "img": "stalwartguardian-taken",
        "abil": "(等级 3) +50 血.勇士姿势:+50HP上限.",
        "passive": "passive"
    },
    {
        "abil_name": "无视疼痛",
        "img": "shrugoff",
        "abil": "(等级 4) +10 物理 抗性. Unbreakable 姿势:+20物理抗性.",
        "passive": "passive"
    },
    {
        "abil_name": "坚定不屈",
        "img": "untouchable",
        "abil": "(等级 5) +1伤害. +1 豁免 Stand Against the Tide姿势.不可击倒",
        "passive": "passive"
    }
], "1a": {
    "abil_name": "不死杀手",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "baneofundeath",
    "multi": false,
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "你获得驱散不死专长。战斗勇气之下你的武器获得不死杀（+2附魔+2d6伤害）"
    }
}, "1b": {
    "abil_name": "无限驱散",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "endlessturning",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "+1驱散次数。驱散回复2分钟1次，或减少10%回复时间。",
        "2": "+1驱散次数。驱散回复2分钟1次，或减少20%回复时间。",
        "3": "+1驱散次数。驱散回复2分钟1次，或减少30%回复时间。"
    }
}, "1c": {
    "abil_name": "抵御冲击",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "braceforimpact",
    "multi": false,
    "passive": "passive",
    "ranks": 2,
    "AP": 2,
    "abil": {
        "1": "+20% 护命. +1全豁免",
        "2": "+40% 护命. +2全豁免"
    }
}, "1d": {
    "abil_name": "盾牌威力",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "shieldprowess",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "护盾防御增强15% ",
        "2": "",
        "3": "护盾防御增强50% "
    }
}, "1e": {
    "abil_name": "体质或魅力",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "chacon",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 体质",
            "2": "+1 魅力"
        }
    }
}, "2a": {
    "abil_name": "正视敌人",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "confrontanyfoe",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 7秒) 近战攻击：使用一次破邪斩：对敌人造成10d10光伤害。"
    }
}, "2b": {
    "abil_name": "狂热信仰",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "smitevillainy",
    "multi": false,
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "获得破邪斩专长. 在坚韧不断状态下,你的武器获得守序或混乱伤害.取决你的阵营"
    }
}, "2c": {
    "abil_name": "无限破邪斩",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "endlesssmiting",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "+1破邪斩次数。破邪斩回复加速10%",
        "2": "+1破邪斩次数。破邪斩回复加速20%",
        "3": "+1破邪斩次数。破邪斩回复加速30%"
    }
}, "2d": {
    "abil_name": "传奇盾牌大师",
    "required": 4,
    "prereq": "1d",
    "selected": 0,
    "img": "legendaryshieldmastery",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "当以佩戴盾牌时，+5物理抗",
        "2": "当以佩戴盾牌时，+10物理抗",
        "3": "当以佩戴盾牌时，+15物理抗"
    }
}, "2e": {
    "abil_name": "体质或魅力",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "chacon",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 体质",
            "2": "+1 魅力"
        }
    }
}, "3a": {
    "abil_name": "阻挡能量",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "shieldagainstenergy",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "当你架盾是，获得10%元素吸收（酸，冰，电，火，力场，光，音波）",
        "2": "当你架盾是，获得20%元素吸收（酸，冰，电，火，力场，光，音波）",
        "3": "当你架盾是，获得30%元素吸收（酸，冰，电，火，力场，光，音波）"
    }
}, "3b": {
    "abil_name": "不耐之击",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "abidenoevil",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 7秒) 近战攻击: 消耗一次破邪斩: 造成+3[w]伤害,对附近的敌人造成1000伤害的仇恨"
    }
}, "3c": {
    "abil_name": "圣疗",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "healinghands",
    "multi": false,
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "你获得圣疗专长。+25正能量法能。"
    }
}, "3d": {
    "abil_name": "无限圣疗",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "endlesslayonhands",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "+1 圣疗.每3分钟恢复一次圣疗",
        "2": "+1 圣疗.每3分钟恢复一次圣疗或恢复时间减少10%",
        "3": "+1 圣疗.每3分钟恢复一次圣疗或恢复时间减少20%"
    }
}, "3e": {
    "abil_name": "体质或魅力",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "chacon",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 体质",
            "2": "+1 魅力"
        }
    }
}, "4a": null, "4b": {
    "abil_name": "生命闪光",
    "required": 12,
    "prereq": null,
    "selected": 0,
    "img": "sparkoflifeeternal",
    "multi": false,
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "获得防死"
    }
}, "4c": {
    "abil_name": "黑暗中的曙光",
    "required": 12,
    "prereq": null,
    "selected": 0,
    "img": "lightthedarkness",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 7秒) 消耗一次圣疗：群体医疗150HP"
    }
}, "4d": {
    "abil_name": "净化武器",
    "required": 12,
    "prereq": null,
    "selected": 0,
    "img": "purifyweapon",
    "multi": false,
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(Stand Against the Tide)中流砥柱形态下，你的武器获得纯善属性+1d6伤害"
    }
}, "4e": {
    "abil_name": "体质或魅力",
    "required": 12,
    "prereq": null,
    "selected": 0,
    "img": "chacon",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 体质",
            "2": "+1 魅力"
        }
    }
}, "5a": {
    "abil_name": "硬化",
    "required": 16,
    "prereq": null,
    "selected": 0,
    "img": "hardened",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "+3 防御",
        "2": "",
        "3": ""
    }
}, "5b": null, "5c": {
    "abil_name": "防御邪恶",
    "required": 16,
    "prereq": null,
    "selected": 0,
    "img": "wardagainstevil",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "受到邪恶生物攻击时,20%几率给其3d6伤害",
        "2": "",
        "3": ""
    }
}, "5d": {
    "abil_name": "圣化武器",
    "required": 16,
    "prereq": "4d,5c",
    "selected": 0,
    "img": "annointweapon",
    "multi": false,
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "如果你是善良阵营，在中流砥柱形态下，你的武器获得神圣属性"
    }
}, "5e": {
    "abil_name": "体质或魅力",
    "required": 16,
    "prereq": null,
    "selected": 0,
    "img": "chacon",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 体质",
            "2": "+1 魅力"
        }
    }
}, "6a": null, "6b": null, "6c": {
    "abil_name": "不死先锋",
    "required": 20,
    "prereq": null,
    "selected": 0,
    "img": "undyingvanguard",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 5分钟) 医疗你自己1000HP。20秒内你获得10000临时生命。需要1000点不屈意志。每当你被攻击时,你获得1点不屈意志。"
    }
}, "6d": null, "6e": {
    "abil_name": "体质或魅力",
    "required": 20,
    "prereq": null,
    "selected": 0,
    "img": "chacon",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 体质",
            "2": "+1 魅力"
        }
    }
}};
