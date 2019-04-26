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

                var data = {
                    "options": {"enhancement": "enhancement"},
                    "OccList": window.OccList,
                    "model":window.model[path]
                };

                self.currentModel = window.model.AirSavant;
                console.log(JSON.stringify(data));
                var main = Hogan.compile(window.Templates.Main);
                var header = Hogan.compile(window.Templates.header);
                var des = Hogan.compile(window.Templates.Des);
                var ability = Hogan.compile(window.Templates.ability);


                var html = main.render(data, {
                    "ability": ability,
                    "des": des,
                    "header": header
                });

                $(this.el).html(html);

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
            //右键事件
            subtracted: function (e) {
                e.preventDefault();
                var my = $(e.currentTarget),
                    iSelect = parseInt(my.find("a").attr("user-selected")),
                    iPoint = parseInt(my.find("a").attr("data-points")),
                    span = my.find("span"),
                    iSpan = parseInt(span.text()),
                    did = e.currentTarget.parentElement.parentElement.parentElement.id,
                    spent = $("#"+did+" .points").find(".spent"),
                    avail = $(".points").find(".avail");

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
            //左键事件
            clicked: function (e) {
                var my = $(e.currentTarget),
                    a = my.find("a"),
                    span = my.find("span"),
                    iSelect = parseInt(a.attr("user-selected")),
                    iPoint = parseInt(a.attr("data-points")),
                    iRank = parseInt(a.attr("data-ranks")),
                    iRequired = parseInt(a.attr("data-required")),
                    req = a.attr("data-req"),
                    spanSelect = parseInt(span.text()),
                    did = e.currentTarget.parentElement.parentElement.parentElement.id,
                    iSet = $("#"+did+" .points").find(".spent"),
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
                        var reqTaken = parseInt($("#"+did+" .gridenha").find("." + e).find("a").attr("user-selected"));
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
                var did = e.currentTarget.parentElement.parentElement.parentElement.id;
                var mod = window.model[did];

                var my = $(e.currentTarget).find("a");
                var iSelect = parseInt(my.attr("user-selected"));

                var id = $(e.currentTarget).attr("class").replace("griditem", "").replace(" ", "");
                var skill = mod[id];
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


this.Templates.Main = '<section class=module style="width: 1650px"> ' +
    '{{> header}}' +
    '<article class="enha">' +
    '   <aside class="list">' +
    '       <hgroup><h2>天赋列表</h2></hgroup>' +
    '        <ul> ' +
    '           {{#OccList}}' +
    '           <a href="#e/{{OccId}}"> <li class="{{OccId}}"><div class="classes-{{OccId}}"></div>{{OccName}}</li> </a>' +
    '           {{/OccList}}' +
    '        </ul>    ' +
    '   </aside>' +
    '<div>{{#model}}{{>des}}{{/model}}</div>' +
    ' <div class=points ><p><span class=avail>80</span> 可用点数.</p> ' +
    '<button class=reset disabled=disabled style="float: left; margin: 10px 0">Reset Tree</button></div>'+
    '</article>' +
    '</section>';
this.Templates.Des = document.getElementById("tempDes").innerHTML;
this.OccList = [
    {"OccId": "Sorcerer", "OccName": "术士"},
    {"OccId": "Wizard", "OccName": "法师" },
    {"OccId": "Artificer", "OccName": "技师"},
    {"OccId": "Bard", "OccName": "诗人"},
    {"OccId": "Druid", "OccName": "德鲁伊"},
    {"OccId": "FavoredSoul", "OccName": "天佑"},
    {"OccId": "Cleric", "OccName": "牧师"},
    {"OccId": "Paladin", "OccName": "骑士"},
    {"OccId": "Ranger", "OccName": "游侠"},
    {"OccId": "Monk", "OccName": "和尚"},
    {"OccId": "Barbarian", "OccName": "野蛮人"},
    {"OccId": "Fighter", "OccName": "战士"},
    {"OccId": "Rogue", "OccName": "盗贼"}
];

this.model.Sorcerer=[ this.model.AirSavant, this.model.EarthSavant , this.model.FireSavant, this.model.WaterSavant, this.model.EldritchKnight],
this.model.Wizard= [this.model.Archmage, this.model.PaleMaster, this.model.EldritchKnight],
this.model.Artificer= [this.model.Arcanotechnician,this.model.BattleEngineer],
this.model.Bard=  [this.model.Spellsinger,this.model.Warchanter],
this.model.Druid=  [this.model.NatureWarrior,this.model.SeasonHerald],
this.model.FavoredSoul= [this.model.AngelOfVengance,this.model.Warpriest],
this.model.Cleric=  [this.model.DivineDisciple,this.model.RadiantServant,this.model.Warpriest],
this.model.Paladin= [this.model.Chalice,this.model.SacredDefender,this.model.Vanguard],
this.model.Ranger= [this.model.ArcaneArcher,this.model.DeepwoodStalker,this.model.Tempest],
this.model.Monk= [this.model.HenshinMystic,this.model.NinjaSpy,this.model.Shintao],
this.model.Barbarian= [this.model.FrenziedBerserker,this.model.OccultSlayer,this.model.Ravager],
this.model.Fighter= [this.model.Kensai, this.model.StalwartDefender],
this.model.Rogue= [this.model.Assassin,this.model.ThiefAcrobat,this.model.Mechanic] ;
/*
 Sorcerer
 Wizard
 Artificer
 Bard
 Druid
 FavoredSoul
 Cleric
 Paladin
 Ranger
 Monk
 Barbarian
 Fighter
 Rogue

 */
