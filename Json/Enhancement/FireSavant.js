this.model.FireSavant = {  "dID": "FireSavant", "name": "火术士", "index":"340","translate":"夜风",
    "x1": {
        "abil_name": "烟火大师",
        "required": 0,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "+10火法强,+1火施法者等级,-10冰法强,-1冰施法者等级."
        }
    }, "x2": {
        "abil_name": "火系亲和",
        "required": 5,
        "prereq": "x1",
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "+10火法强,+1火施法者等级,-10冰法强,-1冰施法者等级."
        }
    }, "x3": {
        "abil_name": "强化火系亲和",
        "required": 10,
        "prereq": "x2",
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "+1火系最大施法者等级.</br>+10火法强,+1火施法者等级,-10冰法强,-1冰施法者等级."
        }
    }, "x4": {
        "abil_name": "献祭",
        "required": 20,
        "prereq": "x3",
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "灼烧:当你施展火系法术时,你的敌人获得灼烧状态(每2秒受到1d6火焰伤害,持续6秒,可叠加20层,停止施展火系法术后每6秒失去1层.)</br></br>+1火系最大施法者等级</br>+10火法强,+1火施法者等级,-10冰法强,-1冰施法者等级."
        }
    }, "x5": {
        "abil_name": "元素坚持",
        "required": 30,
        "prereq": "x4",
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "免疫麻痹</br>+1火系最大施法者等级</br>+10火法强,+1火施法者等级,-10冰法强,-1冰施法者等级."
        }
    }, "x6": {
        "abil_name": "元素化身:火",
        "required": 40,
        "prereq": "x5",
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "<span style='color: green'>主动:</span>激活后转变为火元素,获得100%高护,机关人视为肉身,免疫修理,获得+20火法强,2%暴击率,+1最大施法者等级,+1施法者等级,+10种族火抗,+20物理抵抗</br><span style='color: red'>DeBuff:</span>  电冰酸法术-3最大施法者等级,-3施法者等级,-10冰抗,元素形态时耗蓝增加10%</br><span style='color: darkmagenta'>被动:</span>即使不激活元素化身也将获得 +2魅力,+1火系最大施法者等级.+10火法强,+1火施法者等级,-10冰法强,-1冰施法者等级."
        }
    }, "1a": {
        "abil_name": "类法术:燃烧之手",
        "required": 1,
        "prereq": null,
        "passive": false,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "施展燃烧之手,消耗4SP,冷却12S",
            "2": "施展燃烧之手,消耗3SP,冷却8S",
            "3": "施展燃烧之手,消耗2SP,冷却4S"
        }
    }, "1b": {
        "abil_name": "热情",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+2还价和威吓技能",
            "2": "+4还价和威吓技能",
            "3": "+6还价和威吓技能,+1意志豁免"
        }
    }, "1c": {
        "abil_name": "地狱相伴",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+3火抗",
            "2": "+6火抗",
            "3": "+10火抗"
        }
    }, "1d": {
        "abil_name": "法术重击:火",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "+2%火系重击"
        }
    }, "1e": {
        "abil_name": "战火",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "当施展火系法术时,+5临时火法强,持续6秒",
            "2": "当施展火系法术时,+5临时火法强,持续6秒,可叠加3次",
            "3": "当施展火系法术时,+5临时火法强,持续6秒,可叠加5次"
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
        "abil_name": "火焰穿透",
        "required": 5,
        "prereq": "1c",
        "passive": true,
        "ranks": 3,
        "AP": 2,
        "abil": {
            "1": "你的火系法术攻击具有火焰抵抗的目标时,可以穿透目标5点火抗",
            "2": "你的火系法术攻击具有火焰抵抗的目标时,可以穿透目标10点火抗",
            "3": "你的火系法术攻击具有火焰抵抗的目标时,可以穿透目标15点火抗"
        }
    }, "2d": {
        "abil_name": "法术重击:火",
        "required": 5,
        "prereq": "1d",
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "+2%火系重击"
        }
    }, "2e": {
        "abil_name": "煽风点火",
        "required": 5,
        "prereq": "1e",
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "施展火系法术时,有10%几率获得3点临时SP",
            "2": "施展火系法术时,有20%几率获得3点临时SP",
            "3": "施展火系法术时,有30%几率获得3点临时SP"
        }
    }, "3b": {
        "abil_name": "高效超魔II:只可选择未选过的超魔",
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
        "abil_name": "法术穿透",
        "required": 10,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "法术穿透+1"
        }
    }, "3d": {
        "abil_name": "法术重击:火",
        "required": 10,
        "prereq": "2d",
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "+2%火系重击"
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
                "1": "+1力量",
                "2": "+1魅力"
            }
        }
    }, "4a": {
        "abil_name": "类法术:火焰喷射",
        "required": 20,
        "prereq": "1a",
        "passive": false,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "耗费8SP施展火焰喷射,冷却15秒",
            "2": "耗费6SP施展火焰喷射,冷却10秒",
            "3": "耗费4SP施展火焰喷射,冷却5秒"
        }
    }, "4b": {
        "abil_name": "高效超魔:升阶",
        "required": 20,
        "prereq": "3b",
        "passive": true,
        "ranks": 2,
        "AP": 2,
        "abil": {
            "1": "施展升阶额外耗费的SP减少1",
            "2": "施展升阶额外耗费的SP减少2"
        }
    }, "4c": {
        "abil_name": "火焰守护",
        "required": 20,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "任何对你近战攻击的敌人收到3d6的火焰伤害"
        }
    }, "4d": {
        "abil_name": "法术重击:火",
        "required": 20,
        "prereq": "3d",
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "+2%火系重击"
        }
    }, "4e": {
        "abil_name": "属性强化",
        "required": 20,
        "prereq": "3e",
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": {
                "1": "+1力量",
                "2": "+1魅力"
            }
        }
    }, "5a": {
        "abil_name": "类法术:火球",
        "required": 30,
        "prereq": "4a",
        "passive": false,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "耗费12点SP施展火球术,冷却18秒",
            "2": "耗费8点SP施展火球术,冷却12秒",
            "3": "耗费6点SP施展火球术,冷却6秒"
        }
    }, "5b": {
        "abil_name": "弱点洞察:火",
        "required": 30,
        "prereq": null,
        "passive": false,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "给敌人附加火元素弱点状态,被火系法术攻击时受到额外15%伤害.持续20秒,消耗5SP,冷却20秒"
        }
    }, "5c": {
        "abil_name": "微波炉",
        "required": 30,
        "prereq": "4c",
        "passive": false,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "使敌人内部液体沸腾从而造成伤害,过强韧豁免DC=10+体质调整+术士等级,豁免失败将受到2000点火焰伤害,火元素免疫此法术,消耗50SP,冷却60S"
        }
    }, "5d": {
        "abil_name": "塑能专攻",
        "required": 30,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "+1塑能DC"
        }
    }, "5e": {
        "abil_name": "元素强化",
        "required": 30,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": {
                "1": "+15酸系法术法强",
                "2": "+15电系法术法强",
                "3": "+10力场法强"
            }
        }
    }}
