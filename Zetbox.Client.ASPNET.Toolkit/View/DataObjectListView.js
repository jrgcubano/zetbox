﻿/// <reference name="MicrosoftAjax.js"/>
/// <reference name="../Dialogs/ChooseObjectDialog.js"/>

//----------------------------------------------------------------
// Javascript Functions for the ObjectListControl
//----------------------------------------------------------------

Type.registerNamespace("Zetbox.Client.ASPNET");

Zetbox.Client.ASPNET.ObjectListControl = function(element) {
    // Private Fields
    this._list = null;
    this._items = null;
    this._lnkAdd = null;
    this._lnkNew = null;
    this._type = null;
    
    // Handler
    this._onOnItemDataBoundHandler = null;
    this._onOnDeleteCommandHandler = null;
    this._onOnItemCommandHandler = null;
    this._onLnkAddClickHandler = null;
    this._onLnkNewClickHandler = null;
    this._onItemAddHandler = null;
   
    Zetbox.Client.ASPNET.ObjectListControl.initializeBase(this, [element]);
}

Zetbox.Client.ASPNET.ObjectListControl.prototype = {
    // Inititalize Control
    initialize: function() {
        Zetbox.Client.ASPNET.ObjectListControl.callBaseMethod(this, 'initialize');

        // List Events        
        this._onOnItemDataBoundHandler = Function.createDelegate(this, this._onItemDataBound);
        this._list.add_itemDataBound(this._onOnItemDataBoundHandler);

        this._onOnDeleteCommandHandler = Function.createDelegate(this, this._onItemDeleteCommand);
        this._list.add_deleteCommand(this._onOnDeleteCommandHandler);

        this._onOnItemCommandHandler = Function.createDelegate(this, this._onItemCommand);
        this._list.add_itemCommand(this._onOnItemCommandHandler);
        
        // Menu Events
        this._onLnkAddClickHandler = Function.createDelegate(this, this._onLnkAddClick);
        $addHandler(this._lnkAdd, "click", this._onLnkAddClickHandler);
        this._lnkAdd.href = '#';

        this._onLnkNewClickHandler = Function.createDelegate(this, this._onLnkNewClick);
        $addHandler(this._lnkNew, "click", this._onLnkNewClickHandler);
        this._lnkNew.href = '#';
        
        // Add Callback
        this._onItemAddHandler = Function.createDelegate(this, this._onItemAdd);
        
        this.DataBind();
    },
    // Dispose
    dispose: function() {        
        Zetbox.Client.ASPNET.ObjectListControl.callBaseMethod(this, 'dispose');
    },
    // public Properties
    get_List: function() {
        return this._list;
    },
    set_List: function(val) {
        this._list = val;
    },
    get_Items: function() {
        return this._items;
    },
    set_Items: function(val) {
        this._items = val;
    },
    get_LnkAdd: function() {
        return this._lnkAdd;
    },
    set_LnkAdd: function(val) {
        this._lnkAdd = val;
    },
    get_LnkNew: function() {
        return this._lnkNew;
    },
    set_LnkNew: function(val) {
        this._lnkNew = val;
    },
    get_Type: function() {
        return this._type;
    },
    set_Type: function(val) {
        this._type = val;
    },
    // public Methods
    DataBind: function() {
        var data = Sys.Serialization.JavaScriptSerializer.deserialize(this._items.value);
        this._list.set_dataSource(data);
        this._list.dataBind();
    },
    // Events
    _onItemDataBound: function (sender, e) {
        var item = e.get_item();

        if (item.get_isDataItemType())
        {
            var data = item.get_dataItem();
            var txtText = item.findControl('text');
            Zetbox.Client.ASPNET.JavascriptRenderer.setText(txtText, data.Text);
        }
    },
    _onItemDeleteCommand: function (sender, e) {
        var index = e.get_item().get_itemIndex();
        var data = this._list.get_dataSource();
        Array.removeAt(data, index);
        this._list.dataBind();
    },
    _onItemCommand: function (sender, e) {
        if(e.get_commandName() == "item") 
        {
            var data = e.get_item().get_dataItem();
            Zetbox.JavascriptRenderer.showObject(data);
        }
    },
    _onLnkAddClick: function() {
        Zetbox.Client.ASPNET.ChooseObjectDialog.ChooseObject(this._type, this._onItemAddHandler);
    },
    _onLnkNewClick: function() {
        var obj = Zetbox.JavascriptRenderer.newObject(this._type);
        Zetbox.JavascriptRenderer.showObject(obj);
    },
    _onItemAdd: function(item) {
        var data = this._list.get_dataSource();
        data.push(item);
        this._list.dataBind();
    },
    onSubmit: function() {
        var data = this._list.get_dataSource();
        this._items.value = Sys.Serialization.JavaScriptSerializer.serialize(data);
    }
}

Zetbox.Client.ASPNET.ObjectListControl.registerClass('Zetbox.Client.ASPNET.ObjectListControl', Sys.UI.Control);
if (typeof(Sys) !== 'undefined') Sys.Application.notifyScriptLoaded();