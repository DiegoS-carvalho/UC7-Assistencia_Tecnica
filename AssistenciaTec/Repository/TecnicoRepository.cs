using AssistenciaTec.Data;
using AssistenciaTec.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistenciaTec.Repository
{
    public class TecnicoRepository
    {
        public int Salvar(Tecnico tecnico)
        {

            string sql = "INSERT INTO tbl_tecnicos (nome, email, telefone, especialidade) " +
                "OUTPUT INSERTED.tecnico_id " +
                "VALUES (@Nome, @Email, @Telefone, @Especialidade) ";

            using var conexao = Conexao.GetConexao();

            using var comando = new SqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@Nome", tecnico.Nome);
            comando.Parameters.AddWithValue("@Email", tecnico.Email);
            comando.Parameters.AddWithValue("@Telefone", tecnico.Telefone);
            comando.Parameters.AddWithValue("@Especialidade", tecnico.Especialidade);

            var novoId = (int)comando.ExecuteScalar();
            return novoId;

        }

        public List<Tecnico> ListarTodos()
        {
            var sql = "SELECT * FROM tbl_tecnicos order by nome ASC ";

            using var conexao = Conexao.GetConexao();
            using var comando = new SqlCommand( sql, conexao);
            using var resultado = comando.ExecuteReader();

            List<Tecnico> tecnincos = new List<Tecnico>();

            while (resultado.Read())
            {
                Tecnico tecnico = new Tecnico();
                tecnico.Id = resultado.GetInt32(resultado.GetOrdinal("tecnico_id"));
                tecnico.Nome = resultado.GetString(resultado.GetOrdinal("nome"));
                tecnico.Email = resultado.GetString(resultado.GetOrdinal("email"));
                tecnico.Telefone = resultado.GetString(resultado.GetOrdinal("telefone"));
                tecnico.Especialidade = resultado.GetString(resultado.GetOrdinal("especialidade"));
                tecnincos.Add(tecnico);
            }
            return tecnincos;

        }
   public int excluir(int id)
        {
            var sql = "DELETE FROM tbl_tecnicos WHERE tecnico_id = @Id";

            using var conexao = Conexao.GetConexao();
            using var comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Id", id);
            var resultado = comando.ExecuteNonQuery();
            return resultado;

        }
        public int atualizar (Tecnico tecnico)
        {
            var sql = "UPDATE tbl_tecnicos SET nome = @Nome, " +
                "email = @Email, " +
                "telefone = @Telefone, " +
                "especialidade = @Especialidade " +
                "WHERE tecnico_id = @Id";

            using var conexao = Conexao.GetConexao();
            using var comando = new SqlCommand(sql, conexao);


            comando.Parameters.AddWithValue("@Nome", tecnico.Nome);
            comando.Parameters.AddWithValue("@Email", tecnico.Email);
            comando.Parameters.AddWithValue("@Telefone", tecnico.Telefone);
            comando.Parameters.AddWithValue("@Especialidade", tecnico.Especialidade);
            comando.Parameters.AddWithValue("@Id", tecnico.Id);
            
            var resultado = comando.ExecuteNonQuery();
            return resultado;

        }

        public List<Tecnico> ListarPorNome(string nome)
        {

            // Criar a instrução SQL para listar todos
            var sql = "SELECT * FROM tbl_tecnicos " +
                "WHERE nome LIKE @Nome " +
                "ORDER BY nome ASC";

            // Abrir a conexão com o banco
            using var conexao = Conexao.GetConexao();

            // Criar o comando
            using var comando = new SqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@Nome", "%" + nome + "%");

            // Criar o objeto que guarda o resultado do comando SELECT
            using var resultado = comando.ExecuteReader();

            // Criar uma lista de Tecnico vazia
            List<Tecnico> tecnicos = new List<Tecnico>();

            while (resultado.Read())
            {
                Tecnico tecnico = new Tecnico();
                tecnico.Id = resultado.GetInt32(resultado.GetOrdinal("tecnico_id"));
                tecnico.Nome = resultado.GetString(resultado.GetOrdinal("nome"));
                tecnico.Email = resultado.GetString(resultado.GetOrdinal("email"));
                tecnico.Telefone = resultado.GetString(resultado.GetOrdinal("telefone"));
                tecnico.Especialidade = resultado.GetString(resultado.GetOrdinal("especialidade"));
                tecnicos.Add(tecnico);
            }

            return tecnicos;

        }

    }

}
