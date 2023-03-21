using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Data;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Galeria : System.Web.UI.Page
{
        protected void Page_Load(object sender, EventArgs e)
    {       
        codAlbumLabel.Text=Request["galeria"].ToString();
        
        if (!IsPostBack)
        {
          Iniciar();
        }
    }


        protected void Iniciar()
         {
             
          CarregarImagens();
          CarregarTituloDescricao();
            
         }


       protected void voltarButton_Click(object sender, EventArgs e)
    {

        Response.Redirect("MenuGaleria.aspx");

    }

            protected void CarregarImagens()
        {
            string sql = " SELECT cg.id_imagem, cg.imagem_galeria, cg.cod_album, cga.id_album, cga.descricao_album, cga.titulo_album FROM [banco].[dbo].[GALERIA] cg Left Join [banco].[dbo].[GALERIA_album] cga ON cg.cod_album = cga.id_album where cg.cod_album = "+ codAlbumLabel.Text;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            galeriaRepeater.DataSource = dt;
            galeriaRepeater.DataBind();

        }  

         protected void CarregarTituloDescricao()
         {
            string sql = "SELECT cga.id_album, cga.titulo_album, cga.descricao_album FROM [banco].[dbo].[GALERIA_album] cga LEFT JOIN [banco].[dbo].[GALERIA] cg ON cga.id_album = cg.cod_album where cg.cod_album = "+ codAlbumLabel.Text;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            SqlCommand comando = new SqlCommand(sql, conn);

            conn.Open();

            SqlDataReader resultado = comando.ExecuteReader();
            if (resultado.Read())
            {
                tituloAlbum.Text = Convert.ToString(resultado["titulo_album"]);
                descricaoAlbum.Text = Convert.ToString(resultado["descricao_album"]);
            }

            conn.Close();
            }
}

  

