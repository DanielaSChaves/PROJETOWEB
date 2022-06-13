using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PROJETOWEB.Models
{
    public class Documento
    {
        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public string Processo { get; set; }
        public string Categoria { get; set; }
        public string Arquivo { get; set; }

        public static Documento NewInstancia(int Codigo, string Titulo, string Processo, string Categoria, string Arquivo)
        {
            string mensagens = string.Empty;

            if (Codigo == 0)
                mensagens += "O Codigo é obrigatório. ";

            if (Titulo == "")
                mensagens += "O Titulo é obrigatório. ";

            if (Processo == "")
                mensagens += "O Processo é obrigatório. ";

            if (Categoria == "")
                mensagens += "A Categoria é obrigatória. ";

            if (Arquivo.ToLower().Contains(".pdf") || Arquivo.ToLower().Contains(".doc") || Arquivo.ToLower().Contains(".xls") || Arquivo.ToLower().Contains(".docx") || Arquivo.ToLower().Contains(".xlsx")) ;
            mensagens += "O Arquivo é inválido. ";

            if (string.IsNullOrEmpty(mensagens))
            {
                return new Documento()
                {
                    Codigo = Codigo,
                    Titulo = Titulo,
                    Processo = Processo,
                    Categoria = Categoria,
                    Arquivo = Arquivo
                };
            }
            else
            {
                throw new Exception(mensagens);
            }

        }

        public static List<Documento> Lista = new List<Documento>();
        public List<Documento> Todos()

        { 
            return Documento.Lista;
        
        }
        public void Salvar()
        {
            Documento.Lista.Add(this); 
        }


    }
}