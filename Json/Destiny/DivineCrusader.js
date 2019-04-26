this.model.divine_crusader={  "dID": "divine_crusader", "name": "神圣十字军", "autogrants": [
    {
        "abil_name": "神圣十字军",
        "img": "1z",
        "abil": "你获得与神圣十字军天命等级一致的牧师、天佑和圣骑士的施法者等级。</br>基础被动：+25点蓝，10点血，你的基本攻击加值（BAB）等于你的总角色等级。+2MP",
        "passive": "passive"
    },
    {
        "abil_name": "净化光环",
        "img": "z2",
        "abil": "（主动，姿势，3秒CD），每3秒触发一次，附近的敌人获得一个可叠加的净化效果：-1点攻击力，-2法术强度，最多叠加25次。</br>基础被动：+25蓝，+10血。+2MP",
        "passive": false
    },
    {
        "abil_name": "非凡的美德",
        "img": "z3",
        "abil": "+10％治疗放大和+10正能量法强。25蓝,10血",
        "passive": ""
    },
    {
        "abil_name": "无悔之奉献",
        "img": "z4",
        "abil": "每当敌人被净化光环杀死，附近的盟友将接受与被杀敌人等级一致的治疗量。</br>基础被动：+25蓝，+10血。2MP",
        "passive": ""
    },
    {
        "abil_name": "正义之剑",
        "img": "z5",
        "abil": "+4伤害,+25蓝,+10血。",
        "passive": ""
    },
    {
        "abil_name": "正义之怒",
        "img": "z6",
        "abil": "获得50点怒气值。CD:4分钟</br>每个怒气值提供+1法术强度，+1％所有攻击伤害，+1％双击率,+1MP,+1RP。怒气值每3秒衰减1点,休息不丢失</br>被动+2MP",
        "passive": false
    }
], "1a": {
    "abil_name": "亡灵克星",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "1a",
    "multi": false,
    "passive": true,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "你获得驱散亡灵专长。同时享受战斗活力。你装备的武器获得不死克星效果（对不死生物+2武器等级，+2D6伤害）。"
    }
}, "1b": {
    "abil_name": "无尽转折",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "1b",
    "multi": false,
    "passive":true,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "+1驱散使用次数。如角色具备每2分钟恢复1次使用次数的能力，则每层减少[10]％的恢复时间。如果没有则120秒恢复一次学习前置要求：已学习亡灵克星或牧师、圣骑士专长驱散亡灵。",
        "2": "+2驱散使用次数。如角色具备每2分钟恢复1次使用次数的能力，则每层减少[20]％的恢复时间。如果没有则108秒恢复一次",
        "3": "+3驱散使用次数。如角色具备每2分钟恢复1次使用次数的能力，则每层减少[30]％的恢复时间。如果没有则96秒恢复一次"
    }
}, "1c": {
    "abil_name": "审讯",
    "required": 0,
    "prereq": 0,
    "selected": 0,
    "img": "1c",
    "multi": false,
    "passive": "passive",
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "+5通用法强，+1％法术暴击率。你的攻击性法术使敌人获得一个叠加的净化效果。净化：-1攻击伤害，-2法强。最多可堆叠25次。"
    }
}, "1d": {
    "abil_name": "清除邪恶",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "1d",
    "multi": false,
    "passive": "passive",
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "+2命中和暴击伤害。你的武器每次爆击也使敌人获得一个可叠加的净化效果"
    }
}, "1e": {
    "abil_name": "属性提升",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "1e",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 感知",
            "2": "+1 魅力",
            "3": "+1 力量"
        }
    }
}, "2a": {
    "abil_name": "无畏对抗",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "2a",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "消耗一次驱散亡灵次数，使你的近战攻击在成功击中敌人后附加额外的10D10光伤害。7秒技能CD。学习前置要求：已学习亡灵克星或牧师、圣骑士专长驱散亡灵。"
    }
}, "2b": {
    "abil_name": "奉献",
    "required": 4,
    "prereq": 0,
    "selected": 0,
    "img": "2b",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "持续15秒,激活奉献光环时在范围内每3秒对邪恶生物叠加1个净化效果，并造成每角色等级X[1D6]的火伤害和善良伤害。两者都受火焰法强影响。技能冷却时间：[30]秒）激活费用：[50]法术点。",
        "2": "持续15秒,激活奉献光环时在范围内每3秒对邪恶生物叠加1个净化效果，并造成每角色等级X[1D6]的火伤害和善良伤害。两者都受火焰法强影响。技能冷却时间：[25]秒）激活费用：[40]法术点。",
        "3": "持续15秒,激活奉献光环时在范围内每3秒对邪恶生物叠加1个净化效果，并造成每角色等级X[1D6]的火伤害和善良伤害。两者都受火焰法强影响。技能冷却时间：[20]秒）激活费用：[30]法术点。"
    }
}, "2c": {
    "abil_name": "纯洁之火",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "2c",
    "multi": false,
    "passive": true,
    "ranks": 3,
    "AP":1,
    "abil": {
        "1": "+[10]火法能。",
        "2": "+[20]火法能。",
        "3": "+[30]火法能。"
    }
},"2d": {
    "abil_name": "摧毁邪恶",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "2d",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "（15秒冷却CD，消耗10点蓝）近战攻击获得两倍基于魅力加值的攻击检定，+2W到攻击，+7对抗邪恶的伤害加成。对亡灵和邪恶异界敌人+50光伤害。在投出20点自然骰并确认重击时，摧毁1000HP以下亡灵或邪恶异界生物。"
    }
},"2e": {
    "abil_name": "属性提升",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "2e",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 感知",
            "2": "+1 魅力",
            "3": "+1 力量"
        }
    }
}, "3a": {
    "abil_name": "判断立场！",
    "required": "8",
    "prereq": 0,
    "selected": 0,
    "img": "3a",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "技能冷却[30]秒，消耗[25]蓝。对手必须通过意志豁免检定，否则被击晕，持续6秒。技能DC为30+感知修正。",
        "2": "技能冷却[25]秒，消耗[20]蓝。对手必须通过意志豁免检定，否则被击晕，持续6秒。技能DC为30+感知修正。",
        "3": "技能冷却[20]秒，消耗[15]蓝。对手必须通过意志豁免检定，否则被击晕，持续6秒。技能DC为30+感知修正。"
    }
}, "3b": {
    "abil_name": "圣地",
    "required": "8",
    "prereq": "2b",
    "selected": 0,
    "img": "3b",
    "multi": false,
    "passive": true,
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "范围内你和盟友接受每3秒一次的治疗。治疗量等同于角色等级，受正能量法强影响。bug：目前刀锋和机关人不享受这个愈合光环。"
    }
}, "3c": {
    "abil_name": "魔法苍穹",
    "required": "8",
    "prereq": null,
    "selected": 0,
    "img": "3c",
    "multi": false,
    "passive": true,
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "每当你施放一个火，光，或治疗法术你获得一个苍穹热情点。苍穹热情点每叠加1次给你+2神圣加值的通用法强，+1％神圣加值的所有法术暴击几率。可以叠加10次。持续10秒。"
    }
}, "3d": {
    "abil_name": "刀锋庇护",
    "required": "8",
    "prereq": 0,
    "selected": 0,
    "img": "3d",
    "multi": false,
    "passive": true,
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "你的武器或徒手攻击将被视为具有与你同等阵营的属性。"
    }
}, "3e": {
    "abil_name": "属性提升",
    "required": "8",
    "prereq": null,
    "selected": 0,
    "img": "3e",
    "multi": "multi",
    "passive":true,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 感知",
            "2": "+1 魅力",
            "3": "+1 力量"
        }
    }
}, "4a": {
    "abil_name": "无悔之连坐",
    "required": "12",
    "prereq": 0,
    "selected": 0,
    "img": "4a",
    "multi": false,
    "passive": true,
    "ranks": 1,
    "AP":2,
    "abil": {
        "1": "每当敌人在净化光环中被杀，其他附近的敌人获得1点到4点的净化叠加值。被动：+2MP。"
    }
}, "4b": {
    "abil_name": "十字军",
    "required": "12",
    "prereq": "3b",
    "selected": 0,
    "img": "4b",
    "multi": false,
    "passive": true,
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "你和你的盟友在圣地光环内将每4秒激活一个4秒的buff，提升10％神圣加值伤害。"
    }
},   "4e": {
    "abil_name": "属性提升",
    "required": "12",
    "prereq": null,
    "selected": 0,
    "img": "4e",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 感知",
            "2": "+1 魅力",
            "3": "+1 力量"
        }
    }
}, "5a": {
    "abil_name": "苛责",
        "required": "16",
        "prereq": null,
        "selected": 0,
        "img": "5a",
        "multi": false,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
        "1": "你的净化光环对附近的敌人每3秒造成诅咒伤害。对小怪造成等同于他们最大生命值的百分比伤害，每叠加一次+1％。对于boss每叠加一次净化诅咒造成1d6伤害。被动：+25蓝，+10血。（BUG：目前boss不受此光环伤害。）"
    }
} ,"5b":  {
    "abil_name": "置身天堂",
        "required": "16",
        "prereq": null,
        "selected": 0,
        "img": "5b",
        "multi": false,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
        "1": " +10物抗，+10％酸，冷，电吸收，免疫石化。"
    }
}, "5d": {
    "abil_name": "天体冠军",
    "required": "16",
    "prereq": null,
    "selected": 0,
    "img": "5d",
    "multi": false,
    "passive": true,
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "+1暴击范围。暴击时获得一个天体热情点。每个天体热情点提供+1神圣加值的双击率。最多叠加10次，持续时间6秒。"
    }
},  "5e": {
    "abil_name": "属性提升",
    "required": "16",
    "prereq": null,
    "selected": 0,
    "img": "5e",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 感知",
            "2": "+1 魅力",
            "3": "+1 力量"
        }
    }
}, "6b": {
        "abil_name": "天体轰炸",
        "required": "20",
        "prereq": 0,
        "selected": 0,
        "img": "6b",
        "multi": false,
        "passive": false,
        "ranks": 3,
        "AP":1,
        "abil": {
            "1": "召唤三颗流星对你的敌人进行轰炸，造成每角色等级3d6点火焰伤害。受火焰法强影响，可暴击。此外，敌人需要对抗三个连续的反射豁免，DC为20+感知调整+角色的塑能DC，不过豁免将被击倒。技能消耗[100]点蓝，冷却CD[60]秒。",
            "2": "召唤三颗流星对你的敌人进行轰炸，造成每角色等级3d6点火焰伤害。受火焰法强影响，可暴击。此外，敌人需要对抗三个连续的反射豁免，DC为20+感知调整+角色的塑能DC，不过豁免将被击倒。技能消耗[75]点蓝，冷却CD[45]秒。",
            "3": "召唤三颗流星对你的敌人进行轰炸，造成每角色等级3d6点火焰伤害。受火焰法强影响，可暴击。此外，敌人需要对抗三个连续的反射豁免，DC为20+感知调整+角色的塑能DC，不过豁免将被击倒。技能消耗[50]点蓝，冷却CD[30]秒。"
        }
    },
    "6d": {
    "abil_name": "击倒",
    "required": "20",
    "prereq":0,
    "selected": 0,
    "img": "6d",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "（冷却时间15秒，消耗10点蓝）近战攻击获得2倍魅力加值攻击以及人物等级X3的攻击加成，+7对抗邪恶生物。附加500点火焰伤害。命中后直接摧毁低于1000生命值的亡灵或邪恶异界生物。"
    }
},  "6e": {
    "abil_name": "属性提升",
    "required": "20",
    "prereq": null,
    "selected": 0,
    "img": "6e",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 感知",
            "2": "+1 魅力",
            "3": "+1 力量"
        }
    }
}};
