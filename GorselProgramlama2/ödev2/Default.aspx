<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ödev2._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>2.ödev</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0-beta.2/css/bootstrap.min.css" integrity="sha384-PsH8R72JQ3SOdhVi3uxftmaW6Vc51MKb0q5P2rRUpPvrszuE4W1povHYgTpBfshb" crossorigin="anonymous">
</head>
<body class="container">
    <form id="form1" runat="server">
    <div class="jumbotron">
        <h1>Görsel Programlama 2. Ödev</h1>
        <p>Girilen bir IP adresinin hangi ülkede olduğunu bulmak..</p>
    
    </div>
        <div class="input-group">
          <p>
              <h4> İp adresinizi giriniz :  </h4>  <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
         </p>
           </div>
        <div>
        <asp:Button  type="button" class="btn btn-info" ID="SorguButton" runat="server" OnClick="SorguButton_Click" Text="Sorgula" Width="94px" />
        </div>
            
        <hr />
            
             
         <div class="input-group">
             <p>
               <h4> Ülke =</h4> <asp:TextBox ID="UlkeYazdir" placeholder="Bulunan Ülke.." runat="server"></asp:TextBox>
        
             </p>
        </div>
        <hr />
        <div>

          
              <h4> Daha Önce Araştırılmış Ülkeler:</h4> 
             <asp:ListBox ID="ListBox1" runat="server" Height="94px" Width="186px"></asp:ListBox>
           
            
        </div>
    </form>
</body>
</html>

