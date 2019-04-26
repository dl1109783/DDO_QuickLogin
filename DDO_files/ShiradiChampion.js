this.model.shiradi_champion={  "dID": "shiradi_champion", "name": "妖精射手", "autogrants": [
    {
        "abil_name": "妖精声望",
        "img": "feyfavor-taken",
        "abil": "你获得100SP，长，短弓使用专长。每个始拉蒂冠军等级+1druid和游侠施法等级。每当你的远程攻击Roll20你将获得妖精声望。你有7%在对敌人施法时获得妖精声望。妖精声望：+1幸运在远程攻击AB，+1交涉。可叠加10次。",
        "passive": "passve"
    },
    {
        "abil_name": "妖精视野",
        "img": "feyvisions-taken",
        "abil": "(等级 1) +1远程伤害，+5法能，+5搜索，自动查找暗门",
        "passive": "passve"
    },
    {
        "abil_name": "顺风",
        "img": "favorablewinds",
        "abil": "(等级 2)+1攻击。远程和投掷武器攻击与攻击性法术有7%几率造成额外5d10音波伤害。",
        "passive": "passve"
    },
    {
        "abil_name": "第六感",
        "img": "sixthsense",
        "abil": "(等级 3) +1远程伤害，+5法能，+5聆听，你无视20%闪避，获得幽冥攻击",
        "passive": "passve"
    },
    {
        "abil_name": "强化顺风",
        "img": "favorablewinds",
        "abil": "(等级 4) +1攻击。顺风的额外伤害变成10d10",
        "passive": "passve"
    },
    {
        "abil_name": "妖精力量",
        "img": "feypower-taken",
        "abil": "(等级 5) 远程和投掷武器攻击与攻击性法术有7%几率造成额外2d100力场伤害。",
        "passive": "passve"
    }
], "1a": {
    "abil_name": "寒霜之立",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "stayfrosty",
    "multi": false,
    "passive": false,
    "ranks": 2,
    "AP": 1,
    "abil": {
        "1": "(冷却: 5秒) Shiradi Ranged姿势：远程，投掷，与法术攻击有额外7%几率造成3d10寒冷伤害和使目标减速5秒效果，+3聆听和侦查",
        "2": ""
    }
}, "1b": {
    "abil_name": "乱射",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "wildstrikes",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "(冷却: 45秒) 对你的前方投掷一排匕首。每把刀造成10d20穿刺伤害",
        "2": "(冷却: 30秒) 对你的前方投掷一排匕首。每把刀造成15d20穿刺伤害",
        "3": "(冷却: 15秒) 对你的前方投掷一排匕首。每把刀造成20d20穿刺伤害"
    }
}, "1c": {
    "abil_name": "生命之泉",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "healingspring",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "(冷却: 30秒) 治疗附近队友,每60秒1D100，持续5分钟。每天可使用1次",
        "2": "(冷却: 30秒) 治疗附近队友,每45秒1D100，持续5分钟。每天可使用1次",
        "3": "(冷却: 30秒) 治疗附近队友,每30秒1D100，持续5分钟。每天可使用1次"
    }
}, "1d": {
    "abil_name": "幸福的幻觉",
    "required": 0,
    "prereq": "1c",
    "selected": 0,
    "img": "illusionofwellbeing",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "生命之泉额外给与10点虚假生命，使用次数+1",
        "2": "",
        "3": ""
    }
}, "1e": {
    "abil_name": "敏捷或感知",
    "required": 0,
    "prereq": null,
    "selected": 0,
    "img": "dexwis",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 敏捷",
            "2": "+1 感知"
        }
    }
}, "2a": {
    "abil_name": "棱镜照射",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "prism",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 5秒)Wild Hunter姿势:远程，投掷，与法术攻击有额外7%几率造成2d10随机属性伤害"
    }
}, "2b": {
    "abil_name": "膝盖中箭",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "pin",
    "multi": false,
    "passive": false,
    "ranks": 2,
    "AP": 1,
    "abil": {
        "1": "(冷却: 30秒) 如果目标没有移动，目标受到额外10d10穿刺伤害，被定在原地几秒,DC25/强韧",
        "2": "(冷却: 20秒)如果目标没有移动，目标受到额外10d20穿刺伤害，被定在原地几秒,DC25/强韧"
    }
}, "2c": {
    "abil_name": "妖精之泉",
    "required": 4,
    "prereq": "1c,2d",
    "selected": 0,
    "img": "feyspring",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "生命之泉对附近友人授予DR 2寒铁，和叠加 2 法能。每天+1生命之泉使用次数。",
        "2": "生命之泉对附近友人授予DR 4寒铁，和叠加 4 法能。每天+1生命之泉使用次数。",
        "3": "生命之泉对附近友人授予DR 6寒铁，和叠加 6 法能。每天+1生命之泉使用次数。"
    }
}, "2d": {
    "abil_name": "妖精形态",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "feyform",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "获得DR 3/寒铁，和+5法能。",
        "2": "获得DR 5/寒铁，和+10法能。",
        "3": "获得DR 6/寒铁，和+15法能。"
    }
}, "2e": {
    "abil_name": "敏捷或感知",
    "required": 4,
    "prereq": null,
    "selected": 0,
    "img": "dexwis",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 敏捷",
            "2": "+1 感知"
        }
    }
}, "3a": {
    "abil_name": "彩虹照射",
    "required": 8,
    "prereq": "2a",
    "selected": 0,
    "img": "rainbow",
    "multi": false,
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "在棱镜照射形态中你的远程，投掷，与法术攻击有额外7%几率造成1d100任意伤害。"
    }
}, "3b": {
    "abil_name": "Otto之哨",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "ottoswhistler",
    "multi": false,
    "passive": false,
    "ranks": 2,
    "AP": 1,
    "abil": {
        "1": "(冷却: 30秒)远程攻击:果目标移动，目标受到10d10音波伤害，如果不能通过意志豁免将被跳舞。",
        "2": "(冷却: 20秒)远程攻击:果目标移动，目标受到10d20音波伤害，如果不能通过意志豁免将被跳舞。"
    }
}, "3c": {
    "abil_name": "旋风手腕",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "throwndoublestrike",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "投掷武器攻速+20%",
        "2": "",
        "3": ""
    }
}, "3d": null, "3e": {
    "abil_name": "敏捷或感知",
    "required": 8,
    "prereq": null,
    "selected": 0,
    "img": "dexwis",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 敏捷",
            "2": "+1 感知"
        }
    }
}, "4a": {
    "abil_name": "双彩虹照射",
    "required": 12,
    "prereq": "3a",
    "selected": 0,
    "img": "doublerainbow",
    "multi": false,
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "在棱镜照射形态中你的远程，投掷，与法术攻击有额外7%几率造成特殊状态(附加永久DOT等)。"
    }
}, "4b": {
    "abil_name": "纯善之立",
    "required": 12,
    "prereq": null,
    "selected": 0,
    "img": "staygood",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "(冷却: 5秒)寒霜之立远程形态：远程，投掷，与法术攻击有额外7%几率造成[3d10/3d20]光系伤害,3层使你的武器附近纯善属性。",
        "2": "",
        "3": ""
    }
}, "4c": {
    "abil_name": "野草之中",
    "required": 12,
    "prereq": null,
    "selected": 0,
    "img": "intheweeds",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "+1% 闪避, +2 隐藏. 停止移动3 秒后你将获得额外 +1% 闪避, +3 隐藏",
        "2": "+2% 闪避, +4隐藏. 停止移动3 秒后你将获得额外 +1% 闪避, +3 隐藏,6秒后可叠加1次",
        "3": "+3% 闪避, +6 隐藏. 停止移动9 秒后你将获得额外 +1% 闪避, +3 隐藏,6秒后可叠加1次,9秒后可再次叠加1次"
    }
}, "4d": {
    "abil_name": "元素吸收",
    "required": 12,
    "prereq": "2d",
    "selected": 0,
    "img": "elementalabsorption",
    "multi": false,
    "passive": false,
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "(冷却: 2分钟)降低目标元素抗5%,直到休息后结束。每天可用2次。",
        "2": "",
        "3": ""
    }
}, "4e": {
    "abil_name": "敏捷或感知",
    "required": 12,
    "prereq": null,
    "selected": 0,
    "img": "dexwis",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 敏捷",
            "2": "+1 感知"
        }
    }
}, "5a": {
    "abil_name": "追踪",
    "required": 16,
    "prereq": null,
    "selected": 0,
    "img": "track",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "远程攻击减低目标AC 1点，持续20秒，可叠加3次",
        "2": "",
        "3": ""
    }
}, "5b": {
    "abil_name": "定射",
    "required": 16,
    "prereq": null,
    "selected": 0,
    "img": "standanddeliver",
    "multi": false,
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "如果站定攻击，你每几秒可获得+1伤害，+1%法能，叠加最高到+10"
    }
}, "5c": null, "5d": {
    "abil_name": "神经毒素",
    "required": 16,
    "prereq": null,
    "selected": 0,
    "img": "nervetoxin",
    "multi": false,
    "passive": "passive",
    "ranks": 3,
    "AP": 1,
    "abil": {
        "1": "远程，投掷，与法术攻击有额外3%几率造成6秒麻痹。意志豁免DC30+感知调整。",
        "2": "",
        "3": ""
    }
}, "5e": {
    "abil_name": "敏捷或感知",
    "required": 16,
    "prereq": null,
    "selected": 0,
    "img": "dexwis",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 敏捷",
            "2": "+1 感知"
        }
    }
}, "6a": null, "6b": {
    "abil_name": "妖精王后的邀请",
    "required": 20,
    "prereq": null,
    "selected": 0,
    "img": "audiencewiththequeen",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 2分钟 34秒)去和妖精王后喝杯茶，几秒钟后回来。不管王后对你的看法如何，茶都是不错的。（你喝茶后的效果取决去你的的交涉等级，听说负等级让你变成狗头人）"
    }
}, "6c": {
    "abil_name": "箭雨",
    "required": 20,
    "prereq": null,
    "selected": 0,
    "img": "rainofarrows",
    "multi": false,
    "passive": false,
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": "(冷却: 7秒) 30秒内范围内敌人有20%几率每秒获得1d100穿刺伤害。使用10点妖精声望。"
    }
}, "6d": null, "6e": {
    "abil_name": "敏捷或感知",
    "required": 20,
    "prereq": null,
    "selected": 0,
    "img": "dexwis",
    "multi": "multi",
    "passive": "passive",
    "ranks": 1,
    "AP": 2,
    "abil": {
        "1": {
            "1": "+1 敏捷",
            "2": "+1 感知"
        }
    }
}};
