<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Master.Master" CodeBehind="UserPreferences.aspx.cs" Inherits="JobTest.UserPreferences" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="Main" runat="server">

  <form id="form1" runat="server">

  <div id="recentorders" class="toprightheader inlinelink" style="margin-top:60px;width:760px;">
            <div style="border-radius: 8px; ">
                <h1 style="margin-left: 10px; margin-bottom:10px ; font-family: 'Trebuchet MS' !important;">User Preferences&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                  <asp:Label ID="lblResult" runat="server" Font-Bold="True" ForeColor="Blue" Visible="False"></asp:Label>
                </h1>
            </div>
            
            <div class="noresultfound">
              
             
              <strong>Email Address:&nbsp;
              <asp:TextBox ID="txtEmail" runat="server" Width="264px"></asp:TextBox>
              <asp:Button ID="btnSave2" runat="server" Font-Bold="True" OnClick="btnSave_Click" Text="Save" />
              &nbsp;</strong></div>

</div>
</form>
</asp:Content>

