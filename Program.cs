//Franco Gregorio System;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Project__1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int chosenOne = 0;

            do
            {
                Console.Clear();
                SpinAnimation();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                              ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗                           ");
                Console.WriteLine("                             ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝                           ");
                Console.WriteLine("                             ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗                           ");
                Console.WriteLine("                             ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║                           ");
                Console.WriteLine("                             ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║                           ");
                Console.WriteLine("                              ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝                           ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("        ====================================================================================================           ");
                Console.WriteLine("        ||                                                                                                ||           ");
                Console.WriteLine("        ||                                            Genetics Menu:                                      ||           ");
                Console.WriteLine("        ||                                                                                                ||           ");
                Console.WriteLine("        ||                           [ 1 ] What is Genetics                                               ||           ");
                Console.WriteLine("        ||                           [ 2 ] Types of Genetic Inheritance                                   ||           ");
                Console.WriteLine("        ||                           [ 3 ] More Information About DNA and Genes                           ||           ");
                Console.WriteLine("        ||                           [ 4 ] Chromosomes and Their Function                                 ||           ");
                Console.WriteLine("        ||                           [ 5 ] Genetic Mutations                                              ||           ");
                Console.WriteLine("        ||                           [ 6 ] Gene Editing (CRISPR and Other Technologies)                   ||           ");
                Console.WriteLine("        ||                           [ 7 ] Human Genome Project                                           ||           ");
                Console.WriteLine("        ||                           [ 8 ] Epigenetics                                                    ||           ");
                Console.WriteLine("        ||                           [ 9 ] Evolution and Genetics                                         ||           ");
                Console.WriteLine("        ||                           [ 0 ] Exit                                                           ||           ");
                Console.WriteLine("        ||                                                                                                ||           ");
                Console.WriteLine("        ====================================================================================================           ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                                                                                                       ");
                Console.Write("                        Choose an option: ");
                chosenOne = Convert.ToInt32(Console.ReadLine());

                switch (chosenOne)
                {
                    case 1: WhatIsGenetics(); break;
                    case 2: TypesOfGeneticInheritance(); break;
                    case 3: MoreInfoAboutDNAAndGenes(); break;
                    case 4: ChromosomesAndTheirFunction(); break;
                    case 5: GeneticMutations(); break;
                    case 6: GeneEditing(); break;
                    case 7: HumanGenomeProject(); break;
                    case 8: Epigenetics(); break;
                    case 9: EvolutionAndGenetics(); break;
                    default:
                        break;
                }

            } while (chosenOne != 0);
        }


        static void SpinAnimation()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;

            string[] frames = new string[]
            {
            "        ====================================================================================================     \n" +
            "                                                  O     O          \n" +
            "                                                   \\   /          \n" +
            "                                                    O-O            \n" +
            "                                                   /   \\          \n" +
            "                                                  O     O          \n" +
            "                                                   \\   /          \n" +
            "                                                    O-O            \n" +
            "                                                   /   \\          \n" +
            "                                                  O     O          \n" +
            "                                                   \\   /          \n" +
            "                                                    O-O            \n" +
            "                                                   /   \\          \n" +
            "                                                  O     O          \n" +
            "                                                   \\   /          \n" +
            "                                                    O-O            \n" +
            "                                                   /   \\          \n" +
            "        ====================================================================================================  ",


            "        ====================================================================================================     \n" +
            "                                                   O     O         \n" +
            "                                                    \\   /         \n" +
            "                                                     O-O           \n" +
            "                                                    /   \\         \n" +
            "                                                   O     O         \n" +
            "                                                    \\   /         \n" +
            "                                                     O-O           \n" +
            "                                                    /   \\         \n" +
            "                                                   O     O         \n" +
            "                                                    \\   /         \n" +
            "                                                     O-O           \n" +
            "                                                    /   \\         \n" +
            "                                                   O     O         \n" +
            "                                                    \\   /         \n" +
            "                                                     O-O           \n" +
            "                                                    /   \\         \n" +
            "        ====================================================================================================  ",


            "        ====================================================================================================     \n" +
            "                                                    O     O        \n" +
            "                                                     \\   /        \n" +
            "                                                      O-O          \n" +
            "                                                     /   \\        \n" +
            "                                                    O     O        \n" +
            "                                                     \\   /        \n" +
            "                                                      O-O          \n" +
            "                                                     /   \\        \n" +
            "                                                    O     O        \n" +
            "                                                     \\   /        \n" +
            "                                                      O-O          \n" +
            "                                                     /   \\        \n" +
            "                                                    O     O        \n" +
            "                                                     \\   /        \n" +
            "                                                      O-O          \n" +
            "                                                     /   \\        \n" +
            "        ====================================================================================================  ",


            "        ====================================================================================================     \n" +
            "                                                   O     O         \n" +
            "                                                   \\   /          \n" +
            "                                                   O-O             \n" +
            "                                                   /   \\          \n" +
            "                                                   O     O         \n" +
            "                                                   \\   /          \n" +
            "                                                   O-O             \n" +
            "                                                   /   \\          \n" +
            "                                                   O     O         \n" +
            "                                                   \\   /          \n" +
            "                                                   O-O             \n" +
            "                                                   /   \\          \n" +
            "                                                   O     O         \n" +
            "                                                   \\   /          \n" +
            "                                                   O-O             \n" +
            "                                                   /   \\          \n" +
            "        ====================================================================================================  ",

            };

            for (int i = 0; i < 5; i++)
            {
                foreach (var frame in frames)
                {
                    Console.Clear(); // Cle the next frame
                    Console.WriteLine(frame);
                    Console.WriteLine("                                            Genetics Loading...");
                    Thread.Sleep(200); // Wait fo
                }
            }
            Console.Clear();
            Console.WriteLine("Genetics Menu Complete!");
        }


        static void WhatIsGenetics()
        {

            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                               ╦ ╦┬ ┬┌─┐┌┬┐  ┬┌─┐  ┌─┐┌─┐┌┐┌┌─┐┌┬┐┬┌─┐ ┌─┐                                 ");
            Console.WriteLine("                               ║║║├─┤├─┤ │   │└─┐  │ ┬├┤ │││├┤  │ ││    ┌┘                                 ");
            Console.WriteLine("                               ╚╩╝┴ ┴┴ ┴ ┴   ┴└─┘  └─┘└─┘┘└┘└─┘ ┴ ┴└─┘  o                                  ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||    Genetics is the branch of biology that studies genes, heredity, and genetic variation in    ||   ");
            Console.WriteLine("    ||       living organisms. Genes, made of DNA, are units of heredity passed from parents to       ||   ");
            Console.WriteLine("    ||      offspring, and they determine traits and characteristics. Genetics explains how these     ||   ");
            Console.WriteLine("    ||    traits are inherited, vary among populations, and can sometimes lead to genetic disorders.  ||   ");
            Console.WriteLine("    ||     This field also explores how genes interact with environmental factors, contributing to    ||   ");
            Console.WriteLine("    ||                                     the diversity of life                                      ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in main menu)                                   ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void TypesOfGeneticInheritance()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                AnimateGeneticInheritance();
                Console.Clear();
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                              ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗                           ");
                Console.WriteLine("                             ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝                           ");
                Console.WriteLine("                             ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗                           ");
                Console.WriteLine("                             ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║                           ");
                Console.WriteLine("                             ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║                           ");
                Console.WriteLine("                              ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝                           ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("        ====================================================================================================           ");
                Console.WriteLine("        ||                                                                                                ||           ");
                Console.WriteLine("        ||                                        Types of Genetic Inheritance                            ||           ");
                Console.WriteLine("        ||                                                                                                ||           ");
                Console.WriteLine("        ||                           [ 1 ] Dominant Inheritance                                           ||           ");
                Console.WriteLine("        ||                           [ 2 ] Recessive Inheritance                                          ||           ");
                Console.WriteLine("        ||                           [ 3 ] Co-Dominance                                                   ||           ");
                Console.WriteLine("        ||                           [ 4 ] Incomplete Dominance                                           ||           ");
                Console.WriteLine("        ||                           [ 5 ] Sex-Linked Inheritance                                         ||           ");
                Console.WriteLine("        ||                           [ 6 ] Mitochondrial Inheritance                                      ||           ");
                Console.WriteLine("        ||                           [ 0 ] Go Back                                                        ||           ");
                Console.WriteLine("        ||                                                                                                ||           ");
                Console.WriteLine("        ====================================================================================================           ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                                                                                                       ");
                Console.Write("                        Choose an option: ");

                subOption = Convert.ToInt32(Console.ReadLine());

                switch (subOption)
                {
                    case 1: Inheritance1(); break;
                    case 2: Inheritance2(); break;
                    case 3: Inheritance3(); break;
                    case 4: Inheritance4(); break;
                    case 5: Inheritance5(); break;
                    case 6: Inheritance6(); break;
                    default:
                        break;
                }

            } while (subOption != 0);
        }

        static void AnimateGeneticInheritance()
        {
            string[] frames = new string[]
            {
"        ====================================================================================================     \n" +
    "                           Parent 1 (Alleles: A, a)          Parent 2 (Alleles: A, a)\n" +
    "                                  |                                  |\n" +
    "                                  |                                  |\n" +
    "                                  |                                  |\n" +
    "                                  |                                  |\n" +
    "                                  [A]                                [a]\n" +
    "        ====================================================================================================  ",

    "        ====================================================================================================  \n" +
    "                           Parent 1 (Alleles: A, a)          Parent 2 (Alleles: A, a)\n" +
    "                                   |                                  |\n" +
    "                                   |                                  |\n" +
    "                                   |                                  |\n" +
    "                                   |                                  |\n" +
    "                                  [A]                                [a]\n" +
    "                                    \\                                /\n" +
    "                                     \\                              /\n" +
    "                                      \\                            /\n" +
    "                                       \\                          /\n" +
    "                                         \\                        /\n" +
    "                                         Offspring Alleles: [A, a]\n" +
    "        ====================================================================================================  ",

    "        ====================================================================================================  \n" +
    "                           Parent 1 (Alleles: A, a)          Parent 2 (Alleles: A, a)\n" +
    "                                   |                                  |\n" +
    "                                  [A]                                [A]\n" +
    "                                    \\                                /\n" +
    "                                     \\                              /\n" +
    "                                      \\                            /\n" +
    "                                       \\                          /\n" +
    "                                         Offspring Alleles: [A, A]\n" +
    "        ====================================================================================================  ",

    "        ====================================================================================================  \n" +
    "                           Parent 1 (Alleles: A, a)          Parent 2 (Alleles: A, a)\n" +
    "                                   |                                  |\n" +
    "                                  [a]                                [A]\n" +
    "                                    \\                                /\n" +
    "                                     \\                              /\n" +
    "                                      \\                            /\n" +
    "                                       \\                          /\n" +
    "                                         Offspring Alleles: [a, A]\n" +
    "        ====================================================================================================  ",

    "        ====================================================================================================  \n" +
    "                           Parent 1 (Alleles: A, a)          Parent 2 (Alleles: A, a)\n" +
    "                                   |                                  |\n" +
    "                                  [a]                                [a]\n" +
    "                                    \\                                /\n" +
    "                                     \\                              /\n" +
    "                                      \\                            /\n" +
    "                                       \\                          /\n" +
    "                                         Offspring Alleles: [a, a]\n" +
    "        ====================================================================================================  ",

            };

            for (int i = 0; i < 1; i++)
            {
                foreach (var frame in frames)
                {
                    Console.Clear();
                    Console.WriteLine(frame);
                    Console.WriteLine("");
                    Console.WriteLine("                                        Genetic Inheritance Loading...");
                    Thread.Sleep(1000);
                }
            }
            Console.Clear();
            Console.WriteLine("Genetic Inheritance Complete!");

        }

        static void Inheritance1()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                           ╔╦╗┌─┐┌┬┐┬┌┐┌┌─┐┌┐┌┌┬┐  ╦┌┐┌┬ ┬┌─┐┬─┐┬┌┬┐┌─┐┌┐┌┌─┐┌─┐                           ");
            Console.WriteLine("                            ║║│ ││││││││├─┤│││ │   ║│││├─┤├┤ ├┬┘│ │ ├─┤││││  ├┤                            ");
            Console.WriteLine("                           ═╩╝└─┘┴ ┴┴┘└┘┴ ┴┘└┘ ┴   ╩┘└┘┴ ┴└─┘┴└─┴ ┴ ┴ ┴┘└┘└─┘└─┘                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||      In dominant inheritance, only one copy of a dominant allele (a version of a gene) is      ||   ");
            Console.WriteLine("    ||     needed for a trait to appear in an individual. In genetic terms, this allele dominates     ||   ");
            Console.WriteLine("    ||     over the recessive allele, meaning that even if an individual inherits only one copy of    ||   ");
            Console.WriteLine("    ||    the dominant allele from one parent, they will express the trait associated with it. This   ||   ");
            Console.WriteLine("    ||         pattern of inheritance is common in many genetic disorders and traits.                 ||   ");
            Console.WriteLine("    ||                                     the diversity of life.                                     ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void Inheritance2()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                       ╦═╗┌─┐┌─┐┌─┐┌─┐┌─┐┬┬  ┬┌─┐  ╦┌┐┌┬ ┬┌─┐┬─┐┬┌┬┐┌─┐┌┐┌┌─┐┌─┐                           ");
            Console.WriteLine("                       ╠╦╝├┤ │  ├┤ └─┐└─┐│└┐┌┘├┤   ║│││├─┤├┤ ├┬┘│ │ ├─┤││││  ├┤                            ");
            Console.WriteLine("                       ╩╚═└─┘└─┘└─┘└─┘└─┘┴ └┘ └─┘  ╩┘└┘┴ ┴└─┘┴└─┴ ┴ ┴ ┴┘└┘└─┘└─┘                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||    Recessive inheritance occurs when a trait is expressed only if an individual inherits two   ||   ");
            Console.WriteLine("    ||    copies of a recessive allele, one from each parent. If both parents carry one recessive     ||   ");
            Console.WriteLine("    ||    allele for a trait (making them heterozygous), they are typically asymptomatic carriers,    ||   ");
            Console.WriteLine("    ||    meaning they do not exhibit the trait themselves but can pass it on to their offspring.     ||   ");
            Console.WriteLine("    ||    For an offspring to show the recessive trait, they must inherit the recessive allele from   ||   ");
            Console.WriteLine("    ||                  each parent, resulting in a homozygous recessive genotype.                    ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void Inheritance3()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                      ╔═╗┌─┐  ┌┬┐┌─┐┌┬┐┬┌┐┌┌─┐┌┐┌┌─┐┌─┐                                    ");
            Console.WriteLine("                                      ║  │ │───│││ ││││││││├─┤││││  ├┤                                     ");
            Console.WriteLine("                                      ╚═╝└─┘  ─┴┘└─┘┴ ┴┴┘└┘┴ ┴┘└┘└─┘└─┘                                    ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||    Co-dominance is a form of genetic inheritance where both alleles in a gene pair are fully   ||   ");
            Console.WriteLine("    ||    expressed in the phenotype of a heterozygous individual, without one being dominant over    ||   ");
            Console.WriteLine("    ||    the other. This results in a phenotype that clearly shows both traits side-by-side, rather  ||   ");
            Console.WriteLine("    ||                                      than blending them.                                       ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");

            Console.ReadKey();
        }

        static void Inheritance4()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                            ╦┌┐┌┌─┐┌─┐┌┬┐┌─┐┬  ┌─┐┌┬┐┌─┐  ╔╦╗┌─┐┌┬┐┬┌┐┌┌─┐┌┐┌┌─┐┌─┐                        ");
            Console.WriteLine("                            ║││││  │ ││││├─┘│  ├┤  │ ├┤    ║║│ ││││││││├─┤││││  ├┤                         ");
            Console.WriteLine("                            ╩┘└┘└─┘└─┘┴ ┴┴  ┴─┘└─┘ ┴ └─┘  ═╩╝└─┘┴ ┴┴┘└┘┴ ┴┘└┘└─┘└─┘                        ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||    Incomplete dominance is when two different alleles combine and create a blended trait in    ||   ");
            Console.WriteLine("    ||          the offspring, rather than one trait hiding the other or both showing fully.          ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");


            Console.ReadKey();
        }

        static void Inheritance5()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                          ╔═╗┌─┐─┐ ┬   ┬  ┬┌┐┌┬┌─┌─┐┌┬┐                                    ");
            Console.WriteLine("                                          ╚═╗├┤ ┌┴┬┘───│  ││││├┴┐├┤  ││                                    ");
            Console.WriteLine("                                          ╚═╝└─┘┴ └─   ┴─┘┴┘└┘┴ ┴└─┘─┴┘                                    ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||    Sex-linked inheritance refers to genes located on the sex chromosomes (X and Y). Traits     ||   ");
            Console.WriteLine("    ||     associated with these genes are inherited differently in males and females due to the      ||   ");
            Console.WriteLine("    ||             difference in their sex chromosomes (XX for females and XY for males).             ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void Inheritance6()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                   ╔╦╗┬┌┬┐┌─┐┌─┐┬ ┬┌─┐┌┐┌┌┬┐┬─┐┬┌─┐┬    ╦┌┐┌┬ ┬┌─┐┬─┐┬┌┬┐┌─┐┌┐┌┌─┐┌─┐                      ");
            Console.WriteLine("                   ║║║│ │ │ ││  ├─┤│ ││││ ││├┬┘│├─┤│    ║│││├─┤├┤ ├┬┘│ │ ├─┤││││  ├┤                       ");
            Console.WriteLine("                   ╩ ╩┴ ┴ └─┘└─┘┴ ┴└─┘┘└┘─┴┘┴└─┴┴ ┴┴─┘  ╩┘└┘┴ ┴└─┘┴└─┴ ┴ ┴ ┴┘└┘└─┘└─┘                      ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||    Mitochondrial inheritance, also known as maternal inheritance, refers to the transmission   ||   ");
            Console.WriteLine("    ||    of genes located in the mitochondria, which are small energy-producing structures outside   ||   ");
            Console.WriteLine("    ||      the nucleus of cells. Mitochondrial DNA (mtDNA) is inherited only from the mother, as     ||   ");
            Console.WriteLine("    ||                mitochondria in sperm are typically lost during fertilization.                  ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void MoreInfoAboutDNAAndGenes()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                AnimateDNAAndGenes();
                Console.Clear();
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                              ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗                           ");
                Console.WriteLine("                             ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝                           ");
                Console.WriteLine("                             ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗                           ");
                Console.WriteLine("                             ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║                           ");
                Console.WriteLine("                             ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║                           ");
                Console.WriteLine("                              ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝                           ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("        ====================================================================================================           ");
                Console.WriteLine("        ||                                                                                                ||           ");
                Console.WriteLine("        ||                                            Genetics Menu:                                      ||           ");
                Console.WriteLine("        ||                                                                                                ||           ");
                Console.WriteLine("        ||                           [ 1 ] What is Genetics                                               ||           ");
                Console.WriteLine("        ||                           [ 2 ] Types of Genetic Inheritance                                   ||           ");
                Console.WriteLine("        ||                           [ 3 ] More Information About DNA and Genes                           ||           ");
                Console.WriteLine("        ||                           [ 4 ] Chromosomes and Their Function                                 ||           ");
                Console.WriteLine("        ||                           [ 5 ] Genetic Mutations                                              ||           ");
                Console.WriteLine("        ||                           [ 6 ] Gene Editing (CRISPR and Other Technologies)                   ||           ");
                Console.WriteLine("        ||                           [ 7 ] Human Genome Project                                           ||           ");
                Console.WriteLine("        ||                           [ 8 ] Epigenetics                                                    ||           ");
                Console.WriteLine("        ||                           [ 9 ] Evolution and Genetics                                         ||           ");
                Console.WriteLine("        ||                           [ 0 ] Exit                                                           ||           ");
                Console.WriteLine("        ||                                                                                                ||           ");
                Console.WriteLine("        ====================================================================================================           ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                                                                                                       ");
                Console.Write("                        Choose an option: ");

                subOption = Convert.ToInt32(Console.ReadLine());

                switch (subOption)
                {
                    case 1: DNAIntroduction(); break;
                    case 2: GenesFunctions(); break;
                    case 3: DNAReplication(); break;
                    case 4: GeneExpression(); break;
                    case 5: GeneticVariation(); break;
                    case 6: InheritancePatterns(); break;
                    case 7: GeneticTechnologies(); break;
                    case 8: HumanGenomeProjectInfo(); break;
                    case 9: EthicalConsiderations(); break;
                    case 10: FutureGenetics(); break;
                    default:
                        break;
                }

            } while (subOption != 0);
        }

        static void AnimateDNAAndGenes()
        {
            // A the DNA helix with gene sequences
            string[] frames = new string[]
            {

            "        ====================================================================================================  \n" +
            "                                                  A       T\n" +
            "                                                   \\     /\n" +
            "                                                    \\   /\n" +
            "                                                     C-G\n" +
            "                                                    /   \\\n" +
            "                                                   /     \\\n" +
            "                                                  T       A\n"+
            "        ====================================================================================================  ",


            "        ====================================================================================================  \n" +
            "                                                  C       G\n" +
            "                                                   \\     /\n" +
            "                                                    \\   /\n" +
            "                                                     T-A\n" +
            "                                                    /   \\\n" +
            "                                                   /     \\\n" +
            "                                                  A       T\n"+
            "        ====================================================================================================  ",


            "        ====================================================================================================  \n" +
            "                                                  T       A\n" +
            "                                                   \\     /\n" +
            "                                                    \\   /\n" +
            "                                                     G-C\n" +
            "                                                    /   \\\n" +
            "                                                   /     \\\n" +
            "                                                  C       G\n"+
            "        ====================================================================================================  ",


            "        ====================================================================================================  \n" +
            "                                                  G       C\n" +
            "                                                   \\     /\n" +
            "                                                    \\   /\n" +
            "                                                     A-T\n" +
            "                                                    /   \\\n" +
            "                                                   /     \\\n" +
            "                                                  T       A \n" +
            "        ====================================================================================================  "
            };

            // Loop create the animation effect
            for (int i = 0; i < 3; i++) // Repea a longer animation
            {
                foreach (var frame in frames)
                {
                    Console.Clear();
                    Console.WriteLine(frame);
                    Console.WriteLine("                                            DNA and Genes Loading..");
                    Thread.Sleep(500); // Delay control animation speed
                }
            }
            Console.Clear();
            Console.WriteLine("DNA and Genes Complete!");

        }

        static void DNAIntroduction()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                          ╦┌┐┌┌┬┐┬─┐┌─┐┌┬┐┬ ┬┌─┐┌┬┐┬┌─┐┌┐┌  ┌┬┐┌─┐  ╔╦╗╔╗╔╔═╗                              ");
            Console.WriteLine("                          ║│││ │ ├┬┘│ │ │││ ││   │ ││ ││││   │ │ │   ║║║║║╠═╣                              ");
            Console.WriteLine("                          ╩┘└┘ ┴ ┴└─└─┘─┴┘└─┘└─┘ ┴ ┴└─┘┘└┘   ┴ └─┘  ═╩╝╝╚╝╩ ╩                              ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||     DNA, or deoxyribonucleic acid, is the molecule that contains the genetic information       ||   ");
            Console.WriteLine("    ||    necessary for life. It’s found in nearly all living organisms, serving as the blueprint     ||   ");
            Console.WriteLine("    ||    for building, maintaining, and replicating cells. DNA resides mainly in the cell nucleus    ||   ");
            Console.WriteLine("    ||    (in eukaryotic cells) and carries instructions for protein synthesis, which determines an   ||   ");
            Console.WriteLine("    ||                      organism's structure, function, and development.                          ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");

            Console.ReadKey();
        }

        static void GenesFunctions()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                     ╔═╗┌─┐┌┐┌┌─┐┌─┐  ┌─┐┌┐┌┌┬┐  ╔╦╗┬ ┬┌─┐┬┬─┐  ╔═╗┬ ┬┌┐┌┌─┐┌┬┐┬┌─┐┌┐┌┌─┐                  ");
            Console.WriteLine("                     ║ ╦├┤ │││├┤ └─┐  ├─┤│││ ││   ║ ├─┤├┤ │├┬┘  ╠╣ │ │││││   │ ││ ││││└─┐                  ");
            Console.WriteLine("                     ╚═╝└─┘┘└┘└─┘└─┘  ┴ ┴┘└┘─┴┘   ╩ ┴ ┴└─┘┴┴└─  ╚  └─┘┘└┘└─┘ ┴ ┴└─┘┘└┘└─┘                  ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||     Genes are segments of DNA that act as instructions for building proteins and regulating    ||   ");
            Console.WriteLine("    ||   various biological processes within an organism. Each gene is made up of a specific sequence ||   ");
            Console.WriteLine("    ||    of nucleotide bases (adenine, thymine, cytosine, and guanine), which determines its unique  ||   ");
            Console.WriteLine("    ||                         function and the specific proteins it produces.                        ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");

            Console.ReadKey();
        }

        static void DNAReplication()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                  ╔╦╗╔╗╔╔═╗  ╦═╗┌─┐┌─┐┬  ┬┌─┐┌─┐┌┬┐┬┌─┐┌┐┌                                 ");
            Console.WriteLine("                                   ║║║║║╠═╣  ╠╦╝├┤ ├─┘│  ││  ├─┤ │ ││ ││││                                 ");
            Console.WriteLine("                                  ═╩╝╝╚╝╩ ╩  ╩╚═└─┘┴  ┴─┘┴└─┘┴ ┴ ┴ ┴└─┘┘└┘                                 ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||     DNA replication is the process by which a cell makes an identical copy of its DNA,         ||   ");
            Console.WriteLine("    ||   ensuring that each new cell receives the same genetic information as the original. This      ||   ");
            Console.WriteLine("    ||   process is essential during cell division, allowing genetic information to be passed on      ||   ");
            Console.WriteLine("    ||                  accurately from one generation of cells to the next.                          ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void GeneExpression()
        {
            Console.Clear();
            Console.WriteLine("Gene Expression and Regulation");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("             ╔═╗┌─┐┌┐┌┌─┐  ╔═╗─┐ ┬┌─┐┬─┐┌─┐┌─┐┌─┐┬┌─┐┌┐┌  ┌─┐┌┐┌┌┬┐  ╦═╗┌─┐┌─┐┬ ┬┬  ┌─┐┌┬┐┬┌─┐┌┐┌          ");
            Console.WriteLine("             ║ ╦├┤ │││├┤   ║╣ ┌┴┬┘├─┘├┬┘├┤ └─┐└─┐││ ││││  ├─┤│││ ││  ╠╦╝├┤ │ ┬│ ││  ├─┤ │ ││ ││││          ");
            Console.WriteLine("             ╚═╝└─┘┘└┘└─┘  ╚═╝┴ └─┴  ┴└─└─┘└─┘└─┘┴└─┘┘└┘  ┴ ┴┘└┘─┴┘  ╩╚═└─┘└─┘└─┘┴─┘┴ ┴ ┴ ┴└─┘┘└┘          ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||      Gene expression and regulation refer to the processes by which genes are activated,       ||   ");
            Console.WriteLine("    ||     transcribed, and translated into proteins, and the mechanisms that control when, where,    ||   ");
            Console.WriteLine("    ||      and how much of a gene product (usually a protein) is made. Proper gene regulation is     ||   ");
            Console.WriteLine("    ||               essential for development, adaptation, and cellular function.                    ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void GeneticVariation()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("             ╔═╗┌─┐┌┐┌┌─┐  ╔═╗─┐ ┬┌─┐┬─┐┌─┐┌─┐┌─┐┬┌─┐┌┐┌  ┌─┐┌┐┌┌┬┐  ╦═╗┌─┐┌─┐┬ ┬┬  ┌─┐┌┬┐┬┌─┐┌┐┌          ");
            Console.WriteLine("             ║ ╦├┤ │││├┤   ║╣ ┌┴┬┘├─┘├┬┘├┤ └─┐└─┐││ ││││  ├─┤│││ ││  ╠╦╝├┤ │ ┬│ ││  ├─┤ │ ││ ││││          ");
            Console.WriteLine("             ╚═╝└─┘┘└┘└─┘  ╚═╝┴ └─┴  ┴└─└─┘└─┘└─┘┴└─┘┘└┘  ┴ ┴┘└┘─┴┘  ╩╚═└─┘└─┘└─┘┴─┘┴ ┴ ┴ ┴└─┘┘└┘          ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||      Gene expression and regulation refer to the processes by which genes are activated,       ||   ");
            Console.WriteLine("    ||     transcribed, and translated into proteins, and the mechanisms that control when, where,    ||   ");
            Console.WriteLine("    ||      and how much of a gene product (usually a protein) is made. Proper gene regulation is     ||   ");
            Console.WriteLine("    ||               essential for development, adaptation, and cellular function.                    ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");

            Console.ReadKey();
        }

        static void InheritancePatterns()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                          ╦┌┐┌┬ ┬┌─┐┬─┐┬┌┬┐┌─┐┌┐┌┌─┐┌─┐  ╔═╗┌─┐┌┬┐┌┬┐┌─┐┬─┐┌┐┌┌─┐                          ");
            Console.WriteLine("                          ║│││├─┤├┤ ├┬┘│ │ ├─┤││││  ├┤   ╠═╝├─┤ │  │ ├┤ ├┬┘│││└─┐                          ");
            Console.WriteLine("                          ╩┘└┘┴ ┴└─┘┴└─┴ ┴ ┴ ┴┘└┘└─┘└─┘  ╩  ┴ ┴ ┴  ┴ └─┘┴└─┘└┘└─┘                          ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||        Inheritance patterns describe how genetic traits and conditions are passed from one     ||   ");
            Console.WriteLine("    ||         generation to the next. These patterns are determined by the location of the gene      ||   ");
            Console.WriteLine("    ||     (whether on autosomal or sex chromosomes) and whether the trait is dominant, recessive, or ||   ");
            Console.WriteLine("    ||                    follows other specific inheritance mechanisms.                              ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void GeneticTechnologies()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                           ╔═╗┌─┐┌┐┌┌─┐┌┬┐┬┌─┐  ╔╦╗┌─┐┌─┐┬ ┬┌┐┌┌─┐┬  ┌─┐┌─┐┬┌─┐┌─┐                         ");
            Console.WriteLine("                           ║ ╦├┤ │││├┤  │ ││     ║ ├┤ │  ├─┤││││ ││  │ ││ ┬│├┤ └─┐                         ");
            Console.WriteLine("                           ╚═╝└─┘┘└┘└─┘ ┴ ┴└─┘   ╩ └─┘└─┘┴ ┴┘└┘└─┘┴─┘└─┘└─┘┴└─┘└─┘                         ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||   Genetic technologies are techniques and tools developed to manipulate, analyze, and modify   ||   ");
            Console.WriteLine("    ||  genes and genetic material. These technologies play a critical role in medicine, agriculture, ||   ");
            Console.WriteLine("    ||    forensics, and biological research, enabling advances in areas like gene therapy, disease   ||   ");
            Console.WriteLine("    ||                             diagnostics, and genetic engineering.                              ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void HumanGenomeProjectInfo()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                          ╦ ╦┬ ┬┌┬┐┌─┐┌┐┌  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┌─┐  ╔═╗┬─┐┌─┐ ┬┌─┐┌─┐┌┬┐                        ");
            Console.WriteLine("                          ╠═╣│ ││││├─┤│││  ║ ╦├┤ ││││ ││││├┤   ╠═╝├┬┘│ │ │├┤ │   │                         ");
            Console.WriteLine("                          ╩ ╩└─┘┴ ┴┴ ┴┘└┘  ╚═╝└─┘┘└┘└─┘┴ ┴└─┘  ╩  ┴└─└─┘└┘└─┘└─┘ ┴                         ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||    The Human Genome Project (HGP) was an international research initiative with the primary    ||   ");
            Console.WriteLine("    ||       goal of mapping and understanding all the genes in human DNA. Launched in 1990 and       ||   ");
            Console.WriteLine("    ||       completed in 2003, it aimed to identify the sequence of the approximately 3 billion      ||   ");
            Console.WriteLine("    ||       nucleotide base pairs that make up human DNA, effectively providing a comprehensive      ||   ");
            Console.WriteLine("    ||                                   reference for the human genome.                              ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void EthicalConsiderations()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("          ╔═╗┌┬┐┬ ┬┬┌─┐┌─┐┬    ╔═╗┌─┐┌┐┌┌─┐┬┌┬┐┌─┐┬─┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐  ┬┌┐┌  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┬┌─┐┌─┐        ");
            Console.WriteLine("          ║╣  │ ├─┤││  ├─┤│    ║  │ ││││└─┐│ ││├┤ ├┬┘├─┤ │ ││ ││││└─┐  ││││  ║ ╦├┤ │││├┤  │ ││  └─┐        ");
            Console.WriteLine("          ╚═╝ ┴ ┴ ┴┴└─┘┴ ┴┴─┘  ╚═╝└─┘┘└┘└─┘┴─┴┘└─┘┴└─┴ ┴ ┴ ┴└─┘┘└┘└─┘  ┴┘└┘  ╚═╝└─┘┘└┘└─┘ ┴ ┴└─┘└─┘        ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||    Genetic research and technologies, including gene editing, genetic testing, and cloning,    ||   ");
            Console.WriteLine("    ||     bring about significant ethical considerations. These involve questions about privacy,     ||   ");
            Console.WriteLine("    ||    fairness, human rights, and potential societal impacts. As genetics advances, so do the     ||   ");
            Console.WriteLine("    ||    ethical complexities surrounding its application, calling for careful consideration of      ||   ");
            Console.WriteLine("    ||                    how genetic information and interventions are used.                         ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void FutureGenetics()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                              ╔═╗┬ ┬┌┬┐┬ ┬┬─┐┌─┐  ┌─┐┌─┐  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┬┌─┐┌─┐                           ");
            Console.WriteLine("                              ╠╣ │ │ │ │ │├┬┘├┤   │ │├┤   ║ ╦├┤ │││├┤  │ ││  └─┐                           ");
            Console.WriteLine("                              ╚  └─┘ ┴ └─┘┴└─└─┘  └─┘└    ╚═╝└─┘┘└┘└─┘ ┴ ┴└─┘└─┘                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||    The future of genetics holds immense potential for breakthroughs in medicine, agriculture,  ||   ");
            Console.WriteLine("    ||    environmental conservation, and personalized healthcare. As technologies in gene editing,   ||   ");
            Console.WriteLine("    ||    sequencing, and synthetic biology advance, genetics is likely to transform various fields,  ||   ");
            Console.WriteLine("    ||     ushering in new treatments, enhanced understanding of complex biological processes, and    ||   ");
            Console.WriteLine("    ||                                    ethical challenges.                                         ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void ChromosomesAndTheirFunction()
        {

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("             ╔═╗┬ ┬┬─┐┌─┐┌┬┐┌─┐┌─┐┌─┐┌┬┐┌─┐┌─┐  ┌─┐┌┐┌┌┬┐  ╔╦╗┬ ┬┌─┐┬┬─┐  ╔═╗┬ ┬┌┐┌┌─┐┌┬┐┬┌─┐┌┐┌           ");
            Console.WriteLine("             ║  ├─┤├┬┘│ │││││ │└─┐│ ││││├┤ └─┐  ├─┤│││ ││   ║ ├─┤├┤ │├┬┘  ╠╣ │ │││││   │ ││ ││││           ");
            Console.WriteLine("             ╚═╝┴ ┴┴└─└─┘┴ ┴└─┘└─┘└─┘┴ ┴└─┘└─┘  ┴ ┴┘└┘─┴┘   ╩ ┴ ┴└─┘┴┴└─  ╚  └─┘┘└┘└─┘ ┴ ┴└─┘┘└┘           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ||   Chromosomes are thread-like structures located in the nucleus of cells, composed of DNA      ||   ");
            Console.WriteLine("    ||   and proteins that play a crucial role in heredity and cellular functions. Each chromosome    ||   ");
            Console.WriteLine("    ||   contains genes, which determine an organism's traits, and is made up of DNA wrapped around   ||   ");
            Console.WriteLine("    ||      proteins called histones. They consist of two identical halves, or sister chromatids,     ||   ");
            Console.WriteLine("    ||      connected at the centromere, and have protective caps called telomeres at their ends.     ||   ");
            Console.WriteLine("    ||          Chromosomes ensure accurate genetic material distribution during cell division        ||   ");
            Console.WriteLine("    ||      (mitosis and meiosis), regulate gene activity, enhance genetic diversity through the      ||   ");
            Console.WriteLine("    ||     shuffling of genetic material, and pass traits from parents to offspring. Additionally,    ||   ");
            Console.WriteLine("    ||     possess mechanisms to repair DNA damage, maintaining genetic stability and integrity.      ||   ");
            Console.WriteLine("    ||                                                                                                ||   ");
            Console.WriteLine("    ====================================================================================================   ");
            Console.WriteLine("                                                                                                           ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                        ");
            Console.WriteLine("                                                                                                           ");
            Console.ReadKey();
        }

        static void GeneticMutations()
        {
            int subOption = 0;

            do
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                AnimateGeneticMutations();
                Console.Clear();
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                              ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗                           ");
                Console.WriteLine("                             ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝                           ");
                Console.WriteLine("                             ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗                           ");
                Console.WriteLine("                             ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║                           ");
                Console.WriteLine("                             ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║                           ");
                Console.WriteLine("                              ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝                           ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("        ==================================================================================================          ");
                Console.WriteLine("        ||                                                                                               ||         ");
                Console.WriteLine("        ||                                       Genetic Mutations:                                      ||         ");
                Console.WriteLine("        ||                                                                                               ||         ");
                Console.WriteLine("        ||                                 [ 1 ] Types of Mutations                                      ||         ");
                Console.WriteLine("        ||                                 [ 2 ] Causes of Mutations                                     ||         ");
                Console.WriteLine("        ||                                 [ 3 ] Effects of Mutations                                    ||         ");
                Console.WriteLine("        ||                                 [ 0 ] Go Back                                                 ||         ");
                Console.WriteLine("        ||                                                                                               ||         ");
                Console.WriteLine("        ==================================================================================================          ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                                                                                                       ");
                Console.Write("                               Choose an option: ");

                subOption = Convert.ToInt32(Console.ReadLine());

                switch (subOption)
                {
                    case 1: TypesOfMutations(); break;
                    case 2: CausesOfMutations(); break;
                    case 3: EffectsOfMutations(); break;
                    default:
                        break;
                }

            } while (subOption != 0);
        }


        static void AnimateGeneticMutations()
        {
            //  demonstrate genetic mutations using symbols
            string[] frames = new string[]
             {
            "        ====================================================================================================  \n" +
            "                                              Original DNA Sequence:\n" +
            "                                                A-T  C-G  A-T  G-C\n" +
            "                                                 |    |    |    |\n" +
            "                                                 |    |    |    |\n" +
            "                                                 A    T    A    G\n"+
            "        ====================================================================================================  ",


            "        ====================================================================================================  \n" +
            "                                              Mutation 1:\n" +
            "                                                A-T  C-G  A-T  G-C\n" +
            "                                                 |    |    |    |\n" +
            "                                                 |    |    |    |\n" +
            "                                                 A    T    G    G\n" +
            "                                                 (A-T changed to A-G)\n" +
            "        ====================================================================================================  ",


            "        ====================================================================================================  \n" +
            "                                              Mutation 2:\n" +
            "                                                A-T  C-G  A-T  G-C\n" +
            "                                                 |    |    |    |\n" +
            "                                                 |    |    |    |\n" +
            "                                                 A    T    G    T\n" +
            "                                                 (C-G changed to T-A)\n" +
            "        ====================================================================================================  ",


            "        ====================================================================================================  \n" +

            "                                              Mutation 3:\n" +
            "                                                A-T  C-G  A-T  G-C\n" +
            "                                                 |    |    |    |\n" +
            "                                                 |    |    |    |\n" +
            "                                                 T    T    G    T\n" +
            "                                                 (A-T changed to T-T)\n" +
            "        ====================================================================================================  ",


            "        ====================================================================================================  \n" +
            "                                              Final Mutated DNA Sequence:\n" +
            "                                                T-T  T-A  G-T  G-C\n" +
            "                                                 |    |    |    |\n" +
            "                                                 |    |    |    |\n" +
            "                                                 T    A    G    C\n" +
            "        ====================================================================================================  ",


        };

            // Loop create the animation effect
            for (int i = 0; i < 2; i++) // Repea a longer animation
            {
                foreach (var frame in frames)
                {
                    Console.Clear();
                    Console.WriteLine(frame);
                    Console.WriteLine("                                                Genetic Mutations Loading...");
                    Thread.Sleep(1000); // Delay control animation speed
                }
            }
            Console.Clear();
            Console.WriteLine("Genetic Mutations Complete!");
        }

        static void TypesOfMutations()
        {
            int subOption = 0; // In-zero value to enter the loop

            do
            {
                Console.Clear();
                Console.WriteLine("                                                                                                                        ");
                Console.WriteLine("                                    ╔═╗┌─┐┌┐┌┌─┐┌┬┐┬┌─┐  ╔╦╗┬ ┬┌┬┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐                                      ");
                Console.WriteLine("                                    ║ ╦├┤ │││├┤  │ ││    ║║║│ │ │ ├─┤ │ ││ ││││└─┐                                      ");
                Console.WriteLine("                                    ╚═╝└─┘┘└┘└─┘ ┴ ┴└─┘  ╩ ╩└─┘ ┴ ┴ ┴ ┴ ┴└─┘┘└┘└─┘                                      ");
                Console.WriteLine("                                                                                                                        ");
                Console.WriteLine("        ==================================================================================================           ");
                Console.WriteLine("        ||                                                                                              ||           ");
                Console.WriteLine("        ||                                     Genetic Mutations:                                       ||           ");
                Console.WriteLine("        ||                                                                                              ||           ");
                Console.WriteLine("        ||                                [ 1 ] Point Mutations                                         ||           ");
                Console.WriteLine("        ||                                [ 2 ] Frameshift Mutations                                    ||           ");
                Console.WriteLine("        ||                                [ 3 ] Silent Mutations                                        ||           ");
                Console.WriteLine("        ||                                [ 4 ] Missense Mutations                                      ||           ");
                Console.WriteLine("        ||                                [ 5 ] Nonsense Mutations                                      ||           ");
                Console.WriteLine("        ||                                [ 6 ] Chromosomal Mutations                                   ||           ");
                Console.WriteLine("        ||                                [ 0 ] Go Back                                                 ||           ");
                Console.WriteLine("        ||                                                                                              ||           ");
                Console.WriteLine("        ==================================================================================================           ");
                Console.WriteLine("                                                                                                                        ");
                Console.Write("                               Choose an option: ");

                subOption = Convert.ToInt32(Console.ReadLine());
                switch (subOption)
                {
                    case 1: PointMutations(); break;
                    case 2: FrameshiftMutations(); break;
                    case 3: SilentMutations(); break;
                    case 4: MissenseMutations(); break;
                    case 5: NonsenseMutations(); break;
                    case 6: ChromosomalMutations(); break;
                    case 0: Console.WriteLine("           Returning to the main menu..."); break;
                    default:
                        break;
                }
            } while (subOption != 0);
        }

        static void PointMutations()
        {
            Console.Clear();
            Console.WriteLine("Point Mutations");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    ╔═╗┌─┐┬┌┐┌┌┬┐  ╔╦╗┬ ┬┌┬┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐                                     ");
            Console.WriteLine("                                    ╠═╝│ │││││ │   ║║║│ │ │ ├─┤ │ ││ ││││└─┐                                     ");
            Console.WriteLine("                                    ╩  └─┘┴┘└┘ ┴   ╩ ╩└─┘ ┴ ┴ ┴ ┴ ┴└─┘┘└┘└─┘                                     ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||    Point mutations are alterations in a single nucleotide base pair in DNA that can significantly   ||    ");
            Console.WriteLine("    ||          impact genetic expression and function. They can occur in various forms, including         ||    ");
            Console.WriteLine("    ||        substitutions, insertions, and deletions. Substitutions can be silent (where the change      ||    ");
            Console.WriteLine("    ||        does not affect the amino acid sequence), missense (resulting in a different amino acid),    ||    ");
            Console.WriteLine("    ||        or nonsense (creating a premature stop codon). Although point mutations typically involve    ||    ");
            Console.WriteLine("    ||        a single nucleotide, they can lead to profound effects on protein structure and function,    ||    ");
            Console.WriteLine("    ||        potentially contributing to diseases or phenotypic variations. These mutations can occur     ||    ");
            Console.WriteLine("    ||           spontaneously during DNA replication or be induced by environmental factors such as       ||    ");
            Console.WriteLine("    ||            chemicals or radiation, playing a crucial role in genetic diversity and evolution.       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();

        }

        static void FrameshiftMutations()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                   ╔═╗┬─┐┌─┐┌┬┐┌─┐┌─┐┬ ┬┬┌─┐┌┬┐  ╔╦╗┬ ┬┌┬┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐                       ");
            Console.WriteLine("                                   ╠╣ ├┬┘├─┤│││├┤ └─┐├─┤│├┤  │   ║║║│ │ │ ├─┤ │ ││ ││││└─┐                       ");
            Console.WriteLine("                                   ╚  ┴└─┴ ┴┴ ┴└─┘└─┘┴ ┴┴└   ┴   ╩ ╩└─┘ ┴ ┴ ┴ ┴ ┴└─┘┘└┘└─┘                       ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||   Frameshift mutations occur when nucleotides are inserted or deleted from the DNA sequence,        ||    ");
            Console.WriteLine("    ||  resulting in a shift of the reading frame during protein synthesis. This can lead to dramatic      ||    ");
            Console.WriteLine("    ||  changes in the resulting amino acid sequence, often producing a nonfunctional protein. If the      ||    ");
            Console.WriteLine("    ||    number of nucleotides deleted or inserted is not a multiple of three, all downstream amino       ||    ");
            Console.WriteLine("    ||   acids will be altered. Frameshift mutations can arise from errors in DNA replication or from      ||    ");
            Console.WriteLine("    ||  environmental factors such as radiation and certain chemicals. These mutations play a significant  ||    ");
            Console.WriteLine("    ||      role in genetic disorders and can contribute to evolutionary processes by introducing new      ||    ");
            Console.WriteLine("    ||                                       variations in a population.                                   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();

        }

        static void SilentMutations()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                   ╔═╗┬┬  ┌─┐┌┐┌┌┬┐  ╔╦╗┬ ┬┌┬┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐                                   ");
            Console.WriteLine("                                   ╚═╗││  ├┤ │││ │   ║║║│ │ │ ├─┤ │ ││ ││││└─┐                                   ");
            Console.WriteLine("                                   ╚═╝┴┴─┘└─┘┘└┘ ┴   ╩ ╩└─┘ ┴ ┴ ┴ ┴ ┴└─┘┘└┘└─┘                                   ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||     Silent mutations are changes in the DNA sequence that do not alter the resulting protein's      ||    ");
            Console.WriteLine("    ||    amino acid sequence. These mutations often occur in regions of the DNA that are not critical     ||    ");
            Console.WriteLine("    ||      for protein function, such as synonymous codons that encode the same amino acid. Silent        ||    ");
            Console.WriteLine("    ||      mutations can also arise due to variations in the third nucleotide position of a codon,        ||    ");
            Console.WriteLine("    ||     which frequently does not affect the overall protein structure. While silent mutations are      ||    ");
            Console.WriteLine("    ||     often considered neutral, they can influence gene expression, mRNA stability, and overall       ||    ");
            Console.WriteLine("    ||     protein synthesis efficiency, playing a subtle yet significant role in genetic variability.     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void MissenseMutations()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    ╔╦╗┬┌─┐┌─┐┌─┐┌┐┌┌─┐┌─┐  ╔╦╗┬ ┬┌┬┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐                            ");
            Console.WriteLine("                                    ║║║│└─┐└─┐├┤ │││└─┐├┤   ║║║│ │ │ ├─┤ │ ││ ││││└─┐                            ");
            Console.WriteLine("                                    ╩ ╩┴└─┘└─┘└─┘┘└┘└─┘└─┘  ╩ ╩└─┘ ┴ ┴ ┴ ┴ ┴└─┘┘└┘└─┘                            ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||     Missense mutations are changes in the DNA sequence that result in the incorporation of a        ||    ");
            Console.WriteLine("    ||     different amino acid into the resulting protein. This alteration can affect the protein's       ||    ");
            Console.WriteLine("    ||    function, stability, and interactions with other molecules. Depending on the specific amino      ||    ");
            Console.WriteLine("    ||     acid substitution, the effects can range from benign to detrimental, potentially leading to     ||    ");
            Console.WriteLine("    ||    genetic disorders or diseases. Missense mutations arise from a single nucleotide substitution,   ||    ");
            Console.WriteLine("    ||     highlighting the importance of precise nucleotide sequences in maintaining protein integrity.   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");

            Console.ReadKey();

        }

        static void NonsenseMutations()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                 ╔╗╔┌─┐┌┐┌┌─┐┌─┐┌┐┌┌─┐┌─┐  ┌┬┐┬ ┬┌┬┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐                             ");
            Console.WriteLine("                                 ║║║│ ││││└─┐├┤ │││└─┐├┤   ││││ │ │ ├─┤ │ ││ ││││└─┐                             ");
            Console.WriteLine("                                 ╝╚╝└─┘┘└┘└─┘└─┘┘└┘└─┘└─┘  ┴ ┴└─┘ ┴ ┴ ┴ ┴ ┴└─┘┘└┘└─┘                             ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||     Nonsense mutations are changes in the DNA sequence that create a premature stop codon,          ||    ");
            Console.WriteLine("    ||    leading to truncated proteins that are often nonfunctional. This type of mutation occurs         ||    ");
            Console.WriteLine("    ||    when a nucleotide substitution changes a codon that normally encodes an amino acid into          ||    ");
            Console.WriteLine("    ||      a stop codon. As a result, the synthesis of the protein is halted, which can severely          ||    ");
            Console.WriteLine("    ||      affect cellular function and lead to various genetic disorders or diseases. Nonsense           ||    ");
            Console.WriteLine("    ||     mutations emphasize the critical importance of the genetic code in determining protein          ||    ");
            Console.WriteLine("    ||    structure and function, as even a single nucleotide change can have drastic consequences.        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");

            Console.ReadKey();

        }

        static void ChromosomalMutations()
        {

            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                             ╔═╗┬ ┬┬─┐┌─┐┌┬┐┌─┐┌─┐┌─┐┌┬┐┌─┐┬    ┌┬┐┬ ┬┌┬┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐                        ");
            Console.WriteLine("                             ║  ├─┤├┬┘│ │││││ │└─┐│ ││││├─┤│    ││││ │ │ ├─┤ │ ││ ││││└─┐                        ");
            Console.WriteLine("                             ╚═╝┴ ┴┴└─└─┘┴ ┴└─┘└─┘└─┘┴ ┴┴ ┴┴─┘  ┴ ┴└─┘ ┴ ┴ ┴ ┴ ┴└─┘┘└┘└─┘                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                    ||    ");
            Console.WriteLine("    ||       Chromosomal mutations involve alterations to the structure or number of chromosomes,         ||    ");
            Console.WriteLine("    ||      leading to significant genetic changes. These mutations can occur through duplications,       ||    ");
            Console.WriteLine("    ||    deletions, inversions, or translocations of chromosome segments. Such alterations can result    ||    ");
            Console.WriteLine("    ||     in disorders such as Down syndrome, Turner syndrome, and many types of cancer. The effects     ||    ");
            Console.WriteLine("    ||      of chromosomal mutations can be profound, affecting gene dosage, expression, and function,    ||    ");
            Console.WriteLine("    ||                      ultimately impacting an organism's development and health.                    ||    ");
            Console.WriteLine("    ||                                                                                                    ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();

        }




        static void CausesOfMutations()
        {
            Console.Clear();
            Console.WriteLine("Causes of Mutations");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                               ╔═╗┌─┐┬ ┬┌─┐┌─┐┌─┐  ┌─┐┌─┐  ╔╦╗┬ ┬┌┬┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐                             ");
            Console.WriteLine("                               ║  ├─┤│ │└─┐├┤ └─┐  │ │├┤   ║║║│ │ │ ├─┤ │ ││ ││││└─┐                             ");
            Console.WriteLine("                               ╚═╝┴ ┴└─┘└─┘└─┘└─┘  └─┘└    ╩ ╩└─┘ ┴ ┴ ┴ ┴ ┴└─┘┘└┘└─┘                             ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Mutations can arise from various sources, including spontaneous processes during DNA           ||    ");
            Console.WriteLine("    ||     exposure to environmental factors, and the influence of specific chemicals. Spontaneous         ||    ");
            Console.WriteLine("    ||    mutations occur naturally due to errors in DNA synthesis or repair mechanisms. Environmental     ||    ");
            Console.WriteLine("    ||      mutagens, such as UV radiation and chemicals like benzene or formaldehyde, can increase        ||    ");
            Console.WriteLine("    ||        mutation rates by causing DNA damage or interfering with replication. Additionally,          ||    ");
            Console.WriteLine("    ||        certain viruses can integrate their genetic material into host genomes, leading to           ||    ");
            Console.WriteLine("    ||        mutations. Understanding the causes of mutations is essential for studying genetic           ||    ");
            Console.WriteLine("    ||                          diseases and the mechanisms of evolution.                                  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");

            Console.ReadKey();
        }

        static void EffectsOfMutations()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                 ╔═╗┌─┐┌─┐┌─┐┌─┐┌┬┐┌─┐  ┌─┐┌─┐  ╔╦╗┬ ┬┌┬┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐                        ");
            Console.WriteLine("                                 ║╣ ├┤ ├┤ ├┤ │   │ └─┐  │ │├┤   ║║║│ │ │ ├─┤ │ ││ ││││└─┐                        ");
            Console.WriteLine("                                 ╚═╝└  └  └─┘└─┘ ┴ └─┘  └─┘└    ╩ ╩└─┘ ┴ ┴ ┴ ┴ ┴└─┘┘└┘└─┘                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||    Mutations can have a variety of effects on organisms, ranging from neutral to harmful or even    ||    ");
            Console.WriteLine("    ||      beneficial. Some mutations may not affect the phenotype at all, while others can lead to       ||    ");
            Console.WriteLine("    ||     genetic disorders, cancer, or developmental abnormalities. Beneficial mutations may provide     ||    ");
            Console.WriteLine("    ||          an advantage in certain environments, contributing to evolution and adaptation.            ||    ");
            Console.WriteLine("    ||       Additionally, mutations play a crucial role in generating genetic diversity, which is         ||    ");
            Console.WriteLine("    ||      essential for populations to adapt to changing conditions. Understanding the effects of        ||    ");
            Console.WriteLine("    ||        mutations is key in fields such as medicine, agriculture, and evolutionary biology.          ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");

            Console.ReadKey();
        }


        static void GeneEditing()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                GeneEditingAnimation();
                Console.Clear();
                Console.WriteLine("                                                                                                             ");
                Console.WriteLine("                                                                                                             ");
                Console.WriteLine("                                ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗               ");
                Console.WriteLine("                               ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝               ");
                Console.WriteLine("                               ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗               ");
                Console.WriteLine("                               ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║               ");
                Console.WriteLine("                               ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║               ");
                Console.WriteLine("                                ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝               ");
                Console.WriteLine("                                                                                                             ");
                Console.WriteLine("                                                                                                             ");
                Console.WriteLine("        ==================================================================================================== ");
                Console.WriteLine("        ||                                                                                                || ");
                Console.WriteLine("        ||                                            Genetics Menu:                                      || ");
                Console.WriteLine("        ||                                                                                                || ");
                Console.WriteLine("        ||                       Gene Editing (CRISPR and Other Technologies):                            || ");
                Console.WriteLine("        ||                                                                                                || ");
                Console.WriteLine("        ||                       [ 1 ] What is CRISPR?                                                    || ");
                Console.WriteLine("        ||                       [ 2 ] How CRISPR Works                                                   || ");
                Console.WriteLine("        ||                       [ 3 ] Applications of CRISPR in Medicine                                 || ");
                Console.WriteLine("        ||                       [ 4 ] Gene Therapy and CRISPR                                            || ");
                Console.WriteLine("        ||                       [ 5 ] Ethical Issues in Gene Editing                                     || ");
                Console.WriteLine("        ||                       [ 6 ] Future of CRISPR Technology                                        || ");
                Console.WriteLine("        ||                       [ 7 ] Other Gene Editing Technologies                                    || ");
                Console.WriteLine("        ||                       [ 8 ] Gene Editing in Agriculture                                        || ");
                Console.WriteLine("        ||                       [ 9 ] Gene Editing and Cancer Research                                   || ");
                Console.WriteLine("        ||                       [ 10 ] Risks and Limitations of Gene Editing                             || ");
                Console.WriteLine("        ||                       [ 0 ] Go Back                                                            || ");
                Console.WriteLine("        ||                                                                                                || ");
                Console.WriteLine("        ==================================================================================================== ");
                Console.WriteLine("                                                                                                             ");
                Console.WriteLine("                                                                                                                             ");
                Console.Write("                               Choose an option: ");


                subOption = Convert.ToInt32(Console.ReadLine());

                switch (subOption)
                {
                    case 1: WhatIsCRISPR(); break;
                    case 2: HowCRISPRWorks(); break;
                    case 3: ApplicationsOfCRISPR(); break;
                    case 4: GeneTherapy(); break;
                    case 5: EthicalIssuesGeneEditing(); break;
                    case 6: FutureOfCRISPR(); break;
                    case 7: OtherGeneEditingTechnologies(); break;
                    case 8: GeneEditingInAgriculture(); break;
                    case 9: GeneEditingCancerResearch(); break;
                    case 10: RisksAndLimitationsGeneEditing(); break;
                    default:
                        break;
                }

            } while (subOption != 0);
        }

        static void GeneEditingAnimation()
        {

            string[] frames = new string[]
            {
        "        ====================================================================================================  \n "+
        "                                [G]-[A]-[T]-[C]-[A]-[T]-[C]-[G]-[A]-[T]-[C]-[G]  \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                [G]-[A]-[T]-[C]-[A]-[T]-[C]-[G]-[A]-[T]-[C]-[C]  \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                [G]-[A]-[T]-[C]-[A]-[T]-[C]-[G]-[A]-[G]-[C]-[C]  \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                [G]-[A]-[T]-[C]-[A]-[T]-[C]-[G]-[G]-[G]-[C]-[C]  \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                [G]-[A]-[T]-[C]-[A]-[T]-[C]-[A]-[G]-[G]-[C]-[C]  \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                [G]-[A]-[T]-[C]-[A]-[A]-[C]-[A]-[G]-[G]-[C]-[C]  \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                [G]-[A]-[T]-[C]-[T]-[A]-[C]-[A]-[G]-[G]-[C]-[C]  \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                [G]-[A]-[T]-[G]-[T]-[A]-[C]-[A]-[G]-[G]-[C]-[C]  \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                [G]-[A]-[A]-[G]-[T]-[A]-[C]-[A]-[G]-[G]-[C]-[C]  \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                [G]-[G]-[A]-[G]-[T]-[A]-[C]-[A]-[G]-[G]-[C]-[C]  \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                [C]-[G]-[A]-[G]-[T]-[A]-[C]-[A]-[G]-[G]-[C]-[C]  \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                [C]-[G]-[T]-[G]-[T]-[A]-[C]-[A]-[G]-[G]-[C]-[C]  \n" +
        "        ====================================================================================================  "

            };

            for (int i = 0; i < 3; i++)
            {
                foreach (var frame in frames)
                {
                    Console.Clear();
                    Console.WriteLine(frame);
                    Console.WriteLine("                                             Gene Editing Loading...");
                    Thread.Sleep(300);
                }
            }


            Console.Clear();
            Console.WriteLine("Gene Editing Complete!");
        }


        static void WhatIsCRISPR()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                      ╦ ╦┬ ┬┌─┐┌┬┐  ┬┌─┐  ╔═╗╦═╗╦╔═╗╔═╗╦═╗┌─┐                                    ");
            Console.WriteLine("                                      ║║║├─┤├─┤ │   │└─┐  ║  ╠╦╝║╚═╗╠═╝╠╦╝ ┌┘                                    ");
            Console.WriteLine("                                      ╚╩╝┴ ┴┴ ┴ ┴   ┴└─┘  ╚═╝╩╚═╩╚═╝╩  ╩╚═ o                                     ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||   CRISPR (Clustered Regularly Interspaced Short Palindromic Repeats) is a revolutionary genetic     ||    ");
            Console.WriteLine("    ||    engineering technology that allows scientists to precisely alter DNA within living organisms.    ||    ");
            Console.WriteLine("    ||      It functions like a pair of molecular scissors, enabling targeted modifications that can       ||    ");
            Console.WriteLine("    ||    lead to advancements in medicine, agriculture, and biological research. Applications include     ||    ");
            Console.WriteLine("    ||      gene editing to correct genetic defects, enhance crop resilience, and develop treatments for   ||    ");
            Console.WriteLine("    ||                    various diseases. This powerful tool has the potential to transform multiple     ||    ");
            Console.WriteLine("    ||                        fields, but it also raises ethical questions regarding its use.              ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();

        }

        static void HowCRISPRWorks()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                      ╦ ╦┌─┐┬ ┬  ╔═╗╦═╗╦╔═╗╔═╗╦═╗  ╦ ╦┌─┐┬─┐┬┌─┌─┐                               ");
            Console.WriteLine("                                      ╠═╣│ ││││  ║  ╠╦╝║╚═╗╠═╝╠╦╝  ║║║│ │├┬┘├┴┐└─┐                               ");
            Console.WriteLine("                                      ╩ ╩└─┘└┴┘  ╚═╝╩╚═╩╚═╝╩  ╩╚═  ╚╩╝└─┘┴└─┴ ┴└─┘                               ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||     CRISPR technology utilizes a guide RNA to locate specific DNA sequences, allowing the Cas9      ||    ");
            Console.WriteLine("    ||    enzyme to cut the DNA at precise locations. Once the DNA is cut, the cell's natural repair       ||    ");
            Console.WriteLine("    ||   mechanisms can be harnessed to insert, delete, or modify genes. This method is highly efficient   ||    ");
            Console.WriteLine("    ||   and can be used for a variety of applications, from basic research to developing gene therapies.  ||    ");
            Console.WriteLine("    ||   The flexibility and precision of CRISPR have made it a widely adopted tool in genetic research.   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void ApplicationsOfCRISPR()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                ╔═╗┌─┐┌─┐┬  ┬┌─┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐  ┌─┐┌─┐  ╔═╗╦═╗╦╔═╗╔═╗╦═╗  ┬┌┐┌  ╔╦╗┌─┐┌┬┐┬┌─┐┬┌┐┌┌─┐           ");
            Console.WriteLine("                ╠═╣├─┘├─┘│  ││  ├─┤ │ ││ ││││└─┐  │ │├┤   ║  ╠╦╝║╚═╗╠═╝╠╦╝  ││││  ║║║├┤  ││││  ││││├┤            ");
            Console.WriteLine("                ╩ ╩┴  ┴  ┴─┘┴└─┘┴ ┴ ┴ ┴└─┘┘└┘└─┘  └─┘└    ╚═╝╩╚═╩╚═╝╩  ╩╚═  ┴┘└┘  ╩ ╩└─┘─┴┘┴└─┘┴┘└┘└─┘           ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||     CRISPR has significant potential in medicine, including:                                        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||     1. **Gene Therapy**: Correcting genetic disorders by editing faulty genes.                      ||    ");
            Console.WriteLine("    ||     2. **Cancer Treatment**: Targeting and disrupting cancer cell genes to inhibit growth.          ||    ");
            Console.WriteLine("    ||     3. **Infectious Diseases**: Developing treatments for viral infections like HIV.                ||    ");
            Console.WriteLine("    ||     4. **Drug Development**: Creating models for testing new drugs and understanding diseases.      ||    ");
            Console.WriteLine("    ||     5. **Personalized Medicine**: Tailoring treatments based on individual genetic profiles.        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void GeneTherapy()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                             ╔═╗┌─┐┌┐┌┌─┐  ╔╦╗┬ ┬┌─┐┬─┐┌─┐┌─┐┬ ┬  ┌─┐┌┐┌┌┬┐  ╔═╗╦═╗╦╔═╗╔═╗╦═╗                    ");
            Console.WriteLine("                             ║ ╦├┤ │││├┤    ║ ├─┤├┤ ├┬┘├─┤├─┘└┬┘  ├─┤│││ ││  ║  ╠╦╝║╚═╗╠═╝╠╦╝                    ");
            Console.WriteLine("                             ╚═╝└─┘┘└┘└─┘   ╩ ┴ ┴└─┘┴└─┴ ┴┴   ┴   ┴ ┴┘└┘─┴┘  ╚═╝╩╚═╩╚═╝╩  ╩╚═                    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||     Gene therapy aims to treat or prevent diseases by introducing, removing, or altering genetic    ||    ");
            Console.WriteLine("    ||    material within a patient's cells. CRISPR technology enhances this approach by allowing for      ||    ");
            Console.WriteLine("    ||    precise editing of genes, making it possible to correct mutations that cause genetic disorders.  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||     Applications of CRISPR in gene therapy include:                                                 ||    ");
            Console.WriteLine("    ||     1. **Cystic Fibrosis**: Correcting mutations in the CFTR gene responsible for the disease.      ||    ");
            Console.WriteLine("    ||     2. **Sickle Cell Disease**: Editing genes to produce healthy red blood cells.                   ||    ");
            Console.WriteLine("    ||     3. **Hemophilia**: Targeting genes to restore normal blood clotting functions.                  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void EthicalIssuesGeneEditing()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                     ╔═╗┌┬┐┬ ┬┬┌─┐┌─┐┬    ╦┌─┐┌─┐┬ ┬┌─┐┌─┐  ┬┌┐┌  ╔═╗┌─┐┌┐┌┌─┐  ╔═╗┌┬┐┬┌┬┐┬┌┐┌┌─┐                ");
            Console.WriteLine("                     ║╣  │ ├─┤││  ├─┤│    ║└─┐└─┐│ │├┤ └─┐  ││││  ║ ╦├┤ │││├┤   ║╣  │││ │ │││││ ┬                ");
            Console.WriteLine("                     ╚═╝ ┴ ┴ ┴┴└─┘┴ ┴┴─┘  ╩└─┘└─┘└─┘└─┘└─┘  ┴┘└┘  ╚═╝└─┘┘└┘└─┘  ╚═╝─┴┘┴ ┴ ┴┘└┘└─┘                ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||     The rapid development of gene editing technologies like CRISPR has raised several ethical       ||    ");
            Console.WriteLine("    ||     concerns, including:                                                                            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||     1. **Safety and Unintended Consequences**: Potential off-target effects that could harm         ||    ");
            Console.WriteLine("    ||        patients or create new health issues.                                                        ||    ");
            Console.WriteLine("    ||     2. **Accessibility and Inequality**: The risk of creating a divide between those who can        ||    ");
            Console.WriteLine("    ||        afford gene editing treatments and those who cannot.                                         ||    ");
            Console.WriteLine("    ||     3. **Genetic Enhancement**: Ethical dilemmas surrounding the desire to enhance human traits,    ||    ");
            Console.WriteLine("    ||        leading to concerns about 'designer babies'.                                                 ||    ");
            Console.WriteLine("    ||     4. **Consent**: Challenges in obtaining informed consent, especially for germline editing that  ||    ");
            Console.WriteLine("    ||        affects future generations.                                                                  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to back in menu)                                              ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void FutureOfCRISPR()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                 ╔═╗┬ ┬┌┬┐┬ ┬┬─┐┌─┐  ┌─┐┌─┐  ╔═╗╦═╗╦╔═╗╔═╗╦═╗  ╔╦╗┌─┐┌─┐┬ ┬┌┐┌┌─┐┬  ┌─┐┌─┐┬ ┬                    ");
            Console.WriteLine("                 ╠╣ │ │ │ │ │├┬┘├┤   │ │├┤   ║  ╠╦╝║╚═╗╠═╝╠╦╝   ║ ├┤ │  ├─┤││││ ││  │ ││ ┬└┬┘                    ");
            Console.WriteLine("                 ╚  └─┘ ┴ └─┘┴└─└─┘  └─┘└    ╚═╝╩╚═╩╚═╝╩  ╩╚═   ╩ └─┘└─┘┴ ┴┘└┘└─┘┴─┘└─┘└─┘ ┴                     ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||   The future of CRISPR is promising, with potential to transform medicine, agriculture, and more.   ||    ");
            Console.WriteLine("    ||   Advances may include curing genetic diseases, precise cancer therapies, and engineered crops.     ||    ");
            Console.WriteLine("    ||   New forms like base and prime editing could refine the precision of gene edits. Ethical and       ||    ");
            Console.WriteLine("    ||   safety challenges remain critical, especially in germline editing. Improved delivery methods      ||    ");
            Console.WriteLine("    ||   and expanded applications will likely make CRISPR a core tool in biology and beyond.              ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void OtherGeneEditingTechnologies()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                ╔═╗┌┬┐┬ ┬┌─┐┬─┐  ╔═╗┌─┐┌┐┌┌─┐  ╔═╗┌┬┐┬┌┬┐┬┌┐┌┌─┐  ╔╦╗┌─┐┌─┐┬ ┬┌┐┌┌─┐┬  ┌─┐┌─┐┬┌─┐┌─┐             ");
            Console.WriteLine("                ║ ║ │ ├─┤├┤ ├┬┘  ║ ╦├┤ │││├┤   ║╣  │││ │ │││││ ┬   ║ ├┤ │  ├─┤││││ ││  │ ││ ┬│├┤ └─┐             ");
            Console.WriteLine("                ╚═╝ ┴ ┴ ┴└─┘┴└─  ╚═╝└─┘┘└┘└─┘  ╚═╝─┴┘┴ ┴ ┴┘└┘└─┘   ╩ └─┘└─┘┴ ┴┘└┘└─┘┴─┘└─┘└─┘┴└─┘└─┘             ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||    TALENs (Transcription Activator-Like Effector Nucleases)                                         ||    ");
            Console.WriteLine("    ||    - TALENs bind to specific DNA sequences and introduce cuts. They are versatile but more          ||    ");
            Console.WriteLine("    ||      labor-intensive than CRISPR. They’re useful for high-precision gene targeting.                 ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||    ZFNs (Zinc Finger Nucleases)                                                                     ||    ");
            Console.WriteLine("    ||    - ZFNs use engineered zinc finger proteins to target DNA. They were some of the first            ||    ");
            Console.WriteLine("    ||      gene-editing tools, yet their complex engineering limits broader use compared to CRISPR.       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||    Prime Editing                                                                                    ||    ");
            Console.WriteLine("    ||    - An advanced form of CRISPR that enables highly precise base edits without making DNA           ||    ");
            Console.WriteLine("    ||      double-strand breaks. Prime editing is promising for correcting point mutations.               ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||    Base Editing                                                                                     ||    ");
            Console.WriteLine("    ||    - Another CRISPR-based tool, base editing allows for single base pair changes, offering          ||    ");
            Console.WriteLine("    ||      precision for small mutations, particularly useful in diseases caused by single base errors.   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void GeneEditingInAgriculture()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                      ╔═╗┌─┐┌┐┌┌─┐  ╔═╗┌┬┐┬┌┬┐┬┌┐┌┌─┐  ┬┌┐┌  ╔═╗┌─┐┬─┐┬┌─┐┬ ┬┬ ┌┬┐┬ ┬┬─┐┌─┐                      ");
            Console.WriteLine("                      ║ ╦├┤ │││├┤   ║╣  │││ │ │││││ ┬  ││││  ╠═╣│ ┬├┬┘││  │ ││  │ │ │├┬┘├┤                       ");
            Console.WriteLine("                      ╚═╝└─┘┘└┘└─┘  ╚═╝─┴┘┴ ┴ ┴┘└┘└─┘  ┴┘└┘  ╩ ╩└─┘┴└─┴└─┘└─┘┴─┘┴ └─┘┴└─└─┘                      ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Gene editing is transforming agriculture by making crops and livestock more resilient,         ||    ");
            Console.WriteLine("    ||      productive, and sustainable. Some applications include:                                        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Crop Improvement                                                                               ||    ");
            Console.WriteLine("    ||      - Gene editing enables crops with enhanced traits like drought tolerance, pest resistance,     ||    ");
            Console.WriteLine("    ||        and increased yield. These improvements reduce reliance on pesticides and improve food       ||    ");
            Console.WriteLine("    ||        security, especially in climate-challenged regions.                                          ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Nutritional Enhancement                                                                        ||    ");
            Console.WriteLine("    ||      - Gene editing is used to increase nutritional content, such as higher vitamin levels or       ||    ");
            Console.WriteLine("    ||        better protein quality, addressing malnutrition and offering healthier options.              ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Disease Resistance                                                                             ||    ");
            Console.WriteLine("    ||      - Crops and livestock can be edited for resistance to diseases that impact food supply         ||    ");
            Console.WriteLine("    ||        and lead to heavy agricultural losses, reducing waste and enhancing productivity.            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Reducing Environmental Impact                                                                  ||    ");
            Console.WriteLine("    ||      - Gene-edited plants can improve soil health, reduce greenhouse gases, and even enhance        ||    ");
            Console.WriteLine("    ||        carbon capture. These crops help make agriculture more sustainable and environmentally       ||    ");
            Console.WriteLine("    ||        friendly.                                                                                    ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void GeneEditingCancerResearch()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("             ╔═╗┌─┐┌┐┌┌─┐  ╔═╗┌┬┐┬┌┬┐┬┌┐┌┌─┐  ┌─┐┌┐┌┌┬┐  ╔═╗┌─┐┌┐┌┌─┐┌─┐┬─┐  ╦═╗┌─┐┌─┐┌─┐┌─┐┬─┐┌─┐┬ ┬            ");
            Console.WriteLine("             ║ ╦├┤ │││├┤   ║╣  │││ │ │││││ ┬  ├─┤│││ ││  ║  ├─┤││││  ├┤ ├┬┘  ╠╦╝├┤ └─┐├┤ ├─┤├┬┘│  ├─┤            ");
            Console.WriteLine("             ╚═╝└─┘┘└┘└─┘  ╚═╝─┴┘┴ ┴ ┴┘└┘└─┘  ┴ ┴┘└┘─┴┘  ╚═╝┴ ┴┘└┘└─┘└─┘┴└─  ╩╚═└─┘└─┘└─┘┴ ┴┴└─└─┘┴ ┴            ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||       Gene editing technology has become a powerful tool in cancer research, with applications      ||    ");
            Console.WriteLine("    ||       that include:                                                                                 ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||       Targeted Cancer Therapy                                                                       ||    ");
            Console.WriteLine("    ||       - CRISPR and other gene-editing tools can target specific cancer-related genes, allowing      ||    ");
            Console.WriteLine("    ||         researchers to deactivate or repair mutations that drive cancer growth.                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||       CAR-T Cell Engineering                                                                        ||    ");
            Console.WriteLine("    ||       - Gene editing is used to modify T-cells to recognize and attack cancer cells more            ||    ");
            Console.WriteLine("    ||         in CAR-T cell therapies. This approach shows promise for blood cancers like leukemia.       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||       Immune System Optimization                                                                    ||    ");
            Console.WriteLine("    ||       - Gene editing enhances immune cells' abilities to evade cancer’s defense mechanisms,         ||    ");
            Console.WriteLine("    ||         providing more robust immune responses against solid tumors.                                ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||       Cancer-Related Gene Function Analysis                                                         ||    ");
            Console.WriteLine("    ||       - CRISPR allows scientists to study how specific genes contribute to cancer, helping          ||    ");
            Console.WriteLine("    ||         to identify new drug targets and understand cancer resistance to treatments.                ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||       Tumor Microenvironment Engineering                                                            ||    ");
            Console.WriteLine("    ||       - Gene editing can alter the environment surrounding tumors, affecting factors like           ||    ");
            Console.WriteLine("    ||         immune cell access and nutrient supply to slow or inhibit tumor growth.                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void RisksAndLimitationsGeneEditing()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("          ╦═╗┬┌─┐┬┌─┌─┐  ┌─┐┌┐┌┌┬┐  ╦  ┬┌┬┐┬┌┬┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐  ┌─┐┌─┐  ╔═╗┌─┐┌┐┌┌─┐  ╔═╗┌┬┐┬┌┬┐┬┌┐┌┌─┐         ");
            Console.WriteLine("          ╠╦╝│└─┐├┴┐└─┐  ├─┤│││ ││  ║  │││││ │ ├─┤ │ ││ ││││└─┐  │ │├┤   ║ ╦├┤ │││├┤   ║╣  │││ │ │││││ ┬         ");
            Console.WriteLine("          ╩╚═┴└─┘┴ ┴└─┘  ┴ ┴┘└┘─┴┘  ╩═╝┴┴ ┴┴ ┴ ┴ ┴ ┴ ┴└─┘┘└┘└─┘  └─┘└    ╚═╝└─┘┘└┘└─┘  ╚═╝─┴┘┴ ┴ ┴┘└┘└─┘         ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Gene editing holds great potential but also comes with risks and limitations, including:       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Off-Target Effects                                                                             ||    ");
            Console.WriteLine("    ||      - Gene editing tools can unintentionally alter non-targeted DNA sequences, potentially         ||    ");
            Console.WriteLine("    ||        causing harmful mutations or disrupting other genes, leading to unexpected side effects.     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Ethical Concerns                                                                               ||    ");
            Console.WriteLine("    ||      - Editing germline cells could affect future generations, raising concerns about unintended    ||    ");
            Console.WriteLine("    ||        consequences, consent, and the possibility of creating designer traits.                      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Technical Challenges                                                                           ||    ");
            Console.WriteLine("    ||      - Precise delivery of gene-editing tools to specific cells or tissues remains challenging.     ||    ");
            Console.WriteLine("    ||        Inefficient delivery methods can reduce the effectiveness of the edits and increase risks.   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Limited Understanding of Gene Functions                                                        ||    ");
            Console.WriteLine("    ||      - Our knowledge of all gene functions is still incomplete, meaning that editing certain genes  ||    ");
            Console.WriteLine("    ||        may have unintended and unknown consequences on other biological processes.                  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Immune Reactions                                                                               ||    ");
            Console.WriteLine("    ||      - Introducing foreign gene-editing tools, especially in therapeutic settings, can trigger      ||    ");
            Console.WriteLine("    ||        immune responses, which may reduce the effectiveness of the treatment or cause harm.         ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Accessibility and Inequity                                                                     ||    ");
            Console.WriteLine("    ||      - High costs and resource demands could make gene editing accessible only to a few,            ||    ");
            Console.WriteLine("    ||        potentially increasing social inequality.                                                    ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void HumanGenomeProject()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                HumanGenomeAnimation();
                Console.Clear();
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗                         ");
                Console.WriteLine("                               ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝                         ");
                Console.WriteLine("                               ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗                         ");
                Console.WriteLine("                               ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║                         ");
                Console.WriteLine("                               ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║                         ");
                Console.WriteLine("                                ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝                         ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("        ====================================================================================================           ");
                Console.WriteLine("        ||                                                                                                ||           ");
                Console.WriteLine("        ||                       Human Genome Project:                                                    ||           ");
                Console.WriteLine("        ||                                                                                                ||           ");
                Console.WriteLine("        ||                       [ 1 ] Overview of the Human Genome Project                               ||           ");
                Console.WriteLine("        ||                       [ 2 ] Goals of the Human Genome Project                                  ||           ");
                Console.WriteLine("        ||                       [ 3 ] Timeline of the Human Genome Project                               ||           ");
                Console.WriteLine("        ||                       [ 4 ] Achievements of the Human Genome Project                           ||           ");
                Console.WriteLine("        ||                       [ 5 ] Impact of the Human Genome Project on Medicine                     ||           ");
                Console.WriteLine("        ||                       [ 6 ] Ethical Concerns Related to the Human Genome Project               ||           ");
                Console.WriteLine("        ||                       [ 7 ] International Collaboration in the Human Genome Project            ||           ");
                Console.WriteLine("        ||                       [ 8 ] Role of Technology in the Human Genome Project                     ||           ");
                Console.WriteLine("        ||                       [ 9 ] Human Genome Project and Personalized Medicine                     ||           ");
                Console.WriteLine("        ||                       [ 10 ] Future of Genomic Research                                        ||           ");
                Console.WriteLine("        ||                       [ 0 ] Go Back                                                            ||           ");
                Console.WriteLine("        ||                                                                                                ||           ");
                Console.WriteLine("        ====================================================================================================           ");
                Console.WriteLine("                                                                                                                       ");
                Console.WriteLine("                                                                                                                       ");
                Console.Write("                               Choose an option: ");

                subOption = Convert.ToInt32(Console.ReadLine());

                switch (subOption)
                {
                    case 1: OverviewHumanGenomeProject(); break;
                    case 2: GoalsHumanGenomeProject(); break;
                    case 3: TimelineHumanGenomeProject(); break;
                    case 4: AchievementsHumanGenomeProject(); break;
                    case 5: ImpactHumanGenomeProject(); break;
                    case 6: EthicalConcernsHumanGenomeProject(); break;
                    case 7: InternationalCollaboration(); break;
                    case 8: RoleOfTechnology(); break;
                    case 9: PersonalizedMedicine(); break;
                    case 10: FutureGenomicResearch(); break;
                    default:
                        break;
                }

            } while (subOption != 0);
        }

        static void HumanGenomeAnimation()
        {

            string[] frames = new string[]
            {
        "        ====================================================================================================  \n"+
        "                        __    __    __    __    __    __    __    __    __    __  \n" +
        "                      /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\ \n" +
        "                      (A  )(C  )(G  )(T  )(C  )(G  )(A  )(T  )(C  )(A  )(G  )(T  )\n" +
        "                       \\__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\n" +
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                       __    __    __    __    __    __    __    __    __    __  \n" +
        "                      /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\ \n" +
        "                     (A  )(C  )(G  )(T  )(C  )(G  )(A  )(T  )(C  )(A  )(G  )(A  )\n" +
        "                      \\__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\n" +
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                       __    __    __    __    __    __    __    __    __    __  \n" +
        "                      /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\ \n" +
        "                     (A  )(C  )(G  )(T  )(C  )(G  )(A  )(T  )(C  )(T  )(G  )(A  )\n" +
        "                      \\__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\n" +
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                       __    __    __    __    __    __    __    __    __    __  \n" +
        "                      /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\ \n" +
        "                     (A  )(C  )(G  )(T  )(C  )(G  )(A  )(G  )(C  )(T  )(G  )(A  )\n" +
        "                      \\__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\n" +
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                       __    __    __    __    __    __    __    __    __    __  \n" +
        "                      /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\ \n" +
        "                     (A  )(C  )(G  )(T  )(C  )(G  )(A  )(T  )(C  )(T  )(G  )(A  )\n" +
        "                      \\__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\n" +
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                       __    __    __    __    __    __    __    __    __    __  \n" +
        "                      /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\  /  \\ \n" +
        "                     (A  )(C  )(G  )(T  )(C  )(G  )(A  )(T  )(C  )(A  )(G  )(T  )\n" +
        "                      \\__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__\\/__/\n" +
        "        ====================================================================================================  ",

            };

            for (int i = 0; i < 3; i++)
            {
                foreach (var frame in frames)
                {
                    Console.Clear();
                    Console.WriteLine(frame);
                    Console.WriteLine("                                            Human Genome Sequencing Loading...");
                    Thread.Sleep(300);
                }
            }

            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Human Genome Sequencing Complete!");
        }


        static void OverviewHumanGenomeProject()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("     ╔═╗┬  ┬┌─┐┬─┐┬  ┬┬┌─┐┬ ┬  ┌─┐┌─┐  ┌┬┐┬ ┬┌─┐  ╦ ╦┬ ┬┌┬┐┌─┐┌┐┌  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┌─┐  ╔═╗┬─┐┌─┐ ┬┌─┐┌─┐┌┬┐      ");
            Console.WriteLine("     ║ ║└┐┌┘├┤ ├┬┘└┐┌┘│├┤ │││  │ │├┤    │ ├─┤├┤   ╠═╣│ ││││├─┤│││  ║ ╦├┤ ││││ ││││├┤   ╠═╝├┬┘│ │ │├┤ │   │       ");
            Console.WriteLine("     ╚═╝ └┘ └─┘┴└─ └┘ ┴└─┘└┴┘  └─┘└     ┴ ┴ ┴└─┘  ╩ ╩└─┘┴ ┴┴ ┴┘└┘  ╚═╝└─┘┘└┘└─┘┴ ┴└─┘  ╩  ┴└─└─┘└┘└─┘└─┘ ┴       ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      The Human Genome Project (HGP) was an international research effort that mapped and            ||    ");
            Console.WriteLine("    ||      sequenced all the genes of the human genome. Completed in 2003, the HGP revolutionized         ||    ");
            Console.WriteLine("    ||      biology and genetics, with several key goals and accomplishments:                              ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Mapping the Human Genome                                                                       ||    ");
            Console.WriteLine("    ||      - Scientists identified approximately 20,000-25,000 genes and mapped their locations on        ||    ");
            Console.WriteLine("    ||        human chromosomes, laying the foundation for understanding gene function and structure.      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Sequencing DNA                                                                                 ||    ");
            Console.WriteLine("    ||      - By decoding the three billion base pairs in human DNA, researchers gained insight into       ||    ");
            Console.WriteLine("    ||        genetic diversity and hereditary factors influencing health and disease.                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Advancing Genomic Medicine                                                                     ||    ");
            Console.WriteLine("    ||      - The HGP enabled personalized medicine by helping scientists link specific genes to           ||    ");
            Console.WriteLine("    ||        diseases and create targeted treatments based on individual genetic profiles.                ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Open Data for Global Research                                                                  ||    ");
            Console.WriteLine("    ||      - All HGP data was made publicly available, fueling worldwide research, accelerating           ||    ");
            Console.WriteLine("    ||        biomedical advances, and fostering collaboration.                                            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Legacy and Future Research                                                                     ||    ");
            Console.WriteLine("    ||      - The HGP's success has led to further genome projects, including those of other species,      ||    ");
            Console.WriteLine("    ||        and has set the stage for gene editing and synthetic biology advancements.                   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void GoalsHumanGenomeProject()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("           ╔═╗┌─┐┌─┐┬  ┌─┐  ┌─┐┌─┐  ┌┬┐┬ ┬┌─┐  ╦ ╦┬ ┬┌┬┐┌─┐┌┐┌  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┌─┐  ╔═╗┬─┐┌─┐ ┬┌─┐┌─┐┌┬┐         ");
            Console.WriteLine("           ║ ╦│ │├─┤│  └─┐  │ │├┤    │ ├─┤├┤   ╠═╣│ ││││├─┤│││  ║ ╦├┤ ││││ ││││├┤   ╠═╝├┬┘│ │ │├┤ │   │          ");
            Console.WriteLine("           ╚═╝└─┘┴ ┴┴─┘└─┘  └─┘└     ┴ ┴ ┴└─┘  ╩ ╩└─┘┴ ┴┴ ┴┘└┘  ╚═╝└─┘┘└┘└─┘┴ ┴└─┘  ╩  ┴└─└─┘└┘└─┘└─┘ ┴          ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      The Human Genome Project (HGP) set out to map and understand all genes in human DNA, with      ||    ");
            Console.WriteLine("    ||      several ambitious goals driving this monumental project:                                       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Sequencing the Human Genome                                                                    ||    ");
            Console.WriteLine("    ||      - One of the main goals was to sequence the three billion DNA base pairs in the human genome,  ||    ");
            Console.WriteLine("    ||        laying the groundwork for understanding genetic instructions and variation.                  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Identifying All Human Genes                                                                    ||    ");
            Console.WriteLine("    ||      - Researchers aimed to locate and identify all human genes (estimated to be 20,000-25,000),    ||    ");
            Console.WriteLine("    ||        providing a comprehensive catalog to drive biomedical advances and diagnostics.              ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Mapping Genetic Variation                                                                      ||    ");
            Console.WriteLine("    ||      - The project sought to understand variations between individuals and populations, providing   ||    ");
            Console.WriteLine("    ||        insight into inherited traits, susceptibility to diseases, and human evolution.              ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Developing Technologies                                                                        ||    ");
            Console.WriteLine("    ||      - A major goal was to create new tools and methods for genome analysis, improving accuracy,    ||    ");
            Console.WriteLine("    ||        speed, and accessibility for future genetic research.                                        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Promoting Ethical, Legal, and Social Awareness                                                 ||    ");
            Console.WriteLine("    ||      - The HGP recognized the need to address the ethical, legal, and social implications of        ||    ");
            Console.WriteLine("    ||        genetic knowledge, aiming to ensure responsible use of genomic data.                         ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void TimelineHumanGenomeProject()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("       ╔╦╗┬┌┬┐┌─┐┬  ┬┌┐┌┌─┐  ┌─┐┌─┐  ┌┬┐┬ ┬┌─┐  ╦ ╦┬ ┬┌┬┐┌─┐┌┐┌  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┌─┐  ╔═╗┬─┐┌─┐ ┬┌─┐┌─┐┌┬┐        ");
            Console.WriteLine("        ║ ││││├┤ │  ││││├┤   │ │├┤    │ ├─┤├┤   ╠═╣│ ││││├─┤│││  ║ ╦├┤ ││││ ││││├┤   ╠═╝├┬┘│ │ │├┤ │   │         ");
            Console.WriteLine("        ╩ ┴┴ ┴└─┘┴─┘┴┘└┘└─┘  └─┘└     ┴ ┴ ┴└─┘  ╩ ╩└─┘┴ ┴┴ ┴┘└┘  ╚═╝└─┘┘└┘└─┘┴ ┴└─┘  ╩  ┴└─└─┘└┘└─┘└─┘ ┴         ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Key Milestones of the Human Genome Project:                                                    ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1990                                                                                           ||    ");
            Console.WriteLine("    ||      - The Human Genome Project officially launched as an international effort, led by the          ||    ");
            Console.WriteLine("    ||        United States, with a goal of mapping the entire human genome within 15 years.               ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1992                                                                                           ||    ");
            Console.WriteLine("    ||      - The project completed the first chromosome map, marking the initial success in mapping       ||    ");
            Console.WriteLine("    ||        the order of genes on a human chromosome.                                                    ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1996                                                                                           ||    ");
            Console.WriteLine("    ||      - The HGP created an extensive public database for genomic data, allowing researchers          ||    ");
            Console.WriteLine("    ||        worldwide to access and build on the project’s findings.                                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1999                                                                                           ||    ");
            Console.WriteLine("    ||      - Scientists completed the first fully sequenced human chromosome, Chromosome 22, a            ||    ");
            Console.WriteLine("    ||        major milestone in understanding human genetics.                                             ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2000                                                                                           ||    ");
            Console.WriteLine("    ||      - The first draft of the human genome was announced, covering over 90% of the entire genome    ||    ");
            Console.WriteLine("    ||        and marking a significant breakthrough in genetics.                                          ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2003                                                                                           ||    ");
            Console.WriteLine("    ||      - The Human Genome Project was completed, two years ahead of schedule, providing a             ||    ");
            Console.WriteLine("    ||        comprehensive map of the human genome and opening new doors for medical and genetic          ||    ");
            Console.WriteLine("    ||        research.                                                                                    ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void AchievementsHumanGenomeProject()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                           ╔═╗┌─┐┬ ┬┬┌─┐┬  ┬┌─┐┌┬┐┌─┐┌┐┌┌┬┐┌─┐  ┌─┐┌─┐  ┌┬┐┬ ┬┌─┐                                ");
            Console.WriteLine("                           ╠═╣│  ├─┤│├┤ └┐┌┘├┤ │││├┤ │││ │ └─┐  │ │├┤    │ ├─┤├┤                                 ");
            Console.WriteLine("                           ╩ ╩└─┘┴ ┴┴└─┘ └┘ └─┘┴ ┴└─┘┘└┘ ┴ └─┘  └─┘└     ┴ ┴ ┴└─┘                                ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                          ╦ ╦┬ ┬┌┬┐┌─┐┌┐┌  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┌─┐  ╔═╗┬─┐┌─┐ ┬┌─┐┌─┐┌┬┐                              ");
            Console.WriteLine("                          ╠═╣│ ││││├─┤│││  ║ ╦├┤ ││││ ││││├┤   ╠═╝├┬┘│ │ │├┤ │   │                               ");
            Console.WriteLine("                          ╩ ╩└─┘┴ ┴┴ ┴┘└┘  ╚═╝└─┘┘└┘└─┘┴ ┴└─┘  ╩  ┴└─└─┘└┘└─┘└─┘ ┴                               ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      The Human Genome Project (HGP) achieved several groundbreaking milestones that have            ||    ");
            Console.WriteLine("    ||      our understanding of genetics, medicine, and biology:                                          ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Complete Sequence of the Human Genome                                                       ||    ");
            Console.WriteLine("    ||      - Successfully mapped and sequenced the entire human genome, encompassing approximately        ||    ");
            Console.WriteLine("    ||        3 billion base pairs and identifying around 20,000-25,000 genes.                             ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Genetic Variation Mapping                                                                   ||    ");
            Console.WriteLine("    ||      - Characterized genetic variation across populations, helping to identify links between        ||    ");
            Console.WriteLine("    ||        genetic variations and specific diseases.                                                    ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Advances in Genomic Medicine                                                                ||    ");
            Console.WriteLine("    ||      - Laid the foundation for personalized medicine by correlating genetic information with        ||    ");
            Console.WriteLine("    ||        disease susceptibility and treatment responses.                                              ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Development of New Technologies                                                             ||    ");
            Console.WriteLine("    ||      - Fostered innovation in DNA sequencing and analysis technologies, leading to faster, cheaper, ||    ");
            Console.WriteLine("    ||        and more accurate genomic research methods.                                                  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Public Access to Genetic Data                                                               ||    ");
            Console.WriteLine("    ||      - Made genomic data publicly available, encouraging collaboration and research worldwide.      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      6. Understanding of Complex Diseases                                                           ||    ");
            Console.WriteLine("    ||      - Enhanced understanding of the genetic basis of complex diseases, such as cancer, diabetes,   ||    ");
            Console.WriteLine("    ||        and heart disease, paving the way for new diagnostic tools and therapies.                    ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      7. Ethical, Legal, and Social Considerations                                                   ||    ");
            Console.WriteLine("    ||      - Established frameworks for addressing the ethical, legal, and social implications of         ||    ");
            Console.WriteLine("    ||        genomic research, promoting responsible use of genetic information.                          ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");

            Console.ReadKey();
        }

        static void ImpactHumanGenomeProject()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                  ╦┌┬┐┌─┐┌─┐┌─┐┌┬┐  ┌─┐┌─┐  ┌┬┐┬ ┬┌─┐  ╦ ╦┬ ┬┌┬┐┌─┐┌┐┌  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┌─┐                       ");
            Console.WriteLine("                  ║│││├─┘├─┤│   │   │ │├┤    │ ├─┤├┤   ╠═╣│ ││││├─┤│││  ║ ╦├┤ ││││ ││││├┤                        ");
            Console.WriteLine("                  ╩┴ ┴┴  ┴ ┴└─┘ ┴   └─┘└     ┴ ┴ ┴└─┘  ╩ ╩└─┘┴ ┴┴ ┴┘└┘  ╚═╝└─┘┘└┘└─┘┴ ┴└─┘                       ");
            Console.WriteLine("                                ╔═╗┬─┐┌─┐ ┬┌─┐┌─┐┌┬┐  ┌─┐┌┐┌  ╔╦╗┌─┐┌┬┐┬┌─┐┬┌┐┌┌─┐                               ");
            Console.WriteLine("                                ╠═╝├┬┘│ │ │├┤ │   │   │ ││││  ║║║├┤  ││││  ││││├┤                                ");
            Console.WriteLine("                                ╩  ┴└─└─┘└┘└─┘└─┘ ┴   └─┘┘└┘  ╩ ╩└─┘─┴┘┴└─┘┴┘└┘└─┘                               ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      The Human Genome Project (HGP) has significantly impacted medicine in several transformative   ||    ");
            Console.WriteLine("    ||      ways, leading to advancements in diagnosis, treatment, and understanding of diseases:          ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Personalized Medicine                                                                       ||    ");
            Console.WriteLine("    ||      - Enabled tailored medical treatments based on individual genetic profiles, allowing for       ||    ");
            Console.WriteLine("    ||        more effective therapies with fewer side effects.                                            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Early Diagnosis and Screening                                                               ||    ");
            Console.WriteLine("    ||      - Improved diagnostic tools for genetic disorders, allowing for earlier detection and          ||    ");
            Console.WriteLine("    ||        intervention in conditions such as cystic fibrosis and certain cancers.                      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Targeted Therapies                                                                          ||    ");
            Console.WriteLine("    ||      - Development of targeted therapies, such as monoclonal antibodies for cancer treatment,       ||    ");
            Console.WriteLine("    ||        based on specific genetic mutations.                                                         ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Understanding Genetic Diseases                                                              ||    ");
            Console.WriteLine("    ||      - Enhanced knowledge of the genetic basis of complex diseases, such as Alzheimer's and         ||    ");
            Console.WriteLine("    ||        diabetes, informing prevention and treatment strategies.                                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Pharmacogenomics                                                                            ||    ");
            Console.WriteLine("    ||      - Integration of genetic information into drug development, leading to safer and more          ||    ");
            Console.WriteLine("    ||        effective medications based on genetic variability in drug metabolism.                       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      6. Gene Therapy                                                                                ||    ");
            Console.WriteLine("    ||      - Provided insights for developing gene therapies to treat or cure genetic disorders,          ||    ");
            Console.WriteLine("    ||        such as spinal muscular atrophy and certain types of inherited blindness.                    ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      7. Public Health and Policy                                                                    ||    ");
            Console.WriteLine("    ||      - Informed public health strategies and policies, emphasizing the importance of genetic        ||    ");
            Console.WriteLine("    ||        research in disease prevention and health promotion.                                         ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void EthicalConcernsHumanGenomeProject()
        {
            Console.Clear();

            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                         ╔═╗┌┬┐┬ ┬┬┌─┐┌─┐┬    ╔═╗┌─┐┌┐┌┌─┐┌─┐┬─┐┌┐┌┌─┐  ╦═╗┌─┐┬  ┌─┐┌┬┐┌─┐┌┬┐                    ");
            Console.WriteLine("                         ║╣  │ ├─┤││  ├─┤│    ║  │ │││││  ├┤ ├┬┘│││└─┐  ╠╦╝├┤ │  ├─┤ │ ├┤  ││                    ");
            Console.WriteLine("                         ╚═╝ ┴ ┴ ┴┴└─┘┴ ┴┴─┘  ╚═╝└─┘┘└┘└─┘└─┘┴└─┘└┘└─┘  ╩╚═└─┘┴─┘┴ ┴ ┴ └─┘─┴┘                    ");
            Console.WriteLine("                     ┌┬┐┌─┐  ┌┬┐┬ ┬┌─┐  ╦ ╦┬ ┬┌┬┐┌─┐┌┐┌  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┌─┐  ╔═╗┬─┐┌─┐ ┬┌─┐┌─┐┌┬┐                ");
            Console.WriteLine("                      │ │ │   │ ├─┤├┤   ╠═╣│ ││││├─┤│││  ║ ╦├┤ ││││ ││││├┤   ╠═╝├┬┘│ │ │├┤ │   │                 ");
            Console.WriteLine("                      ┴ └─┘   ┴ ┴ ┴└─┘  ╩ ╩└─┘┴ ┴┴ ┴┘└┘  ╚═╝└─┘┘└┘└─┘┴ ┴└─┘  ╩  ┴└─└─┘└┘└─┘└─┘ ┴                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      The Human Genome Project (HGP) raises several ethical concerns that have important             ||    ");
            Console.WriteLine("    ||      for individuals and society, including:                                                        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Privacy and Confidentiality                                                                 ||    ");
            Console.WriteLine("    ||      - Concerns about how genetic information is stored and shared, including potential misuse of   ||    ");
            Console.WriteLine("    ||        personal genetic data by employers or insurers.                                              ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Genetic Discrimination                                                                      ||    ");
            Console.WriteLine("    ||      - Risks of discrimination based on genetic information, such as employment or insurance .      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Informed Consent                                                                            ||    ");
            Console.WriteLine("    ||      - Ethical issues surrounding obtaining informed consent from participants in genetic,          ||    ");
            Console.WriteLine("    ||        particularly regarding the use and sharing of their genetic information.                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Access to Genetic Information                                                               ||    ");
            Console.WriteLine("    ||      - Concerns about equitable access to genetic testing and therapies,                            ||    ");
            Console.WriteLine("    ||        disparities among different populations.                                                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Potential for 'Designer Babies'                                                             ||    ");
            Console.WriteLine("    ||      - Ethical dilemmas regarding genetic modification of embryos and the potential for creating    ||    ");
            Console.WriteLine("    ||        'designer babies' based on desirable traits, raising concerns about eugenics.                ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      6. Implications for Family and Kinship                                                         ||    ");
            Console.WriteLine("    ||      - Genetic information can have implications beyond the individual, affecting family            ||    ");
            Console.WriteLine("    ||        raising questions about the sharing of genetic risks and information.                        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      7. Ethical Research Practices                                                                  ||    ");
            Console.WriteLine("    ||      - The need for ethical guidelines in conducting genetic research to protect participants and   ||    ");
            Console.WriteLine("    ||        ensure responsible use of genetic data.                                                      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void InternationalCollaboration()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("               ╦┌┐┌┌┬┐┌─┐┬─┐┌┐┌┌─┐┌┬┐┬┌─┐┌┐┌┌─┐┬    ╔═╗┌─┐┬  ┬  ┌─┐┌┐ ┌─┐┬─┐┌─┐┌┬┐┬┌─┐┌┐┌                        ");
            Console.WriteLine("               ║│││ │ ├┤ ├┬┘│││├─┤ │ ││ ││││├─┤│    ║  │ ││  │  ├─┤├┴┐│ │├┬┘├─┤ │ ││ ││││                        ");
            Console.WriteLine("               ╩┘└┘ ┴ └─┘┴└─┘└┘┴ ┴ ┴ ┴└─┘┘└┘┴ ┴┴─┘  ╚═╝└─┘┴─┘┴─┘┴ ┴└─┘└─┘┴└─┴ ┴ ┴ ┴└─┘┘└┘                        ");
            Console.WriteLine("                ┬┌┐┌  ┌┬┐┬ ┬┌─┐  ╦ ╦┬ ┬┌┬┐┌─┐┌┐┌  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┌─┐  ╔═╗┬─┐┌─┐ ┬┌─┐┌─┐┌┬┐                       ");
            Console.WriteLine("                ││││   │ ├─┤├┤   ╠═╣│ ││││├─┤│││  ║ ╦├┤ ││││ ││││├┤   ╠═╝├┬┘│ │ │├┤ │   │                        ");
            Console.WriteLine("                ┴┘└┘   ┴ ┴ ┴└─┘  ╩ ╩└─┘┴ ┴┴ ┴┘└┘  ╚═╝└─┘┘└┘└─┘┴ ┴└─┘  ╩  ┴└─└─┘└┘└─┘└─┘ ┴                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      The Human Genome Project (HGP) exemplified international collaboration in genetic research,    ||    ");
            Console.WriteLine("    ||      involving numerous countries and institutions working together toward common goals:            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Global Partnership                                                                          ||    ");
            Console.WriteLine("    ||      - Launched in 1990, the HGP was an international effort involving institutions from the        ||    ");
            Console.WriteLine("    ||        United States, United Kingdom, Japan, France, and Germany, among others.                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Sharing of Data and Resources                                                               ||    ");
            Console.WriteLine("    ||      - Promoted open access to genetic data, ensuring that all researchers could benefit from       ||    ");
            Console.WriteLine("    ||        shared information, fostering collaboration and innovation.                                  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Coordinated Efforts                                                                         ||    ");
            Console.WriteLine("    ||      - Coordinated sequencing efforts through various centers and consortia, including the          ||    ");
            Console.WriteLine("    ||        International Human Genome Sequencing Consortium (IHGSC).                                    ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. National and International Funding                                                          ||    ");
            Console.WriteLine("    ||      - Supported by significant funding from governments, private organizations, and international  ||    ");
            Console.WriteLine("    ||        agencies, including the National Institutes of Health (NIH) and the Wellcome Trust.          ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Contribution to Global Health                                                               ||    ");
            Console.WriteLine("    ||      - Facilitated international research collaborations focused on global health issues,           ||    ");
            Console.WriteLine("    ||        such as understanding genetic predispositions to diseases in diverse populations.            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      6. Training and Capacity Building                                                              ||    ");
            Console.WriteLine("    ||      -Provided training and resources to scientists worldwide, enhancing capabilities in            ||    ");
            Console.WriteLine("    ||        genomics research and technology development.                                                ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      7. Legacy of Collaboration                                                                     ||    ");
            Console.WriteLine("    ||      -Established a model for future international research collaborations in genetics,             ||    ");
            Console.WriteLine("    ||        biomedical research, and public health initiatives.                                          ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void RoleOfTechnology()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                      ╦═╗┌─┐┬  ┌─┐  ┌─┐┌─┐  ╔╦╗┌─┐┌─┐┬ ┬┌┐┌┌─┐┬  ┌─┐┌─┐┬ ┬  ┬┌┐┌  ┌┬┐┬ ┬┌─┐                      ");
            Console.WriteLine("                      ╠╦╝│ ││  ├┤   │ │├┤    ║ ├┤ │  ├─┤││││ ││  │ ││ ┬└┬┘  ││││   │ ├─┤├┤                       ");
            Console.WriteLine("                      ╩╚═└─┘┴─┘└─┘  └─┘└     ╩ └─┘└─┘┴ ┴┘└┘└─┘┴─┘└─┘└─┘ ┴   ┴┘└┘   ┴ ┴ ┴└─┘                      ");
            Console.WriteLine("                               ╦ ╦┬ ┬┌┬┐┌─┐┌┐┌  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┌─┐  ╔═╗┬─┐┌─┐ ┬┌─┐┌─┐┌┬┐                         ");
            Console.WriteLine("                               ╠═╣│ ││││├─┤│││  ║ ╦├┤ ││││ ││││├┤   ╠═╝├┬┘│ │ │├┤ │   │                          ");
            Console.WriteLine("                               ╩ ╩└─┘┴ ┴┴ ┴┘└┘  ╚═╝└─┘┘└┘└─┘┴ ┴└─┘  ╩  ┴└─└─┘└┘└─┘└─┘ ┴                          ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Technology played a crucial role in the Human Genome Project (HGP), enabling the successful    ||    ");
            Console.WriteLine("    ||      mapping and sequencing of the human genome through various innovative methods and tools:       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. DNA Sequencing Techniques                                                                   ||    ");
            Console.WriteLine("    ||      - Development and refinement of sequencing technologies, including Sanger sequencing and       ||    ");
            Console.WriteLine("    ||        next-generation sequencing (NGS), which significantly increased speed and accuracy.          ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Bioinformatics                                                                              ||    ");
            Console.WriteLine("    ||      - Utilization of computational tools and algorithms to analyze, interpret, and store           ||    ");
            Console.WriteLine("    ||        vast amounts of genetic data generated during the project.                                   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Automated Laboratory Equipment                                                              ||    ");
            Console.WriteLine("    ||      - Implementation of robotics and automation in laboratories to streamline sample preparation,  ||    ");
            Console.WriteLine("    ||        sequencing, and data analysis, improving efficiency and reducing human error.                ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Genetic Mapping Technologies                                                                ||    ");
            Console.WriteLine("    ||      -Use of technologies for genetic mapping, including restriction fragment length polymorphism   ||    ");
            Console.WriteLine("    ||        (RFLP) and single nucleotide polymorphism (SNP) analysis, to identify genetic variations.    ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Collaborative Platforms                                                                     ||    ");
            Console.WriteLine("    ||      -Creation of databases and online platforms, such as the UCSC Genome Browser and GenBank,      ||    ");
            Console.WriteLine("    ||        facilitating data sharing and collaboration among researchers worldwide.                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      6. Quality Control and Standards                                                               ||    ");
            Console.WriteLine("    ||      -Implementation of rigorous quality control measures and standard protocols to ensure          ||    ");
            Console.WriteLine("    ||        the reliability and accuracy of genomic data.                                                ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      7. Interdisciplinary Approaches                                                                ||    ");
            Console.WriteLine("    ||      -Collaboration between geneticists, biologists, computer scientists, and engineers             ||    ");
            Console.WriteLine("    ||        to develop new technologies and methodologies that pushed the boundaries of genetic.         ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void PersonalizedMedicine()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                            ╦ ╦┬ ┬┌┬┐┌─┐┌┐┌  ╔═╗┌─┐┌┐┌┌─┐┌┬┐┌─┐  ╔═╗┬─┐┌─┐ ┬┌─┐┌─┐┌┬┐                            ");
            Console.WriteLine("                            ╠═╣│ ││││├─┤│││  ║ ╦├┤ ││││ ││││├┤   ╠═╝├┬┘│ │ │├┤ │   │                             ");
            Console.WriteLine("                            ╩ ╩└─┘┴ ┴┴ ┴┘└┘  ╚═╝└─┘┘└┘└─┘┴ ┴└─┘  ╩  ┴└─└─┘└┘└─┘└─┘ ┴                             ");
            Console.WriteLine("                      ┌─┐┌┐┌┌┬┐  ╔═╗┌─┐┬─┐┌─┐┌─┐┌┐┌┌─┐┬  ┬┌─┐┌─┐┌┬┐  ╔╦╗┌─┐┌┬┐┬┌─┐┬┌┐┌┌─┐                        ");
            Console.WriteLine("                      ├─┤│││ ││  ╠═╝├┤ ├┬┘└─┐│ ││││├─┤│  │┌─┘├┤  ││  ║║║├┤  ││││  ││││├┤                         ");
            Console.WriteLine("                      ┴ ┴┘└┘─┴┘  ╩  └─┘┴└─└─┘└─┘┘└┘┴ ┴┴─┘┴└─┘└─┘─┴┘  ╩ ╩└─┘─┴┘┴└─┘┴┘└┘└─┘                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      The Human Genome Project (HGP) has laid the foundation for personalized medicine, transforming ||    ");
            Console.WriteLine("    ||      healthcare by enabling tailored treatment approaches based on individual genetic information:  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Genetic Profiling                                                                           ||    ");
            Console.WriteLine("    ||      - Utilization of genomic data to create comprehensive genetic profiles for individuals,        ||    ");
            Console.WriteLine("    ||        enhancing understanding of disease susceptibility and drug response.                         ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Tailored Therapies                                                                          ||    ");
            Console.WriteLine("    ||      - Development of targeted therapies based on specific genetic mutations, improving treatment   ||    ");
            Console.WriteLine("    ||        efficacy and reducing side effects in conditions like cancer and rare genetic disorders.     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Pharmacogenomics                                                                            ||    ");
            Console.WriteLine("    ||      - Integration of genetic information to guide medication selection and dosage, optimizing      ||    ");
            Console.WriteLine("    ||        treatment plans based on individual metabolism and genetic variations.                       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Disease Prevention                                                                          ||    ");
            Console.WriteLine("    ||      - Identification of genetic predispositions allows for proactive health measures and           ||    ");
            Console.WriteLine("    ||        lifestyle modifications to prevent diseases before they manifest.                            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Genetic Counseling                                                                          ||    ");
            Console.WriteLine("    ||      - Enhanced genetic counseling services to help individuals and families understand genetic     ||    ");
            Console.WriteLine("    ||        risks, testing options, and implications for health and treatment.                           ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      6. Research and Development                                                                    ||    ");
            Console.WriteLine("    ||      - Accelerated research in personalized medicine, leading to the discovery of new biomarkers    ||    ");
            Console.WriteLine("    ||        and treatment modalities informed by genetic insights.                                       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      7. Ethical Considerations                                                                      ||    ");
            Console.WriteLine("    ||      - Addressing ethical concerns related to genetic testing, data privacy, and access to          ||    ");
            Console.WriteLine("    ||        personalized treatments in diverse populations.                                              ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void FutureGenomicResearch()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                      ╦ ╦┌─┐┬ ┬  ╔═╗╦═╗╦╔═╗╔═╗╦═╗  ╦ ╦┌─┐┬─┐┬┌─┌─┐                               ");
            Console.WriteLine("                                      ╠═╣│ ││││  ║  ╠╦╝║╚═╗╠═╝╠╦╝  ║║║│ │├┬┘├┴┐└─┐                               ");
            Console.WriteLine("                                      ╩ ╩└─┘└┴┘  ╚═╝╩╚═╩╚═╝╩  ╩╚═  ╚╩╝└─┘┴└─┴ ┴└─┘                               ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      The future of genomic research is poised for significant advancements and transformative       ||    ");
            Console.WriteLine("    ||      developments, driven by technological innovations and interdisciplinary collaboration:         ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Advancements in Sequencing Technologies                                                     ||    ");
            Console.WriteLine("    ||      - Continued improvement in sequencing methods, including ultra-high-throughput sequencing and  ||    ");
            Console.WriteLine("    ||        single-cell sequencing, leading to faster and more cost-effective genome analysis.           ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Integration of Artificial Intelligence                                                      ||    ");
            Console.WriteLine("    ||      - Leveraging AI and machine learning algorithms to analyze complex genomic data, enhance       ||    ");
            Console.WriteLine("    ||        predictive models, and identify novel genetic variants associated with diseases.             ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Expanded Applications in Medicine                                                           ||    ");
            Console.WriteLine("    ||      - Increasing use of genomics in precision medicine, including tailored therapies,              ||    ");
            Console.WriteLine("    ||        preventive medicine, and understanding disease mechanisms.                                   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Genomic Editing and Therapeutics                                                            ||    ");
            Console.WriteLine("    ||      - Further development of gene editing technologies, such as CRISPR, for therapeutic            ||    ");
            Console.WriteLine("    ||        applications, including the treatment of genetic disorders and cancers.                      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Population Genomics                                                                         ||    ");
            Console.WriteLine("    ||      - Expansion of population genomics studies to understand genetic diversity,                    ||    ");
            Console.WriteLine("    ||        disease susceptibility, and responses to therapies across different ethnic and demographic   ||    ");
            Console.WriteLine("    ||        groups.                                                                                      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      6. Ethical and Social Considerations                                                           ||    ");
            Console.WriteLine("    ||      - Ongoing discussions about the ethical implications of genomic research, including data       ||    ");
            Console.WriteLine("    ||        privacy, genetic discrimination, and equitable access to genomic technologies.               ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      7. Interdisciplinary Collaboration                                                             ||    ");
            Console.WriteLine("    ||      - Increased collaboration among geneticists, clinicians, bioinformaticians, and social         ||    ");
            Console.WriteLine("    ||        scientists to address complex biological questions and improve health outcomes.              ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");

            Console.ReadKey();
        }

        static void Epigenetics()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                EpigeneticsAnimation();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Clear(); Console.WriteLine("                                                                                           ");
                Console.WriteLine("                                                                                                              ");
                Console.WriteLine("                                                                                                            ");
                Console.WriteLine("                                  ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗             ");
                Console.WriteLine("                                 ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝             ");
                Console.WriteLine("                                 ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗             ");
                Console.WriteLine("                                 ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║             ");
                Console.WriteLine("                                 ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║             ");
                Console.WriteLine("                                  ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝             ");
                Console.WriteLine("                                                                                                             ");
                Console.WriteLine("        ==================================================================================================== ");
                Console.WriteLine("        ||                                                                                                 ||");
                Console.WriteLine("        ||                             Epigenetics:                                                        ||");
                Console.WriteLine("        ||                                                                                                 ||");
                Console.WriteLine("        ||                     [ 1 ] What is Epigenetics?                                                  ||");
                Console.WriteLine("        ||                     [ 2 ] DNA Methylation                                                       ||");
                Console.WriteLine("        ||                     [ 3 ] Histone Modification                                                  ||");
                Console.WriteLine("        ||                     [ 4 ] Environmental Impact on Epigenetics                                   ||");
                Console.WriteLine("        ||                     [ 5 ] Role of Epigenetics in Disease                                        ||");
                Console.WriteLine("        ||                     [ 0 ] Go Back                                                               ||");
                Console.WriteLine("        ||                                                                                                 ||");
                Console.WriteLine("        ==================================================================================================== ");
                Console.WriteLine("                                                                                                            ");
                Console.WriteLine("                                                                                                            ");
                Console.Write("                        Choose an option: ");
                subOption = Convert.ToInt32(Console.ReadLine());

                switch (subOption)
                {
                    case 1: WhatIsEpigenetics(); break;
                    case 2: DNAMethylation(); break;
                    case 3: HistoneModification(); break;
                    case 4: EnvironmentalImpact(); break;
                    case 5: RoleInDisease(); break;
                    default:
                        break;
                }

            } while (subOption != 0);
        }

        static void EpigeneticsAnimation()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            string[] frames = new string[]
            {
                "        ====================================================================================================  \n"+
                "                                    [A]-[C]-[G]-[T]-[C]-[G]-[A]-[T]-[C]-[A]-[G]-[T]  \n" +
                "        ====================================================================================================  ",
                "        ====================================================================================================  \n"+
                "                                    [A]-[C]-[G]-[T]-[C]-[G]-[A]-[T]-[C]-[A]-[G]-[T]\n"+
                "        ====================================================================================================  ",
                "        ====================================================================================================  \n"+
                "                                    [A]-[C]-[G]-[T]-[C]-[G]-[A]-[T]-[C]-[A]-[G]-[T]\n"+
                "        ====================================================================================================  ",
                "        ====================================================================================================  \n"+
                "                                    [A]-[C]-[G]-[T]-[C]-[G]-[A]-[T]-[C]-[A]-[G]-[T]  \n"+
                "        ====================================================================================================  ",
                "        ====================================================================================================  \n"+
                "                                       |               [CH3]                    \n"+
                "        ====================================================================================================  ",
                "        ====================================================================================================  \n"+
                "                                    [A]-[C]-[G]-[T]-[C]-[G]-[A]-[T]-[C]-[A]-[G]-[T]  \n"+
                "        ====================================================================================================  ",
                "        ====================================================================================================  \n"+
                "                                      [CH3]       [CH3]          [CH3]            \n"+
                "        ====================================================================================================  ",
                "        ====================================================================================================  \n"+
                "                                    [A]-[C]-[G]-[T]-[C]-[G]-[A]-[T]-[C]-[A]-[G]-[T]\n"+
                "        ====================================================================================================  ",
                "        ====================================================================================================  \n"+
                "                                    [A]-[C]-[G]-[T]-[C]-[G]-[A]-[T]-[C]-[A]-[G]-[T]\n"+
                "        ====================================================================================================  ",
         };

            for (int i = 0; i < 2; i++)
            {
                foreach (var frame in frames)
                {
                    Console.Clear();
                    Console.WriteLine(frame);
                    Console.WriteLine("                                       Epigenetic Modifications in Progress...");
                    Thread.Sleep(300);
                }
            }

            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Epigenetic Modifications Complete!");
        }


        static void WhatIsEpigenetics()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                ╦ ╦┬ ┬┌─┐┌┬┐  ┬┌─┐  ╔═╗┌─┐┬┌─┐┌─┐┌┐┌┌─┐┌┬┐┬┌─┐┌─┐┌─┐                             ");
            Console.WriteLine("                                ║║║├─┤├─┤ │   │└─┐  ║╣ ├─┘││ ┬├┤ │││├┤  │ ││  └─┐ ┌┘                             ");
            Console.WriteLine("                                ╚╩╝┴ ┴┴ ┴ ┴   ┴└─┘  ╚═╝┴  ┴└─┘└─┘┘└┘└─┘ ┴ ┴└─┘└─┘ o                              ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Epigenetics is the study of heritable changes in gene expression that do not involve changes   ||    ");
            Console.WriteLine("    ||      to the underlying DNA sequence. This field explores how environmental factors can influence    ||    ");
            Console.WriteLine("    ||      gene activity, leading to variations in phenotype without altering the genetic code.           ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Mechanisms of Epigenetics                                                                   ||    ");
            Console.WriteLine("    ||      - Key mechanisms include DNA methylation, histone modification, and non-coding RNA molecules.  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. DNA Methylation                                                                             ||    ");
            Console.WriteLine("    ||      - Addition of methyl groups to DNA molecules, typically at cytosine bases, which can inhibit   ||    ");
            Console.WriteLine("    ||        gene transcription and reduce gene expression.                                               ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Histone Modification                                                                        ||    ");
            Console.WriteLine("    ||      - Post-translational modifications of histone proteins that can affect chromatin structure     ||    ");
            Console.WriteLine("    ||        and gene accessibility, thus influencing gene expression patterns.                           ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Environmental Influences                                                                    ||    ");
            Console.WriteLine("    ||      - Factors such as diet, stress, toxins, and aging can lead to epigenetic changes, impacting    ||    ");
            Console.WriteLine("    ||        gene expression and contributing to various health conditions.                               ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Epigenetics and Development                                                                 ||    ");
            Console.WriteLine("    ||      - Plays a critical role in cellular differentiation, determining how stem cells develop into   ||    ");
            Console.WriteLine("    ||        various cell types with specific functions.                                                  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      6. Implications for Disease                                                                    ||    ");
            Console.WriteLine("    ||      - Aberrant epigenetic modifications are associated with a range of diseases, including cancer, ||    ");
            Console.WriteLine("    ||        cardiovascular diseases, and neurological disorders.                                         ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      7. Therapeutic Potential                                                                       ||    ");
            Console.WriteLine("    ||      - Understanding epigenetic mechanisms opens new avenues for targeted therapies and drug        ||    ");
            Console.WriteLine("    ||        development aimed at reversing harmful epigenetic changes.                                   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void DNAMethylation()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                     ╔╦╗╔╗╔╔═╗  ╔╦╗┌─┐┌┬┐┬ ┬┬ ┬┬  ┌─┐┌┬┐┬┌─┐┌┐┌                                  ");
            Console.WriteLine("                                      ║║║║║╠═╣  ║║║├┤  │ ├─┤└┬┘│  ├─┤ │ ││ ││││                                  ");
            Console.WriteLine("                                     ═╩╝╝╚╝╩ ╩  ╩ ╩└─┘ ┴ ┴ ┴ ┴ ┴─┘┴ ┴ ┴ ┴└─┘┘└┘                                  ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      DNA methylation is a key epigenetic modification involving the addition of a methyl group      ||    ");
            Console.WriteLine("    ||      to the DNA molecule, typically at the cytosine base of CpG dinucleotides. This process plays   ||    ");
            Console.WriteLine("    ||      a crucial role in regulating gene expression, maintaining genomic stability, and influencing   ||    ");
            Console.WriteLine("    ||      various biological processes:                                                                  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Mechanism of DNA Methylation                                                                ||    ");
            Console.WriteLine("    ||      - DNA methylation occurs through the action of DNA methyltransferases, which catalyze the      ||    ");
            Console.WriteLine("    ||        transfer of a methyl group from S-adenosylmethionine (SAM) to the cytosine residue.          ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Regulation of Gene Expression                                                               ||    ");
            Console.WriteLine("    ||      - Methylation of gene promoter regions typically leads to transcriptional silencing,           ||    ");
            Console.WriteLine("    ||        preventing gene expression. Conversely, demethylation can activate gene transcription.       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Role in Development                                                                         ||    ");
            Console.WriteLine("    ||      - DNA methylation patterns change throughout development, playing a vital role in cellular     ||    ");
            Console.WriteLine("    ||        differentiation and tissue-specific gene expression.                                         ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Influence of Environmental Factors                                                          ||    ");
            Console.WriteLine("    ||      - Environmental factors such as diet, toxins, and stress can lead to changes in DNA            ||    ");
            Console.WriteLine("    ||        methylation patterns, potentially influencing health and disease susceptibility.             ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Implications for Disease                                                                    ||    ");
            Console.WriteLine("    ||      - Aberrant DNA methylation is associated with various diseases, including cancer,              ||    ");
            Console.WriteLine("    ||        neurological disorders, and metabolic diseases, often serving as biomarkers for diagnosis.   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      6. Therapeutic Potential                                                                       ||    ");
            Console.WriteLine("    ||      - Targeting DNA methylation pathways offers potential therapeutic strategies for reversing     ||    ");
            Console.WriteLine("    ||        abnormal gene expression and treating diseases.                                              ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      7. Research and Applications                                                                   ||    ");
            Console.WriteLine("    ||      - Ongoing research focuses on understanding the dynamics of DNA methylation and its            ||    ");
            Console.WriteLine("    ||        implications in various fields, including oncology, developmental biology, and               ||    ");
            Console.WriteLine("    ||        personalized medicine.                                                                       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void HistoneModification()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                              ╦ ╦┬┌─┐┌┬┐┌─┐┌┐┌┌─┐  ╔╦╗┌─┐┌┬┐┬┌─┐┬┌─┐┌─┐┌┬┐┬┌─┐┌┐┌                                ");
            Console.WriteLine("                              ╠═╣│└─┐ │ │ ││││├┤   ║║║│ │ │││├┤ ││  ├─┤ │ ││ ││││                                ");
            Console.WriteLine("                              ╩ ╩┴└─┘ ┴ └─┘┘└┘└─┘  ╩ ╩└─┘─┴┘┴└  ┴└─┘┴ ┴ ┴ ┴└─┘┘└┘                                ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Histone modification refers to a set of biochemical modifications to the histone proteins that ||    ");
            Console.WriteLine("    ||      package and order DNA into structural units called nucleosomes. These modifications play a     ||    ");
            Console.WriteLine("    ||      critical role in regulating gene expression and chromatin structure:                           ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Types of Histone Modifications                                                              ||    ");
            Console.WriteLine("    ||      - Common types include acetylation, methylation, phosphorylation, ubiquitination, and          ||    ");
            Console.WriteLine("    ||        sumoylation, each affecting gene expression in different ways.                               ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Acetylation                                                                                 ||    ");
            Console.WriteLine("    ||      - Addition of an acetyl group to lysine residues on histones, leading to a relaxed chromatin   ||    ");
            Console.WriteLine("    ||        structure and enhanced gene transcription.                                                   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Methylation                                                                                 ||    ");
            Console.WriteLine("    ||      - Addition of methyl groups to lysine or arginine residues, which can either activate or       ||    ");
            Console.WriteLine("    ||        repress transcription depending on the specific context and the number of methyl groups .    ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Phosphorylation                                                                             ||    ");
            Console.WriteLine("    ||      - Addition of phosphate groups to specific amino acids, often associated with chromatin        ||    ");
            Console.WriteLine("    ||        remodeling during cell division and response to DNA damage.                                  ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Functional Implications                                                                     ||    ");
            Console.WriteLine("    ||      - Histone modifications impact the accessibility of DNA for transcription factors and other    ||    ");
            Console.WriteLine("    ||        regulatory proteins, thereby influencing gene expression and cellular function.              ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      6. Role in Development and Differentiation                                                     ||    ");
            Console.WriteLine("    ||      - Histone modifications are crucial during embryonic development, guiding cellular             ||    ");
            Console.WriteLine("    ||        differentiation and organogenesis.                                                           ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      7. Implications for Disease                                                                    ||    ");
            Console.WriteLine("    ||      - Abnormal histone modification patterns are associated with various diseases, including       ||    ");
            Console.WriteLine("    ||        cancer, neurological disorders, and cardiovascular diseases, serving as potential            ||    ");
            Console.WriteLine("    ||        biomarkers and therapeutic targets.                                                          ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      8. Therapeutic Approaches                                                                      ||    ");
            Console.WriteLine("    ||      - Development of drugs targeting histone-modifying enzymes, such as histone deacetylase        ||    ");
            Console.WriteLine("    ||        inhibitors, represents a promising strategy for cancer treatment and other diseases.         ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void EnvironmentalImpact()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("        ╔═╗┌┐┌┬  ┬┬┬─┐┌─┐┌┐┌┌┬┐┌─┐┌┐┌┌┬┐┌─┐┬    ╦┌┬┐┌─┐┌─┐┌─┐┌┬┐  ┌─┐┌┐┌  ╔═╗┌─┐┬┌─┐┌─┐┌┐┌┌─┐┌┬┐┬┌─┐┌─┐          ");
            Console.WriteLine("        ║╣ │││└┐┌┘│├┬┘│ │││││││├┤ │││ │ ├─┤│    ║│││├─┘├─┤│   │   │ ││││  ║╣ ├─┘││ ┬├┤ │││├┤  │ ││  └─┐          ");
            Console.WriteLine("        ╚═╝┘└┘ └┘ ┴┴└─└─┘┘└┘┴ ┴└─┘┘└┘ ┴ ┴ ┴┴─┘  ╩┴ ┴┴  ┴ ┴└─┘ ┴   └─┘┘└┘  ╚═╝┴  ┴└─┘└─┘┘└┘└─┘ ┴ ┴└─┘└─┘          ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Environmental factors can significantly influence epigenetic modifications, which in turn      ||    ");
            Console.WriteLine("    ||      affect gene expression and contribute to various biological processes and diseases.            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Types of Environmental Factors                                                              ||    ");
            Console.WriteLine("    ||      - Factors include diet, toxins, stress, pollution, physical activity, and social interactions. ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Diet and Nutrition                                                                          ||");
            Console.WriteLine("    ||      -Nutrient intake, such as folate, vitamins B12, and others, can influence DNA methylation      || ");
            Console.WriteLine("    ||        patterns and histone modifications, affecting gene expression and health outcomes.           ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Exposure to Toxins                                                                          ||");
            Console.WriteLine("    ||      -Chemicals such as heavy metals, pesticides, and endocrine disruptors can alter epigenetic     || ");
            Console.WriteLine("    ||        marks, leading to changes in gene expression linked to various diseases.                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Stress and Lifestyle                                                                        ||");
            Console.WriteLine("    ||      -Chronic stress can induce epigenetic changes that affect stress - response genes and          || ");
            Console.WriteLine("    ||        influence mental health and behavior.                                                        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Physical Activity                                                                           ||");
            Console.WriteLine("    ||      -Regular exercise can lead to beneficial epigenetic changes that enhance metabolic health      || ");
            Console.WriteLine("    ||        and reduce the risk of chronic diseases.                                                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      6. Epigenetic Inheritance                                                                      ||");
            Console.WriteLine("    ||      -Some epigenetic changes induced by environmental factors can be passed down to future         || ");
            Console.WriteLine("    ||        generations, impacting their health and development.                                         ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      7. Implications for Disease                                                                    ||");
            Console.WriteLine("    ||      -Understanding how environmental factors influence epigenetics can help identify               || ");
            Console.WriteLine("    ||        mechanisms behind complex diseases, such as cancer, cardiovascular diseases, and             ||    ");
            Console.WriteLine("    ||        autoimmune disorders.                                                                        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      8. Research and Therapeutic Applications                                                       ||");
            Console.WriteLine("    ||      -Ongoing research aims to uncover how environmental influences interact with epigenetics       || ");
            Console.WriteLine("    ||        to develop strategies for disease prevention and personalized medicine.                      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");

            Console.ReadKey();
        }

        static void RoleInDisease()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                   ╦═╗┌─┐┬  ┌─┐  ┌─┐┌─┐  ╔═╗┌─┐┬┌─┐┌─┐┌┐┌┌─┐┌┬┐┬┌─┐┌─┐  ┬┌┐┌  ╔╦╗┬┌─┐┌─┐┌─┐┌─┐┌─┐                ");
            Console.WriteLine("                   ╠╦╝│ ││  ├┤   │ │├┤   ║╣ ├─┘││ ┬├┤ │││├┤  │ ││  └─┐  ││││   ║║│└─┐├┤ ├─┤└─┐├┤                 ");
            Console.WriteLine("                   ╩╚═└─┘┴─┘└─┘  └─┘└    ╚═╝┴  ┴└─┘└─┘┘└┘└─┘ ┴ ┴└─┘└─┘  ┴┘└┘  ═╩╝┴└─┘└─┘┴ ┴└─┘└─┘                ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Epigenetics plays a crucial role in the development and progression of various diseases by     ||    ");
            Console.WriteLine("    ||      influencing gene expression without altering the underlying DNA sequence. This has important   ||    ");
            Console.WriteLine("    ||      implications for understanding disease mechanisms and developing therapeutic strategies.       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Cancer                                                                                      ||    ");
            Console.WriteLine("    ||      - Abnormal epigenetic modifications, such as DNA methylation and histone modification,         ||    ");
            Console.WriteLine("    ||        contribute to oncogenesis by silencing tumor suppressor genes or activating oncogenes.       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Cardiovascular Diseases                                                                     ||    ");
            Console.WriteLine("    ||      - Epigenetic changes in response to environmental factors can affect genes involved in         ||    ");
            Console.WriteLine("    ||        inflammation, lipid metabolism, and blood pressure regulation, increasing disease risk.      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Neurological Disorders                                                                      ||    ");
            Console.WriteLine("    ||      - Epigenetic mechanisms are implicated in various neurological conditions, including           ||    ");
            Console.WriteLine("    ||        Alzheimer's disease and depression, influencing synaptic plasticity and neuronal function.   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Autoimmune Diseases                                                                         ||    ");
            Console.WriteLine("    ||      - Dysregulation of epigenetic marks can lead to inappropriate gene expression, contributing    ||    ");
            Console.WriteLine("    ||        to the development of autoimmune disorders such as lupus and rheumatoid arthritis.           ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Metabolic Disorders                                                                         ||    ");
            Console.WriteLine("    ||      - Epigenetic changes can affect metabolic pathways, contributing to obesity, diabetes,         ||    ");
            Console.WriteLine("    ||        and related conditions through altered gene expression.                                      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      6. Inherited Epigenetic Changes                                                                ||    ");
            Console.WriteLine("    ||      - Some epigenetic modifications can be inherited, potentially predisposing future              ||    ");
            Console.WriteLine("    ||        generations to certain diseases based on environmental exposures experienced by ancestors.   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      7. Therapeutic Approaches                                                                      ||    ");
            Console.WriteLine("    ||      - Targeting epigenetic modifications using drugs, such as histone deacetylase inhibitors,      ||    ");
            Console.WriteLine("    ||        is being explored as a potential strategy for cancer and other diseases, aiming to restore   ||    ");
            Console.WriteLine("    ||        normal gene expression patterns.                                                             ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      8. Research and Future Directions                                                              ||    ");
            Console.WriteLine("    ||      - Ongoing research aims to elucidate the complex interplay between genetics, epigenetics,      ||    ");
            Console.WriteLine("    ||        and environmental factors to develop more effective prevention and treatment strategies.     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");

            Console.ReadKey();
        }

        static void EvolutionAndGenetics()
        {
            int subOption = 0;

            do
            {

                Console.Clear();
                EvolutionAndGeneticsAnimation();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Clear();
                Console.WriteLine("                                                                                                                          ");
                Console.WriteLine("                                                                                                                          ");
                Console.WriteLine("                                  ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗                          ");
                Console.WriteLine("                                 ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝                          ");
                Console.WriteLine("                                 ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗                          ");
                Console.WriteLine("                                 ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║                          ");
                Console.WriteLine("                                 ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║                          ");
                Console.WriteLine("                                  ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝                          ");
                Console.WriteLine("                                                                                                                          ");
                Console.WriteLine("        ====================================================================================================           ");
                Console.WriteLine("        ||                                                                                                 ||          ");
                Console.WriteLine("        ||                            Evolution and Genetics:                                              ||          ");
                Console.WriteLine("        ||                                                                                                 ||          ");
                Console.WriteLine("        ||                     [ 1 ] What is Evolution?                                                    ||          ");
                Console.WriteLine("        ||                     [ 2 ] Natural Selection                                                     ||          ");
                Console.WriteLine("        ||                     [ 3 ] Genetic Drift                                                         ||          ");
                Console.WriteLine("        ||                     [ 4 ] Gene Flow                                                             ||          ");
                Console.WriteLine("        ||                     [ 5 ] Evolutionary Developmental Biology                                    ||          ");
                Console.WriteLine("        ||                     [ 0 ] Go Back                                                               ||          ");
                Console.WriteLine("        ||                                                                                                 ||          ");
                Console.WriteLine("        ====================================================================================================           ");
                Console.WriteLine("                                                                                                                          ");
                Console.WriteLine("                                                                                                                          ");
 Console.Write("                        Choose an option: ");
                subOption = Convert.ToInt32(Console.ReadLine());

                switch (subOption)
                {
                    case 1: WhatIsEvolution(); break;
                    case 2: NaturalSelection(); break;
                    case 3: GeneticDrift(); break;
                    case 4: GeneFlow(); break;
                    case 5: EvolutionaryDevelopmentalBiology(); break;
                    default:
                        break;
                }

            } while (subOption != 0);
        }

        static void EvolutionAndGeneticsAnimation()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            string[] frames = new string[]
            {
        "        ====================================================================================================  \n"+
        "                                              ========================  \n" +
        "                                              || A - T - G - C - A ||  \n" +
        "                                              || C - G - T - A - C ||  \n" +
        "                                              ========================  \n" +
        "                                                   Initial Sequence     \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                              ========================  \n" +
        "                                              || A - T - G - C - A ||  \n" +
        "                                              || C - G - T - A - C ||  \n" +
        "                                              ========================  \n" +
        "                                                      Stable            \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                             ========================  \n" +
        "                                             || A - T - G - C - T ||  \n" + // Mutation at 5th position
        "                                             || C - G - T - A - C ||  \n" +
        "                                             ========================  \n" +
        "                                                   Mutation A -> T     \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                              ========================  \n" +
        "                                              || A - T - G - C - T ||  \n" + // Retaining mutation
        "                                              || C - G - T - G - C ||  \n" + // Mutation at 4th position
        "                                              ========================  \n" +
        "                                                  Adaptation G -> T     \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                              ========================  \n" +
        "                                              || A - A - G - C - T ||  \n" + // Mutation at 2nd position
        "                                              || C - G - T - G - C ||  \n" + // Retaining previous mutations
        "                                              ========================  \n" +
        "                                                  Evolution A -> A      \n"+
        "        ====================================================================================================  ",
        "        ====================================================================================================  \n"+
        "                                              ========================  \n" +
        "                                              || A - A - G - C - T ||  \n" + // Final state with mutations
        "                                              || C - A - T - G - C ||  \n" + // Change at 2nd position
        "                                              ========================  \n" +
        "                                                   Final Sequence       \n"+
        "        ====================================================================================================  ",
            };

            for (int i = 0; i < 2; i++) // Loop to repeat the animation
            {
                foreach (var frame in frames)
                {
                    Console.Clear();
                    Console.WriteLine(frame);
                    Console.WriteLine("                                          Evolution and Genetics in Action...");
                    Thread.Sleep(700); // Pause for 700 milliseconds for clarity
                }
            }

            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("Evolution and Genetics Process Complete!");
        }


        static void WhatIsEvolution()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                 ┬ ┬┬ ┬┌─┐┌┬┐  ┬┌─┐  ┌─┐┬  ┬┌─┐┬  ┬ ┬┌┬┐┬┌─┐┌┐┌┌─┐                               ");
            Console.WriteLine("                                 │││├─┤├─┤ │   │└─┐  ├┤ └┐┌┘│ ││  │ │ │ ││ ││││ ┌┘                               ");
            Console.WriteLine("                                 └┴┘┴ ┴┴ ┴ ┴   ┴└─┘  └─┘ └┘ └─┘┴─┘└─┘ ┴ ┴└─┘┘└┘ o                                ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Evolution is the process by which different kinds of living organisms develop and diversify    ||    ");
            Console.WriteLine("    ||      from earlier forms over successive generations. It is driven by mechanisms such as natural     ||    ");
            Console.WriteLine("    ||      selection, mutation, gene flow, and genetic drift.                                             ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Natural Selection                                                                           ||    ");
            Console.WriteLine("    ||      - The mechanism proposed by Charles Darwin, where organisms with favorable traits are more     ||    ");
            Console.WriteLine("    ||        likely to survive and reproduce, leading to the adaptation of species over time.             ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Mutation                                                                                    ||    ");
            Console.WriteLine("    ||      - Random changes in DNA sequences that can introduce new traits or variations in a population, ||    ");
            Console.WriteLine("    ||        which can be beneficial, neutral, or harmful.                                                ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Gene Flow                                                                                   ||    ");
            Console.WriteLine("    ||      - The transfer of genetic material between populations through migration or interbreeding,     ||    ");
            Console.WriteLine("    ||        which can increase genetic diversity and alter allele frequencies.                           ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Genetic Drift                                                                               ||    ");
            Console.WriteLine("    ||      - A random process that can cause allele frequencies to change in a population, especially in  ||    ");
            Console.WriteLine("    ||        small populations, leading to the loss of genetic diversity.                                 ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Speciation                                                                                  ||    ");
            Console.WriteLine("    ||      - The process by which new species arise, often through mechanisms such as geographical        ||    ");
            Console.WriteLine("    ||        isolation, reproductive isolation, or adaptive radiation.                                    ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      6. Evidence of Evolution                                                                       ||    ");
            Console.WriteLine("    ||      - Evidence supporting evolution includes fossil records, comparative anatomy, molecular        ||    ");
            Console.WriteLine("    ||        biology, and embryology, which demonstrate the shared ancestry and changes in organisms      ||    ");
            Console.WriteLine("    ||        over time.                                                                                   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      7. Modern Synthesis                                                                            ||    ");
            Console.WriteLine("    ||      - The current understanding of evolution that integrates genetics with Darwin's theory of      ||    ");
            Console.WriteLine("    ||        natural selection, emphasizing the role of genes and population genetics in evolutionary     ||    ");
            Console.WriteLine("    ||        processes.                                                                                   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      8. Implications for Science and Society                                                        ||    ");
            Console.WriteLine("    ||      - Understanding evolution is crucial for fields like medicine, conservation, and agriculture,  ||    ");
            Console.WriteLine("    ||        as it provides insights into the development of diseases, species conservation strategies,   ||    ");
            Console.WriteLine("    ||        and crop improvement.                                                                        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");

            Console.ReadKey();
        }

        static void NaturalSelection()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                ╔╗╔┌─┐┌┬┐┬ ┬┬─┐┌─┐┬    ╔═╗┌─┐┬  ┌─┐┌─┐┌┬┐┬┌─┐┌┐┌                                 ");
            Console.WriteLine("                                ║║║├─┤ │ │ │├┬┘├─┤│    ╚═╗├┤ │  ├┤ │   │ ││ ││││                                 ");
            Console.WriteLine("                                ╝╚╝┴ ┴ ┴ └─┘┴└─┴ ┴┴─┘  ╚═╝└─┘┴─┘└─┘└─┘ ┴ ┴└─┘┘└┘                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Natural selection is a fundamental mechanism of evolution proposed by Charles Darwin. It       ||    ");
            Console.WriteLine("    ||      explains how species adapt to their environments over time through differential survival and   ||    ");
            Console.WriteLine("    ||      reproduction of individuals with favorable traits.                                             ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Variation                                                                                   ||    ");
            Console.WriteLine("    ||      - Within any population, individuals exhibit variations in traits, such as size, color, or     ||    ");
            Console.WriteLine("    ||        behavior. These variations can be genetic and are often influenced by environmental factors. ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Competition                                                                                 ||    ");
            Console.WriteLine("    ||      - Organisms compete for limited resources, such as food, mates, and habitat. This competition  ||    ");
            Console.WriteLine("    ||        creates a struggle for survival, influencing which individuals are more likely to survive    ||    ");
            Console.WriteLine("    ||        and reproduce.                                                                               ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Survival of the Fittest                                                                     ||    ");
            Console.WriteLine("    ||      - Individuals with traits better suited to their environment are more likely to survive and    ||    ");
            Console.WriteLine("    ||        reproduce, passing on their advantageous traits to the next generation.                      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Adaptation                                                                                  ||    ");
            Console.WriteLine("    ||      - Over time, natural selection leads to adaptations, where populations develop traits that     ||    ");
            Console.WriteLine("    ||        enhance their survival and reproduction in specific environments.                            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Speciation                                                                                  ||    ");
            Console.WriteLine("    ||      - Prolonged natural selection can result in speciation, the emergence of new species,          ||    ");
            Console.WriteLine("    ||        when populations of the same species become reproductively isolated due to differing         ||    ");
            Console.WriteLine("    ||        environmental pressures.                                                                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      6. Evidence of Natural Selection                                                               ||    ");
            Console.WriteLine("    ||      - Evidence supporting natural selection includes observations in the fossil record, studies of ||    ");
            Console.WriteLine("    ||        antibiotic resistance in bacteria, and experimental evidence from laboratory studies.        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      7. Human Influence                                                                             ||    ");
            Console.WriteLine("    ||      - Human activities, such as habitat destruction and climate change, can influence natural      ||    ");
            Console.WriteLine("    ||        selection, altering the pressures faced by species and potentially leading to rapid          ||    ");
            Console.WriteLine("    ||        evolutionary changes.                                                                        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      8. Implications for Conservation                                                               ||    ");
            Console.WriteLine("    ||      - Understanding natural selection is crucial for conservation efforts, as it helps predict     ||    ");
            Console.WriteLine("    ||        how species might respond to environmental changes and informs strategies for preserving     ||    ");
            Console.WriteLine("    ||        biodiversity.                                                                                ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void GeneticDrift()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                          ╔═╗┌─┐┌┐┌┌─┐┌┬┐┬┌─┐  ╔╦╗┬─┐┬┌─┐┌┬┐                                     ");
            Console.WriteLine("                                          ║ ╦├┤ │││├┤  │ ││     ║║├┬┘│├┤  │                                      ");
            Console.WriteLine("                                          ╚═╝└─┘┘└┘└─┘ ┴ ┴└─┘  ═╩╝┴└─┴└   ┴                                      ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Genetic drift is a mechanism of evolution that involves random changes in allele frequencies   ||    ");
            Console.WriteLine("    ||      within a population over time, particularly in small populations. These changes can lead to    ||    ");
            Console.WriteLine("    ||      the loss of genetic diversity and can influence evolutionary trajectories.                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Random Sampling                                                                             ||    ");
            Console.WriteLine("    ||      - Genetic drift occurs due to the random sampling of alleles from one generation to the next,  ||    ");
            Console.WriteLine("    ||        leading to fluctuations in allele frequencies that are not driven by natural selection.      ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Founder Effect                                                                              ||    ");
            Console.WriteLine("    ||      - When a small group of individuals establishes a new population, the allele frequencies in    ||    ");
            Console.WriteLine("    ||        that group may differ significantly from the original population, leading to a reduced       ||    ");
            Console.WriteLine("    ||        genetic diversity in the new population.                                                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Bottleneck Effect                                                                           ||    ");
            Console.WriteLine("    ||      - A sudden reduction in population size, such as due to environmental events or human          ||    ");
            Console.WriteLine("    ||        activities, can drastically reduce genetic diversity and alter allele frequencies in the     ||    ");
            Console.WriteLine("    ||        surviving population.                                                                        ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Implications for Evolution                                                                  ||    ");
            Console.WriteLine("    ||      - Genetic drift can lead to the fixation or loss of alleles over time, influencing the         ||    ");
            Console.WriteLine("    ||        evolution of traits within populations. It can also affect speciation processes.             ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Interaction with Natural Selection                                                          ||    ");
            Console.WriteLine("    ||      - Genetic drift can interact with natural selection, where random changes may favor certain    ||    ");
            Console.WriteLine("    ||        alleles in specific environments, complicating the understanding of evolutionary dynamics.   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      6. Impact on Conservation                                                                      ||    ");
            Console.WriteLine("    ||      - In conservation biology, genetic drift is a significant concern for small or isolated        ||    ");
            Console.WriteLine("    ||        populations, as it can lead to inbreeding and loss of genetic variability, affecting their   ||    ");
            Console.WriteLine("    ||        ability to adapt to environmental changes.                                                   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      7. Experimental Evidence                                                                       ||    ");
            Console.WriteLine("    ||      - Studies, including laboratory experiments with organisms and field observations, have        ||    ");
            Console.WriteLine("    ||        demonstrated the effects of genetic drift on allele frequencies and population genetics.     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      8. Implications for Human Populations                                                          ||    ");
            Console.WriteLine("    ||      - Genetic drift can also occur in human populations, particularly in isolated or small         ||    ");
            Console.WriteLine("    ||        communities, influencing genetic diversity and health outcomes.                              ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void GeneFlow()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                            ╔═╗┌─┐┌┐┌┌─┐  ╔═╗┬  ┌─┐┬ ┬                                           ");
            Console.WriteLine("                                            ║ ╦├┤ │││├┤   ╠╣ │  │ ││││                                           ");
            Console.WriteLine("                                            ╚═╝└─┘┘└┘└─┘  ╚  ┴─┘└─┘└┴┘                                           ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Gene flow, also known as gene migration, is the transfer of genetic material between           ||    ");
            Console.WriteLine("    ||      populations through processes such as migration, interbreeding, or the movement of gametes.    ||    ");
            Console.WriteLine("    ||      It plays a crucial role in maintaining genetic diversity and influencing evolutionary dynamics.||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Mechanisms of Gene Flow                                                                     ||    ");
            Console.WriteLine("    ||      - Gene flow can occur through various mechanisms, including the movement of individuals,       ||    ");
            Console.WriteLine("    ||        pollen transfer in plants, and dispersal of seeds.                                           ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Importance for Genetic Diversity                                                            ||    ");
            Console.WriteLine("    ||      - Gene flow increases genetic diversity within populations by introducing new alleles, which   ||    ");
            Console.WriteLine("    ||        can enhance adaptability and resilience to environmental changes.                            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Impact on Local Populations                                                                 ||    ");
            Console.WriteLine("    ||      - While gene flow can benefit populations by increasing diversity, it can also threaten local  ||    ");
            Console.WriteLine("    ||        adaptations by diluting unique alleles, leading to a loss of local traits.                   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Gene Flow and Speciation                                                                    ||    ");
            Console.WriteLine("    ||      - Gene flow can inhibit speciation by allowing gene exchange between populations, which may    ||    ");
            Console.WriteLine("    ||        reduce the chances of reproductive isolation.                                                ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Human Influence on Gene Flow                                                                ||    ");
            Console.WriteLine("    ||      - Human activities, such as habitat fragmentation and urbanization, can disrupt natural gene   ||    ");
            Console.WriteLine("    ||        flow, leading to isolated populations and decreased genetic diversity.                       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      6. Applications in Conservation                                                                ||    ");
            Console.WriteLine("    ||      - Understanding gene flow is essential for conservation strategies, as it informs decisions    ||    ");
            Console.WriteLine("    ||        about habitat corridors, wildlife corridors, and breeding programs to maintain genetic       ||    ");
            Console.WriteLine("    ||        diversity among endangered species.                                                          ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      7. Gene Flow in Agriculture                                                                    ||    ");
            Console.WriteLine("    ||      - In agriculture, gene flow can affect crop varieties, particularly when genetically modified  ||    ");
            Console.WriteLine("    ||        organisms (GMOs) crossbreed with wild or heirloom varieties, potentially impacting food      ||    ");
            Console.WriteLine("    ||        security and biodiversity.                                                                   ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      8. Research and Methodology                                                                    ||    ");
            Console.WriteLine("    ||      - Studies on gene flow often involve genetic analysis, tracking movements, and monitoring      ||    ");
            Console.WriteLine("    ||        populations to understand patterns of gene exchange and their effects on evolution.          ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();
        }

        static void EvolutionaryDevelopmentalBiology()
        {
            Console.Clear();
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("      ╔═╗┬  ┬┌─┐┬  ┬ ┬┌┬┐┬┌─┐┌┐┌┌─┐┬─┐┬ ┬  ╔╦╗┌─┐┬  ┬┌─┐┬  ┌─┐┌─┐┌┬┐┌─┐┌┐┌┌┬┐┌─┐┬    ╔╗ ┬┌─┐┬  ┌─┐┌─┐┬ ┬         ");
            Console.WriteLine("      ║╣ └┐┌┘│ ││  │ │ │ ││ ││││├─┤├┬┘└┬┘   ║║├┤ └┐┌┘├┤ │  │ │├─┘│││├┤ │││ │ ├─┤│    ╠╩╗││ ││  │ ││ ┬└┬┘         ");
            Console.WriteLine("      ╚═╝ └┘ └─┘┴─┘└─┘ ┴ ┴└─┘┘└┘┴ ┴┴└─ ┴   ═╩╝└─┘ └┘ └─┘┴─┘└─┘┴  ┴ ┴└─┘┘└┘ ┴ ┴ ┴┴─┘  ╚═╝┴└─┘┴─┘└─┘└─┘ ┴          ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("    ========================================================================================================     ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      Evolutionary developmental biology (evo-devo) is a field of biology that studies the           ||    ");
            Console.WriteLine("    ||      relationship between development and evolutionary processes. It integrates concepts from       ||    ");
            Console.WriteLine("    ||      evolutionary biology, genetics, and developmental biology to understand how developmental      ||    ");
            Console.WriteLine("    ||      processes influence evolutionary change.                                                       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      1. Core Concepts                                                                               ||    ");
            Console.WriteLine("    ||      - Evo-devo examines how changes in developmental pathways can lead to morphological and        ||    ");
            Console.WriteLine("    ||        functional diversity among organisms over evolutionary time.                                 ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      2. Developmental Pathways                                                                      ||    ");
            Console.WriteLine("    ||      - Key developmental processes, such as cell differentiation, growth, and pattern formation,    ||    ");
            Console.WriteLine("    ||        play critical roles in shaping organismal form and function.                                 ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      3. Evolutionary Change                                                                         ||    ");
            Console.WriteLine("    ||      - Small genetic changes during development can result in significant evolutionary adaptations, ||    ");
            Console.WriteLine("    ||        leading to novel traits or even new species over time.                                       ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      4. Homology and Evolution                                                                      ||    ");
            Console.WriteLine("    ||      - Evo-devo studies homologies in developmental mechanisms across different species, helping    ||    ");
            Console.WriteLine("    ||        to trace evolutionary relationships and understand the origins of complex traits.            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      5. Model Organisms                                                                             ||    ");
            Console.WriteLine("    ||      - Researchers use various model organisms, such as fruit flies (Drosophila), zebrafish, and    ||    ");
            Console.WriteLine("    ||        mice, to investigate developmental processes and their evolutionary implications.            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      6. Applications in Evolutionary Biology                                                        ||    ");
            Console.WriteLine("    ||      - Insights from evo-devo contribute to understanding the evolution of major innovations,       ||    ");
            Console.WriteLine("    ||        including limbs, wings, and other adaptations.                                               ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      7. Integration with Other Disciplines                                                          ||    ");
            Console.WriteLine("    ||      - Evo-devo intersects with paleontology, ecology, and genomics, providing a comprehensive      ||    ");
            Console.WriteLine("    ||        understanding of how organisms develop and evolve in their environments.                     ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    ||      8. Evolutionary Innovations                                                                    ||    ");
            Console.WriteLine("    ||      - Evo-devo explores the genetic basis of evolutionary innovations and the genetic changes      ||    ");
            Console.WriteLine("    ||        that facilitate the emergence of new traits, such as the transition from aquatic to          ||    ");
            Console.WriteLine("    ||        terrestrial life.                                                                            ||    ");
            Console.WriteLine("    ||                                                                                                     ||    ");
            Console.WriteLine("    =========================================================================================================    ");
            Console.WriteLine("                                                                                                                 ");
            Console.WriteLine("                                    (Enter any key to return to the menu)                                        ");
            Console.WriteLine("                                                                                                                 ");
            Console.ReadKey();


        }
    }
}
