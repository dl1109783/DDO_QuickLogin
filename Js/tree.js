(function (Tree) {
    Tree.Router = Backbone.Router.extend({
        collection: {},
        currentRequest: null,
        models: window.model,
        routes: {
            "d/:path": "loadTree"
        },
        //路径导航
        loadTree: function (path) {
            this.currentRequest = new Tree.Views.Test;
            this.currentRequest.render({collection: Destiny, model: window.model[path], path: path})
        }
    }),
        Tree.Collection = Backbone.Collection.extend({}),
        Tree.Model = Backbone.Model.extend({}),
        //显示
        Tree.Views.Test = Backbone.View.extend({
            el: "body",
            currentPath: "",
            currentModel: {},
            currentSpent: 0,
            currentLeft: 24,
            events: {
                "click .griditem": "clicked",
                "click .reset": "reset",
                "mouseover .griditem": "tooltip",
                "mouseout .griditem": "tooltipOut"
            },
            render: function (options) {
                var self = this,
                    collection = options.collection,
                    model = options.model;
                self.currentPath = options.path;
                self.currentModel = model;
                $(this.el).html(builder.fetchAndRender('embed', {
                    partial: ['tree', 'class', 'ability', 'tooltip', 'autogrant-ability', 'autogrant-tooltip', 'header'],
                    collection: collection,
                    model: model,
                    options: {tree: "tree"}
                }));

                $("aside").find("li").removeClass("active");
                $("aside").find("." + self.currentPath).addClass("active");

                $('.griditem').bind('contextmenu', function (e) {
                    e.preventDefault();
                    self.subtracted(e);
                    return false;
                });

                $('a[data-toggle="tooltip"]', this.el).tooltip({placement: 'right', delay: {show: 200}});
                return this;
            },
            initialize: function () {
                $(this.el).undelegate();
                this.delegateEvents();
            },
            reset: function (e) {
                return $(e).attr("disabled") === true ? false : (window.location.reload(), true)
            },
            //数字计算
            subtracted: function (e) {
                var my = $(e.currentTarget),
                    iSelect = parseInt(my.find("a").attr("user-selected")),
                    iPoint = parseInt(my.find("a").attr("data-points")),
                    span = my.find("span"),
                    iSpan = parseInt(span.text()),
                    spent = $(".points").find(".spent"),
                    avail = $(".points").find(".avail"),
                    img = my.find(".skillimg").attr("classname");
                if (my.parent(".gridrow").hasClass("autogrants") === true) return false;
                if (e.currentTarget.childNodes.length < 2) return false;
                if (iSelect === 1) my.find("." + img + "-taken").removeClass(img + "-taken").addClass(img);
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
                    imgCss = my.find(".skillimg").attr("classname"),
                    goodToGo = true;
                if (my.parent(".gridrow").hasClass("autogrants")) return false;
                if (e.currentTarget.childNodes.length < 2) return false;
                if (iRequired > parseInt(iSet.text())) return false;
                if (iPoint > parseInt(iAll.text())) return false;
                if (iRank == span.text()) return false;
                if ((req !== undefined && req !== "")) {
                    var reqs = [];
                    reqs = req.split(",");
                    _.each(reqs, function (e, t) {
                        var reqTaken = parseInt($(".grid").find("." + e).find("a").attr("user-selected"));
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
                    my.find("." + imgCss).removeClass(imgCss).addClass(imgCss + "-taken");
                    this.tooltip(e);
                }
                return true;
            },
            tooltipOut: function () {
                $(".tooltipWrapper").remove()
            },
            //鼠标移动到图标时的事件
            tooltip: function (e) {
                var my = $(e.currentTarget).find("a"),
                    iSelect = parseInt(my.attr("user-selected")),
                    id = $(e.currentTarget).attr("class").replace("griditem", "").replace(" ", ""),
                    skill = this.currentModel[id],
                    desc = skill.abil;
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

})(builder.module("tree"));

//天命里被动获得的描述
this.Templates["autogrant-tooltip"] =
    '<a data-toggle="tooltip" data-postion="right" title="<div> <h4> {{abil_name}}</h4> <p>{{{abil}}}</p> </div>">' +
    '<div class="toggleTooltip"></div></a>';
this.Templates["autogrant-ability"] = '{{> autogrant-tooltip}}{{#passive}}<div class="passive"> <div class="inner-passive"></div></div>{{/passive}}{{^passive}}<div class="active"></div>{{/passive}}';


//天命列表
this.Templates.tree = '<article class="tree"><aside class=nav><hgroup><h2>天命列表</h2></hgroup><ul>' +
    '{{#collection}}<a href="#d/{{dID}}"><li class="{{dID}}"><div class="classes-{{dID}}"></div>{{name}}</li></a>{{/collection}} ' +
    '</ul></aside>{{> class}}</article>';
//天命详细
this.Templates["class"] = '{{#model}}<div id={{dID}} class=skills>  <div class=header>    <div class=destinies-{{dID}}></div><h1>{{name}}</h1>  </div>  <div class="grid trees-{{dID}}">    <div class=gridrow>      <div class="6a griditem">        {{#6a}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-6a>0</span>/{{ranks}}        {{/6a}}      </div>      <div class="6b griditem">        {{#6b}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-6b>0</span>/{{ranks}}        {{/6b}}      </div>      <div class="6c griditem">        {{#6c}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-6c>0</span>/{{ranks}}        {{/6c}}      </div>      <div class="6d griditem">        {{#6d}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-6d>0</span>/{{ranks}}        {{/6d}}      </div>      <div class="6e griditem">        {{#6e}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-6e>0</span>/{{ranks}}        {{/6e}}      </div>    </div>    <div class=clear></div>    <div class=gridrow>      <div class="5a griditem">        {{#5a}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-5a>0</span>/{{ranks}}        {{/5a}}      </div>      <div class="5b griditem">        {{#5b}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-5b>0</span>/{{ranks}}        {{/5b}}      </div>      <div class="5c griditem">        {{#5c}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-5c>0</span>/{{ranks}}        {{/5c}}      </div>      <div class="5d griditem">        {{#5d}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-5d>0</span>/{{ranks}}        {{/5d}}      </div>      <div class="5e griditem">        {{#5e}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-5e>0</span>/{{ranks}}        {{/5e}}      </div>    </div>    <div class=clear></div>    <div class=gridrow>      <div class="4a griditem">        {{#4a}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-4a>0</span>/{{ranks}}        {{/4a}}      </div>      <div class="4b griditem">        {{#4b}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-4b>0</span>/{{ranks}}        {{/4b}}      </div>      <div class="4c griditem">        {{#4c}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-4c>0</span>/{{ranks}}        {{/4c}}      </div>      <div class="4d griditem">        {{#4d}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-4d>0</span>/{{ranks}}        {{/4d}}      </div>      <div class="4e griditem">        {{#4e}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-4e>0</span>/{{ranks}}        {{/4e}}      </div>    </div>    <div class=clear></div>    <div class=gridrow>      <div class="3a griditem">        {{#3a}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-3a>0</span>/{{ranks}}        {{/3a}}      </div>      <div class="3b griditem">        {{#3b}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-3b>0</span>/{{ranks}}        {{/3b}}      </div>      <div class="3c griditem">        {{#3c}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-3c>0</span>/{{ranks}}        {{/3c}}      </div>      <div class="3d griditem">        {{#3d}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-3d>0</span>/{{ranks}}        {{/3d}}      </div>      <div class="3e griditem">        {{#3e}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-3e>0</span>/{{ranks}}        {{/3e}}      </div>    </div>    <div class=clear></div>    <div class=gridrow>      <div class="2a griditem">        {{#2a}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-2a>0</span>/{{ranks}}        {{/2a}}      </div>      <div class="2b griditem">        {{#2b}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-2b>0</span>/{{ranks}}        {{/2b}}      </div>      <div class="2c griditem">        {{#2c}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-2c>0</span>/{{ranks}}        {{/2c}}      </div>      <div class="2d griditem">        {{#2d}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-2d>0</span>/{{ranks}}        {{/2d}}      </div>      <div class="2e griditem">        {{#2e}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-2e>0</span>/{{ranks}}        {{/2e}}      </div>    </div>    <div class=clear></div>    <div class=gridrow>      <div class="1a griditem">        {{#1a}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-1a>0</span>/{{ranks}}        {{/1a}}      </div>      <div class="1b griditem">        {{#1b}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-1b>0</span>/{{ranks}}        {{/1b}}      </div>      <div class="1c griditem">        {{#1c}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-1c>0</span>/{{ranks}}        {{/1c}}      </div>      <div class="1d griditem">        {{#1d}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-1d>0</span>/{{ranks}}        {{/1d}}      </div>      <div class="1e griditem">        {{#1e}}          {{> ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>          <span class=taken-1e>0</span>/{{ranks}}        {{/1e}}      </div>    </div>    <div class=clear></div>    <div class="gridrow autogrants">      {{#autogrants}}        <div class="griditem">          {{> autogrant-ability}}          <div class="{{dID}}-{{img}} skillimg {{#passive}}{{passive}}{{/passive}}" classname="{{dID}}-{{img}}"></div>        </div>      {{/autogrants}}    </div>    <div class=clear></div>    <button class=reset disabled=disabled>Reset Tree</button>  </div>  <div class=points>    <p><span class=avail>24</span> 可用点数.   <span class=spent>0</span> 已用点数</p>  </div>  <div class=clear></div></div>{{/model}}';

this.Destiny = [];
this.Destiny.push(window.model.grandmaster_of_flowers);
this.Destiny.push(window.model.shiradi_champion);
this.Destiny.push(window.model.magister);
this.Destiny.push(window.model.fatesinger);
this.Destiny.push(window.model.legendary_dreadnought);
this.Destiny.push(window.model.unyielding_sentinel);
this.Destiny.push(window.model.fury_of_the_wild);
this.Destiny.push(window.model.exalted_angel);
this.Destiny.push(window.model.draconic_incarnation);
this.Destiny.push(window.model.primal_avatar);
this.Destiny.push(window.model.shadowdancer);
this.Destiny.push(window.model.divine_crusader);