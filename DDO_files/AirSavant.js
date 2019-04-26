this.model.AirSavant = {  "dID": "AirSavant", "name": "气术士", "index":"374","translate":"夜风",
    "x1": {
        "abil_name": "气系大师",
        "required": 0,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "气系法术包含电,音,以及风,天赋中所加法强施法等级暴击为电音通用法强</br>+10气系法强,+1气系施法者等级,-10酸法强,-1酸施法者等级."
        }
    }, "x2": {
        "abil_name": "气系亲和",
        "required": 5,
        "prereq": "x1",
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "+10气系法强,+1气系施法者等级,-10酸法强,-1酸施法者等级."
        }
    }, "x3": {
        "abil_name": "强化气系亲和",
        "required": 10,
        "prereq": "x2",
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "+1气系最大施法者等级.</br>+10气系法强,+1气系施法者等级,-10酸法强,-1酸施法者等级."
        }
    }, "x4": {
        "abil_name": "电感",
        "required": 20,
        "prereq": "x3",
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "当你施展气系法术时,你的敌人随机获得0-2个电感状态(每个电感状态使目标受到的伤害加深1%,持续3秒,可叠加20层,停止施展气系法术后每3秒失去1层.)</br></br>+1气系最大施法者等级</br>+10气系法强,+1气系施法者等级,-10酸法强,-1酸施法者等级."
        }
    }, "x5": {
        "abil_name": "脚前灯",
        "required": 30,
        "prereq": "x4",
        "passive": true,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "免疫跌到</br>+1气系最大施法者等级</br>+10气系法强,+1气系施法者等级,-10酸法强,-1酸施法者等级."
        }
    }, "x6": {
        "abil_name": "元素化身:风",
        "required": 40,
        "prereq": "x5",
        "passive": false,
        "ranks": 1,
        "AP": 1,
        "abil": {
            "1": "<span style='color: green'>主动:</span>激活后转变为风元素,获得100%高护,机关人视为肉身,免疫修理,获得+20气系法强,2%暴击率,3%闪避,+1最大施法者等级,+1施法者等级,+10种族电抗,+20物理抵抗</br><span style='color: red'>DeBuff:</span>  冰火酸法术-3最大施法者等级,-3施法者等级,-10酸抗,元素形态时耗蓝增加10%</br><span style='color: darkmagenta'>被动:</span>即使不激活元素化身也将获得 +2魅力,+1气系最大施法者等级.+10气系法强,+1气系施法者等级,-10酸法强,-1酸施法者等级."
        }
    }, "1a": {
        "abil_name": "类法术:电爪术",
        "required": 1,
        "prereq": null,
        "passive": false,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "施展电爪,消耗4SP,冷却12S",
            "2": "施展电爪,消耗3SP,冷却8S",
            "3": "施展电爪,消耗2SP,冷却4S"
        }
    }, "1b": {
        "abil_name": "杂技",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+2翻滚,跳跃,平衡技能",
            "2": "+4翻滚,跳跃,平衡技能",
            "3": "+6翻滚,跳跃,平衡技能,+1%闪避"
        }
    }, "1c": {
        "abil_name": "暴风相伴",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "+3电抗",
            "2": "+6电抗",
            "3": "+10电抗"
        }
    }, "1d": {
        "abil_name": "法术重击:电",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "+2%电系重击"
        }
    }, "1e": {
        "abil_name": "触电",
        "required": 1,
        "prereq": null,
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "当施展电系法术时,+5临时电法强,持续6秒",
            "2": "当施展电系法术时,+5临时电法强,持续6秒,可叠加3次",
            "3": "当施展电系法术时,+5临时电法强,持续6秒,可叠加5次"
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
        "abil_name": "电阻穿透",
        "required": 5,
        "prereq": "1c",
        "passive": true,
        "ranks": 3,
        "AP": 2,
        "abil": {
            "1": "你的电系法术攻击具有电抵抗的目标时,可以穿透目标5点电抗",
            "2": "你的电系法术攻击具有电抵抗的目标时,可以穿透目标10点电抗",
            "3": "你的电系法术攻击具有电抵抗的目标时,可以穿透目标15点电抗"
        }
    }, "2d": {
        "abil_name": "法术重击:电",
        "required": 5,
        "prereq": "1d",
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "+2%电系重击"
        }
    }, "2e": {
        "abil_name": "交流电",
        "required": 5,
        "prereq": "1e",
        "passive": true,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "施展电系法术时,有10%几率获得3点临时SP",
            "2": "施展电系法术时,有20%几率获得3点临时SP",
            "3": "施展电系法术时,有30%几率获得3点临时SP"
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
        "abil_name": "法术重击:电",
        "required": 10,
        "prereq": "2d",
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "+2%电系重击"
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
                "2": "+1魅力"
            }
        }
    }, "4a": {
        "abil_name": "类法术:电环",
        "required": 20,
        "prereq": "1a",
        "passive": false,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "耗费8SP施展电环,冷却15秒",
            "2": "耗费6SP施展电环,冷却10秒",
            "3": "耗费4SP施展电环,冷却5秒"
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
        "abil_name": "羽落",
        "required": 20,
        "prereq": null,
        "passive": false,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "获得羽落效果"
        }
    }, "4d": {
        "abil_name": "法术重击:电",
        "required": 20,
        "prereq": "3d",
        "passive": true,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "+2%电系重击"
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
                "1": "+1敏捷",
                "2": "+1魅力"
            }
        }
    }, "5a": {
        "abil_name": "类法术:闪电束",
        "required": 30,
        "prereq": "4a",
        "passive": false,
        "ranks": 3,
        "AP": 1,
        "abil": {
            "1": "耗费12点SP施展闪电束,冷却18秒",
            "2": "耗费8点SP施展闪电束,冷却12秒",
            "3": "耗费6点SP施展闪电束,冷却6秒"
        }
    }, "5b": {
        "abil_name": "弱点洞察:电",
        "required": 30,
        "prereq": null,
        "passive": false,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "给敌人附加电弱点状态,被电系法术攻击时受到额外15%伤害.持续20秒,消耗5SP,冷却20秒"
        }
    }, "5c": {
        "abil_name": "风之舞",
        "required": 30,
        "prereq": "4c",
        "passive": false,
        "ranks": 1,
        "AP": 2,
        "abil": {
            "1": "你在空中飞舞,可以向前飞跃一段距离,类似和尚,副本中15秒恢复1次,城市中3秒恢复1次(消耗10SP,冷却3秒)"
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
                "1": "+15火系法术法强",
                "2": "+15冰系法术法强",
                "3": "+10力场法强"
            }
        }
    }}
