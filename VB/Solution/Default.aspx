<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Solution._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script type="text/javascript">
        function ShowPopup(elementID, imageUrl, description) {
            if (popup.GetClientVisible())
                popup.Hide();

            clientImage.SetImageUrl(imageUrl);
            clientLabel.SetText("This is the " + description);

            popup.ShowAtElementByID(elementID);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxGridView ID="ASPxGridView1" runat="server" ClientInstanceName="grid" OnHtmlDataCellPrepared="ASPxGridView1_HtmlDataCellPrepared" AutoGenerateColumns="False">
            <Columns>
                <dx:GridViewDataColumn FieldName="ImageUrl" VisibleIndex="0">
                    <DataItemTemplate>
                        <dx:ASPxImage ID="ASPxImage1" ImageUrl='<%# Eval("ImageUrl") %>' Width="50px" Height="50px" runat="server">
                        </dx:ASPxImage>
                    </DataItemTemplate>
                </dx:GridViewDataColumn>
                <dx:GridViewDataTextColumn FieldName="Description" ReadOnly="True" VisibleIndex="1">
                </dx:GridViewDataTextColumn>
            </Columns>
        </dx:ASPxGridView>

        <dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server" ShowHeader="false" ClientInstanceName="popup" CloseAction="MouseOut">
            <ContentCollection>
                <dx:PopupControlContentControl runat="server" SupportsDisabledAttribute="True">
                    <table>
                        <tr>
                            <td>
                                <dx:ASPxImage runat="server" ID="Image" ClientInstanceName="clientImage" Height="200px"
                                    Width="200px">
                                </dx:ASPxImage>
                            </td>
                            <td>
                                <dx:ASPxLabel runat="server" Text="Desc" ClientInstanceName="clientLabel">
                                </dx:ASPxLabel>
                            </td>
                        </tr>
                    </table>
                </dx:PopupControlContentControl>
            </ContentCollection>
        </dx:ASPxPopupControl>
    </form>
</body>
</html>
