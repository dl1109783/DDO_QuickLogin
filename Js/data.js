this.Templates = this.Templates || {};
this.model = this.model || {};
//基本结构
this.Templates.embed = "<section class=module>  {{> header}}  {{> partial}}</section>";
//标题
this.Templates.header =
    '<header><a {{#options}}{{#tree}}class="active"{{/tree}}{{/options}} href="#d/fatesinger">天命树</a>' +
    '<a {{#options}}{{#map}}class="active"{{/map}}{{/options}} href="#">天命圈</a>' +
    '<a {{#options}}{{#enhancement}}class="active"{{/enhancement}}{{/options}} href="#e/Sorcerer">天赋</a></header>';

//描述文字
this.Templates.tooltip =
    "<div class=mytooltip><h2>{{taken}}等级:</h2>  " +
    "<h4> {{{abil_name}}} <small>({{required}}点前置)</small></h4>   " +
    "<p>{{#abil.1}}任选一种: <br />{{abil.1}}" +
    "{{#abil.2}}<br />{{abil.2}}{{/abil.2}}" +
    "{{#abil.3}}<br />{{abil.3}}{{/abil.3}} " +
    "{{#abil.4}}<br />{{abil.4}}{{/abil.4}}" +
    "{{#abil.5}}<br />{{abil.5}}{{/abil.5}}" +
    "{{#abil.6}}<br />{{abil.6}}{{/abil.6}}" +
    "{{#abil.7}}<br />{{abil.7}}{{/abil.7}}" +
    "{{/abil.1}}{{^abil.1}}{{{abil}}}{{/abil.1}}</p></div>";
//属性
this.Templates.ability =
    '<a data-ranks="{{ranks}}" ' +
    'data-required="{{required}}" ' +
    'data-postion="right" ' +
    'user-selected="0" ' +
    'data-points="{{AP}}" ' +
    '{{#prereq}}data-req="{{prereq}}"{{/prereq}}>' +
    '<div class="toggleTooltip"></div></a>' +
    '{{#passive}}<div class="passive"> <div class="inner-passive"></div></div>' +
    '{{/passive}}{{^passive}}<div class="active"></div>{{/passive}}';

this.builder = {
    module: function () {
        var modules = {};
        return function (name) {
            if (modules[name]) {
                return modules[name];
            }
            return modules[name] = { Views: {} };
        };
    }(),
    fetchAndRender: function (tpl, info) {
        window.Templates = window.Templates || {};
        if (Templates[tpl]) {
            var h = Hogan.compile(Templates[tpl]);
            var temp = {};
            if (info.partial) {
                if (typeof (info.partial) === 'object') {

                    temp.partial = Hogan.compile(Templates[info.partial.shift()]);
                    for (var i in info.partial) {
                        temp[info.partial[i]] = Hogan.compile(Templates[info.partial[i]]);
                    }
                } else {
                    temp = { partial: Hogan.compile(Templates[info.partial]) };
                }
                return h.render(info, temp);
            } else {
                return h.render(info);
            }
        }
    },
    render: function (main,data,temp) {
         return Hogan.compile(main).render(data,temp);
    },
    app: _.extend({}, Backbone.Events)
};


