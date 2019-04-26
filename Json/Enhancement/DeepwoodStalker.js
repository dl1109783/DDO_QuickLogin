this.model.DeepwoodStalker = {"dID": "DeepwoodStalker", "name": "密林", "index": "510", "translate": "Arcatta",
    "x1": {
        "abil_name": "远射",
        "required": 0,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "+1偷袭骰，每当你习得一个密林追踪者核心能力，近程射击和远程偷袭距离+5米"
        }
    }, "x2": {
        "abil_name": "偷袭",
        "required": 5,
        "prereq": "x1",
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "+1偷袭骰"
        }
    }, "x3": {
        "abil_name": "必中之箭",
        "required": 10,
        "prereq": "x2",
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": {
                "1": "Sniper Shot-狙击-远程攻击：+2[W]，+4命中，+2重击范围和倍数，造成伤害时，目标将被强制偷袭，CD6秒",
                "2": "Exposing Strike-突袭-近战攻击：+2[W]，+4命中，+1重击范围和倍数，造成伤害时，目标将被强制偷袭，CD6秒"
            }
        }
    }, "x4": {
        "abil_name": "偷袭",
        "required": 20,
        "prereq": "x3",
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "+1偷袭骰"
        }
    }, "x5": {
        "abil_name": "猎人标记",
        "required": 30,
        "prereq": "x4",
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "消耗1次理解动物次数来标记一个怪物，被标记的目标-10%护命，-10AC，-10法抗，-4属性，持续3分钟"
        }
    }, "x6": {
        "abil_name": "视界射击",
        "required": 40,
        "prereq": "x5",
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "+2敏捷，+1偷袭骰，你永远视为处于近程射击的距离内	"
        }
    }, "1a": {
        "abil_name": "宿敌防御",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": {
                "1": "对抗宿敌时+2AC",
                "2": "对抗宿敌时+1豁免"
            },
            "2": {
                "1": "对抗宿敌时+4AC",
                "2": "对抗宿敌时+2豁免"
            },
            "3": {
                "1": "对抗宿敌时+6AC",
                "2": "对抗宿敌时+3豁免"
            }
        }
    }, "1b": {
        "abil_name": "隐匿",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+1隐藏和潜行",
            "2": "+2隐藏和潜行",
            "3": "+3隐藏和潜行，+1偷袭骰"
        }
    }, "1c": {
        "abil_name": "额外共鸣",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+1交涉和理解动物次数，+15治疗法强",
            "2": "+2交涉和理解动物次数，+30治疗法强",
            "3": "+3交涉和理解动物次数，+45治疗法强"
        }
    }, "1d": {
        "abil_name": "精通共鸣",
        "required": 1,
        "prereq": "1c",
        "passive": true,
        "ranks": 2,
        "AP": 1,
        "abil": {
            "1": "你的理解动物专长可以作用于虫类,+15治疗法强",
            "2": "你的理解动物专长可以作用于虫类和元素,30治疗法强"
        }
    }, "1e": {
        "abil_name": "分筋：近战攻击",
        "required": 1,
        "prereq": null,
        "passive": false,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+0.5[W]，偷袭时，目标移动速度-50%",
            "2": "+1[W]，偷袭时，目标移动速度-50%",
            "3": "+1.5[W]，偷袭时，目标移动速度-50%"
        }
    }, "2a": {
        "abil_name": "宿敌防御",
        "required": 5,
        "prereq": "1a",
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": {
                "1": "对抗宿敌时+2AC",
                "2": "对抗宿敌时+1豁免"
            },
            "2": {
                "1": "对抗宿敌时+4AC",
                "2": "对抗宿敌时+2豁免"
            },
            "3": {
                "1": "对抗宿敌时+6AC",
                "2": "对抗宿敌时+3豁免"
            }
        }
    }, "2b": {
        "abil_name": "快速潜行",
        "required": 5,
        "prereq": "1b",
        "passive": true,
        "ranks": 3,
        "AP": 2,
        "abil": {
            "1": "+20%潜行移动速度",
            "2": "+35%潜行移动速度",
            "3": "+50%潜行移动速度"
        }
    }, "2c": {
        "abil_name": "移情治疗：类法术",
        "required": 5,
        "prereq": "1c",
        "passive": false,
        "ranks": 2,
        "AP": 2,
        "abil": {
            "1": "消耗1次理解动物次数，产生次级活力的效果",
            "2": "消耗1次理解动物次数，产生群体次级活力效果"
        }
    }, "2d": {
        "abil_name": "精通武器娴熟",
        "required": 5,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "你的武器娴熟专长，可以同时影响武器伤害（用敏捷调整值来计算伤害）"
        }
    }, "2e": {
        "abil_name": "行动提升",
        "required": 5,
        "prereq": null,
        "passive": false,
        "ranks": 3,
        "AP": 2,
        "abil": {
            "1": {
                "1": "伤害提升：+10%伤害，持续20秒",
                "2": "技能提升：+2技能，持续20秒"
            },
            "2": {
                "1": "伤害提升：+20%伤害，持续20秒",
                "2": "技能提升：+4技能，持续20秒"
            },
            "3": {
                "1": "伤害提升：+30%伤害，持续20秒",
                "2": "技能提升：+6技能，持续20秒"
            }
        }
    }, "3a": {
        "abil_name": "宿敌命中",
        "required": 10,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 2,
        "abil": {
            "1": "对抗宿敌时+1命中",
            "2": "对抗宿敌时+2命中",
            "3": "对抗宿敌时+3命中"
        }
    }, "3b": {
        "abil_name": "狩猎兴奋",
        "required": 10,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 2,
        "abil": {
            "1": "怪物血量在25%以下时，如果你伤害到它，你获得+1伤害，持续6秒",
            "2": "怪物血量在25%以下时，如果你伤害到它，你获得+2伤害，持续6秒",
            "3": "怪物血量在35%以下时，如果你伤害到它，你获得+3伤害，持续6秒"
        }
    }, "3d": {
        "abil_name": "瞄准射击：远程攻击",
        "required": 10,
        "prereq": null,
        "passive": false,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "+10命中，+1重击倍数，命中时，如果你处于Archer's Focus并且多重射击没有被激活，则你获得3层Archer's Focus"
        }
    }, "3e": {
        "abil_name": "属性提升",
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
        "abil_name": "宿敌伤害",
        "required": 20,
        "prereq": "3a",
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "对抗宿敌时+1伤害",
            "2": "对抗宿敌时+2伤害",
            "3": "对抗宿敌时+3伤害"
        }
    }, "4b": {
        "abil_name": "杀手",
        "required": 20,
        "prereq": "4a",
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "当你杀死一个怪物时，获得5%双击或双射，士气加值，此效果可以叠加2次，杀死弱小的怪物会降低触发的概率",
            "2": "当你杀死一个怪物时，获得5%双击或双射，士气加值，此效果可以叠加3次，杀死弱小的怪物会降低触发的概率",
            "3": "当你杀死一个怪物时，获得5%双击或双射，士气加值，此效果可以叠加4次，杀死弱小的怪物会降低触发的概率"
        }
    }, "4c": {
        "abil_name": "猎人怜悯",
        "required": 20,
        "prereq": "4b",
        "passive": false,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": {
                "1": "怜悯之箭-远程攻击：+3[W]，偷袭时，如果怪物血量在20%以下，造成500伤害，CD15秒",
                "2": "怜悯一击-近战攻击：+3[W]，偷袭时，如果怪物血量在20%以下，造成500伤害，CD15秒"
            }
        }
    }, "4d": {
        "abil_name": "射腿：远程攻击",
        "required": 20,
        "prereq": "3d",
        "passive": false,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "命中时，怪物移动速度-50%，持续10秒"
        }
    }, "4e": {
        "abil_name": "属性提升",
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
        "abil_name": "额外宿敌",
        "required": 30,
        "prereq": "4a",
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "额外选择一种怪物作为宿敌"
        }
    }, "5b": {
        "abil_name": "强弓：攻击姿态",
        "required": 30,
        "prereq": null,
        "passive": false,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "当此效果激活时，你的远程+5伤害-5命中，所有影响猛力攻击的效果同样影响此天赋，此效果不影响弩类"
        }
    }, "5d": {
        "abil_name": "爆头：远程攻击",
        "required": 30,
        "prereq": "4d",
        "passive": false,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "此攻击自动视为重击威胁，斩首时，+500伤害"
        }
    }, "5e": {
        "abil_name": "精通射手专注",
        "required": 30,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "你的Archer's Focus可以叠加25次"
        }
    }}