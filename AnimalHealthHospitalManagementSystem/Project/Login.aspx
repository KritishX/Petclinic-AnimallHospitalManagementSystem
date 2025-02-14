<%@ Page Title="Login" Language="C#" MasterPageFile="~/Project/UserPanel.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="AnimalHealthHospitalManagementSystem.Project.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <center>
         <h1 style="font-size: xx-large; font-weight: bold; color: #0000FF">Sign Up</h1>
       <table style="width: 400px; height: 200px; background-color: #0000FF; font-size: large; font-weight: bold; color: #FFFFFF;" >
           <tr>
               <td style="width: 172px" align="center">Username</td>
               <td style="width: 188px">
                   <asp:Label ID="lbl_rid" runat="server" Text="Label"></asp:Label>
                  <%-- <asp:TextBox ID="txt_signup_username" runat="server" Width="225px"></asp:TextBox>--%></td>
           </tr>

             <tr>
               <td style="width: 172px" align="center">Username</td>
               <td style="width: 188px">
                   <asp:TextBox ID="txt_signup_username" runat="server" Width="225px"></asp:TextBox></td>
           </tr>

           

         

            <tr>
               <td style="width: 172px" align="center">Password</td>
               <td style="width: 188px">
                   <asp:TextBox ID="txt_signup_pass" TextMode="Password" runat="server" Width="225px"></asp:TextBox></td>
           </tr>


            <tr>
               <td  style="height: 54px" colspan="2" align="center">
                   <asp:CheckBox ID="CheckBox1" runat="server" />Remember me
                &nbsp&nbsp
                    <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" Font-Underline="True" OnClick="LinkButton1_Click" >Sign UP</asp:LinkButton></td>
               
           </tr>

           <tr>
               <td  align="center" colspan="2">
                   <asp:Button ID="btn_login_b" runat="server" Text="Login" Font-Bold="True" OnClick="btn_login_b_Click"  />&nbsp&nbsp&nbsp</td>
           </tr>
       </table>
    </center>


</asp:Content>
