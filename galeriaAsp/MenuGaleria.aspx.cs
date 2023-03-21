using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MenuGaleria : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Iniciar();
            
        }
    }
   
     protected void Iniciar()
        {
            CarregarImagem();
            
          
        }

    
        protected void CarregarImagem()
    {
        string sql = "SELECT id_album, capa_album, titulo_album from [banco].[dbo].GALERIA_album] where st = 1";
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
        DataTable dt = new DataTable();
        
        sda.Fill(dt);
        galeriaRepeater.DataSource = dt;
        galeriaRepeater.DataBind();

    }   

 
}


