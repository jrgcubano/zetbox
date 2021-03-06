﻿/// <reference name="MicrosoftAjax.js"/>
/// <reference name="../Dialogs/ChooseObjectDialog.js"/>

//----------------------------------------------------------------
// Javascript Functions for the WorkspaceView
//----------------------------------------------------------------

Type.registerNamespace("Zetbox.Client.ASPNET.View");

Zetbox.Client.ASPNET.View.WorkspaceView = function(element) {
    // Private Fields
    this._listObjects = null;
    this._currentIndex = null;

    Zetbox.Client.ASPNET.View.WorkspaceView.initializeBase(this, [element]);
}

Zetbox.Client.ASPNET.View.WorkspaceView.prototype = {
    // Inititalize Control
    initialize: function() {
        Zetbox.Client.ASPNET.View.WorkspaceView.callBaseMethod(this, 'initialize');

        this.SetObjectVisible(this.get_CurrentIndex());
    },
    // Dispose
    dispose: function() {
        Zetbox.Client.ASPNET.View.WorkspaceView.callBaseMethod(this, 'dispose');
    },
    // public Properties
    get_ListObjects: function() {
        return this._listObjects;
    },
    set_ListObjects: function(val) {
        this._listObjects = val;
    },
    get_CurrentIndexCtrl: function() {
        return this._currentIndex;
    },
    set_CurrentIndexCtrl: function(val) {
        this._currentIndex = val;
    },
    get_CurrentIndex: function() {
        return this._currentIndex.value;
    },
    set_CurrentIndex: function(val) {
        this._currentIndex.value = val;
    },
    // Methods
    SetObjectVisible: function(idx) {
        for (var i = 0; i < this._listObjects.length; i++) {
            var e = $get(this._listObjects[i]);

            if (i == idx) {
                e.style.display = 'block';
            } else {
                e.style.display = 'none';
            }
        }
    }
}

Zetbox.Client.ASPNET.View.WorkspaceView.registerClass('Zetbox.Client.ASPNET.View.WorkspaceView', Sys.UI.Control);
if (typeof (Sys) !== 'undefined') Sys.Application.notifyScriptLoaded();