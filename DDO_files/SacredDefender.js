this.model.SacredDefender = {"dID": "SacredDefender", "name": "圣神防御者", "index": "1020", "translate": "",
    "x1": {
        "abil_name": "神圣堡垒",
        "required": 0,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "天赋树中每一点AP加1hp和1正能量法强，每层核心加2%护命"
        }
    }, "x2": {
        "abil_name": "神圣防御姿态",
        "required": 5,
        "prereq": "x1",
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "+10pr 10 mr 50% 仇恨，移动惩罚取消，神圣防御姿态与双持共同工作，需要盾牌或者中甲/重甲；"
        }
    }, "x3": {
        "abil_name": "",
        "required": 10,
        "prereq": "x2",
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "消耗一次驱散,持续时间内造成100%仇恨"
        }
    }, "x4": {
        "abil_name": "拯救",
        "required": 20,
        "prereq": "x3",
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "增加pal法术，lvl2起死，lvl3复活，lvl4大复活，被动：5prr、5mrr"
        }
    }, "x5": {
        "abil_name": "光辉屹立",
        "required": 30,
        "prereq": "x4",
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "短时间内DR20/epic，元素与负能量伤害减免，双倍治疗，免疫次要伤害效果比如流血、斩首；被动：+5prr 5mrr; "
        }
    }, "x6": {
        "abil_name": "永恒防御",
        "required": 40,
        "prereq": "x5",
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "被动：+2cha、+2con，10prr 10mrr，延长濒死范围；开启时：濒死时（hp<0）自动消耗两次lay on hand和两次驱散给自己加250血。"
        }
    }, "1a": {
        "abil_name": "物品防护",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "25%机会抵抗物品损坏",
            "2": "50%机会抵抗物品损坏",
            "3": "75%机会抵抗物品损坏"
        }
    }, "1b": {
        "abil_name": "额外圣疗",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1":"+1",
            "2":"+2",
            "3":"+3"
        }
    }, "1c": {
        "abil_name": "进阶神圣防御姿态",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "a、抗性防御：+1全save；</br>" +
                "b、持久防御：+5prr与mrr；</br>" +
                "c、挑衅防御：+25%近战仇恨；",
            "2": "a、抗性防御：+2全save；</br>" +
                "b、持久防御：+10prr与mrr；</br>" +
                "c、挑衅防御：+50近战仇恨；",
            "3": "a、抗性防御：+3全save；</br>" +
                "b、持久防御：+15prr与mrr；</br>" +
                "c、挑衅防御：+75%近战仇恨；"

        }
    }, "1d": {
        "abil_name": "顽强防御精通",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+1AC，+1 AC的敏捷调整加值上限",
            "2": "+2AC，+2 AC的敏捷调整加值上限",
            "3": "+3AC，+3 AC的敏捷调整加值上限"

        }
    }, "1e": {
        "abil_name": "防御激升",
        "required": 1,
        "prereq": null,
        "passive": false,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+5 AC、prr、mrr 20秒",
            "2": "+10AC、prr、mrr 20秒",
            "3": "+15AC、prr、mrr 20秒"
        }
    }, "2a": {
        "abil_name": "本能防御",
        "required": 5,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "减少5%无助时受到的伤害",
            "2": "减少10%无助时受到的伤害",
            "3": "减少15%无助时受到的伤害"
        }
    }, "2b": {
        "abil_name": "抗性光环",
        "required": 5,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "你的光环额外增加1AC",
            "2": "你的光环额外增加3AC",
            "3": "你的光环额外增加5AC"
        }
    }, "2c": {
        "abil_name": "进阶神圣防御姿态",
        "required": 5,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "a、抗性防御：+1全save；</br>" +
                "b、持久防御：+5prr与mrr；</br>" +
                "c、挑衅防御：+25%近战仇恨；",
            "2": "a、抗性防御：+2全save；</br>" +
                "b、持久防御：+10prr与mrr；</br>" +
                "c、挑衅防御：+50近战仇恨；",
            "3": "a、抗性防御：+3全save；</br>" +
                "b、持久防御：+15prr与mrr；</br>" +
                "c、挑衅防御：+75%近战仇恨；"
        }
    }, "2d": {
        "abil_name": "顽强盾牌精通",
        "required": 5,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+5%盾牌AC加值,+1塔盾AC的敏捷加值上限；",
            "2": "+10%盾牌AC加值,+2塔盾AC的敏捷加值上限；",
            "3": "+15%盾牌AC加值,+3塔盾AC的敏捷加值上限；"
        }
    }, "2e": {
        "abil_name": "防御提升",
        "required": 5,
        "prereq": null,
        "passive": false,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "20秒增加5AC",
            "2": "20秒增加10AC",
            "3": "20秒增加15AC"
        }
    }, "3b": {
        "abil_name": "豁免光环",
        "required": 10,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "你的光环现在额外增加1豁免",
            "2": "你的光环现在额外增加2豁免",
            "3": "你的光环现在额外增加3豁免"
        }
    }, "3c": {
        "abil_name": "进阶神圣防御姿态",
        "required": 10,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "a、抗性防御：+1全save；</br>" +
                "b、持久防御：+5prr与mrr；</br>" +
                "c、挑衅防御：+25%近战仇恨；",
            "2": "a、抗性防御：+2全save；</br>" +
                "b、持久防御：+10prr与mrr；</br>" +
                "c、挑衅防御：+50近战仇恨；",
            "3": "a、抗性防御：+3全save；</br>" +
                "b、持久防御：+15prr与mrr；</br>" +
                "c、挑衅防御：+75%近战仇恨；"
        }
    }, "3d": {
        "abil_name": "强化神圣防御",
        "required": 10,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "穿着[重甲|中甲|精金身躯天赋|持盾]时,A:+2力量;B:+2体质;C:+10%血上限",
            "2": "穿着[重甲|中甲|精金身躯天赋|持盾]时,A:+4力量;B:+4体质;C:+15%血上限",
            "3": "穿着[重甲|中甲|精金身躯天赋|持盾]时,A:+6力量;B:+6体质;C:+20%血上限"
        }
    }, "3e": {
        "abil_name": "属性强化",
        "required": 10,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": {
                "1": "+1体质",
                "2": "+1魅力"
            }
        }
    }, "4a": {
        "abil_name": "增强防御",
        "required": 20,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "A:盔甲AC加值增加15%;B:盾牌AC加值增加15%",
            "2": "A:盔甲AC加值增加30%;B:盾牌AC加值增加30%",
            "3": "A:盔甲AC加值增加50%;B:盾牌AC加值增加50%"
        }
    }, "4b": {
        "abil_name": "法抗光环",
        "required": 20,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "你的光环现在额外增加2法抗",
            "2": "你的光环现在额外增加4法抗",
            "3": "你的光环现在额外增加6法抗"
        }
    }, "4c": {
        "abil_name": "迅速防御",
        "required": 20,
        "prereq": null,
        "passive": true,
        "ranks":1,
        "AP": 1,
        "abil": {
            "1": "神圣防御姿态增加移动速度10%"
        }
    }, "4d": {
        "abil_name": "强化神圣防御",
        "required": 20,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "穿着[重甲|中甲|精金身躯天赋|持盾]时,A:+2力量;B:+2体质;C:+10%血上限",
            "2": "穿着[重甲|中甲|精金身躯天赋|持盾]时,A:+4力量;B:+4体质;C:+15%血上限",
            "3": "穿着[重甲|中甲|精金身躯天赋|持盾]时,A:+6力量;B:+6体质;C:+20%血上限"
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
                "1": "+1体质",
                "2": "+1力量"
            }
        }
    }, "5a": {
        "abil_name": "增强防御",
        "required": 30,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "A:盔甲AC加值增加15%;B:盾牌AC加值增加15%",
            "2": "A:盔甲AC加值增加30%;B:盾牌AC加值增加30%",
            "3": "A:盔甲AC加值增加50%;B:盾牌AC加值增加50%"
        }
    }, "5b": {
        "abil_name": "光辉庇护",
        "required": 30,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+10prr和mrr +1圣疗使用次数,格挡时反伤3d4,bug:prr和mrr收益叠加3层总共增加50",
            "2": "+15prr和mrr +2圣疗使用次数,格挡时反伤4d4",
            "3": "+25prr和mrr +3圣疗使用次数,格挡时反伤5d4"
        }
    }, "5c": {
        "abil_name": "复仇",
        "required": 30,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "被攻击时,你的下一次攻击增加1点伤害,可叠加3次",
            "2": "被攻击时,你的下一次攻击增加1点伤害,可叠加6次",
            "3": "被攻击时,你的下一次攻击增加1点伤害,可叠加10次"
        }
    }, "5d": {
        "abil_name": "强化神圣防御",
        "required": 30,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "穿着[重甲|中甲|精金身躯天赋|持盾]时,A:+2力量;B:+2体质;C:+10%血上限",
            "2": "穿着[重甲|中甲|精金身躯天赋|持盾]时,A:+4力量;B:+4体质;C:+15%血上限",
            "3": "穿着[重甲|中甲|精金身躯天赋|持盾]时,A:+6力量;B:+6体质;C:+20%血上限"
        }
    }}