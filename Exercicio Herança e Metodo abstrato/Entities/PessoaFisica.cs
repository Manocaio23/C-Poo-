

namespace Exercicio_Herança_e_Metodo_abstrato.Entities
{
    class PessoaFisica : Pessoa
    {
        public double Saude { get; set; }

       

        public PessoaFisica(string nome, double rendaAnual, double saude) : base(nome, rendaAnual)
        {
     
            Saude = saude;
        }

        public override double Taxa()
        {
            
            double tot = 0;
            double final = 0;
            if (RendaAnual < 20000.00)
            {
                tot = 15;
            }
            else if (RendaAnual >= 20000.00)
            {
                tot = 25;

            }

            final = (RendaAnual * tot / 100) - (Saude * 50 / 100);
            return final;
        }

        
    }
}
