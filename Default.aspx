<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        1. 選取準備辨識的圖片
        <asp:FileUpload runat="server" ID="FileUpload_ScanImage" />
        <asp:Button runat="server" ID="Button_Submit" Text="送出" OnClick="Button_Submit_Click" />
    </div>
    </form>
</body>
</html>
