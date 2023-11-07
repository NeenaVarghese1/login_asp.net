<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Web2.login2aspx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html>

    <html>
    <head>
        <title>LOGIN PAGE</title>
        <style>
            h1 {
                text-align: center;
                font-size: 24px;
                margin-bottom: 20px;
            }

            .form-container {
                max-width: 400px;
                margin: 0 auto;
                padding: 20px;
                border: 2px solid #000; /* Highlighted outer border */
                
                text-align: center; /* Center the contents horizontally */
                background-color: #cfe6d0; 
                 box-shadow: 5px 5px 5px #888;
            }

            table {
                width: 100%;
                border-collapse: collapse;
                border-spacing: 0; /* Set border-spacing to 0 to hide cell division */
                
            }

            th, td {
                padding: 10px;
                text-align: left;
                border-bottom: 1px solid #000; /* Highlight the horizontal border with black color */
                  
            }

            th {
                background-color:#cfe6d0 ;
                width: 3cm; /* Increase the width of the label (header) to 3 centimeters */
            }

            .form-button {
                width: 100%;
                padding: 10px;
                background-color:#00ff90;
                color: #000;
                border: none;
                border-radius: 4px;
                cursor: pointer;
                border: 2px solid #000;
            }
        </style>
    </head>
    <body>
        <form id="form1" >
            <h1>LOGIN PAGE</h1>
            <hr />
            <br />
            <br />
            <br />
            <div class="form-container">
                <table>
                    <tr>
                        <th>USERNAME</th>
                        <td><asp:TextBox ID="Textbox1" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <th>PASSWORD</th>
                        <td><asp:TextBox ID="Textbox2" runat="server" TextMode="Password"></asp:TextBox></td>
                    </tr>
                    
                </table>
                <asp:Button ID="SaveButton" CssClass="form-button" runat="server" Text="SAVE" OnClick="SaveButton_Click"  /><br />
                  <asp:Label ID="Label2" runat="server" Text="" ForeColor="#990000"></asp:Label>
            </div>
        </form>
       
       
       
        
    </body>
    </html>
</asp:Content>

