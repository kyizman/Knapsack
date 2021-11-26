using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Knapsack;
namespace Knapsack
{
    class Genetic
    {
        private bool verbose = false;
        private bool mutation = false;
        private int crossover_count = 0;
        private int clone_count = 0;
        private int number_of_items = 0;
        private int population_size = 0;
        private int maximum_generations = 0;
        private int generation_counter = 1;
        private double knapsack_capacity = 0;
        private double prob_crossover = 0;
        private double prob_mutation = 0;
        private double total_fitness_of_generation = 0;

        ArrayList value_of_items = new ArrayList();
        ArrayList weight_of_items = new();
        ArrayList fitness = new();
        ArrayList best_fitness_of_generation = new();
        ArrayList mean_fitness_of_generation = new();
        ArrayList population = new();
        ArrayList breed_population = new();
        ArrayList best_solution_of_generation = new();




        /**  
         * Default constructor
         */
        public string KnapsackProblem(ArrayList itemslist, int bagsize)
        {

            ArrayList value_of_items = new ArrayList();
            ArrayList weight_of_items = new();
            ArrayList fitness = new();
            ArrayList best_fitness_of_generation = new();
            ArrayList mean_fitness_of_generation = new();
            ArrayList population = new();
            ArrayList breed_population = new();
            ArrayList best_solution_of_generation = new();

            int pop = itemslist.Count;
            foreach (items item in itemslist)
            {
                value_of_items.Add(item.value);
                weight_of_items.Add(item.weight);
            }

            for (int x = 0; x < 30; x++)
            {
                for (int z = 0; z < itemslist.Count; z++)
                {
                    population.Add(newgene(itemslist.Count));
                }

                



            }

            return null;


        }


        /**
         * Controls knapsack problem logic and creates first generation
         */



        public string newgene(int x)
        {
            StringBuilder genes = new StringBuilder(x);
            char y;
            Random random = new Random();
            for (int z = 0; z < x; z++)
            {
                if (random.Next(100) % 2 != 0)
                {
                    y = '1';
                }
                else
                {
                    y = '0';
                }

                genes.Append(y);
            }


            return genes.ToString();

        }


    }
}