using System;

namespace Jamal2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de Exercicio 1\n");
            Console.WriteLine("Escolha uma opção abaixo :\n");
            Console.WriteLine("Exercicio 1 : Calcule a média ");
            Console.WriteLine("Exercicio 2 : Descubra qual o mês de referencia ");
            Console.WriteLine("Exercicio 3 : Jogo da Forca ");
            Console.WriteLine("Exercicio 4 : Calcule a média ");
            Console.WriteLine("Exercicio 5 : Calcule a média ");
            Console.WriteLine("Exercicio 6 : Calcule a média ");
            Console.WriteLine("Exercicio 7 : Calcule a média ");
            Console.WriteLine("Exercicio 8 : Calcule a média ");
            Console.WriteLine("Exercicio 9 : Calcule a média ");
            Console.WriteLine("Exercicio 10 : Calcule a média ");
            String option = Console.ReadLine();
            int castOption = Convert.ToInt32(option);
                        
            switch (castOption)
            {
                case 1:
                    Console.WriteLine("Calcule a média : \n");
                    Console.WriteLine("Informe a Primeira Nota");
		            String nota01 = Console.ReadLine();
                    double castNota1 = Convert.ToDouble(nota01);
		
		            Console.WriteLine("Informe a Segunda Nota");
		            String nota02 = Console.ReadLine();
                    double castNota2 = Convert.ToDouble(nota02);
		
		            Console.WriteLine("Informe a Terceira Nota");
		            String nota03 = Console.ReadLine();
                    double castNota3 = Convert.ToDouble(nota03);

                    Console.WriteLine("A sua média de nota é :");    
		            Console.WriteLine((castNota1+castNota2+castNota3)/3);
                break;

                case 2:
                    /*
                        String value = Console.ReadLine();
                        int castValue = Convert.ToInt32(value);
                        Console.WriteLine(castValue);
                    */
                    Console.WriteLine("Informe um número e descubra qual o mês de referencia: \n");
                    String mes = Console.ReadLine();
                    int CastMes = Convert.ToInt32(mes);                    

                    switch(CastMes){ // Avalia todos os meses
                    case 1:
                        mes = "Janeiro";
                    break;
                    case 2:
                        mes = "Fevereiro";
                    break;
                    case 3:
                        mes = "Março";
                    break;
                    case 4:
                        mes = "Abril";
                    break;
                    case 5:
                        mes = "Maio";
                    break;
                    case 6:
                        mes = "Junho";
                    break;
                    case 7:
                        mes = "Julho";
                    break;
                    case 8:
                        mes = "Agosto";
                    break;
                    case 9:
                        mes = "Setembro";
                    break;
                    case 10:
                        mes = "Outubro";
                    break;
                    case 11:
                        mes = "Novembro";
                    break;
                    case 12:
                        mes = "Dezembro";
                    break;
                    default:
                        mes = "Inválido";
                    break;
                    }
                    Console.WriteLine("O mês escolhido é " + mes + ".");
                break;
                case 3:
                    Console.WriteLine("Digite a palavra oculta: ");
                    String palavraOculta = Console.ReadLine();

                    Console.WriteLine("Digite a quantidade de tentativas: ");
                    int tentativas = Convert.ToInt32(Console.ReadLine());

                    String resposta;
                    int contadorTentativas = 0;
                    int valorPasso = Math.Abs(tentativas/3); // Salva a quantidade de saltos entre cada parte do corpo
                    int contadorPartes = tentativas; // Inicia o contador de exibição das partes com o número de tentativas
                    int contadorExibicao = 0; // Cria uma variável de controle para a exibição das partes
                    for(int i=0; i < tentativas; i++){
                        Console.WriteLine("Qual a palavra oculta?");
                        resposta = Console.ReadLine();
                        contadorTentativas = (tentativas - (i+1));
                    if (Equals(palavraOculta,resposta)){ // COmpara a resposta e caso seja igual para a repetição
                        Console.WriteLine("Parabéns você acertou!!");
                    break;
                    } else {
                        // Avalia partes do corpo
                        if (tentativas < 3){ // Se tiver menos que três chances, deve mostrar mais de uma parte do corpo
                            if (contadorTentativas == 1){
                                Console.WriteLine("xxx Cabeça e Tronco xxx");
                    } else {
                        Console.WriteLine("xxx Membros xxx");
                    }
                    } else {
                        // Avalia se já 'erro' a quantidade de vezes do salto entre partes
                        if((contadorPartes - valorPasso) == contadorTentativas)
                        {
                            if(contadorExibicao == 0) {
                                Console.WriteLine("xxx Cabeça xxx");
                        } else if (contadorExibicao == 1){
                            Console.WriteLine("xxx Tronco xxx");
                        } else {
                            Console.WriteLine("xxx Membros xxx");
                        }
                        contadorExibicao++;
                        contadorPartes -= valorPasso;
                    }
                    }

                    if(contadorTentativas == 0)
                    {
                        Console.WriteLine("Você foi enforcado!");
                    }   
                    else 
                    {
                        Console.WriteLine("Errou, você tem mais " + contadorTentativas);
                    }
                    }
                    }
                break;
                case 4:
                break;
                case 5:
                break;
                case 6:
                break;
                case 7:
                break;
                case 8:
                break;
                case 9:
                break;
                case 10:
                break;
                case 11:
                break;
                case 12:
                break;
                default:
                break;
            }
        }
    }
}
