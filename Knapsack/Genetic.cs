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
  

        public string KnapsackProblem(ArrayList itemslist, int bagsize)
        {
            string best = "";
            double fitnessbest = 0;
            double weightbetst = 0;
            double currentpopweight = 0;
            string[] fixformutationarray = new string[itemslist.Count];
            int currentpopvalue = 0;
            ArrayList value_of_items = new ArrayList();
            ArrayList weight_of_items = new();
       
            ArrayList population = new();

           string[] bestitems = new string[itemslist.Count];

            int[] bestfitness = new int[itemslist.Count];

            int pop = itemslist.Count;
            foreach (items item in itemslist)
            {
                value_of_items.Add(item.value);
                weight_of_items.Add(item.weight);
            }
            for (int z = 0; z < itemslist.Count; z++)
            {
                population.Add(newgene(itemslist.Count));
            }
          
            for (int x = 0; x < itemslist.Count; x++)
            {


                for (int w = 0; w < population.Count; w++)
                {
                     currentpopweight = 0;
                     currentpopvalue = 0;
                    char[] temp = population[w].ToString().ToCharArray();
                    for (int y=0;y< population[w].ToString().Length; y++)
                    {
                        

                       if(temp[y]=='1')
                        {
                            currentpopweight += (int)weight_of_items[w];
                            currentpopvalue += (int)value_of_items[w];

                        }
                    }

                    if(currentpopweight<=bagsize)
                    {
                        if(currentpopvalue>fitnessbest)
                        {
                            fitnessbest = currentpopvalue;
                            best = population[w].ToString();
                            weightbetst = currentpopweight;
                            bestfitness[w] = currentpopvalue;
                            bestitems[w] = best;
                        }
                    }

                    for(int p =0; p<bestfitness.Length;p++)
                    {

                        if(bestfitness[p] < fitnessbest/3 )
                        {
                            bestfitness[p] = 0;
                        }

                    }
                    

                    
                    
                   

                }
                int counter = 0;
                for(int q=0; q<bestitems.Length;q++)
                {

                    if(bestitems[q]!=null)
                    {
                        fixformutationarray[counter] = bestitems[q];
                        counter++;
                    }
                }

                population.Clear();

                string gene1 = "";
                string gene2 = "";

                Random random = new Random();

                for(int u=0; u<fixformutationarray.Length;u++)
                {
                    
                    if(u > fixformutationarray.Length-1 && fixformutationarray[u]!=null && fixformutationarray[u-1]!=null)
                    {
                        gene1 = bestitems[u].Substring(0, itemslist.Count/2);
                        gene2 = bestitems[u-1].Substring(itemslist.Count / 2,itemslist.Count-1);

                        if (random.Next(0, 10) > 5)
                        {


                            population.Add(gene1 + gene2);
                        }
                        else
                        {
                            if (random.Next(0, 10) > 5)
                            {
                                char[] temp1 = gene1.ToCharArray();
                                int selection = random.Next(0, temp1.Length);
                                if(temp1[selection] =='1')
                                {
                                    temp1[selection] = '0';
                                }
                                else
                                {
                                    temp1[selection] = '1';
                                }

                                gene1 = temp1.ToString();
                                population.Add(gene1 + gene2);
                            }

                            else
                            {
                                char[] temp2 = gene2.ToCharArray();
                                int selection = random.Next(0, temp2.Length);
                                if (temp2[selection] == '1')
                                {
                                    temp2[selection] = '0';
                                }
                                else
                                {
                                    temp2[selection] = '1';
                                }

                                gene2 = temp2.ToString();
                                population.Add(gene1 + gene2);
                            }
                        }

                    }

                    else if (fixformutationarray[u] != null && fixformutationarray[u +1] != null)
                    {
                        gene1 = fixformutationarray[u].Substring(0, itemslist.Count / 2);
                        gene2 = fixformutationarray[u + 1].Substring((itemslist.Count/2)+1);
                        if (random.Next(0, 10) > 5)
                        {


                            population.Add(gene1 + gene2);
                        }
                        else
                        {
                            if (random.Next(0, 10) > 5)
                            {
                                char[] temp1 = gene1.ToCharArray();
                                int selection = random.Next(0, temp1.Length);
                                if (temp1[selection] == '1')
                                {
                                    temp1[selection] = '0';
                                }
                                else
                                {
                                    temp1[selection] = '1';
                                }

                                gene1 = temp1.ToString();
                                population.Add(gene1 + gene2);
                            }

                            else
                            {
                                char[] temp2 = gene2.ToCharArray();
                                int selection = random.Next(0, temp2.Length);
                                if (temp2[selection] == '1')
                                {
                                    temp2[selection] = '0';
                                }
                                else
                                {
                                    temp2[selection] = '1';
                                }

                                gene2 = temp2.ToString();
                                population.Add(gene1 + gene2);
                            }
                        }
                    }
                }


                for (int y =0; y <bestitems.Length;y++)
                {
                   if(bestfitness[y] >0)
                    {
                        population.Add(bestitems[y]);
                    }
                    

                }
                //for (int z = population.Count; z < itemslist.Count; z++)
                //{
                //    population.Add(newgene(itemslist.Count));
                //}

                //population.Clear();
                //for (int z = 0; z < itemslist.Count; z++)
                //{
                //    population.Add(newgene(itemslist.Count));
                //}



            }

            return best;


        }


       




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