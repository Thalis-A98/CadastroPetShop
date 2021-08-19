using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CadastroPetShop
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            char sexo = ' ';
            if (rbMacho.Checked)
            {
                sexo = 'M';
            }
            else if (rbFemea.Checked)
            {
                sexo = 'F';
            }

            string comando = $@"insert into caes (nome, peso, raca, sexo, data_nascimento, castrado, porte)
                            values('{txtNome.Text}','{txtPeso.Text}','{txtRaca.Text}','{sexo}','{txtDataNascimento.Text}',
                                    {ckCastrado.Checked} ,'{ddlPorte.SelectedValue}')";
            ConexaoMySql.ComandoSemRetorno(comando);
            Response.Redirect(Request.RawUrl);
        }
    }
}