﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="WorkspaceView.ascx.cs"
    Inherits="View_WorkspaceView" %>
<div style="float: left; min-width: 200px; margin-right: 10px;" id="container" runat="server">
    <asp:HiddenField ID="hdObjects" runat="server" />
    <div id="divLoadingModules" style="display: none;">
        <strong>Modules:</strong>
        <br />
        <asp:Image runat="server" ImageUrl="~/Images/Loading.gif" AlternateText="Loading..." />
    </div>
    <adc:DataList ID="listModules" runat="server" DataKeyField="ID" CssClass="ItemTable">
        <HeaderTemplate>
            <strong>Modules</strong>
        </HeaderTemplate>
        <ItemTemplate>
            <a href="#" commandName="item">Select</a> <span id="text"></span>
        </ItemTemplate>
    </adc:DataList>
    <div id="divLoadingObjectClasses" style="display: none;">
        <strong>Object Classes:</strong>
        <br />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/Loading.gif" AlternateText="Loading..." />
    </div>
    <adc:DataList ID="listObjectClasses" runat="server" DataKeyField="ID" CssClass="ItemTable">
        <HeaderTemplate>
            <strong>Object Classes</strong>
        </HeaderTemplate>
        <ItemTemplate>
            <a href="#" commandName="item">Select</a> <span id="text"></span>
        </ItemTemplate>
    </adc:DataList>
    <div id="divLoadingInstances" style="display: none;">
        <strong>Instances:</strong>
        <br />
        <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/Loading.gif" AlternateText="Loading..." />
    </div>
    <adc:DataList ID="listInstances" runat="server" DataKeyField="ID" CssClass="ItemTable">
        <HeaderTemplate>
            <strong>Instances</strong>
        </HeaderTemplate>
        <ItemTemplate>
            <a href="#" commandName="item">Select</a> <span id="text"></span>
        </ItemTemplate>
    </adc:DataList>
    <div>
        <adc:DataList ID="listRecentObjects" runat="server" DataKeyField="ID" CssClass="ItemTable">
            <HeaderTemplate>
                <strong>Recent Objects</strong>
            </HeaderTemplate>
            <ItemTemplate>
                <a href="#" commandName="item">Select</a> <span id="text"></span>
            </ItemTemplate>
        </adc:DataList>
    </div>
</div>
<div style="float: left; width: 600px; border: solid 1px black;">
    <ajaxToolkit:TabContainer ID="tabObjects" runat="server">
    </ajaxToolkit:TabContainer>
</div>
