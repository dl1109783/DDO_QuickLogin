this.model.primal_avatar={  "dID": "primal_avatar", "name": "原始化身", "autogrants": [
    {
        "abil_name": "精神之力",
        "img": "spiritofstrength",
        "abil": "(冷却: 5秒) 每当你攻击敌人，对友对敌施法，你获得一点灵魂能量。每3秒每个同样的攻击可以获得1点，最高储存30点。每9秒消失一点。启动：获得+30全系法能。1点神怪点启动，每6秒消除1点。",
        "passive": false
    },
    {
        "abil_name": "自然法术",
        "img": "magicofnature",
        "abil": "(等级 1) 每个原始化身等级+50SP，+1德鲁伊，游侠施法等级。",
        "passive": "passive"
    },
    {
        "abil_name": "原始奔跃",
        "img": "primaltravel",
        "abil": "(等级 2) 消耗1点精神能量，向后跳跃数次。",
        "passive": false
    },
    {
        "abil_name": "精神勇士",
        "img": "mightamongspirits",
        "abil": "(等级 3)+20血。精神能量每9秒消失1点改为每15秒消失1点。",
        "passive": "passive"
    },
    {
        "abil_name": "永恒轮回",
        "img": "eternalreturn",
        "abil": "(等级 4) 果你的血在50%以下，每2秒恢复12血，消耗1点精神能量与4点魔法值。",
        "passive": false
    },
    {
        "abil_name": "与精神同行",
        "img": "walkwithspirits",
        "abil": "(等级 5) 消耗100蓝和1点精神能量激活，你变成隐身外加幽冥状，+30隐藏，潜行。每秒消耗1点精神能量。",
        "passive": false
    }
], "1a": {
    "abil_name": "短暂的进化",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "ephemeralevolution",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "每当你受到物理伤害，你获得+1物理抗性持续3秒。可叠加[5]次，每秒只可叠加一次。",
        "2": "每当你受到物理伤害，你获得+1物理抗性持续3秒。可叠加[10]次，每秒只可叠加一次。",
        "3": "每当你受到物理伤害，你获得+1物理抗性持续3秒。可叠加[15]次，每秒只可叠加一次。"
    }
}, "1b": {
    "abil_name": "恢复魔茧",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "rejuvenationcocoon",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "对一个队友释放持续30秒的[90]临时生命护盾，如果护盾没有消失，每2秒恢复1d10HP。",
        "2": "对一个队友释放持续30秒的[120]临时生命护盾，如果护盾没有消失，每2秒恢复1d10HP。",
        "3": "对一个队友释放持续30秒的[150]临时生命护盾，如果护盾没有消失，每2秒恢复1d10HP。"
    }
}, "1c": {
    "abil_name": "危险孢子",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "insidiousspores",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "敌人受到孢子的影响18秒。每2秒2d10毒系和锈蚀伤害。叠加[2]次,如果在5分钟之内如果他们死亡，他们附近的人有几率受到传染。",
        "2": "敌人受到孢子的影响18秒。每2秒2d10毒系和锈蚀伤害。叠加[3]次,如果在5分钟之内如果他们死亡，他们附近的人有几率受到传染。",
        "3": "敌人受到孢子的影响18秒。每2秒2d10毒系和锈蚀伤害。叠加[4]次,如果在5分钟之内如果他们死亡，他们附近的人有几率受到传染。"
    }
}, "1d": {
    "abil_name": "自然之友",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "friendsofnature",
    "multi": "multi",
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "蝙蝠: +10音系法能,+5音抗,+3聆听",
            "2": "小鸟: +1闪避,+3侦查",
            "3": "狐狸: +1偷袭伤害,+3潜行",
            "4": "青蛙: +2 物理抵抗,+3 跳",
            "5": "松鼠: +2 夹击, +3 隐藏"
        }
    }
}, "1e": {
    "abil_name": "力量或感知",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 力量",
            "2": "+1 感知"
        }
    }
}, "2a": {
    "abil_name": "寻求平衡",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "seekingbalance",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "变身为动物，双持，空手时+1敏捷豁免，+2翻滚，+2平稳。此加值为原始加值，技能加值必须已有点数。",
        "2": "变身为动物，双持，空手时+1/2/3敏捷豁免，+2/4/6翻滚，+2/4/6平稳。此加值为原始加值，技能加值必须已有点数。",
        "3": "变身为动物，双持，空手时+1/2/3敏捷豁免，+2/4/6翻滚，+2/4/6平稳。此加值为原始加值，技能加值必须已有点数。"
    }
}, "2b": {
    "abil_name": "春风之柔",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "suppleasspring",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "如果你受到伤害,你和附件的队友获得1%闪避,原始加值,持续6秒",
        "2": "如果你受到伤害,你和附件的队友获得2%闪避,原始加值,持续6秒",
        "3": "如果你受到伤害,你和附件的队友获得3%闪避,原始加值,持续6秒"
    }
}, "2c": {
    "abil_name": "宿敌",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "contagiousspores",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "对抗不和谐生物:获得对抗宿敌+2伤害,可在你的宿敌内选一，如果没有宿敌，可选异怪。",
            "2": "对抗不和谐生物:获得对抗宿敌+2伤害,可在你的宿敌内选一，如果没有宿敌，可选构装。",
            "3": "对抗不和谐生物:获得对抗宿敌+2伤害,可在你的宿敌内选一，如果没有宿敌，可选不死。"
        }
    }
}, "2d": {
    "abil_name": "自然之盾",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "naturalshielding",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "你的召唤物，佣兵，魅惑的宠物获得[30]血，+[10]物理抗性。",
        "2": "你的召唤物，佣兵，魅惑的宠物获得[60]血，+[20]物理抗性。",
        "3": "你的召唤物，佣兵，魅惑的宠物获得[100]血，+[30]物理抗性。自然生物（动物，元素）获得反射闪避。"
    }
}, "2e": {
    "abil_name": "力量或感知",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 力量",
            "2": "+1 感知"
        }
    }
}, "3a": {
    "abil_name": "平衡攻击",
    "required": 8,
    "prereq": "2a",
    "selected": 0,
    "img": "balancedattack",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "变身为动物，双持，空手时+[2]攻击,原始加值",
        "2": "变身为动物，双持，空手时+[4]攻击,原始加值",
        "3": "变身为动物，双持，空手时+[6]攻击,原始加值"
    }
}, "3b": {
    "abil_name": "夏天的烟雾",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "summersmoke",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "你与队友有几率在攻击时额外造成5d20火伤害。",
        "2": "你与队友有几率在攻击时额外造成10d20火伤害。",
        "3": "你与队友有几率在攻击时额外造成15d20火伤害。"
    }
}, "3c": {
    "abil_name": "海啸",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "tsunami",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "召唤海啸，推到敌人，对敌造成30+1d10每人物等级冰系和钝击伤害(过强韧豁免DC=10+感知调整+人物等级)。泥巴怪和水元素免疫。"
    }
}, "3d": {
    "abil_name": "飓风前夕",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "oncomingstorm",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "你的召唤物，佣兵，魅惑的宠物获得1%几率绊倒敌人",
        "2": "你的召唤物，佣兵，魅惑的宠物获得1%几率绊倒敌人,并且额外造成20d20音波伤害.",
        "3": "你的召唤物，佣兵，魅惑的宠物获得1%几率绊倒敌人,并且额外造成20d20电伤害."
    }
}, "3e": {
    "abil_name": "力量或感知",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 力量",
            "2": "+1 感知"
        }
    }
}, "4a": {
    "abil_name": "双手格挡/对角攻击",
    "required": 12,
    "prereq": "3a",
    "selected": 0,
    "img": "pp-ss",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "变身为动物，双持，空手时+5防御",
            "2": "变身为动物，双持，空手时+5%物理伤害"
        }
    }
}, "4b": {
    "abil_name": "秋收",
    "required": 12,
    "prereq": null,
    "selected": 0,
    "img": "autumnharvest",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "当附近的敌人死亡时，附近的队友有5%几率恢复10d10血。不受法能影响。",
        "2": "当附近的敌人死亡时，附近的队友有5%几率恢复15d10血。不受法能影响。",
        "3": "当附近的敌人死亡时，附近的队友有5%几率恢复20d10血。不受法能影响。"
    }
}, "4c": {
    "abil_name": "风暴之怒",
    "required": 12,
    "prereq": null,
    "selected": 0,
    "img": "stormrage",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "每当你攻击或利用法术伤害到一个敌人时，该目标受到10d20电系伤害，豁免减半DC50.每秒可击一个目标。你获得羽落和拨档箭镞。持续18秒"
    }
}, "4d": {
    "abil_name": "召唤树精长老",
    "required": 12,
    "prereq": null,
    "selected": 0,
    "img": "summondryad",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "召唤一只树精长老。会施法及治疗"
    }
}, "4e": {
    "abil_name": "力量或感知",
    "required": 12,
    "prereq": null,
    "selected": 0,
    "img": "",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 力量",
            "2": "+1 感知"
        }
    }
}, "5a": null, "5b": {
    "abil_name": "严冬之霜",
    "required": 16,
    "prereq": null,
    "selected": 0,
    "img": "chillofwinter",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "凡是伤害你和你附近队友的敌人有20%几率被冷冻，受到每2秒1d20冰，锈铸伤害，减速5%，维持20秒，伤害可叠加10次。",
        "2": "凡是伤害你和你附近队友的敌人有20%几率被冷冻，受到每2秒1d20冰，锈铸伤害，减速15%，维持20秒，伤害可叠加10次。",
        "3": "凡是伤害你和你附近队友的敌人有20%几率被冷冻，受到每2秒1d20冰，锈铸伤害，减速25%，维持20秒，伤害可叠加10次。"
    }
}, "5c": {
    "abil_name": "精神祝福",
    "required": 16,
    "prereq": null,
    "selected": 0,
    "img": "spiritboon",
    "multi": "multi",
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+2力，体，敏。",
            "2": "+2智力，感知，魅力。"
        }
    }
}, "5d": null, "5e": {
    "abil_name": "力量或感知",
    "required": 16,
    "prereq": null,
    "selected": 0,
    "img": "",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 力量",
            "2": "+1 感知"
        }
    }
}, "6a": {
    "abil_name": "自然怒火/自然闪避",
    "required": 20,
    "prereq": "4a",
    "selected": 0,
    "img": "nfne",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "变身为动物，双持，空手时roll19-20获得+1重击倍数。",
            "2": "变身为动物，双持，空手时获得反射闪避。"
        }
    }
}, "6b": null, "6c": {
    "abil_name": "自然化身",
    "required": 20,
    "prereq": null,
    "selected": 0,
    "img": "aon",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "你变身成为自然神体，每3秒你获得+1体形，+2力量，+2体质，体形伤害，减速，叠加4次。T1:+50体形物理抵抗.T2:被你攻击的敌人有几率中毒，每2秒+2d10毒素伤害，叠加5次。T3:敌人攻击你是会感染疾病，10秒内，每2秒受到1d4体质伤害。T4:大地在你的脚下颤抖，你原地的每第3个攻击，可以击倒附近的敌人外加额外范围钝击伤害。你的神怪点每几秒减低，按你的体形算"
    }
}, "6d": null, "6e": {
    "abil_name": "力量或感知",
    "required": 20,
    "prereq": null,
    "selected": 0,
    "img": "",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 力量",
            "2": "+1 感知"
        }
    }
}};
