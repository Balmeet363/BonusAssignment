<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="question1.aspx.cs" Inherits="Bonus_Assignment.question1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <section>
                <!-- Program heading -->
                <h2>Program to check Quadrant</h2>
                <!--Allowing user to enter X-axis and Y-axis value in text boxes and validating user input -->
                <p>Enter an X axis value:</p>
                <asp:TextBox runat="server" ID="Xaxis_value"></asp:TextBox>
                <asp:RequiredFieldValidator 
                     runat="server" 
                     EnableClientScript="true" 
                     ErrorMessage="Please enter X-axis Value" 
                     ControlToValidate="Xaxis_Value">
                </asp:RequiredFieldValidator>
                <p>Enter an Y axis value:</p>
                <asp:TextBox runat="server" ID="Yaxis_value"></asp:TextBox>
                <asp:RequiredFieldValidator 
                     runat="server" 
                     EnableClientScript="true" 
                     ErrorMessage="Please enter Y-axis Value" 
                     ControlToValidate="Yaxis_Value">
                </asp:RequiredFieldValidator>
            </section>
            <!--Creating blank div to generate message which quadrant coordinate would fall after clicking on button-->
            <div id="coordinate_summary" runat="server"></div>
            <asp:Button runat="server" text="submit" />
        </div>
    </form>
</body>
</html>
