// If you override the initialize, all that is needed to
// incorporate this functionality is to call
// `model.__super__.initialize()` in your subs constructor
Backbone.Model.prototype.initialize = function() {
  this._setOriginalAttributes();
  return this;
};

// 
Backbone.Model.prototype._setOriginalAttributes = function() {
  this._originalAttributes = this.toJSON();
  return this;
};

Backbone.Model.prototype.reset = function() {
  this.set(this._originalAttributes);
  return this;
};

// Note that this only works on the first `fetch`, until
// Backbone supports a `reset` event for models.