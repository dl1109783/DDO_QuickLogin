(function (Enha) {
    Enha.Router = Backbone.Router.extend({
        collection: {},
        currentRequest: null,
        routes: {
            "e/:path": "loadEnhancement"
        },
        //路径导航
        loadEnhancement: function (path) {
            this.currentRequest = new Enha.Views;
            this.currentRequest.render(path);
        }
    }),
        Enha.Collection = Backbone.Collection.extend({}),
        Enha.Model = Backbone.Model.extend({}),
        //显示
        Enha.Views = Backbone.View.extend({
            el: "body",
            currentSpent: 0,
            currentLeft: 80,
            render: function (path) {
                var self = this;
                var model = window.model[path];
                self.currentModel = model;
                var temp = [];
                temp.push(window.Templates.List);
                temp.push(window.Templates.header);
                temp.push(window.Templates.Des);
                temp.push(window.Templates.ability);
                temp.push(window.Templates.tooltip);

                $(this.el).html(builder.test(temp, {
                    Occ: Occ, //职业列表用到的数据.
                    model: model,
                    options: {enhancement: "enhancement"}//标题里options节点那个字段高亮显示
                }));

                $("aside").find("li").removeClass("active");
                $("aside").find("." + path).addClass("active");
                $('a[data-toggle="tooltip"]', this.el).tooltip({placement: 'right', delay: {show: 200}});
                return this;
            },


            initialize: function () {
                $(this.el).undelegate(),
                    this.delegateEvents()
            },
            reset: function (e) {
                return $(e).attr("disabled") === true ? false : (window.location.reload(), true)
            },
            events: {
                "click .griditem": "clicked",//绑定点击方法
                "click .reset": "reset",//绑定复位按钮方法
                "contextmenu .griditem": "subtracted",//右键方法.减数字调用 subtracted方法
                "mouseover .griditem": "tooltip",
                "mouseout .griditem": "tooltipOut"
            },
            //数字计算
            subtracted: function (e) {
                e.preventDefault();
                var my = $(e.currentTarget),
                    iSelect = parseInt(my.find("a").attr("user-selected")),
                    iPoint = parseInt(my.find("a").attr("data-points")),
                    span = my.find("span"),
                    iSpan = parseInt(span.text()),
                    spent = $(".points").find(".spent"),
                    avail = $(".points").find(".avail");
                if (my.parent(".gridrow").hasClass("autogrants") === true) return false;
                if (e.currentTarget.childNodes.length < 2) return false;
                if (iSelect === 1) my.find(".icon-taken").removeClass("icon-taken").addClass("icon");
                else if (iSelect === 0) return false;
                span.text(iSpan - 1);
                my.find("a").attr("user-selected", iSpan - 1);
                spent.text(parseInt(spent.text()) - iPoint);
                avail.text(parseInt(avail.text()) + iPoint);
                if (parseInt(spent.text()) === 0) $(".reset").attr("disabled", "disabled");
                this.tooltip(e);
                return  true;
            },
            //点击事件
            clicked: function (e) {
                var my = $(e.currentTarget),
                    a = my.find("a"),
                    iSelect = parseInt(a.attr("user-selected")),
                    iPoint = parseInt(a.attr("data-points")),
                    iRank = parseInt(a.attr("data-ranks")),
                    iRequired = parseInt(a.attr("data-required")),
                    req = a.attr("data-req"),
                    span = my.find("span"),
                    spanSelect = parseInt(span.text()),
                    iSet = $(".points").find(".spent"),
                    iAll = $(".points").find(".avail"),
                    goodToGo = true;

                if (e.currentTarget.childNodes.length < 2) return false;
                if (iRequired > parseInt(iSet.text())) return false;
                if (iPoint > parseInt(iAll.text())) return false;
                if (iRank == span.text()) return false;
                if (req !== undefined && req !== "") {
                    var reqs = [];
                    reqs = req.split(",");
                    _.each(reqs, function (e, t) {
                        var reqTaken = parseInt($(".gridenha").find("." + e).find("a").attr("user-selected"));
                        if (iSelect + 1 > reqTaken) {
                            goodToGo = false;
                            return false;
                        }
                    })
                }
                if (goodToGo) {
                    span.text(spanSelect + 1);
                    a.attr("user-selected", spanSelect + 1);
                    iSet.text(parseInt(iSet.text()) + iPoint);
                    iAll.text(parseInt(iAll.text()) - iPoint);
                    $(".reset").removeAttr("disabled");
                    my.find(".icon").removeClass("icon").addClass("icon-taken");
                    this.tooltip(e);
                }
                return true;

            },
            tooltipOut: function () {
                $(".tooltipWrapper").remove()
            },
            //鼠标移动到图标时的事件
            tooltip: function (e) {
                var my = $(e.currentTarget).find("a");
                var iSelect = parseInt(my.attr("user-selected"));
                var did = $(e.currentTarget).attr("dID");
                var id = $(e.currentTarget).attr("class").replace("griditem", "").replace(" ", "");
                var skill = this.currentModel[id];
                var desc = skill.abil;
                $(".tooltipWrapper").remove();
                if (parseInt(my.attr("data-ranks")) !== null) {
                    $(e.currentTarget).append('<div class="tooltipWrapper"></div>');
                    if (desc[iSelect]) {
                        $(".tooltipWrapper").append(builder.fetchAndRender("tooltip", {
                            taken: "当前",
                            required: skill.required,
                            abil: desc[iSelect],
                            abil_name: skill.abil_name
                        }))
                    }
                    if (desc[iSelect + 1]) {
                        $(".tooltipWrapper").append(builder.fetchAndRender("tooltip", {
                            taken: "下个",
                            required: skill.required,
                            abil: desc[iSelect + 1],
                            abil_name: skill.abil_name
                        }))
                    }
                }
            }


        })

})(builder.module("enhancement"));
//框架  {{> partial}}
this.Templates.List = '<section class=module>  {{> header}}<article class="tree"><aside class=enha><hgroup><h2>天赋列表</h2></hgroup><ul>' +
    '{{#Occ}}<a href="#e/{{OccId}}"><li class="{{OccId}}"><div class="classes-{{OccId}} list_bg"></div>{{OccName}}</li></a>{{/Occ}} </ul></aside>' +
    //'{{#model}}  <div id={{dID}} class=skills>{{> Des}} <div class=points><p><span class=avail>80</span> 可用点数. <span class=spent>0</span> 已用点数</p></div><div class="des">{{des}}</div>    <div class=clear></div></div>{{/model}}' +
    '</article></section>';

