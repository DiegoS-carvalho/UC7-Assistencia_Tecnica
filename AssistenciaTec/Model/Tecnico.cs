using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistenciaTec.Model
{
     
    
        public class Tecnico
    {
            public int Id { get; set; }

            private string _nome;
            private string _email;
            private string _telefone;
            private string _especialidade;

            // Propriedade Nome (exemplo fornecido)
            public string Nome
            {
                get { return _nome; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("O campo nome é obrigatório!", nameof(Nome));
                    }
                    _nome = value;
                }
            }

            // Propriedade Email
            public string Email
            {
                get { return _email; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("O campo e-mail é obrigatório!", nameof(Email));
                    }
                    _email = value;
                }
            }

            // Propriedade Telefone
            public string Telefone
            {
                get { return _telefone; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("O campo telefone é obrigatório!", nameof(Telefone));
                    }
                    _telefone = value;
                }
            }

        // Propriedade Especialidade
        public string Especialidade
            {
                get { return _especialidade; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("O campo Especialidade é obrigatório!", nameof(Especialidade));
                    }
                _especialidade = value;
                }
            }
        }
    }

