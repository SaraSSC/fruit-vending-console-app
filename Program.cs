// valor morangos(<=5kg) = 2,50€ ; (>5kg)=2,20€
//valor macas(<=5kg) = 1,80€ ; (>5kg)=1,50€
//peso >10kg || custo > 25€ == desconto 10%


namespace Exercicio2_teste
{
    class Program
    {
        //var global
        static double pesoMorangos, pesoMaças, preçoTotalFruta, pesoTotalFruta;
        static double preçoTotalMorangos, preçoTotalMaças;
        static double preçoDesconto, preçoFinal;


        static void Main(string[] args)
        {

            Console.WriteLine("Qual a quantida de morangos (kg): ");
            pesoMorangos = Convert.ToDouble(Console.ReadLine());

            if (pesoMorangos <= 5)
            {
                preçoTotalMorangos = pesoMorangos * 2.50;
                Console.WriteLine("Preço a pagar pelos morangos: {0}", preçoTotalMorangos);
           
            } else if (pesoMorangos > 5)
            {
                preçoTotalMorangos = pesoMorangos * 2.20;
                Console.WriteLine("Preço a pagar pelos morangos: {0}", preçoTotalMorangos);
            };

            Console.WriteLine("Qual a quantidade de maçãs (kg): ");
            pesoMaças = Convert.ToDouble(Console.ReadLine());

            if (pesoMaças <= 5)
            {
                preçoTotalMaças = pesoMaças * 1.80;
                Console.WriteLine("Preço a pagar pelas maçãs: {0}", preçoTotalMaças);
            
            } else if (pesoMaças > 5)
            {
                preçoTotalMaças = pesoMaças * 1.50;
                Console.WriteLine("Preço a pagar pelas maçãs: {0}", preçoTotalMaças);
            };


            pesoTotalFruta = pesoMorangos + pesoMaças;
            preçoTotalFruta = preçoTotalMorangos + preçoTotalMaças;

            if (pesoTotalFruta > 10 || preçoTotalFruta > 25)
            {
                preçoDesconto = (preçoTotalFruta * 10) / 100;
                preçoFinal = preçoTotalFruta - preçoDesconto;

                Console.WriteLine("Total  a pagar após desconto: {0}",preçoFinal);
            } else
            {
                Console.WriteLine("Total a pagar : {0}", preçoTotalFruta);
            }

        }
    }                 
}



           

            

