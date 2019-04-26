

jQuery(function ($) {
    var app = builder.app;
    var Tree = builder.module("tree");
    var Map = builder.module("map");
    var Enh=builder.module("enhancement");
    builder.Router = Backbone.Router.extend({
        routes: {
            "*splat": "loadMap"
        },
        initialize: function () {
            this.tree = new Tree.Router();
            this.map = new Map.Router();
            this.enhancement = new Enh.Router();
        },
        loadMap: function (splat) {
            var self = this;
            self.map.loadMap();
        }
    });
    builder.app = new builder.Router();
    Backbone.history.start({ pushState: false });
    $(document).on("click", "a:not([data-bypass])", function (evt) {
        var href = $(this).attr("href");
        var protocol = this.protocol + "//";
        if (href && href.slice(0, protocol.length) !== protocol) {
            evt.preventDefault();
            if ($(this).attr('data-silent') === true) {
                builder.app.navigate(href, { trigger: true, replace: true });
            } else {
                builder.app.navigate(href, true);
            }
        }
    });
});
