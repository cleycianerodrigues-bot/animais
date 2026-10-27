﻿using System;
namespace SistemaZoo
{

    public class Animal
    {
      
        public string Nome { get; set; }
        public int Idade { get; set; }

  
        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public virtual void EmitirSom()
        {
            Console.WriteLine("O animal está emitindo um som genérico.");
        }
    }

 
    public class Cachorro : Animal
    {
 
        public Cachorro(string nome, int idade) : base(nome, idade)
        {
        }

   
        public override void EmitirSom()
        {
            Console.WriteLine("O cachorro está latindo: Au au!");
        }
    }


    public class Gato : Animal
    {
      
        public Gato(string nome, int idade) : base(nome, idade)
        {
        }

      
        public override void EmitirSom()
        {
            Console.WriteLine("O gato está miando: Miau!");
        }
    }

 
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE ANIMAIS ===\n");

 
            Cachorro cachorro = new Cachorro("Rex", 3);
            Gato gato = new Gato("Mimi", 2);

        
            List<Animal> listaDeAnimais = new List<Animal>
            {
                cachorro,
                gato
            };

          
            foreach (Animal animal in listaDeAnimais)
            {
                Console.WriteLine($"Animal: {animal.Nome}");
                Console.WriteLine($"Idade: {animal.Idade} anos");
                Console.Write("Som: ");
                animal.EmitirSom();
                Console.WriteLine();
            }

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}