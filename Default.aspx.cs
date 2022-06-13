using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PROJETOWEB.Models;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;


namespace PROJETOWEB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                GridView1.DataSource = Documento.Lista;
                GridView1.DataBind();
            }
        }

        protected void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        protected void listProcesso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
        
        }
    

        protected void ButInserirDoc_Click(object sender, EventArgs e)
        {
            string caminhoArquivo = AppDomain.CurrentDomain.BaseDirectory + System.Configuration.ConfigurationManager.AppSettings["caminhoArquivos"] + @"\" + FupArquivo.FileName;
           


            Documento doc = new Documento();
            try
            {
                doc = Documento.NewInstancia(Convert.ToInt32(txtCodigo.Text), txtTitulo.Text, listProcesso.Text, txtCategoria.Text, caminhoArquivo);
            }
            catch (Exception err)
            {
                Page.RegisterClientScriptBlock("erro", "<script>alert('" + err.Message + "')</script>");

            }

            doc.Salvar();
        }
    }
}