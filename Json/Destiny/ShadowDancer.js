this.model.shadowdancer={  "dID": "shadowdancer", "name": "影舞者", "autogrants": [
    {
        "abil_name": "幽影训练 I",
        "img": "shadowtraining_i",
        "abil": "每个影舞者等级+1偷袭骰",
        "passive": "passive"
    },
    {
        "abil_name": "幽影训练 II",
        "img": "fullmovesneak",
        "abil": "(等级 1) (冷却: 5分钟) 启动该技能，在30秒之内可以在潜行中保持非潜行移动速度和跳跃",
        "passive": false
    },
    {
        "abil_name": "幽影训练 III",
        "img": "ShadowTrainingIII",
        "abil": "(等级 2) (冷却: 2秒) 减低近战远程攻击伤害20%仇恨",
        "passive": false
    },
    {
        "abil_name": "幽影训练 IV",
        "img": "shadowwalk-taken",
        "abil": "(等级 3) (冷却: 1分钟) 可以使用行影术5次。如果武器是灵巧武器，+3%亵渎双击几率。该几率对匕首，手斧，镰刀，曲刀，轻锤，轻十字锤，刺剑，短剑，徒手，动物自然武器有效",
        "passive": false
    },
    {
        "abil_name": "幽影训练 V",
        "img": "dimensiondoor-taken",
        "abil": "(等级 4) (冷却: 1分钟) 可以使用5次次元门,同时可以让幽影训练II的冷却时间由5分钟降低至3分钟",
        "passive": false
    },
    {
        "abil_name": "黑暗逃避",
        "img": "darkelusion-taken",
        "abil": "(等级 5) 你获得反射闪避。另外，当你的攻击Roll20，你的影子覆盖了目标，目标受到的所有物理伤害+5%，如果目标有免疫偷袭的能力，那么还将暂时移除目标的偷袭免疫能力,该效果触发后持续12秒。",
        "passive": "passive"
    }
], "1a": {
    "abil_name": "隐蔽",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "stealthy",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "+2 隐藏和潜行. +2 刺杀DC.",
        "2": "+4 隐藏和潜行. +4 刺杀DC.",
        "3": "+6 隐藏和潜行. +6 刺杀DC.  你获得视线躲避"
    }
}, "1b": {
    "abil_name": "暗影长枪",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "shadowlance",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "(冷却: 30秒) 向目标投掷3枚暗影长枪,每支造成6D3+18点邪恶伤害,如果你拥有暗影充能，则可能使你的目标进入目盲状态(致盲DC=[14+智力调整值+人物等级/2]每支暗影长枪的伤害鉴定单独计算,致盲鉴定只做一次）",
        "2": "(冷却: 30秒) 向目标投掷3枚暗影长枪,每支造成8D3+24点邪恶伤害,如果你拥有暗影充能，则可能使你的目标进入目盲状态(致盲DC=[16+智力调整值+人物等级/2]每支暗影长枪的伤害鉴定单独计算,致盲鉴定只做一次）",
        "3": "(冷却: 30秒) 向目标投掷3枚暗影长枪,每支造成10D3+30点邪恶伤害,如果你拥有暗影充能，则可能使你的目标进入目盲状态(致盲DC=[18+智力调整值+人物等级/2]每支暗影长枪的伤害鉴定单独计算,致盲鉴定只做一次）"
    }
}, "1c": {
    "abil_name": "杂技",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "acrobatic",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "+2 平衡, 跳跃,翻滚; +3翻滚时反射豁免",
        "2": "+4 平衡, 跳跃,翻滚; +6翻滚时反射豁免",
        "3": "+6 平衡, 跳跃,翻滚; +9翻滚时反射豁免"
    }
}, "1d": {
    "abil_name": "技术师",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "technician",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "+2 搜索, 侦查, 解除装置,开锁,夹击奖励",
        "2": "+4 搜索, 侦查, 解除装置,开锁,夹击奖励",
        "3": "+6 搜索, 侦查, 解除装置,开锁,夹击奖励"
    }
}, "1e": {
    "abil_name": "敏捷或智力",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "dexint",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 敏捷",
            "2": "+1 智力"
        }
    }
}, "2a": {
    "abil_name": "逃脱",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "escapenotice",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 1分钟) 激发一次利用隐藏技能的交涉"
    }
}, "2b": null, "2c": {
    "abil_name": "轻盈",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "lithe",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "+2 反射, 防御,轻甲最大敏捷加值",
        "2": "+4 反射, 防御,轻甲最大敏捷加值",
        "3": "+6 反射, 防御,轻甲最大敏捷加值"
    }
}, "2d": {
    "abil_name": "技能大师",
    "required": 4,
    "prereq": "1d",
    "selected": 0,
    "img": "skillmastery",
    "multi": false,
    "passive": "passive",
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "+1所有技能"
    }
}, "2e": {
    "abil_name": "敏捷或智力",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "dexint",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 敏捷",
            "2": "+1 智力"
        }
    }
}, "3a": {
    "abil_name": "幽影披风",
    "required": 8,
    "prereq": "3b",
    "selected": 0,
    "img": "cloakofshadows",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 2分钟) 使用一个暗影充能，使你笼罩在黑暗中，吸收光与负能量伤害，持续5分钟或吸收120点伤害后消失。"
    }
}, "3b": {
    "abil_name": "暗影标记",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "darkshrouding",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "(冷却: 15秒) 近战或远程攻击: +1[w] 伤害.命中后标识目标.如果标识的目标10秒内死亡,你将获得暗影充能. 最大叠加[3]暗影充能",
        "2": "(冷却: 15秒) 近战或远程攻击: +2[w] 伤害.命中后标识目标.如果标识的目标10秒内死亡,你将获得暗影充能. 最大叠加[5]层暗影充能",
        "3": "(冷却: 15秒) 近战或远程攻击: +3[w] 伤害.命中后标识目标.如果标识的目标10秒内死亡,你将获得暗影充能. 最大叠加[7]层暗影充能"
    }
}, "3c": {
    "abil_name": "融入黑暗",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "meldintoshadow",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "(冷却: 2分钟) +100% 闪避,附魔加值,持续9 秒.",
        "2": "(冷却: 2分钟) +100% 闪避,附魔加值,持续12 秒.",
        "3": "(冷却: 2分钟) +100% 闪避,附魔加值,持续15 秒."
    }
}, "3d": {
    "abil_name": "冷酷的精准",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "grimprecision",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "无视敌人5%护命和1%闪避 ",
        "2": "无视敌人10%护命和2%闪避 ",
        "3": "无视敌人15%护命和3%闪避 "
    }
}, "3e": {
    "abil_name": "敏捷或智力",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "dexint",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 敏捷",
            "2": "+1 智力"
        }
    }
}, "4a": null, "4b": {
    "abil_name": "高级隐身",
    "required": 12,
    "prereq": "3b",
    "selected": 0,
    "img": "improvedinvis",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "(冷却: 4分钟)隐身[10]秒。攻击不会使隐身失效，隐身结束后你获得30秒的位移效果。",
        "2": "(冷却: 4分钟)隐身[20]秒。攻击不会使隐身失效，隐身结束后你获得60秒的位移效果。",
        "3": "(冷却: 4分钟)隐身[30]秒。攻击不会使隐身失效，隐身结束后你获得90秒的位移效果。"
    }
}, "4c": null, "4d": {
    "abil_name": "穿透黑暗",
    "required": 12,
    "prereq": "3d",
    "selected": 0,
    "img": "piercethegloom",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却:2分钟) 30秒内攻击增加+100%"
    }
}, "4e": {
    "abil_name": "敏捷或智力",
    "required": 12,
    "prereq": null,
    "selected": 0,
    "img": "dexint",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 敏捷",
            "2": "+1 智力"
        }
    }
}, "5a": {
    "abil_name": "暗影支配",
    "required": 16,
    "prereq": "3a",
    "selected": 0,
    "img": "shadowmanipulation",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却:2分钟) 消耗1个暗影充能可以支配一个目标1分钟,过意志豁免[DC=14+人物等级+智力调整],结束之后目标过强韧豁免[DC=14+人物等级+智力调整],失败则立刻死亡。"
    }
}, "5b": {
    "abil_name": "不可触摸",
    "required": 16,
    "prereq": "4b",
    "selected": 0,
    "img": "untouchable",
    "multi": false,
    "passive": "passive",
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "每次获得暗影充能奖励额外1%闪避,最大+7%"
    }
}, "5c": {
    "abil_name": "处刑攻击",
    "required": 16,
    "prereq": null,
    "selected": 0,
    "img": "executionersstrike",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "(冷却:30秒)施展一次近战或远程攻击,伤害+1[W],重击范围+1,重击倍数+1,死亡效果豁免成功则受到75点额外伤害,命中后投100面骰,36以下时对目标施加死亡攻击效果,死亡攻击会在1秒之后对目标进行一次即死鉴定,失败则立即死亡,DC=7+人物等级+敏捷调整值+暗影充能层数。",
        "2": "(冷却:30秒)施展一次近战或远程攻击,伤害+2[W],重击范围+1,重击倍数+1,死亡效果豁免成功则受到150点额外伤害,命中后投100面骰,36以下时对目标施加死亡攻击效果,死亡攻击会在1秒之后对目标进行一次即死鉴定,失败则立即死亡,DC=7+人物等级+敏捷调整值+暗影充能层数。",
        "3": "(冷却:30秒)施展一次近战或远程攻击,伤害+3[W],重击范围+1,重击倍数+1,死亡效果豁免成功则受到225点额外伤害,命中后投100面骰,36以下时对目标施加死亡攻击效果,死亡攻击会在1秒之后对目标进行一次即死鉴定,失败则立即死亡,DC=7+人物等级+敏捷调整值+暗影充能层数。"
    }
}, "5d": {
    "abil_name": "固魂",
    "required": 16,
    "prereq": null,
    "selected": 0,
    "img": "sealedsoul",
    "multi": false,
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "免疫负向等级"
    }
}, "5e": {
    "abil_name": "敏捷或智力",
    "required": 16,
    "prereq": null,
    "selected": 0,
    "img": "dexint",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 敏捷",
            "2": "+1 智力"
        }
    }
}, "6a": {
    "abil_name": "吞噬",
    "required": 20,
    "prereq": "5a",
    "selected": 0,
    "img": "consume",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 2分钟)消耗1层暗影充能,在你周围制造一个持续10秒的死亡力场,每2秒都会引导暗影试图吞噬周围的敌人,受到该效果的目标都需要进行一个DC=29的强韧豁免检定,豁免失败则立即死亡,豁免成功则受到10D5+70点无类型伤害。施展该能力之后你依然可以自由进行其他动作。"
    }
}, "6b": {
    "abil_name": "幽影形态",
    "required": 20,
    "prereq": "5b",
    "selected": 0,
    "img": "shadowform",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 60秒)消耗1层暗影充能使你变成幽影形态(获得25%虚体,恒定羽落术,+20潜行,隐藏和翻滚,物理攻击重击会使目标受到1D6点力量伤害,获得翻滚穿越效果:翻滚动作会穿过目标而不受阻挡,受到双倍光伤害。)"
    }
}, "6c": {
    "abil_name": "黑暗降临",
    "required": 20,
    "prereq": "6b",
    "selected": 0,
    "img": "darkimbuement",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 4分钟)每当一个标记的目标在10秒内死亡时,获得一个点数,当累计到20时,可以激活,在武器上附加暗影能量。每次攻击+2d6邪恶伤害,攻击距离增加,你的远程武器攻击有30%几率爆炸,造成10d6邪恶伤害。"
    }
}, "6d": null, "6e": {
    "abil_name": "敏捷或智力",
    "required": 20,
    "prereq": null,
    "selected": 0,
    "img": "dexint",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 敏捷",
            "2": "+1 智力"
        }
    }
}};
