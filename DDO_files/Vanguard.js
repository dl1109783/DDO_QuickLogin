this.model.Vanguard  = {  "dID": "Vanguard", "name": "先锋", "index":"1122","translate":"",
    "x1": {
        "abil_name": "走在前",
        "required": 0,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "持盾时主武器与盾击都+1攻击与伤害；"
        }
    }, "x2": {
        "abil_name": "盾战I",
        "required": 5,
        "prereq": "x1",
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "10%机会二次盾击"
        }
    }, "x3": {
        "abil_name": "恶意之盾",
        "required": 10,
        "prereq": "x2",
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "10%机会二次盾击(共20%)，+5%攻速"
        }
    }, "x4": {
        "abil_name": "盾战II",
        "required": 20,
        "prereq": "x3",
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "10%机会二次盾击(共30%)，+5%攻速(共10%)，盾击+1W"
        }
    }, "x5": {
        "abil_name": "恶意之盾II",
        "required": 30,
        "prereq": "x4",
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "盾牌增加1重击范围1重击倍数1w,近战5%攻速(共15%)"
        }
    }, "x6": {
        "abil_name": "盾牌队长",
        "required": 40,
        "prereq": "x5",
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "持盾时+2攻+2伤害+5%双击败+5%攻速；盾击+1W，5%击晕（DC 10+1/2角色等级+力量调整+stun加值）"
        }
    }, "1a": {
        "abil_name": "盾牌特长",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "被动，持盾时+1攻、伤害、AC"
        }
    }, "1b": {
        "abil_name": "无弱点",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "被动，+1坚韧",
            "2": "被动，+2坚韧",
            "3": "被动，+3坚韧"
        }
    }, "1c": {
        "abil_name": "盾砸",
        "required": 1,
        "prereq": null,
        "passive": false,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "持盾时，盾击一下+1W；造成伤害时+2prr与mrr 12秒，CD16秒",
            "2": "持盾时，盾击一下+2W；造成伤害时+4prr与mrr 12秒，CD12秒",
            "3": "持盾时，盾击一下+3W；造成伤害时+6prr与mrr 12秒，CD8秒"
        }
    }, "1d": {
        "abil_name": "失衡撞",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "盾击-1反射2秒",
            "2": "盾击-1反射4秒",
            "3": "盾击-1反射6秒"
        }
    }, "1e": {
        "abil_name": "护甲训练",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "被动，+1平衡、恐吓、跳跃，-1甲盾惩罚",
            "2": "被动，+2平衡、恐吓、跳跃，-2甲盾惩罚",
            "3": "被动，+3平衡、恐吓、跳跃，-3甲盾惩罚"
        }
    },"2a": {
        "abil_name": "盾牌特长",
        "required": 5,
        "prereq": "1a",
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "被动，持盾时+1攻、伤害、AC"
        }
    }, "2b": {
        "abil_name": "残暴",
        "required": 5,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP":1,
        "abil": {
            "1":"+1击晕DC",
            "2": "+2击晕DC",
            "3": "+3击晕DC"

        }
    }, "2c": {
        "abil_name": "击晕盾",
        "required": 5,
        "prereq": null,
        "passive": false,
        "ranks": 3,
        "AP":1,
        "abil": {
            "1": "一次近战盾击+1W，击晕6秒，坚韧DC10+最高属性的调整值+角色等级+stun加值，CD60秒",
            "2": "一次近战盾击+2W，击晕6秒，坚韧DC10+最高属性的调整值+角色等级+stun加值，CD45秒",
            "3": "一次近战盾击+3W，击晕6秒，坚韧DC10+最高属性的调整值+角色等级+stun加值，CD30秒"
        }
    }, "2d": {
        "abil_name": "拨箭盾",
        "required": 5,
        "prereq": null,
        "passive": true,
        "ranks":3,
        "AP": 1,
        "abil": {
            "1": "被动，持盾时获得拨箭专长，每6秒触发一次",
            "2": "被动，持盾时获得拨箭专长，每4秒触发一次",
            "3": "被动，持盾时获得拨箭专长，每2秒触发一次"
        }
    }, "2e": {
        "abil_name": "行动提升",
        "required": 5,
        "prereq": null,
        "passive": false,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "melee power +10%",
            "2": "melee power +20%",
            "3": "melee power +30%"
        }
    },"3a": {
        "abil_name": "盾牌特长",
        "required": 10,
        "prereq": "2a",
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "被动，持盾时+1攻、伤害、AC"
        }
    }, "3b": {
        "abil_name": "跟上",
        "required": 10,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "击晕敌人后12秒内melee power+3",
            "2": "击晕敌人后12秒内melee power+6",
            "3": "击晕敌人后12秒内melee power+9"
        }
    }, "3c": {
        "abil_name": "致命防护",
        "required": 10,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "盾击+1重击范围"
        }
    }, "3d": {
        "abil_name": "盾牌反击",
        "required": 10,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "持盾miss时反击1d4钝击伤害，以melee power调整",
            "2": "持盾miss时反击1d6钝击伤害，以melee power调整",
            "3": "持盾miss时反击1d8钝击伤害，以melee power调整"
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
                "1": "+1敏捷",
                "2": "+1力量"
            }
        }
    }, "4a": {
        "abil_name": "盾牌特长",
        "required": 20,
        "prereq": "3a",
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "被动，持盾时+1攻、伤害、AC"
        }
    }, "4b": {
        "abil_name": "先锋护甲精通",
        "required": 20,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+1AC，+1 AC的敏捷调整加值上限",
            "2": "+2AC，+2 AC的敏捷调整加值上限",
            "3": "+3AC，+3 AC的敏捷调整加值上限"
        }
    }, "4c": {
        "abil_name": "盾牌冲锋",
        "required": 20,
        "prereq": null,
        "passive": false,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "持盾时朝选定的敌人冲30尺后+1W盾击范围内所有敌人，CD逐级下降",
            "2": "持盾时朝选定的敌人冲30尺后+2W盾击范围内所有敌人，CD逐级下降",
            "3": "持盾时朝选定的敌人冲30尺后+3W盾击范围内所有敌人，CD逐级下降"
        }
    }, "4d": {
        "abil_name": "弥尔米顿之锋",
        "required": 20,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP":1,
        "abil": {
            "1": "+1居合",
            "2": "+2居合",
            "3": "+3居合"
        }
    }, "4e": {
        "abil_name": "属性强化",
        "required": 20,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": {
                "1": "+1敏捷",
                "2": "+1力量"
            }
        }
    }, "5a": {
        "abil_name": "盾牌打脸",
        "required": 30,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "10%机会二次盾击"
        }
    }, "5b": {
        "abil_name": "乱砸",
        "required": 30,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP":1,
        "abil": {
            "1": "盾击时造成1层易伤，每3秒触发一次,可叠加20次,每3秒消失1层",
            "2": "盾击时造成1层易伤，每2秒触发一次,可叠加20次,每3秒消失1层",
            "3": "盾击时造成1层易伤，每1秒触发一次,可叠加20次,每3秒消失1层"
        }
    }, "5c": {
        "abil_name": "盾牌冲击",
        "required": 30,
        "prereq": null,
        "passive": false,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "直线前冲，+2W盾击线上所有敌人，摔拌DC20+最高属性调整值+角色等级+摔拌加值，不过击倒，CD逐级下降；",
            "2": "直线前冲，+4W盾击线上所有敌人，摔拌DC20+最高属性调整值+角色等级+摔拌加值，不过击倒，CD逐级下降；",
            "3": "直线前冲，+6W盾击线上所有敌人，摔拌DC20+最高属性调整值+角色等级+摔拌加值，不过击倒，CD逐级下降；"
        }
    }, "5d": {
        "abil_name": "装甲能量",
        "required": 30,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "+10melee power"
        }
    }}
