using System;
using System.Linq;

namespace calculadora{

    class Program{
//função principal
        static void Main(){

            Program.MenuPrincipal();
      
        }
        

/*

_________________________________________________|funções de navegação|______________________________________________________________________________

*/
        static void MenuPrincipal(){

            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("____________________| Calculadora |____________________");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" Escolha a operação a ser executada:");
            Console.WriteLine(" ");
            Console.WriteLine("(0) fechar programa.");
            Console.WriteLine("(1) Adição.");
            Console.WriteLine("(2) Subtração.");
            Console.WriteLine("(3) Multiplicação.");
            Console.WriteLine("(4) Divisão.");
            Console.WriteLine("(5) Exponenciação.");
            Console.WriteLine("(6) Radiciação.");
            Console.WriteLine("(7) Média.");
            Console.WriteLine("(8) Trigonometria.");
            Console.WriteLine("(9) Área de polígonos.");
            Console.WriteLine("(10) volume de polígonos.");
            Console.WriteLine("_____________________________________");
            var indicador = int.Parse(Console.ReadLine());

            if(indicador == 0){
                
                Console.Clear();
                Environment.Exit(0);

            }else if(indicador == 1){

                Console.Clear();
                Console.WriteLine("______________| Adição |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite o primeiro número:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" Digite o segundo número:");
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Program.Somar(num1, num2);

            }else if(indicador == 2){

                Console.Clear();
                Console.WriteLine("______________| Subtração |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite o primeiro número:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" Digite o segundo número:");
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Program.Subtrair(num1, num2);

            }else if(indicador == 3){

                Console.Clear();
                Console.WriteLine("______________| Multiplicação |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite o primeiro número:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" Digite o segundo número:");
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Program.Multiplicar(num1, num2);

            }else if(indicador == 4){

                Console.Clear();
                Console.WriteLine("______________| Divisão |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite o primeiro número:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" Digite o segundo número:");
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Program.Dividir(num1, num2);

            }else if(indicador == 5){

                Console.Clear();
                Console.WriteLine("______________| exponenciação |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a base:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a potência:");
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Program.Exponenciar(num1, num2);

            }else if(indicador == 6){

                Program.MenuRadiciacao();

            }else if(indicador == 7){

                Program.MenuMedia();

            }else if(indicador == 8){

                Program.MenuTrigonometria();

            }else if(indicador == 9){

                Program.MenuAreaDosPoligonos();

            }else if(indicador == 10){

                Program.MenuVolumeDosPoligonos();

            }else{

                Program.MenuPrincipal();

            }
        }


        static void MenuAreaDosPoligonos(){

            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("_______________| Área dos polígonos |_______________");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" Escolha a operação a ser executada:");
            Console.WriteLine(" ");    
            Console.WriteLine("(0) Voltar ao inicio.");
            Console.WriteLine("(1) Área de um triângulo.");
            Console.WriteLine("(2) Área de um quadrilatero.");
            Console.WriteLine("(3) Área de um paralelogramo.");
            Console.WriteLine("(4) Área de um trapézio.");
            Console.WriteLine("(5) Área de um hexagono.");
            Console.WriteLine("(6) Área de um losango.");
            var indicador = int.Parse(Console.ReadLine());

            if(indicador == 0){
                
                Program.MenuPrincipal();

            }else if(indicador == 1){

                Program.MenuAreaDosPoligonosSubTriangulos();

            }else if(indicador == 2){

                Program.MenuAreaDosPoligonosSubquadrilateros();

            }else if(indicador == 3){

                Console.Clear();
                Console.WriteLine("______________| Área de um paralelogramo |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a base:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a altura:");
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Program.AreaParalelogramo(num1, num2);
            
            }else if(indicador == 4){

                Console.Clear();
                Console.WriteLine("______________| Área de um trapézio |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a base maior:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a base menor:");
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a altura:");
                var num3 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Program.AreaTrapezio(num1, num2, num3);
            
            }else if(indicador == 5){

                Console.Clear();
                Console.WriteLine("______________| Área de um trapézio |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite o lado de um dos triângulos do hexagono:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Program.AreaHexagono(num1);

            }else if(indicador == 6){

                Console.Clear();
                Console.WriteLine("______________| Área de um paralelogramo |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a diagonal maior:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a diagonal menor:");
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Program.AreaLosango(num1, num2);
            
            }else{

                Program.MenuAreaDosPoligonos();

            }

        }


        static void MenuAreaDosPoligonosSubTriangulos(){

            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("_______________| Área dos triângulos |_______________");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" Escolha a operação a ser executada:");
            Console.WriteLine(" ");    
            Console.WriteLine("(0) Voltar ao inicio.");
            Console.WriteLine("(1) Área de um triângulo Equilatero.");
            Console.WriteLine("(2) Área de um triângulo isoceles.");
            Console.WriteLine("(3) Área de um triângulo retângulo.");
            var indicador = int.Parse(Console.ReadLine());

            if(indicador == 0){

                Program.MenuPrincipal();
                
            }else if(indicador == 1){

                Console.Clear();
                Console.WriteLine("______________| Área de um triângulo equilatero |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a medida do lado:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Program.AreaTrianguloEquilatero(num1);

            }else if(indicador == 2){

                Console.Clear();
                Console.WriteLine("______________| Área de um triângulo isoceles |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a medida da base:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a medida da altura:");
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Program.AreaTrianguloIsoceles(num1, num2);

            }else if(indicador == 3){

                Console.Clear();
                Console.WriteLine("______________| Área de um triângulo retângulo |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a medida do cateto oposto:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a medida do cateto adjacente:");
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Program.AreaTrianguloRetangulo(num1, num2);

            }else{

                Program.MenuAreaDosPoligonosSubTriangulos();

            }
        }


        static void MenuAreaDosPoligonosSubquadrilateros(){

            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("_______________| Área dos quadrilateros |_______________");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Escolha a operação a ser executada:");
            Console.WriteLine(" ");    
            Console.WriteLine("(0) Voltar ao inicio.");
            Console.WriteLine("(1) Área de um quadrado.");
            Console.WriteLine("(2) Área de um retângulo.");
            var indicador = int.Parse(Console.ReadLine());

                if(indicador == 0){
                    
                    Program.MenuPrincipal();
                
                }else if(indicador == 1){

                    Console.WriteLine("_______________|Área Dos Quadrilateros|______________");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Digite a medida do lado do quadrilatero:");
                    var num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Program.AreaQuadrado(num1);

                }else if(indicador == 2){

                    Console.WriteLine("_______________|Área Dos Retângulos|______________");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Digite a medida do lado menor:");
                    var num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.WriteLine("Digite a medida do lado maior:");
                    var num2 = double.Parse(Console.ReadLine());
                    Program.AreaRetangulo(num1, num2);

                }else{

                    Program.MenuAreaDosPoligonosSubquadrilateros();

                }
        }


        static void MenuRadiciacao(){

            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("_______________| Radiciação |_______________");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Escolha a operação a ser executada:");
            Console.WriteLine(" ");
            Console.WriteLine("(0) Voltar ao inicio.");
            Console.WriteLine("(1) Raíz quadrada.");
            Console.WriteLine("(2) Raíz cubica.");
            var indicador = int.Parse(Console.ReadLine());

            if(indicador == 0){

                Program.MenuPrincipal();
            
            }else if(indicador == 1){

                Console.WriteLine("_______________|Raíz Quadrada|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Digite o número que você quer tirar a raíz:");
                var num1 = double.Parse(Console.ReadLine());

                Program.TirarRaizQuadrada(num1);

            }else if(indicador == 2){

                Console.WriteLine("_______________|Raíz Cúbica|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Digite o número que você quer tirar a raíz:");
                var num1 = double.Parse(Console.ReadLine());
                Program.TirarRaizCubica(num1);

            }else{
                
                Program.MenuRadiciacao();
            
            }
       
        }


        static void MenuMedia(){

            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("_______________| Calcular média |_______________");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Escolha a operação a ser executada:");
            Console.WriteLine(" ");
            Console.WriteLine("(0) Voltar ao inicio.");
            Console.WriteLine("(1) Média simples.");
            Console.WriteLine("(2) Média ponderada.");
            var indicador = int.Parse(Console.ReadLine());

            if(indicador == 0){

                Program.MenuPrincipal();

            }else if(indicador == 1){

                Console.WriteLine("_______________|Média Simples|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Digite a quantidade de itens a ser contabilizados:");
                var num1 = int.Parse(Console.ReadLine());
                Program.MediaSimples(num1);

            }else if(indicador == 2){

                Console.WriteLine("_______________|Média Ponderada|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Digite a quantidade de itens a ser contabilizados:");
                var num1 = int.Parse(Console.ReadLine());
                Program.MediaPonderada(num1);

            }else{

                Program.MenuMedia();

            }

        }


        static void MenuVolumeDosPoligonos(){

            Console.WriteLine("_______________|Volume Dos Polígonos|______________");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Escolha a operação a ser executada:");
            Console.WriteLine("");
            Console.WriteLine("(0) Voltar ao inicio.");
            Console.WriteLine("(1) Volume de um cubo.");
            Console.WriteLine("(2) Volume de um paralelepipedo.");
            Console.WriteLine("(3) Volume de um cilindro.");
            Console.WriteLine("(4) Volume de um cone.");
            Console.WriteLine("(5) Volume de uma piramide.");
            Console.WriteLine("______________________________________");
            var indicador = int.Parse(Console.ReadLine());

            if(indicador == 0){

                Program.MenuPrincipal();
            
            }else if(indicador == 1){

                Console.WriteLine("_______________|Volume De Um Cubo|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Digite a medida de um dos lados do cubo:");
                var num1 = double.Parse(Console.ReadLine());
                Program.VolumeCubo(num1);

            }else if(indicador == 2){

                Console.WriteLine("_______________|Volume De Um Paralelepipedo|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Digite a medida do comprimento do paralelepipedo:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a medida da largura do paralelepipedo:");
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a medida da altura do paralelepipedo:");
                var num3 = double.Parse(Console.ReadLine());
                Program.VolumeParalelepipedo(num1, num2, num3);

            }else if(indicador == 3){

                Console.WriteLine("_______________|Volume De Um Cilindro|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Digite a medida do raio do cilindro:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a medida da altura do cilindro:");
                var num2 = double.Parse(Console.ReadLine());
                Program.VolumeCilindro(num1, num2);

            }else if(indicador == 4){

                Console.WriteLine("_______________|Volume De Um Cone|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Digite a medida do raio do cone:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a medida da altura do cone:");
                var num2 = double.Parse(Console.ReadLine());
                Program.VolumeCone(num1, num2);

            }else if(indicador == 5){

                Console.WriteLine("Esta funcionalidade está temporariamente desativada.");
                Console.ReadLine();
                Program.MenuVolumeDosPoligonos();

            }else{

                Program.MenuPrincipal();
 
            }

        }

        static void MenuTrigonometria(){

            Console.WriteLine("_______________|Trigonometria|_______________");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Escolha a operação a ser executada:");
            Console.WriteLine(" ");
            Console.WriteLine("(0) Voltar ao inicio.");
            Console.WriteLine("(1) Seno.");
            Console.WriteLine("(2) Cosseno.");
            Console.WriteLine("(3) Tangente.");
            Console.WriteLine("(4) Teorema de Pitágoras");
            Console.WriteLine("(5) Area de um triângulo");
            Console.WriteLine("(6) Função seno");
            Console.WriteLine("(7) Função consseno");
            Console.WriteLine("(8) Função tangente");
            var indicador = int.Parse(Console.ReadLine());

        
            if(indicador == 0){
                Program.MenuPrincipal();
            }else if(indicador == 1){
                
                Console.WriteLine("_______________|Determinar seno|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Digite o ângulo que você deseja determinar o seno:");
                double angulo = double.Parse(Console.ReadLine());
                Program.PegarValorSeno(angulo);

            }else if(indicador == 2){

                Console.WriteLine("_______________|Determinar cosseno|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Digite o ângulo que você deseja determinar o cosseno:");
                double angulo = double.Parse(Console.ReadLine());
                Program.PegarValorCosseno(angulo);

            }else if(indicador == 3){

                Console.WriteLine("_______________|Determinar tangente|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Digite o ângulo que você deseja determinar a tangente:");
                double angulo = double.Parse(Console.ReadLine());
                Program.PegarValorTagente(angulo);

            }else if(indicador == 4){

                Console.WriteLine("_______________|Teorema de pitágoras|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Escolha a situação em que você se encontra:");
                Console.WriteLine(" ");
                Console.WriteLine("(1) Você possui o valor da hipotenusa, mas precisa encontrar o valor de um dos catetos.");
                Console.WriteLine("(2) Você possui o valor dos dois catetos, mas precisa encontrar o valor da hipotenusa.");
                int i = int.Parse(Console.ReadLine());
                Program.TeoremaPitagoras(i);

            }else if(indicador == 5){

            }else if(indicador == 6){

            }else if(indicador == 7){

            }else if(indicador == 8){

            }else{
                Program.MenuPrincipal();
            }
        }

/*

_________________________________________|funções de operações|_________________________________________________________________________________________

*/

        static void Somar(double num1, double num2){

            double resultado = num1 + num2;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuPrincipal();
        }


        static void Subtrair(double num1, double num2){

            double resultado = num1 - num2;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuPrincipal();

        }


        static void Multiplicar(double num1, double num2){

            double resultado = num1 * num2;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuPrincipal();

        }


        static void Dividir(double num1, double num2){

            double resultado = num1 / num2;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuPrincipal();

        }


        static void Exponenciar(double num1, double num2){

            double resultado = Math.Pow(num1, num2);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuPrincipal();

        }


        static void TirarRaizQuadrada(double num1){

            double resultado = Math.Sqrt(num1);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuRadiciacao();

        }


        static void TirarRaizCubica(double num1){

            double resultado = Math.Cbrt(num1);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuRadiciacao();
            
        }


        static void MediaSimples(int indicador){
            //a variavel "indicador" deve ser usada para determinar o número de itens("item{valor}").
            double[] numeros = new double[indicador];
            //o looping abaixo solicita que o usuário digite o valor de cada item, e depois guarda no array declarado acima.
            for(int i = 0; i < indicador; i++){
                Console.WriteLine(" ");
                Console.WriteLine($"Digite o {i+1}º numero:");
                numeros[i] = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
            }
            //a variavel abaixo recebe: (a soma de todos os itens do array "numeros") dividido pela variavel "indicador".
            double resultado = (numeros.Sum()) / indicador;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuMedia();

        }


        static void MediaPonderada(int indicador){
            //a variavel "indicador" deve ser usada para determinar o número de itens("item{peso, valor}").
            double[] peso =  new double[indicador];
            double[] valor = new double[indicador];
            double[] produto = new double[indicador];
            //o looping abaixo solicita que o usuário digite o peso de cada item, e depois guarda no array "peso", declarado acima.
            for(int i = 0; i < indicador; i++){
                Console.WriteLine(" ");
                Console.WriteLine($"Digite o {i+1}º peso:");
                peso[i] = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
            }
            //o looping abaixo solicita que o usuário digite o valor de cada item, e depois guarda no array "valor", declarado acima.
            for(int i = 0; i < indicador; i++){
                Console.WriteLine(" ");
                Console.WriteLine($"Digite o {i+1}º valor:");
                valor[i] = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
            }
            //o looping abaixo determina o produto entre o peso e valor dos itens, e depois guarda no array "produto", declarado acima.
            for(int i =0; i < indicador; i++){
                produto[i] = peso[i] * valor[i];
            }
            //a variavel abaixo recebe: (a soma de todos os itens do array "produto") dividido por (a soma de todos os itens do array "peso").
            double resultado = (produto.Sum()) / (peso.Sum());

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuMedia();

        }


        static void AreaHexagono(double _ladoTriangulo_){
            //a variavel ladoTriangulo refere-se a um lado de um dos 6 triângulos do hexágono
            double resultado = 6*( (Math.Pow(_ladoTriangulo_, 2)) * 1.73 / 4);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuAreaDosPoligonos();

        }


        static void AreaQuadrado(double _lado_){
            //a variavel lado refere-se a medida do lado do quadrado
            double resultado = Math.Pow(_lado_, 2);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuAreaDosPoligonosSubquadrilateros();

        }


        static void AreaRetangulo(double _ladoMaior_, double _ladoMenor_){
            
            double resultado = _ladoMaior_ * _ladoMenor_;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuAreaDosPoligonosSubquadrilateros();

        }


        static void AreaParalelogramo(double _base_, double _altura_){

            double resultado = _base_ * _altura_;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuAreaDosPoligonos();

        }


        static void AreaTrapezio(double _baseMaior_, double _baseMenor_, double _altura_){

            double resultado = ((_baseMaior_ + _baseMenor_)*_altura_) / 2;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuAreaDosPoligonos();

        }


        static void AreaLosango(double _diagonalMaior_, double _diagonalMenor_){

            double resultado = (_diagonalMaior_ * _diagonalMenor_) / 2;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuAreaDosPoligonos();

        }


        static void AreaTrianguloIsoceles(double _base_, double _altura_){

            double resultado = (_base_ * _altura_) / 2;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuAreaDosPoligonosSubTriangulos();

        }


        static void AreaTrianguloRetangulo(double _catetoOposto_, double _catetoAdjacente_){

            double resultado = (_catetoOposto_ * _catetoAdjacente_) / 2;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuAreaDosPoligonosSubTriangulos();

        }


        static void AreaTrianguloEquilatero(double _lado_){
            //a variavel lado refere-se a medida do lado do quadrado
            double resultado = (Math.Pow(_lado_, 2)) * 1.73 / 4;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuAreaDosPoligonosSubTriangulos();

        }


        static void VolumeParalelepipedo(double _comprimento_, double _largura_, double _profundidade_){

            double resultado = _comprimento_ * _largura_ * _profundidade_;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuVolumeDosPoligonos();

        }


        static void VolumeCubo(double _lado_){

            double resultado = Math.Pow(_lado_, 3);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuVolumeDosPoligonos();

        }


        static void VolumeCilindro(double _raio_, double _altura_){

            double resultado = 3.14 * (Math.Pow(_raio_, 2)) * _altura_;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuVolumeDosPoligonos();

        }


        static void VolumeCone(double _raio_, double _altura_){

            double resultado = (3.14 * (Math.Pow(_raio_, 2)) * _altura_) / 3;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuVolumeDosPoligonos();

        }

/*
        função pausada pq falta um método para representar frações dentro da função

        a formula é: V = 1/3 * area da base (area =  base * altura) * altura


        static void VolumePiramide(double _base_, double _altura_, double _Altura_){

            double _areaBase_ = _base_ * _altura_;

            double resultado = ();

            Console.WriteLine($" O resultado é: {resultado}.");

        }

*/


        static void PegarValorSeno(double _angulo_){

            double resultado = Math.Sin(_angulo_);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuVolumeDosPoligonos();

        }

        static void PegarValorCosseno(double _angulo_){

            double resultado = Math.Cos(_angulo_);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuVolumeDosPoligonos();

        }

        static void PegarValorTagente(double _angulo_){

            double resultado = Math.Tan(_angulo_);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Program.MenuVolumeDosPoligonos();

        }

        static void TeoremaPitagoras(int _parteFaltando_){
            // (a² = b² + c²)
            // a variavel "_parteFaltando_" deve receber apenas os seguintes valores: 1 ou 2 (int)
            //lembre-se de fornecer uma tabela indicando os possiveis valores para a variavel "_parteFaltando_"
            double[] valores = new double[2];

            if(_parteFaltando_ == 1){
                //neste caso, a parte faltando é a hipotenusa.
                Console.WriteLine("Digite o valor do primeiro cateto");
                valores[0] = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Digite o valor do segundo cateto:");
                valores[1] = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                double resultado = Math.Sqrt((Math.Pow(valores[0], 2)) + (Math.Pow(valores[1], 2)));
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($" O valor da hipotenusa é : {resultado}.");
                Console.ResetColor();
                Console.ReadLine();
                Program.MenuVolumeDosPoligonos();

            }else if(_parteFaltando_ == 2){
                //neste caso, a parte faltando é um cateto.
                Console.WriteLine("Digite o valor da hipotenusa");
                valores[0] = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Digite o valor do cateto:");
                valores[1] = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                double resultado = Math.Sqrt((Math.Pow(valores[0], 2)) - (Math.Pow(valores[1], 2)));
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($" O valor do cateto é : {resultado}.");
                Console.ResetColor();
                Console.ReadLine();
                Program.MenuVolumeDosPoligonos();

            }else{

                Console.WriteLine("Valor inesperado, por favor forneça os valores de acordo com a tabela.");
                Console.ReadLine();
                Program.MenuTrigonometria();

            }
        }






    }
}
