(function (Map) {
    Map.Router = Backbone.Router.extend({
        loadMap: function () {
            this.currentRequest = new Map.Views.Test();
            this.currentRequest.render();
        }
    });
    Map.Collection = Backbone.Collection.extend({});
    Map.Model = Backbone.Model.extend({});
    Map.Views.Test = Backbone.View.extend({
        initialize: function () {},
        render: function (options) {
            $("body").html(builder.fetchAndRender('embed', { partial: ["map",  "header"], options: { map: "map"} }));
            return this;
        }
    });
})(builder.module("map"));

//天命圈
this.Templates.map = '<article class=map>  <div class=divine>    <div class=us>      <a href="#d/unyielding_sentinel" title="Unyielding Sentinel"><div class="classes-unyielding_sentinel"></div></a>    </div>    <div class=ea>      <a href="#d/exalted_angel" title="Exalted Angel"><div class="classes-exalted_angel"></div></a>    </div>  </div>  <div class=martial>    <div class=gf>      <a href="#d/grandmaster_of_flowers" title="Grandmaster of Flowers"><div class="classes-grandmaster_of_flowers"></div></a>    </div>    <div class=sd>      <a href="#d/shadowdancer" title="Shadowdancer"><div class="classes-shadowdancer"></div></a>    </div>    <div class=ld>      <a href="#d/legendary_dreadnought" title="Legendary Dreadnought"><div class="classes-legendary_dreadnought"></div></a>    </div>  </div>  <div class=primal>    <div class=sc>      <a href="#d/shiradi_champion" title="Shiradi Champion"><div class="classes-shiradi_champion"></div></a>    </div>    <div class=pa>      <a href="#d/primal_avatar" title="Primal Avatar"><div class="classes-primal_avatar"></div></a>    </div>    <div class=fw>      <a href="#d/fury_of_the_wild" title="Fury of the Wild"><div class="classes-fury_of_the_wild"></div></a>    </div>  </div>  <div class=arcane>    <div class=fs>      <a href="#d/fatesinger" title="Fatesinger"><div class="classes-fatesinger"></div></a>    </div>    <div class=di>      <a href="#d/draconic_incarnation" title="Draconic Incarnation"><div class="classes-draconic_incarnation"></div></a>    </div>    <div class=mg>      <a href="#d/magister" title="Magister"><div class="classes-magister"></div></a>    </div>  </div></article>';
