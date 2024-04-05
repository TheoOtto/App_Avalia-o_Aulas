using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAvaliacoes
{
    class ComandosCRUD
    {
        private const string stringConexao = "server = .\\TEW_SQLEXPRESS; " +
                            "database=appAvaliacao; " +
                             "trusted_connection=true; " +
                             "trustServerCertificate=true;";
        private string comando;
        public int usuarConectado { get; set; }

        SqlConnection sqlCon = new SqlConnection(stringConexao);
        SqlCommand sqlComando;
        SqlDataReader dataReader;

        private void abrirConexao()
        {
            if (sqlCon.State != ConnectionState.Open)
            {
                sqlCon.Close();
                sqlCon.Open();
            }

            if (sqlCon.State != System.Data.ConnectionState.Open)
            {
                throw new Exception("Erro ao conectar ao banco.");
            }
        }


        public bool usuarioExistente(string email, string senha)
        {
            abrirConexao();

            comando = $"SELECT * FROM Usuarios WHERE email_usuario = @email AND senha_hash = @password";

            sqlComando = new SqlCommand(comando, sqlCon);
            sqlComando.Parameters.AddWithValue("@email", email);
            sqlComando.Parameters.AddWithValue("@password", senha);

            dataReader = sqlComando.ExecuteReader();

            if (dataReader.Read())
            {
                usuarConectado = (int)dataReader[0];
                sqlCon.Close();
                return true;
            }
            else
            {
                sqlCon.Close();
                return false;
            }

        }

        public async void criarConta(string email, string nomeUsuario, string senha)
        {
            if (!usuarioExistente(email, senha))
            {
                abrirConexao();

                comando = $"INSERT Usuarios VALUES (NULL, @password, @username, @email)";

                sqlComando = new SqlCommand(comando, sqlCon);
                sqlComando.Parameters.AddWithValue("@email", email);
                sqlComando.Parameters.AddWithValue("@username", nomeUsuario);
                sqlComando.Parameters.AddWithValue("@password", senha);

                sqlComando.ExecuteNonQuery();
                sqlCon.Close();
                await Shell.Current.DisplayAlert("Cadastro", "Cadastro realizado com sucesso! Faça seu login.", "OK");
            }
            else
            {
                await Shell.Current.DisplayAlert("Conta existente", "Essa conta já existe. Crie uma diferente.", "OK");
            }
        }


        public SqlDataReader readerAulas(string materia)
        {
            abrirConexao();

            comando = $"SELECT a.id_aula, a.data_aula, a.professor_aula, a.descricao_aula " +
                $"FROM Aula AS a INNER JOIN Materia AS m " +
                $"ON a.materia_aula=m.id_materia " +
                $"WHERE m.nome_materia= @materia";

            sqlComando = new SqlCommand(comando, sqlCon);
            sqlComando.Parameters.AddWithValue("@materia", materia);

            dataReader = sqlComando.ExecuteReader();

            return dataReader;
        }


        public void InserirComentario(string comentario, int user,  int aula, int nota)
        {
            abrirConexao();
            if (comentario.IsNullOrEmpty())
            {
                comentario = "Avaliação enviada sem comentário.";
            }

            comando = $"INSERT Comentario VALUES (@comentario, @user, @aula, @nota)";

            sqlComando = new SqlCommand(comando, sqlCon);
            sqlComando.Parameters.AddWithValue("@comentario", comentario);
            sqlComando.Parameters.AddWithValue("@user", user);
            sqlComando.Parameters.AddWithValue("@aula", aula);
            sqlComando.Parameters.AddWithValue("@nota", nota);

            sqlComando.ExecuteNonQuery();
            sqlCon.Close();
        }
    }
}
