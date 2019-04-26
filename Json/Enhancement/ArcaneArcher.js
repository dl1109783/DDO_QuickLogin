this.model.ArcaneArcher = {"dID": "ArcaneArcher", "name": "魔射", "index": "578","translate":"Arcatta",
    "x1": {
        "abil_name": "魔射手",
        "required": 0,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "每当你习得一个魔射手核心能力时，你所持的弓获得+1增强加值，最高+6；你的弓具有法器效果（Implement）：你获得其增强加值×3的法强，法器加值"
        }
    }, "x2": {
        "abil_name": "变形箭：箭头注魔",
        "required": 5,
        "prereq": "x1",
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "你的箭头造成敲击、挥砍和穿刺伤害；花费20SP，CD10秒"
        }
    }, "x3": {
        "abil_name": "合金箭：箭头注魔",
        "required": 10,
        "prereq": "x2",
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "你的箭头破所有材质类DR；花费20SP，CD10秒"
        }
    }, "x4": {
        "abil_name": "联盟箭：箭头注魔",
        "required": 20,
        "prereq": "x3",
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "你的箭头破所有阵营类DR；花费20SP，CD10秒"
        }
    }, "x5": {
        "abil_name": "幽影箭：箭头注魔",
        "required": 30,
        "prereq": "x4",
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "+5%双射；花费20SP，CD10秒"
        }
    }, "x6": {
        "abil_name": "注魔大师",
        "required": 40,
        "prereq": "x5",
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "+2敏捷，+10%双射，当你离开主箭头注魔姿态时，该箭头注魔的效果将继续持续30秒，才完全消除"
        }
    }, "1a": {
        "abil_name": "召唤箭支",
        "required": 1,
        "prereq": null,
        "passive": false,
        "ranks": 1,
        "AP":2,
        "abil": {
            "1": "召唤一组+1回旋箭"
        }
    }, "1b": {
        "abil_name": "精确打击：远程攻击",
        "required": 1,
        "prereq": null,
        "passive": false,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+20命中, 花费2SP，CD3秒",
            "2": "+20命中，你额外获得+2命中，持续6秒，洞察加值；花费2SP，CD3秒",
            "3": "+20命中，你额外获得+4命中，持续12秒，洞察加值；花费2SP，CD3秒"
        }
    }, "1c": {
        "abil_name": "荒野能量",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+30SP",
            "2": "+60SP",
            "3": "+100SP，获得Magical Training-魔法训练专长"
        }
    }, "1d": {
        "abil_name": "元素箭：箭头注魔",
        "required": 1,
        "prereq": null,
        "passive": false,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "你的箭头获得冰、火、酸、电属性，造成1d6相应属性的伤害，你每次只能选择一种未选过的元素；花费20SP，CD10秒"
        }
    }, "1e": {
        "abil_name": "警觉",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+1聆听、搜索、侦察和命中",
            "2": "+2聆听、搜索、侦察和命中",
            "3": "+3聆听、搜索、侦察和命中"
        }
    }, "2a": {
        "abil_name": "驱散箭：远程攻击",
        "required": 5,
        "prereq": null,
        "passive": false,
        "ranks": 3,
        "AP": 2,
        "abil": {
            "1": "+1[W]，并驱散目标的1个有益buff；花费5SP，CD3秒	",
            "2": "+2[W]，并驱散目标的2个有益buff；花费5SP，CD3秒	",
            "3": "+3[W]，并驱散目标的3个有益buff；花费5SP，CD3秒	"
        }
    }, "2b": {
        "abil_name": "力场箭：箭头注魔",
        "required": 5,
        "prereq": null,
        "passive": false,
        "ranks": 3,
        "AP": 2,
        "abil": {
            "1": "你的箭头获得幽冥效果，造成1d4力场伤害；花费20SP，CD10秒	",
            "2": "你的箭头获得幽冥效果，造成1d6力场伤害；花费20SP，CD10秒	",
            "3": "你的箭头获得幽冥效果，造成1d6+(1d10~3d10重击)力场伤害；花费20SP，CD10秒	"
        }
    }, "2c": {
        "abil_name": "地狱火：远程攻击",
        "required": 5,
        "prereq": null,
        "passive": false,
        "ranks": 3,
        "AP": 2,
        "abil": {
            "1": "+命中时，目标获得1层地狱火效果（每2秒钟目标受到1d6火伤害，持续6秒，此效果可叠加20次，期满消失1层）；花费6SP，CD3秒",
            "2": "+1[W]，命中时，目标获得1层地狱火效果（每2秒钟目标受到1d6火伤害，持续6秒，此效果可叠加20次，期满消失1层）；花费6SP，CD3秒",
            "3": "+2[W]，命中时，目标获得1层地狱火效果（每2秒钟目标受到1d6火伤害，持续6秒，此效果可叠加20次，期满消失1层）；花费6SP，CD3秒"
        }
    }, "2d": {
        "abil_name": "元素箭：箭头注魔",
        "required": 5,
        "prereq": "1d",
        "passive": false,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "你的箭头获得冰、火、酸、电属性，造成1d6相应属性的伤害，你每次只能选择一种未选过的元素；花费20SP，CD10秒"
        }
    }, "2e": {
        "abil_name": "行动提升：命中提升",
        "required": 5,
        "prereq": null,
        "passive": false,
        "ranks": 3,
        "AP": 2,
        "abil": {
            "1": "+4命中，持续20秒；能量抵抗：+5元素抗力，持续20秒",
            "2": "+6命中，持续20秒；能量抵抗：+10元素抗力，持续20秒",
            "3": "+8命中，持续20秒；能量抵抗：+15元素抗力，持续20秒"
        }
    }, "3a": {
        "abil_name": "破魔箭：远程攻击",
        "required": 10,
        "prereq": null,
        "passive": false,
        "ranks": 3,
        "AP": 2,
        "abil": {
            "1": "+1[W]，命中时，怪物获得1层法抗削弱效果（每层-1法抗，此效果可叠加100次），斩首时，破抗（-100法抗，持续10秒，通过意志豁免DC10+一半游侠等级+感知调整值则无效）；花费4SP，CD3秒",
            "2": "+2[W]，命中时，怪物获得2层法抗削弱效果（每层-1法抗，此效果可叠加100次），斩首时，破抗（-100法抗，持续10秒，通过意志豁免DC14+一半游侠等级+感知调整值则无效）；花费4SP，CD3秒",
            "3": "+3[W]，命中时，怪物获得3层法抗削弱效果（每层-1法抗，此效果可叠加100次），斩首时，破抗（-100法抗，持续10秒，通过意志豁免DC18+一半游侠等级+感知调整值则无效）；花费4SP，CD3秒"
        }
    }, "3b": {
        "abil_name": "恐惧箭：箭头注魔",
        "required": 10,
        "prereq": null,
        "passive": false,
        "ranks": 3,
        "AP": 2,
        "abil": {
            "1": "命中时，目标恐惧（通过意志豁免DC17则无效），斩首时，目标将受到魅影杀手效果；花费20SP，CD10秒",
            "2": "命中时，目标恐惧（通过意志豁免DC21则无效），斩首时，目标将受到魅影杀手效果；花费20SP，CD10秒",
            "3": "命中时，目标恐惧（通过意志豁免DC25则无效），斩首时，目标将受到魅影杀手效果；花费20SP，CD10秒"
        }
    }, "3c": {
        "abil_name": "魂术",
        "required": 10,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP":1,
        "abil": {
            "1": "+10通用法强，每当你用弓攻击到敌人时，你获得1点临时SP，此效果可叠加10次"
        }
    }, "3d": {
        "abil_name": "元素箭：箭头注魔",
        "required": 10,
        "prereq": "2d",
        "passive": false,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "你的箭头获得冰、火、酸、电属性，造成1d6相应属性的伤害，你每次只能选择一种未选过的元素；花费20SP，CD10秒"
        }
    }, "3e": {
        "abil_name": "敏捷或感知",
        "required": 10,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": {
                "1": "+1感知",
                "2": "+1敏捷"
            }
        }
    }, "4a": {
        "abil_name": "驱逐箭：箭头注魔",
        "required": 20,
        "prereq": null,
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "你的箭头获得驱逐效果，斩首时，1000HP以下的异界生物被驱逐到原位面，否则遭受100伤害；花费20SP，CD10秒"
        }
    }, "4b": {
        "abil_name": "麻痹箭：箭头注魔",
        "required": 20,
        "prereq": "3b",
        "passive": false,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "你的箭头获得麻痹效果，命中时，目标被麻痹（通过意志豁免DC18则无效）；花费20SP，CD10秒",
            "2": "你的箭头获得麻痹效果，命中时，目标被麻痹（通过意志豁免DC22则无效）；花费20SP，CD10秒",
            "3": "你的箭头获得麻痹效果，命中时，目标被麻痹（通过意志豁免DC26则无效）；花费20SP，CD10秒"
        }
    }, "4c": {
        "abil_name": "摧毁箭：箭头注魔",
        "required": 20,
        "prereq": null,
        "passive": false,
        "ranks":1,
        "AP": 1,
        "abil": {
            "1": "你的箭头获得摧毁效果，斩首时，1000HP以下的构装生物被直接摧毁，否则遭受100伤害；花费20SP，CD10秒"
        }
    }, "4d": {
        "abil_name": "元素箭：箭头注魔",
        "required": 20,
        "prereq": "3d",
        "passive": false,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "你的箭头获得冰、火、酸、电属性，造成1d6相应属性的伤害，你每次只能选择一种未选过的元素；花费20SP，CD10秒"
        }
    }, "4e": {
        "abil_name": "敏捷或感知",
        "required": 20,
        "prereq": "3e",
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": {
                "1": "+1感知",
                "2": "+1敏捷"
            }
        }
    }, "5a": {
        "abil_name": "月之弓",
        "required": 30,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "+10通用法强，当你手持弓箭时，每30秒你将获得20SP，持续10秒"
        }
    }, "5b": {
        "abil_name": "杀戮箭：远程攻击",
        "required": 30,
        "prereq": "4b",
        "passive": false,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "+250伤害，此伤害可被重击效果翻倍；花费20SP，CD20秒"
        }
    },   "5d": {
        "abil_name": "精通元素箭",
        "required": 30,
        "prereq": "4d",
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "你的元素箭注魔获得“爆”的效果（1d10~3d10重击）；" +
                "</br>另外，" +
                "</br>酸箭获得Improved Destruction-精通削弱效果：命中时，-2AC，-2%护命，此效果可叠加4次；" +
                "</br>火箭获得重击时1层Burning-灼烧效果：每2秒钟目标受到1d6火伤害，持续6秒，此效果可叠加20次，期满消失1层；" +
                "</br>冰箭获得重击时1层Lethargy-昏睡效果：-1豁免，非boss额外-5%移动和攻击速度，此效果可叠加5次；" +
                "</br>电箭获得重击时Vulnerable-脆弱效果：目标受到额外2%伤害，持续6秒，此效果可叠加10次，期满消失1层"
        }
    }, "5e": {
        "abil_name": "符文弓",
        "required": 30,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "你所持的弓箭获得额外+2增强加值，这被视为魔法武器效果"
        }
    }}