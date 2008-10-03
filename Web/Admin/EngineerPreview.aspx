<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EngineerPreview.aspx.cs" Inherits="Web.Admin.EngineerPreview" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:DetailsView ID="dvEngineer" runat="server" AutoGenerateRows="False" 
        Height="50px" Width="900px" CellPadding="4" ForeColor="#333333">
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <CommandRowStyle BackColor="#E2DED6" Font-Bold="True" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" Width="10%" />
        <FieldHeaderStyle BackColor="#E9ECF1" Font-Bold="True" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Right" />
        <Fields>
            <asp:BoundField HeaderText="美发师姓名" DataField="HairEngineerName">
                <HeaderStyle Height="15%" />
                <ItemStyle Width="85%" />
            </asp:BoundField>
            <asp:BoundField HeaderText="年龄" DataField="HairEngineerAge"/>
            <asp:BoundField HeaderText="性别" DataField="HairEngineerSex"/>
            <asp:BoundField HeaderText="所属美发厅" DataField="HairEngineerConstellation" />
            <asp:TemplateField HeaderText="照片">
                <EditItemTemplate>
                    <asp:Image ID="EngineerPhoto" runat="server" />
                </EditItemTemplate>
                <InsertItemTemplate>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField HeaderText="所属美发厅" DataField="HairShopName" />
            <asp:BoundField HeaderText="工作年限" DataField="HairEngineerYear"/>
            <asp:BoundField HeaderText="技能" DataField="HairEngineerSkill"/>
            <asp:BoundField HeaderText="关键字" DataField="HairEngineerTagIDs"/>
            <asp:BoundField HeaderText="点击量" DataField="HairEngineerHits"/>
            <asp:BoundField HeaderText="描述" DataField="HairEngineerDescription"/>
            <asp:BoundField HeaderText="服务数量" DataField="HairEngineerOrderNum"/>
            <asp:BoundField HeaderText="推荐数" DataField="HairEngineerRecommandNum"/>
            <asp:BoundField HeaderText="剪发价格" DataField="HairEngineerPrice"/>
            <asp:BoundField HeaderText="预约电话" DataField="HairEngineerRawPrice"/>
            <asp:BoundField HeaderText="好评率" DataField="HairEngineerGood"/>
            <asp:BoundField HeaderText="差评率" DataField="HairEngineerBad"/>
            <asp:BoundField HeaderText="头衔" DataField="HairEngineerClassName"/>
        </Fields>
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" 
            Width="5%" />
        <EditRowStyle BackColor="#999999" />
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    </asp:DetailsView>
    </form>
</body>
</html>
