this.model.Arcanotechnician= {  "dID": "Arcanotechnician", "name": "奥秘工程师",  "index":"204","translate":"冬日咕咕酱",
    "x1": {
        "abil_name": "奥秘工程师",
        "required": 0,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "你在奥秘工程师每花费一点AP，你就可以获得1点通用法术强度。"
        }
    }, "x2": {
        "abil_name": "应急药水",
        "required": 5,
        "prereq": "x1",
        "selected": 0,
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "创造一瓶充满魔法能量的药水，你将它投向你的目标区域。药水将在小范围炸裂，提供给附近的队友20暂时生命值和10暂时法力值。这将持续一分钟，或者直到受影响的生物休息为止。（使用消耗：5点法力值。冷却时间：30s）"
        }
    }, "x3": {
        "abil_name": "秘术电池",
        "required": 10,
        "prereq": "x2",
        "selected": 0,
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "当你施展一个机关术或者法术时，你截取一些机关术和法术的能量，这将为你提供1点暂时法力值。这将持续一分钟，或者直到你休息为止。"
        }
    }, "x4": {
        "abil_name": "闪电束",
        "required": 20,
        "prereq": "x3",
        "selected": 0,
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "将闪电束添加到你法术书第三级机关术士法术列表中。"
        }
    }, "x5": {
        "abil_name": "强力治疗药剂",
        "required": 30,
        "prereq": "x4",
        "selected": 0,
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "创造一瓶充满魔法能量的药水，你将它投向你的目标区域。药水将在小范围炸裂，为周围的队友治疗6D8+8点生命值，同时也会伤害不死生物。这项机关术被“机关术士知识：药水知识”所影响。这项类法术能力不需要施法材料。"
        }
    }, "x6": {
        "abil_name": "奥秘增效",
        "required": 40,
        "prereq": "x5",
        "selected": 0,
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "那些最为复杂的魔法公式在你看起来就像是小孩的涂鸦一样。你获得+2智力和+5法术辨识。任何非卷轴的激活式魔法物品（比如魔杖，法杖，盔甲或者其他储法物品）的施法者等级都将提升到与你相同，同时那些有DC的法术DC也将会提高（变成10+你的智力加值+法术等级），这项提升在你的魔法物品知识之后提升，所以并不与你的魔法物品知识专长叠加。"
        }
    }, "1a": {
        "abil_name": "类法术:静电冲击",
        "required": 1,
        "prereq": null,
        "selected": 0,
        "passive": false,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "静电冲击（消耗4法力值，冷却时间124s)",
            "2": "静电冲击（消耗3法力值，冷却时间8s)",
            "3": "静电冲击（消耗2法力值，冷却时间4s)"
        }
    }, "1b": {
        "abil_name": "造物能量",
        "required": 1,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "你的研究将提升你最大法力值30.",
            "2": "你的研究将提升你最大法力值60.",
            "3": "你的研究将提升你最大法力值90."
        }
    }, "1c": {
        "abil_name": "冷漠大师",
        "required": 1,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "在你眼中你的钢铁防御者是消耗品——你总是可以在之后重新制作。你在钢铁防御者阵亡后不再丢失法力值。"
        }
    }, "1d": {
        "abil_name": "法术重击",
        "required": 1,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "你的电,火，力场法术将额外获得1%法术重击几率。"
        }
    }, "1e": {
        "abil_name": "魔杖和卷轴精通",
        "required": 1,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+25%魔杖，卷轴以及其他储法物品的效果",
            "2": "+50%魔杖，卷轴以及其他储法物品的效果",
            "3": "+75%魔杖，卷轴以及其他储法物品的效果"
        }
    }, "2b": {
        "abil_name": "高效超魔",
        "required": 5,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 3,
        "AP": 2,
        "abil": {
            "1": {
                "1": "强效:使用法术强效时法力值消耗将减少2点。",
                "2": "瞬发:使用法术瞬发时法力值消耗将减少1点。"
            },
            "2": {
                "1": "强效:使用法术强效时法力值消耗将减少4点。",
                "2": "瞬发:使用法术瞬发时法力值消耗将减少2点。"
            },
            "3":{
                "1": "强效:使用法术强效时法力值消耗将减少6点。",
                "2": "瞬发:使用法术瞬发时法力值消耗将减少4点。"
            }
        }
    }, "2c": {
        "abil_name": "充能防御者",
        "required": 5,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "你的钢铁防御者获得+5PRR和5%的双击。",
            "2": "你的钢铁防御者获得+10PRR和10%的双击。",
            "3": "你的钢铁防御者获得+15PRR和15%的双击。"
        }
    }, "2d": {
        "abil_name": "法术重击",
        "required": 5,
        "prereq": "1d",
        "selected": 0,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "你的电,火，力场法术将额外获得1%法术重击几率"
        }
    }, "2e": {
        "abil_name": "静电易伤",
        "required": 5,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 3,
        "AP": 2,
        "abil": {
            "1": "你施展的任何电法术有5%几率对怪物造成1层易伤。易伤：目标在6秒内受到2%额外伤害。这个效果可以叠加10次，每过期一次将减少一层。",
            "2": "你施展的任何电法术有5%几率对怪物造成1d2层易伤。易伤：目标在6秒内受到2%额外伤害。这个效果可以叠加10次，每过期一次将减少一层。",
            "3": "你施展的任何电法术有5%几率对怪物造成1d3层易伤。易伤：目标在6秒内受到2%额外伤害。这个效果可以叠加10次，每过期一次将减少一层。"
        }
    }, "3a": {
        "abil_name": "类法术:",
        "required": 10,
        "prereq": "1a",
        "selected": 0,
        "passive": false,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "施展类法术闪电法球（消耗8法力值，冷却时间15)",
            "2": "施展类法术闪电法球（消耗6法力值，冷却时间10)",
            "3": "施展类法术闪电法球（消耗4法力值，冷却时间5)"
        }
    }, "3b": {
        "abil_name": "高效超魔",
        "required": 10,
        "prereq": "2b",
        "selected": 0,
        "passive": true,
        "ranks": 3,
        "AP":2,
        "abil": {
            "1": {
                "1": "强效:使用法术强效时法力值消耗将减少2点。",
                "2": "瞬发:使用法术瞬发时法力值消耗将减少1点。"
            },
            "2": {
                "1": "强效:使用法术强效时法力值消耗将减少4点。",
                "2": "瞬发:使用法术瞬发时法力值消耗将减少2点。"
            },
            "3":{
                "1": "强效:使用法术强效时法力值消耗将减少6点。",
                "2": "瞬发:使用法术瞬发时法力值消耗将减少4点。"
            }
        }
    }, "3c": {
        "abil_name": "自动修复",
        "required": 10,
        "prereq": "2c",
        "selected": 0,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "你在你的钢铁防御者中安装了自动修复系统，它将每18s修复自己/你/周围的队友4d4+1点生命值（你必须能被修理法术治疗才可以被自动修复治疗）。",
            "2": "你在你的钢铁防御者中安装了自动修复系统，它将每12s修复自己/你/周围的队友4d4+1点生命值（你必须能被修理法术治疗才可以被自动修复治疗）。",
            "3": "你在你的钢铁防御者中安装了自动修复系统，它将每6s修复自己/你/周围的队友4d4+1点生命值（你必须能被修理法术治疗才可以被自动修复治疗）。"
        }
    }, "3d": {
        "abil_name": "法术重击",
        "required": 10,
        "prereq": "2d",
        "selected": 0,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "你的电,火，力场法术将额外获得1%法术重击几率。"
        }
    }, "3e": {
        "abil_name": "属性增强",
        "required": 10,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "+1智力"
        }
    }, "4a": {
        "abil_name": "爆裂法杖:爆裂法杖",
        "required": 20,
        "prereq": "3a",
        "selected": 0,
        "passive": false,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "爆裂法杖（消耗12法力值，冷却时间18)",
            "2": "爆裂法杖（消耗8法力值，冷却时间12)",
            "3": "爆裂法杖（消耗6法力值，冷却时间6)"
        }
    }, "4b": {
        "abil_name": "高效超魔:升阶",
        "required": 20,
        "prereq": "3b",
        "selected": 0,
        "passive": true,
        "ranks": 2,
        "AP": 2,
        "abil": {
            "1": "施展升阶额外耗费的SP减少1",
            "2": "施展升阶额外耗费的SP减少2"
        }
    }, "4c": {
        "abil_name": "秘术引擎",
        "required": 20,
        "prereq": "3c",
        "selected": 0,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "你在你的钢铁防御者的核心上刻画奥术符文，使你可以从它身上引导奥术能量。当在你的钢铁防御者身边时，它将提供给你3点通用法术强度。",
            "2": "你在你的钢铁防御者的核心上刻画奥术符文，使你可以从它身上引导奥术能量。当在你的钢铁防御者身边时，它将提供给你6点通用法术强度。",
            "3": "你在你的钢铁防御者的核心上刻画奥术符文，使你可以从它身上引导奥术能量。当在你的钢铁防御者身边时，它将提供给你10点通用法术强度。"
        }
    }, "4d": {
        "abil_name": "法术重击",
        "required": 20,
        "prereq": "3d",
        "selected": 0,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "你的电,火，力场法术将额外获得1%法术重击几率。"
        }
    }, "4e": {
        "abil_name": "属性增强",
        "required": 20,
        "prereq": "3e",
        "selected": 0,
        "passive": false,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "+1智力"
        }
    }, "5a": {
        "abil_name": "类法术:闪电尘",
        "required": 30,
        "prereq": "4a",
        "selected": 0,
        "passive": false,
        "ranks": 3,
        "AP":2,
        "abil": {
            "1": "闪电尘：类法术能力：（消耗12法力值，冷却时间18)",
            "2": "闪电尘：类法术能力：（消耗8法力值，冷却时间12)",
            "3": "闪电尘：类法术能力：（消耗6法力值，冷却时间6)"
        }
    }, "5c": {
        "abil_name": "大师级防御者",
        "required": 30,
        "prereq": "4c",
        "selected": 0,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "你的钢铁防御者获得+2力量，敏捷以及体质。同时，当你在你的钢铁防御者身边时，它还会提供给你1%闪避。",
            "2": "你的钢铁防御者获得+4力量，敏捷以及体质。同时，当你在你的钢铁防御者身边时，它还会提供给你2%闪避。",
            "3": "你的钢铁防御者获得+6力量，敏捷以及体质。同时，当你在你的钢铁防御者身边时，它还会提供给你3%闪避。"
        }
    }, "5d": {
        "abil_name": "塑能专注",
        "required": 30,
        "prereq": null,
        "selected": 0,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "你在广泛地训练了塑能魔法，提供给你+1塑能法术DC。"
        }
    } }