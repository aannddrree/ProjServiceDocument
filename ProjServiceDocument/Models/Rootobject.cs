using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjServiceDocument.Services
{
    [NotMapped]
    public class Rootobject
    {
        public Atividade_Principal[] atividade_principal { get; set; }
        public string data_situacao { get; set; }
        public string complemento { get; set; }
        public string tipo { get; set; }
        public string nome { get; set; }
        public string uf { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
        public Atividades_Secundarias[] atividades_secundarias { get; set; }
        public string situacao { get; set; }
        public string bairro { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string cep { get; set; }
        public string municipio { get; set; }
        public string porte { get; set; }
        public string abertura { get; set; }
        public string natureza_juridica { get; set; }
        public string fantasia { get; set; }
        public string cnpj { get; set; }
        public DateTime ultima_atualizacao { get; set; }
        public string status { get; set; }
        public string efr { get; set; }
        public string motivo_situacao { get; set; }
        public string situacao_especial { get; set; }
        public string data_situacao_especial { get; set; }
        public string capital_social { get; set; }
        public object[] qsa { get; set; }
        public Extra extra { get; set; }
        public Billing billing { get; set; }
    }

    public class Extra
    {
    }

    public class Billing
    {
        public bool free { get; set; }
        public bool database { get; set; }
    }

    public class Atividade_Principal
    {
        public string text { get; set; }
        public string code { get; set; }
    }

    public class Atividades_Secundarias
    {
        public string text { get; set; }
        public string code { get; set; }
    }

}