//this.Templates.Des = document.getElementById("tempDes").innerHTML;
//
//this.Enhancement = [];
//this.Druid = [];
//this.Druid.Occ = "Druid";
//this.Druid.OccName = "德鲁伊";
//this.Druid.push(window.model.NatureWarrior);
//this.Druid.push(window.model.SeasonHerald);
//this.Enhancement.push(this.Druid);
//this.Enhancement.push(window.model.NatureWarrior);
//this.Enhancement.push(window.model.SeasonHerald);

this.Occ = {
    "a": {"OccId": "Druid", "OccName": "德鲁伊"},
    "b": {"OccId": "Sorcerer", "OccName": "术士"},
    "c": {"OccId": "Wizard", "OccName": "法师"},
    "d": {"OccId": "Fighter", "OccName": "战士"},
    "e": {"OccId": "FavoredSoul", "OccName": "天佑"}
};

/*Artificer
 Barbarian
 Bard
 Cleric
 Druid
 Favored Soul
 Fighter
 Monk
 Paladin
 Ranger
 Rogue
 Sorcerer
 Wizard*/

/*
 this.Enhancement = [];
 this.Enhancement.push(window.model.WaterSavant);
 this.Enhancement.push(window.model.FireSavant);
 this.Enhancement.push(window.model.AirSavant);
 this.Enhancement.push(window.model.EarthSavant);
 this.Enhancement.push(window.model.EldritchKnight);

 this.Enhancement.push(window.model.NatureWarrior);
 this.Enhancement.push(window.model.SeasonHerald);

 this.Enhancement.push(window.model.Arcanotechnician);


 this.Enhancement.push(window.model.AngelOfVengance);
 this.Enhancement.push(window.model.ArcaneArcher);

 this.Enhancement.push(window.model.Archmage);
 this.Enhancement.push(window.model.Assassin);
 this.Enhancement.push(window.model.BattleEngineer);
 this.Enhancement.push(window.model.Chalice);
 this.Enhancement.push(window.model.DeepwoodStalker);
 this.Enhancement.push(window.model.DivineDisciple);


 this.Enhancement.push(window.model.FrenziedBerserker);
 this.Enhancement.push(window.model.HenshinMystic);
 this.Enhancement.push(window.model.Kensai);
 this.Enhancement.push(window.model.Mechanic);

 this.Enhancement.push(window.model.NinjaSpy);
 this.Enhancement.push(window.model.OccultSlayer);
 this.Enhancement.push(window.model.PaleMaster);
 this.Enhancement.push(window.model.RadiantServant);
 this.Enhancement.push(window.model.Ravager);
 this.Enhancement.push(window.model.SacredDefender);

 this.Enhancement.push(window.model.Shintao);
 this.Enhancement.push(window.model.Spellsinger);
 this.Enhancement.push(window.model.StalwartDefender);
 this.Enhancement.push(window.model.Tempest);
 this.Enhancement.push(window.model.ThiefAcrobat);
 this.Enhancement.push(window.model.Warchanter);
 this.Enhancement.push(window.model.Warpriest);*/
