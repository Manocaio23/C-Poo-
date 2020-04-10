

namespace Exercicio_Herança_e_Metodo_abstrato.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int QuantidadeFuncionarios { get; set; }

       

        public PessoaJuridica(string nome, double rendaAnual, int quantidadeFuncionarios) : base(nome, rendaAnual)
        {
            
            QuantidadeFuncionarios = quantidadeFuncionarios;
        }

        public override double Taxa()
        {
            double tot = 0;
            double final = 0;
            if (QuantidadeFuncionarios <=10)
            {
                tot = 16;

            } else if (QuantidadeFuncionarios>10) {
                tot = 14;
            }
            final = RendaAnual * tot / 100;

            return final;
        }
    }
}
