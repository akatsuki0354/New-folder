//Franco Gregorio
// BSIS 1-2
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("                                                                                      ");
                Console.WriteLine("                                                                                      ");
                Console.WriteLine("            ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗            ");
                Console.WriteLine("           ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝            ");
                Console.WriteLine("           ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗            ");
                Console.WriteLine("           ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║            ");
                Console.WriteLine("           ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║            ");
                Console.WriteLine("            ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝            ");
                Console.WriteLine("                                                                                      ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("           ================================================================           ");
                Console.WriteLine("           ||                                                            ||           ");
                Console.WriteLine("           ||                       Genetics Menu:                       ||           ");
                Console.WriteLine("           ||                                                            ||           ");
                Console.WriteLine("           ||      [ 1 ] What is Genetics                                ||           ");
                Console.WriteLine("           ||      [ 2 ] Types of Genetic Inheritance                    ||           ");
                Console.WriteLine("           ||      [ 3 ] More Information About DNA and Genes            ||           ");
                Console.WriteLine("           ||      [ 4 ] Chromosomes and Their Function                  ||           ");
                Console.WriteLine("           ||      [ 5 ] Genetic Mutations                               ||           ");
                Console.WriteLine("           ||      [ 6 ] Gene Editing (CRISPR and Other Technologies)    ||           ");
                Console.WriteLine("           ||      [ 7 ] Human Genome Project                            ||           ");
                Console.WriteLine("           ||      [ 8 ] Epigenetics                                     ||           ");
                Console.WriteLine("           ||      [ 9 ] Evolution and Genetics                          ||           ");
                Console.WriteLine("           ||      [ 0 ] Exit                                            ||           ");
                Console.WriteLine("           ||                                                            ||           ");
                Console.WriteLine("           ================================================================           ");
                Console.WriteLine("                                                                                      ");
                Console.WriteLine("                                                                                      ");
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
                }

            } while (chosenOne != 0);
        }


        static void SpinAnimation()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            string[] frames = new string[]
       {
            "  O     O  \n   \\   /   \n    O-O    \n   /   \\   \n  O     O  \n   \\   /   \n    O-O    \n   /   \\   \n  O     O  \n   \\   /   \n    O-O    \n   /   \\   \n  O     O  \n   \\   /   \n    O-O    \n   /   \\   ",
            "   O     O  \n    \\   /   \n     O-O    \n    /   \\   \n   O     O  \n    \\   /   \n     O-O    \n    /   \\   \n   O     O  \n    \\   /   \n     O-O    \n    /   \\   \n   O     O  \n    \\   /   \n     O-O    \n    /   \\   ",
            "    O     O  \n     \\   /   \n      O-O    \n     /   \\   \n    O     O  \n     \\   /   \n      O-O    \n     /   \\   \n    O     O  \n     \\   /   \n      O-O    \n     /   \\   \n    O     O  \n     \\   /   \n      O-O    \n     /   \\   ",
            "   O     O   \n   \\   /     \n   O-O       \n   /   \\     \n  O     O    \n   \\   /     \n   O-O       \n   /   \\     \n  O     O    \n   \\   /     \n   O-O       \n   /   \\     \n  O     O    \n   \\   /     \n   O-O       \n   /   \\     ",
            "  O     O    \n   \\   /     \n    O-O      \n   /   \\     \n  O     O    \n   \\   /     \n    O-O      \n   /   \\     \n  O     O    \n   \\   /     \n    O-O      \n   /   \\     \n  O     O    \n   \\   /     \n    O-O      \n   /   \\     "
       };

            for (int i = 0; i < 5; i++) // Loop to repeat the animation
            {
                foreach (var frame in frames)
                {
                    Console.Clear(); // Clear the console for the next frame
                    Console.WriteLine(frame);
                    Console.WriteLine("Genetics Loading...");
                    Thread.Sleep(200); // Wait for 200 milliseconds
                }
            }

            Console.WriteLine("Animation complete.");
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
                Console.ForegroundColor = ConsoleColor.Red;
                AnimateGeneticInheritance();
                Console.Clear();
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗               ");
                Console.WriteLine("               ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝               ");
                Console.WriteLine("               ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗               ");
                Console.WriteLine("               ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║               ");
                Console.WriteLine("               ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║               ");
                Console.WriteLine("                ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝               ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("           =======================================================================           ");
                Console.WriteLine("           ||                                                                   ||           ");
                Console.WriteLine("           ||                    Types of Genetic Inheritance:                  ||           ");
                Console.WriteLine("           ||                                                                   ||           ");
                Console.WriteLine("           ||              [ 1 ] Dominant Inheritance                           ||           ");
                Console.WriteLine("           ||              [ 2 ] Recessive Inheritance                          ||           ");
                Console.WriteLine("           ||              [ 3 ] Co-Dominance                                   ||           ");
                Console.WriteLine("           ||              [ 4 ] Incomplete Dominance                           ||           ");
                Console.WriteLine("           ||              [ 5 ] Sex-Linked Inheritance                         ||           ");
                Console.WriteLine("           ||              [ 6 ] Mitochondrial Inheritance                      ||           ");
                Console.WriteLine("           ||              [ 0 ] Go Back                                        ||           ");
                Console.WriteLine("           ||                                                                   ||           ");
                Console.WriteLine("           =======================================================================           ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");
                Console.Write("                           Choose an option: ");

                subOption = Convert.ToInt32(Console.ReadLine());

                switch (subOption)
                {
                    case 1: Inheritance1(); break;
                    case 2: Inheritance2(); break;
                    case 3: Inheritance3(); break;
                    case 4: Inheritance4(); break;
                    case 5: Inheritance5(); break;
                    case 6: Inheritance6(); break;
                }

            } while (subOption != 0);
        }

        static void AnimateGeneticInheritance()
        {
            string[] frames = new string[]
            {
            " Parent 1 (Alleles: A, a)          Parent 2 (Alleles: A, a)\n" +
            "         |                                  |\n" +
            "         |                                  |\n" +
            "         |                                  |\n" +
            "        [A]                                [a]",

            " Parent 1 (Alleles: A, a)          Parent 2 (Alleles: A, a)\n" +
            "         |                                  |\n" +
            "         |                                  |\n" +
            "         |                                  |\n" +
            "         |                                  |\n" +
            "        [A]                                [a]\n" +
            "          \\                                /\n" +
            "           \\                              /\n" +
            "            \\                            /\n" +
            "             \\                          /\n" +
            "              \\                        /\n" +
            "               Offspring Alleles: [A, a]",

            " Parent 1 (Alleles: A, a)          Parent 2 (Alleles: A, a)\n" +
            "         |                                  |\n" +
            "        [A]                                [A]\n" +
            "          \\                                /\n" +
            "           \\                              /\n" +
            "            \\                            /\n" +
            "             \\                          /\n" +
            "               Offspring Alleles: [A, A]",

            " Parent 1 (Alleles: A, a)          Parent 2 (Alleles: A, a)\n" +
            "         |                                  |\n" +
            "        [a]                                [A]\n" +
            "          \\                                /\n" +
            "           \\                              /\n" +
            "            \\                            /\n" +
            "             \\                          /\n" +
            "               Offspring Alleles: [a, A]",

            " Parent 1 (Alleles: A, a)          Parent 2 (Alleles: A, a)\n" +
            "         |                                  |\n" +
            "        [a]                                [a]\n" +
            "          \\                                /\n" +
            "           \\                              /\n" +
            "            \\                            /\n" +
            "             \\                          /\n" +
            "               Offspring Alleles: [a, a]"
            };

            for (int i = 0; i < 1; i++)
            {
                foreach (var frame in frames)
                {
                    Console.Clear();
                    Console.WriteLine(frame);
                    Console.WriteLine("");
                    Console.WriteLine("===================================================");
                    Console.WriteLine("          Genetic Inheritance Loading...");
                    Thread.Sleep(1000);
                }
            }
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
                Console.ForegroundColor = ConsoleColor.Cyan;
                AnimateDNAAndGenes();
                Console.Clear();
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗               ");
                Console.WriteLine("               ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝               ");
                Console.WriteLine("               ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗               ");
                Console.WriteLine("               ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║               ");
                Console.WriteLine("               ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║               ");
                Console.WriteLine("                ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝               ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("               =================================================================             ");
                Console.WriteLine("               ||                                                             ||             ");
                Console.WriteLine("               ||             More Information About DNA and Genes:           ||             ");
                Console.WriteLine("               ||                                                             ||             ");
                Console.WriteLine("               ||             [ 1 ] Introduction to DNA                       ||             ");
                Console.WriteLine("               ||             [ 2 ] Genes and Their Functions                 ||             ");
                Console.WriteLine("               ||             [ 3 ] DNA Replication                           ||             ");
                Console.WriteLine("               ||             [ 4 ] Gene Expression and Regulation            ||             ");
                Console.WriteLine("               ||             [ 5 ] Genetic Variation                         ||             ");
                Console.WriteLine("               ||             [ 6 ] Inheritance Patterns                      ||             ");
                Console.WriteLine("               ||             [ 7 ] Genetic Technologies                      ||             ");
                Console.WriteLine("               ||             [ 8 ] Human Genome Project                      ||             ");
                Console.WriteLine("               ||             [ 9 ] Ethical Considerations in Genetics        ||             ");
                Console.WriteLine("               ||             [ 10 ] Future of Genetics                       ||             ");
                Console.WriteLine("               ||             [ 0 ] Go Back                                   ||             ");
                Console.WriteLine("               ||                                                             ||             ");
                Console.WriteLine("               =================================================================             ");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.Write("               Choose an option: ");
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
                }

            } while (subOption != 0);
        }

        static void AnimateDNAAndGenes()
        {
            // Array of frames for the DNA helix with gene sequences
            string[] frames = new string[]
            {
            "         A       T\n" +
            "          \\     /\n" +
            "           \\   /\n" +
            "            C-G\n" +
            "           /   \\\n" +
            "          /     \\\n" +
            "         T       A",

            "         C       G\n" +
            "          \\     /\n" +
            "           \\   /\n" +
            "            T-A\n" +
            "           /   \\\n" +
            "          /     \\\n" +
            "         A       T",

            "         T       A\n" +
            "          \\     /\n" +
            "           \\   /\n" +
            "            G-C\n" +
            "           /   \\\n" +
            "          /     \\\n" +
            "         C       G",

            "         G       C\n" +
            "          \\     /\n" +
            "           \\   /\n" +
            "            A-T\n" +
            "           /   \\\n" +
            "          /     \\\n" +
            "         T       A"
            };

            // Loop through frames to create the animation effect
            for (int i = 0; i < 3; i++) // Repeat the sequence for a longer animation
            {
                foreach (var frame in frames)
                {
                    Console.Clear();
                    Console.WriteLine(frame);
                    Console.WriteLine("DNA and Genes Loading..");
                    Thread.Sleep(500); // Delay between frames to control animation speed
                }
            }
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
            Console.WriteLine("Chromosomes and Their Function:");
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
                Console.ForegroundColor = ConsoleColor.Green;
                AnimateGeneticMutations();
                Console.Clear();
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗               ");
                Console.WriteLine("               ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝               ");
                Console.WriteLine("               ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗               ");
                Console.WriteLine("               ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║               ");
                Console.WriteLine("               ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║               ");
                Console.WriteLine("                ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝               ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("           =======================================================================           ");
                Console.WriteLine("           ||                                                                   ||           ");
                Console.WriteLine("           ||                   Genetic Mutations:                              ||           ");
                Console.WriteLine("           ||                                                                   ||           ");
                Console.WriteLine("           ||                 [ 1 ] Types of Mutations                          ||           ");
                Console.WriteLine("           ||                 [ 2 ] Causes of Mutations                         ||           ");
                Console.WriteLine("           ||                 [ 3 ] Effects of Mutations                        ||           ");
                Console.WriteLine("           ||                 [ 0 ] Go Back                                     ||           ");
                Console.WriteLine("           ||                                                                   ||           ");
                Console.WriteLine("           =======================================================================           ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");

                Console.Write("Choose an option: ");

                subOption = Convert.ToInt32(Console.ReadLine());

                switch (subOption)
                {
                    case 1: TypesOfMutations(); break;
                    case 2: CausesOfMutations(); break;
                    case 3: EffectsOfMutations(); break;
                }

            } while (subOption != 0);
        }


        static void AnimateGeneticMutations()
        {
            // Array of frames to demonstrate genetic mutations using symbols
            string[] frames = new string[]
             {
            "Original DNA Sequence:\n" +
            "  A-T  C-G  A-T  G-C\n" +
            "   |    |    |    |\n" +
            "   |    |    |    |\n" +
            "   A    T    A    G\n",

            "Mutation 1:\n" +
            "  A-T  C-G  A-T  G-C\n" +
            "   |    |    |    |\n" +
            "   |    |    |    |\n" +
            "   A    T    G    G\n" +
            "   (A-T changed to A-G)",

            "Mutation 2:\n" +
            "  A-T  C-G  A-T  G-C\n" +
            "   |    |    |    |\n" +
            "   |    |    |    |\n" +
            "   A    T    G    T\n" +
            "   (C-G changed to T-A)",

            "Mutation 3:\n" +
            "  A-T  C-G  A-T  G-C\n" +
            "   |    |    |    |\n" +
            "   |    |    |    |\n" +
            "   T    T    G    T\n" +
            "   (A-T changed to T-T)",

            "Final Mutated DNA Sequence:\n" +
            "  T-T  T-A  G-T  G-C\n" +
            "   |    |    |    |\n" +
            "   |    |    |    |\n" +
            "   T    A    G    C\n"
        };

            // Loop through frames to create the animation effect
            for (int i = 0; i < 2; i++) // Repeat the sequence for a longer animation
            {
                foreach (var frame in frames)
                {
                    Console.Clear();
                    Console.WriteLine(frame);
                    Console.WriteLine("Genetic Mutations Loading...");
                    Thread.Sleep(1000); // Delay between frames to control animation speed
                }
            }
        }

        static void TypesOfMutations()
        {
            int subOption = 0; // Initialized to a non-zero value to enter the loop

            do
            {
                Console.Clear();
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                        ╔═╗┌─┐┌┐┌┌─┐┌┬┐┬┌─┐  ╔╦╗┬ ┬┌┬┐┌─┐┌┬┐┬┌─┐┌┐┌┌─┐                       ");
                Console.WriteLine("                        ║ ╦├┤ │││├┤  │ ││    ║║║│ │ │ ├─┤ │ ││ ││││└─┐                       ");
                Console.WriteLine("                        ╚═╝└─┘┘└┘└─┘ ┴ ┴└─┘  ╩ ╩└─┘ ┴ ┴ ┴ ┴ ┴└─┘┘└┘└─┘                       ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("           =======================================================================           ");
                Console.WriteLine("           ||                                                                   ||           ");
                Console.WriteLine("           ||                          Genetic Mutations:                       ||           ");
                Console.WriteLine("           ||                                                                   ||           ");
                Console.WriteLine("           ||                      [ 1 ] Point Mutations                        ||           ");
                Console.WriteLine("           ||                      [ 2 ] Frameshift Mutations                   ||           ");
                Console.WriteLine("           ||                      [ 3 ] Silent Mutations                       ||           ");
                Console.WriteLine("           ||                      [ 4 ] Missense Mutations                     ||           ");
                Console.WriteLine("           ||                      [ 5 ] Nonsense Mutations                     ||           ");
                Console.WriteLine("           ||                      [ 6 ] Chromosomal Mutations                  ||           ");
                Console.WriteLine("           ||                      [ 0 ] Go Back                                ||           ");
                Console.WriteLine("           ||                                                                   ||           ");
                Console.WriteLine("           =======================================================================           ");
                Console.WriteLine("                                                                                             ");
                Console.Write("           Choose an option: ");
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
                        Console.WriteLine("           Invalid option. Please choose a number between 0 and 6.");
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
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗               ");
                Console.WriteLine("               ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝               ");
                Console.WriteLine("               ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗               ");
                Console.WriteLine("               ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║               ");
                Console.WriteLine("               ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║               ");
                Console.WriteLine("                ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝               ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("           =======================================================================           ");
                Console.WriteLine("           ||                                                                   ||           ");
                Console.WriteLine("           ||                 Gene Editing (CRISPR and Other Technologies):     ||           ");
                Console.WriteLine("           ||                                                                   ||           ");
                Console.WriteLine("           ||                 [ 1 ] What is CRISPR?                             ||           ");
                Console.WriteLine("           ||                 [ 2 ] How CRISPR Works                            ||           ");
                Console.WriteLine("           ||                 [ 3 ] Applications of CRISPR in Medicine          ||           ");
                Console.WriteLine("           ||                 [ 4 ] Gene Therapy and CRISPR                     ||           ");
                Console.WriteLine("           ||                 [ 5 ] Ethical Issues in Gene Editing              ||           ");
                Console.WriteLine("           ||                 [ 6 ] Future of CRISPR Technology                 ||           ");
                Console.WriteLine("           ||                 [ 7 ] Other Gene Editing Technologies             ||           ");
                Console.WriteLine("           ||                 [ 8 ] Gene Editing in Agriculture                 ||           ");
                Console.WriteLine("           ||                 [ 9 ] Gene Editing and Cancer Research            ||           ");
                Console.WriteLine("           ||                 [ 10 ] Risks and Limitations of Gene Editing      ||           ");
                Console.WriteLine("           ||                 [ 0 ] Go Back                                     ||           ");
                Console.WriteLine("           ||                                                                   ||           ");
                Console.WriteLine("           =======================================================================           ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");

                Console.Write("           Choose an option: ");

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
                }

            } while (subOption != 0);
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
            Console.WriteLine("Future of CRISPR Technology");
            Console.ReadKey();
        }

        static void OtherGeneEditingTechnologies()
        {
            Console.Clear();
            Console.WriteLine("Other Gene Editing Technologies (Zinc Finger Nucleases, TALENs)");
            Console.ReadKey();
        }

        static void GeneEditingInAgriculture()
        {
            Console.Clear();
            Console.WriteLine("Gene Editing in Agriculture");
            Console.ReadKey();
        }

        static void GeneEditingCancerResearch()
        {
            Console.Clear();
            Console.WriteLine("Gene Editing and Cancer Research");
            Console.ReadKey();
        }

        static void RisksAndLimitationsGeneEditing()
        {
            Console.Clear();
            Console.WriteLine("Risks and Limitations of Gene Editing");
            Console.ReadKey();
        }

        static void HumanGenomeProject()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗               ");
                Console.WriteLine("               ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝               ");
                Console.WriteLine("               ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗               ");
                Console.WriteLine("               ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║               ");
                Console.WriteLine("               ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║               ");
                Console.WriteLine("                ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝               ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("           =======================================================================           ");
                Console.WriteLine("           ||                                                                   ||           ");
                Console.WriteLine("           ||                   Human Genome Project:                           ||           ");
                Console.WriteLine("           ||                                                                   ||           ");
                Console.WriteLine("           ||   [ 1 ] Overview of the Human Genome Project                      ||           ");
                Console.WriteLine("           ||   [ 2 ] Goals of the Human Genome Project                         ||           ");
                Console.WriteLine("           ||   [ 3 ] Timeline of the Human Genome Project                      ||           ");
                Console.WriteLine("           ||   [ 4 ] Achievements of the Human Genome Project                  ||           ");
                Console.WriteLine("           ||   [ 5 ] Impact of the Human Genome Project on Medicine            ||           ");
                Console.WriteLine("           ||   [ 6 ] Ethical Concerns Related to the Human Genome Project      ||           ");
                Console.WriteLine("           ||   [ 7 ] International Collaboration in the Human Genome Project   ||           ");
                Console.WriteLine("           ||   [ 8 ] Role of Technology in the Human Genome Project            ||           ");
                Console.WriteLine("           ||   [ 9 ] Human Genome Project and Personalized Medicine            ||           ");
                Console.WriteLine("           ||   [ 10 ] Future of Genomic Research                               ||           ");
                Console.WriteLine("           ||   [ 0 ] Go Back                                                   ||           ");
                Console.WriteLine("           ||                                                                   ||           ");
                Console.WriteLine("           =======================================================================           ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");
                Console.Write("Choose an option: ");

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
                }

            } while (subOption != 0);
        }

        static void OverviewHumanGenomeProject()
        {
            Console.Clear();
            Console.WriteLine("Overview of the Human Genome Project");
            Console.ReadKey();
        }

        static void GoalsHumanGenomeProject()
        {
            Console.Clear();
            Console.WriteLine("Goals of the Human Genome Project");
            Console.ReadKey();
        }

        static void TimelineHumanGenomeProject()
        {
            Console.Clear();
            Console.WriteLine("Timeline of the Human Genome Project");
            Console.ReadKey();
        }

        static void AchievementsHumanGenomeProject()
        {
            Console.Clear();
            Console.WriteLine("Achievements of the Human Genome Project");
            Console.ReadKey();
        }

        static void ImpactHumanGenomeProject()
        {
            Console.Clear();
            Console.WriteLine("Impact of the Human Genome Project on Medicine");
            Console.ReadKey();
        }

        static void EthicalConcernsHumanGenomeProject()
        {
            Console.Clear();
            Console.WriteLine("Ethical Concerns Related to the Human Genome Project");
            Console.ReadKey();
        }

        static void InternationalCollaboration()
        {
            Console.Clear();
            Console.WriteLine("International Collaboration in the Human Genome Project");
            Console.ReadKey();
        }

        static void RoleOfTechnology()
        {
            Console.Clear();
            Console.WriteLine("Role of Technology in the Human Genome Project");
            Console.ReadKey();
        }

        static void PersonalizedMedicine()
        {
            Console.Clear();
            Console.WriteLine("Human Genome Project and Personalized Medicine");
            Console.ReadKey();
        }

        static void FutureGenomicResearch()
        {
            Console.Clear();
            Console.WriteLine("Future of Genomic Research");
            Console.ReadKey();
        }

        static void Epigenetics()
        {
            int subOption = 0;

            do
            {

                Console.Clear();
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗               ");
                Console.WriteLine("               ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝               ");
                Console.WriteLine("               ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗               ");
                Console.WriteLine("               ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║               ");
                Console.WriteLine("               ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║               ");
                Console.WriteLine("                ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝               ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("           =======================================================================           ");
                Console.WriteLine("           ||                                                                   ||           ");
                Console.WriteLine("           ||                     Epigenetics:                                  ||           ");
                Console.WriteLine("           ||                                                                   ||           ");
                Console.WriteLine("           ||                 [ 1 ] What is Epigenetics?                        ||           ");
                Console.WriteLine("           ||                 [ 2 ] DNA Methylation                             ||           ");
                Console.WriteLine("           ||                 [ 3 ] Histone Modification                        ||           ");
                Console.WriteLine("           ||                 [ 4 ] Environmental Impact on Epigenetics         ||           ");
                Console.WriteLine("           ||                 [ 5 ] Role of Epigenetics in Disease              ||           ");
                Console.WriteLine("           ||                 [ 0 ] Go Back                                     ||           ");
                Console.WriteLine("           ||                                                                   ||           ");
                Console.WriteLine("           =======================================================================           ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");
                Console.Write("Choose an option: ");

                subOption = Convert.ToInt32(Console.ReadLine());

                switch (subOption)
                {
                    case 1: WhatIsEpigenetics(); break;
                    case 2: DNAMethylation(); break;
                    case 3: HistoneModification(); break;
                    case 4: EnvironmentalImpact(); break;
                    case 5: RoleInDisease(); break;
                }

            } while (subOption != 0);
        }

        static void WhatIsEpigenetics()
        {
            Console.Clear();
            Console.WriteLine("What is Epigenetics?");
            Console.ReadKey();
        }

        static void DNAMethylation()
        {
            Console.Clear();
            Console.WriteLine("DNA Methylation");
            Console.ReadKey();
        }

        static void HistoneModification()
        {
            Console.Clear();
            Console.WriteLine("Histone Modification");
            Console.ReadKey();
        }

        static void EnvironmentalImpact()
        {
            Console.Clear();
            Console.WriteLine("Environmental Impact on Epigenetics");
            Console.ReadKey();
        }

        static void RoleInDisease()
        {
            Console.Clear();
            Console.WriteLine("Role of Epigenetics in Disease");
            Console.ReadKey();
        }

        static void EvolutionAndGenetics()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                ██████╗ ███████╗███╗   ██╗███████╗████████╗██╗ ██████╗███████╗               ");
                Console.WriteLine("               ██╔════╝ ██╔════╝████╗  ██║██╔════╝╚══██╔══╝██║██╔════╝██╔════╝               ");
                Console.WriteLine("               ██║  ███╗█████╗  ██╔██╗ ██║█████╗     ██║   ██║██║     ███████╗               ");
                Console.WriteLine("               ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝     ██║   ██║██║     ╚════██║               ");
                Console.WriteLine("               ╚██████╔╝███████╗██║ ╚████║███████╗   ██║   ██║╚██████╗███████║               ");
                Console.WriteLine("                ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝   ╚═╝   ╚═╝ ╚═════╝╚══════╝               ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("           =======================================================================           ");
                Console.WriteLine("           ||                                                                   ||           ");
                Console.WriteLine("           ||                   Evolution and Genetics:                         ||           ");
                Console.WriteLine("           ||                                                                   ||           ");
                Console.WriteLine("           ||                 [ 1 ] What is Evolution?                          ||           ");
                Console.WriteLine("           ||                 [ 2 ] Natural Selection                           ||           ");
                Console.WriteLine("           ||                 [ 3 ] Genetic Drift                               ||           ");
                Console.WriteLine("           ||                 [ 4 ] Gene Flow                                   ||           ");
                Console.WriteLine("           ||                 [ 5 ] Evolutionary Developmental Biology          ||           ");
                Console.WriteLine("           ||                 [ 0 ] Go Back                                     ||           ");
                Console.WriteLine("           ||                                                                   ||           ");
                Console.WriteLine("           =======================================================================           ");
                Console.WriteLine("                                                                                             ");
                Console.WriteLine("                                                                                             ");
                Console.Write("Choose an option: ");

                subOption = Convert.ToInt32(Console.ReadLine());

                switch (subOption)
                {
                    case 1: WhatIsEvolution(); break;
                    case 2: NaturalSelection(); break;
                    case 3: GeneticDrift(); break;
                    case 4: GeneFlow(); break;
                    case 5: EvolutionaryDevelopmentalBiology(); break;
                }

            } while (subOption != 0);
        }

        static void WhatIsEvolution()
        {
            Console.Clear();
            Console.WriteLine("What is Evolution?");
            Console.ReadKey();
        }

        static void NaturalSelection()
        {
            Console.Clear();
            Console.WriteLine("Natural Selection");
            Console.ReadKey();
        }

        static void GeneticDrift()
        {
            Console.Clear();
            Console.WriteLine("Genetic Drift");
            Console.ReadKey();
        }

        static void GeneFlow()
        {
            Console.Clear();
            Console.WriteLine("Gene Flow");
            Console.ReadKey();
        }

        static void EvolutionaryDevelopmentalBiology()
        {
            Console.Clear();
            Console.WriteLine("Evolutionary Developmental Biology");
            Console.ReadKey();


        }


    }
}
