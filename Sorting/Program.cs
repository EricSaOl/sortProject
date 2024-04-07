
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice, number;
            int[] array,arrayOriginal;
            List<string> listaDeNomes = new List<string>();

            Console.WriteLine(" --------------------------------------------------"
                          + "\n|         Menu de opções:                          |"
                          + "\n|                                                  |"
                          + "\n|1- Operação Bubblesort:                           |"
                          + "\n|2- Operação SelectionSort:                        |" 
                          + "\n|3- Operação InsertSort:                           |"
                          + "\n|4- Todas as operações acima:                      |"
                          + "\n|5- Inverter um nome:                              |"
                          + "\n|6- Adicionar um nome a lista de nomes:            |"
                          + "\n|7- Ordenar lista de nomes por tamanho de nomes:   |"
                          + "\n -------------------------------------------------- ");

            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a quantidade de numeros que devem ser lidos no vetor:");
            number = int.Parse(Console.ReadLine());
            array = new int[number];
            arrayOriginal = new int[number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Entre com o {(i+1)}º numero:");
                array[i] = int.Parse(Console.ReadLine());
                arrayOriginal[i] = array[i];
            }


            
            switch (choice)
            {
                case 1:
                    array = BobbleSort(array, number);
                    Console.ReadKey();
                    break;
                case 2:
                    array = SelectionSort(array, number);
                    Console.ReadKey();
                    break;
                case 3:
                    array = InsertSort(array, number);
                    Console.ReadKey();
                    break;
//Precisa de ateção 
                case 4:
                    
                    int[] boobleSortArray = BobbleSort(array, number);
                    int[] selectionArray = SelectionSort(array, number);
                    Console.Write($"\nVetor original: ");
                    for (int i = 0; i < number; i++)
                    {
                        Console.Write($"{arrayOriginal[i]} ");
                    }
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Oção inválida");
                    break;
                case 5:
                    char temp;
                    Console.WriteLine();
                    Console.Write("Digite um nome: ");
                    string nome = Console.ReadLine();
                    char[] letras = nome.ToCharArray();
                    for (int i = 0; i < letras.Length - 1; i++)
                    {
                        for (int j = 0; j < letras.Length - 1; j++)
                        {
                            if (letras[j] > letras[j + 1])
                            {
                                temp = letras[j];
                                letras[j] = letras[j + 1];
                                letras[j + 1] = temp;
                            }
                        }
                    }
                    Console.Write("Nome ordenado: ");
                    foreach (char c in letras)
                    {
                        Console.Write($"{c}");
                    }
                    Console.WriteLine("\n");
                    break;

                case 6:
                    int qnt;
                    Console.WriteLine();
                    Console.Write("Digite a quantidade de nomes: ");
                    qnt = int.Parse(Console.ReadLine());
                    string[] nomes = new string[qnt];
                    for (int i = 0; i < qnt; i++)
                    {
                        Console.WriteLine();
                        Console.Write($"Entre com o {i + 1}º nome: ");
                        listaDeNomes.Add( Console.ReadLine());
                    }
                    break;

            }

        }
        public static int[] BobbleSort(int[] array, int number)
        {
            int aux;
            int compares = 0, changes = 0;
            for (int i = 0; i <= number - 1; i++)
            {
                for (int j = 0; j < number - 1; j++)
                {
                    compares++;
                    if (array[j] > array[j + 1])
                    {
                        aux = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = aux;
                        changes++;
                    }
                }
            }
            Console.Write($"\nQuantidade de comparações feitas: {compares}\nQuantidade de trocas feitas: {changes}\nVetor ordenado: ");
            for (int i = 0; i < number; i++)
            {
                Console.Write($"{array[i]} ");
            }
            return array;
        }
        //MOdificar contagem de trocas e de comparações
        public static int[] SelectionSort(int[] array, int number)
        {
            int minor, aux, compares = 0, changes = 0;
            for (int i = 0; i < number - 1; i++)
            {
                    compares++;
                minor = i;
                for (int j = i + 1; j < number; j++)
                {
                    if (array[j] < array[minor])
                    {
                        minor = j;
                    }
                    if (i != minor)
                    {
                        aux = array[i];
                        array[i] = array[minor];
                        array[minor] = aux;
                        changes++;
                    }
                }
            }
            Console.Write($"\nQuantidade de comparações feitas: {compares}\nQuantidade de trocas feitas: {changes}\nVetor ordenado: ");
            for (int i = 0; i < number; i++)
            {
                Console.Write($"{array[i]} ");
            }

            return array;
            //MOdificar contagem de trocas e de comparações
        }
        public static int[] InsertSort(int[] array, int number)
        {
            int  aux, compares = 0, changes = 0;
            for (int i = 0; i < number; i++)
            {
                    compares++;
                aux = array[i];
                for (int j = i; (j>0) && (aux < array[j-1]);j-- )
                {
                    array[j] = array[j-1];
                }
                array[i] = aux;
            }
            Console.Write($"\nQuantidade de comparações feitas: {compares}\nQuantidade de trocas feitas: {changes}\nVetor ordenado: ");
            for (int i = 0; i < number; i++)
            {
                Console.Write($"{array[i]} ");
            }

            return array;
        }
    }
    }

