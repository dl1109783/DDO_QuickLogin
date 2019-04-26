this.model.fatesinger ={  "dID": "fatesinger", "name": "命运咏者", "autogrants": [
    {
        "abil_name": "命运咏者的剧目",
        "img": "fatesingersrepertoire-taken",
        "abil": "每个等级的命运咏者获得2个歌，+3音波抗，+25法强。如果你没有士气之歌专长，你将获得该专长。+1奥法施法等级",
        "passive": false
    },
    {
        "abil_name": "名誉之辉",
        "img": "glitteroffame-taken",
        "abil": "(等级 1) +1奥法施法等级，+1AB。特效：只要你还有10%血，你充满自信：+1所有属性",
        "passive": "passive"
    },
    {
        "abil_name": "和谐共鸣",
        "img": "harmonicresonance-taken",
        "abil": "(等级 2) 你的近战远程攻击有10%几率对敌人叠加上共鸣。每次叠加增加该目标的音波伤害10%。最高叠加5次，为时20秒。启动：你用掉1个歌曲，激发和谐共鸣。你的法术不再需要施法材料。",
        "passive": false
    },
    {
        "abil_name": "迷人的姿态",
        "img": "intoxicatingpresence-taken",
        "abil": "(等级 3) +1奥术施法等级，+1AB。特效：只要你还有10%血，凡是攻击你的敌人有5%几率被迷惑12秒，无豁免。",
        "passive": "passive"
    },
    {
        "abil_name": "宏伟姿态",
        "img": "grandeur-taken",
        "abil": "(等级 4) +1奥术施法等级，+1AB。特效：只要你还有10%血，你投射了一个宏伟的姿态。你和你的队友获得+1豁免，+2魅力技能，+3伤害",
        "passive": "passive"
    },
    {
        "abil_name": "皇家姿态",
        "img": "majesty",
        "abil": "(等级 5) +1奥术施法等级，+1AB，+5对抗附魔豁免，+2附魔法术施法等级，+10音波，正能，光系法能。攻击到你的敌人有5%几率被你了光环致盲，无豁免。",
        "passive": "passive"
    }
], "1a": {
    "abil_name": "赞美命运女神",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "ofortuna",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "鼓舞士气给予+1反射和坚韧豁免",
        "2": "鼓舞士气给予+2反射和坚韧豁免",
        "3": "鼓舞士气给予+3反射和坚韧豁免"
    }
}, "1b": {
    "abil_name": "诱惑之歌",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "allure",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "每天增加额外1首歌曲,+2 还价, 表演 ,唬骗,  ",
        "2": "每天增加额外2首歌曲,+4 还价, 表演 ,唬骗,  ",
        "3": "每天增加额外3首歌曲,+6 还价, 表演 ,唬骗,  "
    }
}, "1c": {
    "abil_name": "蜘蛛女王之歌",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "musicspiderqueen",
    "multi": false,
    "passive": "passive",
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "你的迷魂歌可以影响到鼠虫类"
    }
}, "1d": {
    "abil_name": "挽歌",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "revielle",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "(冷却: 6秒) 18秒内你每3秒对敌人造成10d4负能量伤害10d8音波伤害，坚韧豁免减半。另外如果没过豁免，敌人被减速5%。",
        "2": "(冷却: 6秒) 18秒内你每3秒对敌人造成10d6负能量伤害10d10音波伤害，坚韧豁免减半。另外如果没过豁免，敌人被减速5%。",
        "3": "(冷却: 6秒) 18秒内你每3秒对敌人造成10d8负能量伤害10d12音波伤害，坚韧豁免减半。另外如果没过豁免，敌人被减速5%。"
    }
}, "1e": {
    "abil_name": "魅力或力量",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "strcha",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 魅力",
            "2": "+1 力量"
        }
    }
}, "2a": {
    "abil_name": "顺风",
    "required": 4,
    "prereq": "1a",
    "selected": 0,
    "img": "tailwind",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "鼓舞士气给予+2远程武器伤害",
        "2": "鼓舞士气给予+4远程武器伤害",
        "3": "鼓舞士气给予+6远程武器伤害"
    }
}, "2b": {
    "abil_name": "明朗的命运",
    "required": 4,
    "prereq": "1b",
    "selected": 0,
    "img": "lucidity",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "额外增加1首歌曲,+2 专注, 交涉,UMD",
        "2": "额外增加2首歌曲,+4 专注, 交涉,UMD",
        "3": "额外增加3首歌曲,+6 专注, 交涉,UMD"
    }
}, "2c": {
    "abil_name": "假面舞会",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "maskedball",
    "multi": false,
    "passive": "passive",
    "ranks": 2,
    "AP": 1,
    "abil": {
        "1": "迷魂歌或挽歌赋予你和你的队友+10跳跃和翻滚，+2魅力；",
        "2": "迷魂歌或挽歌赋予你和你的队友+20跳跃和翻滚，+2魅力；, 第3级获得光滑表面免疫"
    }
}, "2d": null, "2e": {
    "abil_name": "魅力或力量",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "strcha",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 魅力",
            "2": "+1 力量"
        }
    }
}, "3a": {
    "abil_name": "海妖之歌",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "sirenssong",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "(冷却: 60秒)对一个目标施展不可解的迷惑，另外造成每3秒2点体质伤害。",
        "2": "(冷却: 50秒)对一个目标施展不可解的迷惑，另外造成每2秒2点体质伤害。",
        "3": "(冷却: 40秒)对一个目标施展不可解的迷惑，另外造成每1秒2点体质伤害。"
    }
}, "3b": {
    "abil_name": "统治之歌",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "artfulmisdirection",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "自发歌曲(没有唱歌的时间):你获得+20临时生命。Roll20:+7d20音波，7d20电系伤害，持续180秒。",
        "2": "自发歌曲(没有唱歌的时间):你获得+40临时生命。Roll20:+9d20音波，9d20电系伤害，持续180秒。",
        "3": "自发歌曲(没有唱歌的时间):你获得+60临时生命。Roll20:+11d20音波，11d20电系伤害，持续180秒。"
    }
}, "3c": {
    "abil_name": "祖先之言：奥法",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "echoesmagister",
    "multi": "multi",
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1体质，+20SP，+1自然AC，+2毒系豁免。+5火酸冰电法能。",
            "2": "+1智力，+1UMD，+2法穿，+2法棒DC，+20SP"
        }
    }
}, "3d": {
    "abil_name": "清晰之气",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "ventriloquism",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "你的法术减去10%仇恨。另外+25音波系法能，+5力场，正能量，负能量法能。持续(10x表演技能)秒",
        "2": "你的法术减去20%仇恨。另外+50音波系法能，+10力场，正能量，负能量法能。持续(10x表演技能)秒",
        "3": "你的法术减去30%仇恨。另外+75音波系法能，+15力场，正能量，负能量法能。持续(10x表演技能)秒"
    }
}, "3e": {
    "abil_name": "魅力或力量",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "strcha",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 魅力",
            "2": "+1 力量"
        }
    }
}, "4a": {
    "abil_name": "断音之弦",
    "required": 12,
    "prereq": "3a",
    "selected": 0,
    "img": "chorddisruption",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "当海妖之歌结束时，断音之弦对目标造成[5D100+700]点音波伤害。豁免伤害减半",
        "2": "当海妖之歌结束时，断音之弦对目标造成[6D100+800]点音波伤害。豁免伤害减半",
        "3": "当海妖之歌结束时，断音之弦对目标造成[7D100+900]点音波伤害。豁免伤害减半"
    }
}, "4b": {
    "abil_name": "祖先之言：神圣",
    "required": 12,
    "prereq": null,
    "selected": 0,
    "img": "echoesexaltedangel",
    "multi": "multi",
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1感知，+15SP，+3跳，+4疾病豁免，+20正能量法能。",
            "2": "+1感知，+1豁免，你的士气之歌给予+2恐惧豁免，如果你有骑士的善良之环，额外获得+2恐惧豁免。如果你有驱散，你的驱散效果+2等级。"
        }
    }
}, "4c": {
    "abil_name": "祖先之言：战争",
    "required": 12,
    "prereq": null,
    "selected": 0,
    "img": "echoeslegendarydreadnaught",
    "multi": "multi",
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1体质，+10HP，+1战技DC，+2架盾DR，+2架盾AC，+1AB",
            "2": "+1感知，+2翻滚AC，+1豁免。如果专注，+5%AC。",
            "3": "+1敏捷，+2机关豁免，+1d6偷袭，如果你被攻击到，5%几率获得4秒的随影，随影：位移，+4AB+2伤害，+15%攻击速度，如果被伤害效果解除。"
        }
    }
}, "4d": {
    "abil_name": "祖先之言：原始",
    "required": 12,
    "prereq": null,
    "selected": 0,
    "img": "echoeswildhunter",
    "multi": "multi",
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1体质，+20HP。如果你有狂暴，你的狂暴+1力量，+1体质。你有2%几率在溅射攻击是激活你的武器特效。",
            "2": "+1敏捷，+2巡视，+2听力，+2躲藏，+2无声无息，+2交涉，+1Actionboost。你的远程，投射武器速度+5%，+1%闪避。"
        }
    }
}, "4e": {
    "abil_name": "魅力或力量",
    "required": 12,
    "prereq": null,
    "selected": 0,
    "img": "strcha",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 魅力",
            "2": "+1 力量"
        }
    }
}, "5a": {
    "abil_name": "绑定之命运",
    "required": 16,
    "prereq": null,
    "selected": 0,
    "img": "boundfate",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "(冷却: 4分钟) 一个目标必须过意志豁免DC魅力调整。如果豁免失败，目标被绑定，1分钟内+6%音波，冰，电伤害，-6法抗。目标-4伤害。瞬发",
        "2": "(冷却: 4分钟) 一个目标必须过意志豁免DC魅力调整。如果豁免失败，目标被绑定，1分钟内+10%音波，冰，电伤害，-10法抗。目标-6伤害。瞬发",
        "3": "(冷却: 4分钟) 一个目标必须过意志豁免DC魅力调整。如果豁免失败，目标被绑定，1分钟内+15%音波，冰，电伤害，-15法抗。目标-8伤害。瞬发"
    }
}, "5b": {
    "abil_name": "歌曲片段：明晰",
    "required": 16,
    "prereq": null,
    "selected": 0,
    "img": "fragmentclarity",
    "multi": false,
    "passive": "passive",
    "ranks": 2,
    "AP": 1,
    "abil": {
        "1": "士气之歌减少你的施法SP5%，15临时SP。",
        "2": "士气之歌减少你的施法SP5%，减少你的队友的施法SP5%，+4专注。你获得15临时SP。"
    }
}, "5c": {
    "abil_name": "假面舞会",
    "required": 16,
    "prereq": null,
    "selected": 0,
    "img": "masquerade",
    "multi": false,
    "passive": "passive",
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "激活假面舞会可以在休息点变换你的命运编织"
    }
}, "5d": {
    "abil_name": "歌曲片段：勇气",
    "required": 16,
    "prereq": null,
    "selected": 0,
    "img": "fragmentvalor",
    "multi": false,
    "passive": "passive",
    "ranks": 2,
    "AP": 1,
    "abil": {
        "1": "你的士气之歌授予+4攻击速度，+20临时HP。解除移动攻击的惩罚。",
        "2": "你的士气之歌授予+4攻击速度，+20临时HP。给你的队友20临时HP，+4威吓，解除移动攻击的惩罚。2%几率+5%电，光，音波弱点，叠加3次。"
    }
}, "5e": {
    "abil_name": "魅力或力量",
    "required": 16,
    "prereq": null,
    "selected": 0,
    "img": "strcha",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 魅力",
            "2": "+1 力量"
        }
    }
}, "6a": {
    "abil_name": "严酷的命运",
    "required": 20,
    "prereq": "5a",
    "selected": 0,
    "img": "grimfate",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "的绑定之命运增加了目标的物理伤害弱点+5%。就算绑定之命运被豁免，严酷的命运也有效, 持续 30 秒. ",
        "2": "的绑定之命运增加了目标的物理伤害弱点+10%。就算绑定之命运被豁免，严酷的命运也有效, 持续 30 秒. ",
        "3": "的绑定之命运增加了目标的物理伤害弱点+15%。就算绑定之命运被豁免，严酷的命运也有效, 持续 30 秒. "
    }
}, "6b": null, "6c": {
    "abil_name": "转换输赢",
    "required": 20,
    "prereq": null,
    "selected": 0,
    "img": "turnofthetide",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 10 分钟)使用一个歌曲去激活：+5AB，+40%伤害，DR15，+4魅力，每次攻击：+5d20+150音波伤害（对boss无效）。在这个效果之下，如果投1，你不会对意志豁免自动失败。持续20秒。"
    }
}, "6d": null, "6e": {
    "abil_name": "魅力或力量",
    "required": 20,
    "prereq": null,
    "selected": 0,
    "img": "strcha",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 魅力",
            "2": "+1 力量"
        }
    }
}};
