this.model.exalted_angel={  "dID": "exalted_angel", "name": "大天使", "autogrants": [
    {
        "abil_name": "神府天命",
        "img": "celestialdestiny",
        "abil": "+50SP，每个大天使等级+50SP，+1牧师，骑士，天佑施法等级。重造技能可以对自己使用。",
        "passive": "passive"
    },
    {
        "abil_name": "天使附身",
        "img": "angelicpresence-taken",
        "abil": "(等级 1) (冷却: 10秒) 生命在50%以上时，+2神圣值的魅力，-2怪物攻击。这个惩罚属于恐惧类型和天佑光环叠加。",
        "passive": false
    },
    {
        "abil_name": "星界活力",
        "img": "angelicpresence-taken",
        "abil": "(等级 2) (冷却: 10秒) 生命在50%以上时，如果敌人的生命在50%一下，他们每2秒受到1d4伤害，然后这个伤害增加1d4每2秒，最高到20d4每2秒。你附近的队友如果生命在50%一下，他们每2秒被医疗1d4伤害，然后这个医疗效果增加1d4每2秒，最高到20d4每2秒。费用1sp每2秒，+1sp每两秒，（1，2，3，4，5。。。每2秒）",
        "passive": false
    },
    {
        "abil_name": "信仰飞跃",
        "img": "leapoffaith-taken",
        "abil": "(等级 3) (冷却: 3秒, 10 蓝) 获得飞跃，如果你已有此技能，现在这个技能野外回复从15秒变成12秒。",
        "passive": false
    },
    {
        "abil_name": "祝福之剑",
        "img": "blessedblades",
        "abil": "(等级 4)你用的所有武器获得你的阵营属性伤害。中立者无效。",
        "passive": "passive"
    },
    {
        "abil_name": "飞升",
        "img": "ascendance-taken",
        "abil": "(等级 5) (冷却: 5分钟) 变成天使（天使,善良异界生物）。每当你用光系法术，你有几率回蓝。每当你用治疗法术，你有几率给目标加上虚假生命。每次你攻击敌人，你有几率获得虚假生命。你的天使附身与星界活力不再有生命上限的需求。星界活力不再消耗SP。为时2分钟，消耗50SP",
        "passive": false
    }
], "1a": {
    "abil_name": "复仇之光",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "avenginglight",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 3秒) 对一个目标造成1d4，+1d4每3人物等级光系伤害，坚韧豁免（DC10+人物等级+魅力调整）减半"
    }
}, "1b": {
    "abil_name": "光的力量",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "radiantpower",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "+10 光法强",
        "2": "+20 光法强",
        "3": "+30 光法强"
    }
}, "1c": {
    "abil_name": "无边的信仰",
    "required": 0,
    "prereq": "1b,1d",
    "selected": 0,
    "img": "endlessfaith",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "SP上限增加4%。法力呼应技能可以补充18SP。",
        "2": "SP上限增加7%。法力呼应技能可以补充24SP。",
        "3": "SP上限增加10%。法力呼应技能可以补充30SP。"
    }
}, "1d": {
    "abil_name": "治疗力量",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "healingpower",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "+10 正能量法强",
        "2": "+20 正能量法强",
        "3": "+30 正能量法强"
    }
}, "1e": {
    "abil_name": "感知或魅力",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "wischa",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 感知",
            "2": "+1 魅力"
        }
    }
}, "2a": {
    "abil_name": "神圣裁决",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "judgement",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 15秒, 10蓝) 如果目标不死或邪恶异界生物被杀死，他将爆炸，对周围不死或异界生物造成10d100光系伤害。"
    }
}, "2b": {
    "abil_name": "光之信奉",
    "required": 4,
    "prereq": "1b",
    "selected": 0,
    "img": "embracethelight",
    "multi": false,
    "passive": "pasive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "你减少10%光伤害",
        "2": "你减少20%光伤害",
        "3": "你减少30%光伤害"
    }
}, "2c": null, "2d": null, "2e": {
    "abil_name": "感知或魅力",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "wischa",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 感知",
            "2": "+1 魅力"
        }
    }
}, "3a": {
    "abil_name": "安息吧！",
    "required": "8",
    "prereq": "2a",
    "selected": 0,
    "img": "laytorest",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 15秒, 10蓝) 对已有神圣裁决的不死，邪恶异界生物目标造成10d100光系伤害"
    }
}, "3b": {
    "abil_name": "破邪斩",
    "required": "8",
    "prereq": null,
    "selected": 0,
    "img": "smitethewicked",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 15秒, 10蓝) 近战攻击。如果攻击邪恶目标，你获得+2倍魅力调整到AB上，伤害增加（等级x3+7）命中不死或邪恶异界生物增加+50光伤害。如果Roll20点（斩首）：毁灭生命1000以下的不死或邪恶异界生物"
    }
}, "3c": {
    "abil_name": "再造",
    "required": "8",
    "prereq": null,
    "selected": 0,
    "img": "mend",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "(冷却: 3秒, 5蓝) 医疗1d2HP每4人物等级每2秒，持续8秒。如果目标生命值不足50%,则附加‘天体盾牌’可吸收30点伤害。",
        "2": "(冷却: 3秒, 5蓝) 医疗1d2HP每3人物等级每2秒，持续8秒。如果目标生命值不足50%,则附加‘天体盾牌’可吸收40点伤害。",
        "3": "(冷却: 3秒, 5蓝) 医疗1d2HP每2人物等级每2秒，持续8秒。如果目标生命值不足50%,则附加‘天体盾牌’可吸收50点伤害。"
    }
}, "3d": {
    "abil_name": "纯洁本质",
    "required": "8",
    "prereq": "1d,3c",
    "selected": 0,
    "img": "purityofessence",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "3% 治疗放大",
        "2": "5% 治疗放大",
        "3": "10% 治疗放大"
    }
}, "3e": {
    "abil_name": "感知或魅力",
    "required": "8",
    "prereq": null,
    "selected": 0,
    "img": "wischa",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 感知",
            "2": "+1 魅力"
        }
    }
}, "4a": {
    "abil_name": "群体裁决",
    "required": "12",
    "prereq": "3a",
    "selected": 0,
    "img": "judgethemany",
    "multi": false,
    "passive": "passive",
    "ranks": 1,
    "AP": 1,
    "abil": {
        "1": "被神圣裁决的不死或邪恶异界生物获得连坐效果。如死亡，周边不死和恶异界生物有50%几率被神圣裁决。"
    }
}, "4b": {
    "abil_name": "训斥敌人",
    "required": "12",
    "prereq": "4c",
    "selected": 0,
    "img": "rebukefoe",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 3秒) 只能在你的‘无边热情’大于4时使用。目标敌人在30秒内受到额外+5%物理和光系伤害。可以叠加5次，每次叠加增加30秒时间。‘无边热情’值清零。"
    }
}, "4c": {
    "abil_name": "血与光",
    "required": "12",
    "prereq": null,
    "selected": 0,
    "img": "bloodandradiance",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "每当你用光系法术，你获得1个‘无边热情’值，+1正能量法能10秒。每当你用正能量系法术，你获得1个‘正义热情’值，+1光系法能10秒。叠加10次，每次叠加延长10秒。",
        "2": "",
        "3": ""
    }
}, "4d": {
    "abil_name": "苛责",
    "required": "12",
    "prereq": "4c",
    "selected": 0,
    "img": "excoriate",
    "multi": false,
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "如果你的‘正义热情’大于4，你的光系法术与破邪斩有3%几率震撼目标6秒。"
    }
}, "4e": {
    "abil_name": "感知或魅力",
    "required": "12",
    "prereq": null,
    "selected": 0,
    "img": "wischa",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 感知",
            "2": "+1 魅力"
        }
    }
}, "5a": {
    "abil_name": "和平至上",
    "required": "16",
    "prereq": null,
    "selected": 0,
    "img": "beatpeace",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": " (冷却: 2 分钟, 10使目标眩晕1分钟，无豁免。‘无边热情’与‘正义热情’值清零。"
    }
}, "5b": null, "5c": null, "5d": null, "5e": {
    "abil_name": "感知或魅力",
    "required": "16",
    "prereq": null,
    "selected": 0,
    "img": "wischa",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 感知",
            "2": "+1 魅力"
        }
    }
}, "6a": null, "6b": {
    "abil_name": "神圣怒火",
    "required": "20",
    "prereq": "4b",
    "selected": 0,
    "img": "divinewrath",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 3秒, 30蓝) 只能在‘无边热情’值等于10时使用。召唤神的怒火，对敌人造成2d6每人物等级光系伤害。意志豁免减半（DC10+人物等级+一半魅力调整）。所有队友获得1d6每人物等级的医疗。‘无边热情’值清零。"
    }
}, "6c": {
    "abil_name": "光辉复生",
    "required": "20",
    "prereq": "4c",
    "selected": 0,
    "img": "reborninlight",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 30分钟) 每当你获得‘无边热情’或‘正义热情’值时，你的光辉复生筹码+1，当这个筹码到100时，你可以使用传奇瞬间转身：你立刻无伤恢复，启动飞升，天使附身与星界活力天命技能（无视这些技能的CD）。在2分钟之内（或当你解除你的天使形态），你无视光系伤害，+50%幽冥形态，+100光系与正能量法能可以在死亡状态中使用，使你原地满血复活外加以上的好处，所有的光系，正能量系法术的CD减少至正常的1/5，所有法术消耗50%蓝，你所有的物理攻击获得如果攻击到:+100光系伤害。如果重击：消灭小于1000血的不死与邪恶异界生物。"
    }
}, "6d": {
    "abil_name": "击倒",
    "required": "20",
    "prereq": "4d",
    "selected": 0,
    "img": "strikedown",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 15秒, 10蓝) 只能在你的‘正义热情’值=10的时候使用。近战破邪斩：如果攻击邪恶目标，你获得+2倍魅力调整到AB上，伤害增加（等级x3+7）如果命中：+500光系伤害，毁灭生命不到1000点的不死或邪恶异界生物。"
    }
}, "6e": {
    "abil_name": "感知或魅力",
    "required": "20",
    "prereq": null,
    "selected": 0,
    "img": "wischa",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 感知",
            "2": "+1 魅力"
        }
    }
}};
