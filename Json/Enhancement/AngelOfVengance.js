this.model.AngelOfVengance = {"dID": "AngelOfVengance", "name": "复仇天使", "index": "102", "translate": "冬日咕咕酱",
    "x1": {
        "abil_name": "法力洗池",
        "required": 0,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "在此树中每花费1AP，你获得+1通用法术强度和+2法力值。"
        }
    }, "x2": {
        "abil_name": "谴责护盾",
        "required": 5,
        "prereq": "x1",
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "激活: 击中你的敌人将有机会被神圣谴责20秒, 提升他们受到的光和阵营伤害10%,然后削弱他们10%的护命. 这个效果可以叠加5次,祝福效果将驱散此效果."
        }
    }, "x3": {
        "abil_name": "威胁灵光",
        "required": 10,
        "prereq": "x2",
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "激活: 你弥散出15米的威胁灵光, 降低周围敌人2点豁免，命中以及AC."
        }
    }, "x4": {
        "abil_name": "召唤亚空神使",
        "required": 20,
        "prereq": "x3",
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "类法术能力:召唤亚空神使 (激活花费: 20 法力值 冷却时间: 6s ）" +
                "一个小型的亚空神使悬停在你的肩膀上并攻击周围的敌人。 召唤出的亚空神使不会被摧毁, 每2s造成1D3+施法者等级的光伤害, " +
                "你一半的光法强以及光法术重击几率将会应用于亚空神使的光线攻击之上。 " +
                "亚空神使只会攻击那些受伤的敌人, 并且不会攻击被迷魂的敌人, 并且它将总是优先攻击那些只剩下最少生命值的敌人." +
                "所有由亚空神使造成的仇恨将会应用在你身上。"
        }
    }, "x5": {
        "abil_name": "复仇魔法",
        "required": 30,
        "prereq": "x4",
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "你在75%生命值以下时获得+1%神圣加值的法术重击几率，在50%生命值以下时获得+1神圣加值的法术DC，在25%生命值以下时在火焰、力场、光和物理伤害法术上获得50%神圣加值的法术重击伤害。"
        }
    }, "x6": {
        "abil_name": "超凡入圣",
        "required": 40,
        "prereq": "x5",
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": {
                "1": "太阳之矢:需求：阿曼纳塔宠儿。  被动：你在魅力上获得+2加值，并且在交涉以及法术辨识技能上获得+2加值。主动：你可以用意志施展太阳束法术。",
                "2": "治疗真言:需求: 天命诸神宠儿。  被动: 你在魅力上获得+2加值，并且在交涉以及治疗技能上获得+2加值。    主动: 你可以使用意志施展治疗轻伤法术。",
                "3": "火焰之光:需求: 银焰宠儿。      被动: 你在魅力上获得+2加值，并且在威吓以及治疗技能上获得 +2加值。   主动: 你可以使用意志施展灼热光辉。",
                "4": "利刃庇护:需求: 刀锋领主宠儿。  被动: 你在魅力上获得+2加值，并且在威吓以及维修技能上获得+2加值。    主动: 你可以使用意志施展护盾术。",
                "5": "猎手隐秘:需求: 瓦库瑞宠儿。    被动: 你在魅力上获得+2加值，并且在躲藏以及无声移动技能上获得+2加值。主动: 你可以使用意志施展隐形术。",
                "6": "不死之言:需求: 不朽评议会宠儿。被动: 你在魅力上获得+2加值，并且在侦查以及搜索技能上获得+2加值。    主动: 你可以使用意志施展命令不死生物。"
            }
        }
    }, "1a": {
        "abil_name": "灾祸",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "当你施展任何火焰、力场、光或者物理伤害的法术时, 你获得持续6秒的3点火焰，力场，光 或者 物理伤害的法术强度。这个效果可以叠加 3次。",
            "2": "当你施展任何火焰、力场、光或者物理伤害的法术时, 你获得持续6秒的3点火焰，力场，光 或者 物理伤害的法术强度。这个效果可以叠加 6次。",
            "3": "当你施展任何火焰、力场、光或者物理伤害的法术时, 你获得持续6秒的3点火焰，力场，光 或者 物理伤害的法术强度。这个效果可以叠加 10次。"
        }
    }, "1b": {
        "abil_name": "心魂",
        "required": 1,
        "prereq": "1a",
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "你在造成伤害时:你有 20% 几率获得 1 层灾祸的效果。",
            "2": "你在造成伤害时:你有 50% 几率获得 1 层灾祸的效果。",
            "3": "你在造成伤害时:你有 100% 几率获得 1 层灾祸的效果。"
        }
    }, "1c": {
        "abil_name": "惩戒",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "火焰，力场，光或者物理伤害法术将获得2%法术重击几率。"
        }
    }, "1d": {
        "abil_name": "天使抗力",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "你在对抗法术的时候获得 1 点豁免。",
            "2": "你在对抗法术的时候获得 2 点豁免。",
            "3": "你在对抗法术的时候获得 3 点豁免。"
        }
    }, "1e": {
        "abil_name": "审讯",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+1 专注, 威吓以及对恐惧效果的豁免。",
            "2": "+2 专注, 威吓以及对恐惧效果的豁免。",
            "3": "+3 专注, 威吓以及对恐惧效果的豁免。"
        }
    }, "2a": {
        "abil_name": "正义报偿",
        "required": 5,
        "prereq": "1a",
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "当你的任何 火焰，力场，光 或者 物理伤害 的法术重击时, 你获得 3 神圣临时法力值.",
            "2": "当你的任何 火焰，力场，光 或者 物理伤害 的法术重击时, 你获得 6 神圣临时法力值.",
            "3": "当你的任何 火焰，力场，光 或者 物理伤害 的法术重击时, 你获得 10 神圣临时法力值."
        }
    }, "2b": {
        "abil_name": "高效超魔",
        "required": 5,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 2,
        "abil": {
            "1": {
                "1": "强效:施展强效额外耗费的SP减少2",
                "2": "极效:施展极效额外耗费的SP减少3",
                "3": "瞬发:施展瞬发额外耗费的SP减少1",
                "4": "增远:施展增远额外耗费的SP减少1"
            },
            "2": {
                "1": "强效:施展强效额外耗费的SP减少4",
                "2": "极效:施展极效额外耗费的SP减少6",
                "3": "瞬发:施展瞬发额外耗费的SP减少2",
                "4": "增远:施展增远额外耗费的SP减少2"
            },
            "3": {
                "1": "强效:施展强效额外耗费的SP减少6",
                "2": "极效:施展极效额外耗费的SP减少9",
                "3": "瞬发:施展瞬发额外耗费的SP减少4",
                "4": "增远:施展增远额外耗费的SP减少4"
            }
        }
    }, "2c": {
        "abil_name": "惩戒",
        "required": 5,
        "prereq": "1c",
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "火焰，力场，光或者物理伤害法术将获得2%法术重击几率。"
        }
    }, "2d": {
        "abil_name": "信仰文献",
        "required": 5,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "神祗的偏爱武器将会视为法具。(信息: 法具提供3*武器附魔加值的通用法术强度)"
        }
    }, "2e": {
        "abil_name": "法术强度提升",
        "required": 5,
        "prereq": null,
        "passive": false,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "（冷却时间: 30s）激活以获得+10持续10秒行动提升加值的通用法术强度。",
            "2": "（冷却时间: 30s）激活以获得+20持续20秒行动提升加值的通用法术强度。",
            "3": "（冷却时间: 30s）激活以获得+30持续30秒行动提升加值的通用法术强度。"
        }
    }, "3a": {
        "abil_name": "卷轴和魔杖精通",
        "required": 10,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+25%你使用的魔杖、卷轴以及其他储法物品的效果，同时你攻击型魔杖将获得+1法术难度。",
            "2": "+50%你使用的魔杖、卷轴以及其他储法物品的效果，同时你攻击型魔杖将获得+2法术难度。",
            "3": "+75%你使用的魔杖、卷轴以及其他储法物品的效果，同时你攻击型魔杖将获得+3法术难度。"
        }
    }, "3b": {
        "abil_name": "高效超魔",
        "required": 10,
        "prereq": "2b",
        "passive": true,
        "ranks": 3,
        "AP": 2,
        "abil": {
            "1": {
                "1": "强效:施展强效额外耗费的SP减少2",
                "2": "极效:施展极效额外耗费的SP减少3",
                "3": "瞬发:施展瞬发额外耗费的SP减少1",
                "4": "增远:施展增远额外耗费的SP减少1"
            },
            "2": {
                "1": "强效:施展强效额外耗费的SP减少4",
                "2": "极效:施展极效额外耗费的SP减少6",
                "3": "瞬发:施展瞬发额外耗费的SP减少2",
                "4": "增远:施展增远额外耗费的SP减少2"
            },
            "3": {
                "1": "强效:施展强效额外耗费的SP减少6",
                "2": "极效:施展极效额外耗费的SP减少9",
                "3": "瞬发:施展瞬发额外耗费的SP减少4",
                "4": "增远:施展增远额外耗费的SP减少4"
            }
        }
    }, "3c": {
        "abil_name": "惩戒",
        "required": 10,
        "prereq": "2c",
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "火焰，力场，光或者物理伤害法术将获得2%法术重击几率。"
        }
    }, "3d": {
        "abil_name": "法术穿透",
        "required": 10,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "获得+1法术穿透"
        }
    }, "3e": {
        "abil_name": "魅力或者感知",
        "required": 10,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": {
                "1": "+1魅力",
                "2": "+1感知"
            }
        }
    }, "4a": {
        "abil_name": "报应冠冕",
        "required": 20,
        "prereq": null,
        "passive": false,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "（冷却时间:15s）你移除自己的谴责护盾并将其加冕在友军身上。 当友军在你的威胁灵光范围之内，谴责护盾将在他们身上显现。任何攻击你的友军的人将遭受你的神谴，受到1D8+1 点光伤害。这一能力只能用在其他玩家或者雇佣兵、或者你自己召唤的怪物身上。"
        }
    }, "4b": {
        "abil_name": "高效超魔:升阶",
        "required": 20,
        "prereq": "3b",
        "passive": true,
        "ranks": 2,
        "AP": 2,
        "abil": {
            "1": "使用法术升阶超魔专长将减少每提升一个等级1点法力值消耗。",
            "2": "使用法术升阶超魔专长将减少每提升一个等级2点法力值消耗。"
        }
    }, "4c": {
        "abil_name": "惩戒",
        "required": 20,
        "prereq": "3c",
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "你火焰，力场，光或者物理伤害法术将获得2%法术重击几率"
        }
    }, "4d": {
        "abil_name": "强烈信仰",
        "required": 20,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "火焰，力场，光或者物理伤害法术提高+1施法者等级",
            "2": "火焰，力场，光或者物理伤害法术提高+2施法者等级",
            "3": "火焰，力场，光或者物理伤害法术提高+3施法者等级"
        }
    }, "4e": {
        "abil_name": "魅力或者感知",
        "required": 20,
        "prereq": "3e",
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": {
                "1": "+1魅力",
                "2": "+1感知"
            }
        }
    }, "5b": {
        "abil_name": "法不可挡",
        "required": 30,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "在你威胁灵光之中的敌人将受到-1 法术抗力。",
            "2": "在你威胁灵光之中的敌人将受到-2 法术抗力。",
            "3": "在你威胁灵光之中的敌人将受到-3 法术抗力。"
        }
    }, "5c": {
        "abil_name": "塑能专攻",
        "required": 30,
        "prereq": "4c",
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "你广泛地训练自己的塑能法术, 获得+1塑能法术DC。"
        }
    }, "5d": {
        "abil_name": "狂热信仰",
        "required": 30,
        "prereq": "4d",
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "你火焰，力场，光或者物理伤害法术提高+1最大施法者等级",
            "2": "你火焰，力场，光或者物理伤害法术提高+2最大施法者等级",
            "3": "你火焰，力场，光或者物理伤害法术提高+3最大施法者等级"
        }
    } }