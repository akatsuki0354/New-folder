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
                Console.WriteLine("           ||      [ 6 ] Genetic Disorders                               ||           ");
                Console.WriteLine("           ||      [ 7 ] Gene Editing (CRISPR and Other Technologies)    ||           ");
                Console.WriteLine("           ||      [ 8 ] Human Genome Project                            ||           ");
                Console.WriteLine("           ||      [ 9 ] Epigenetics                                     ||           ");
                Console.WriteLine("           ||      [ 10 ] Evolution and Genetics                         ||           ");
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
                    case 6: GeneticDisorders(); break;
                    case 7: GeneEditing(); break;
                    case 8: HumanGenomeProject(); break;
                    case 9: Epigenetics(); break;
                    case 10: EvolutionAndGenetics(); break;
                }

            } while (chosenOne != 0);
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
            Console.WriteLine("    ||                                     the diversity of life.                                      ||   ");
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
            Console.WriteLine("Genetic Variation");
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
            Console.WriteLine("Inheritance Patterns");
            Console.ReadKey();
        }

        static void GeneticTechnologies()
        {
            Console.Clear();
            Console.WriteLine("Genetic Technologies");
            Console.ReadKey();
        }

        static void HumanGenomeProjectInfo()
        {
            Console.Clear();
            Console.WriteLine("Human Genome Project");
            Console.ReadKey();
        }

        static void EthicalConsiderations()
        {
            Console.Clear();
            Console.WriteLine("Ethical Considerations in Genetics");
            Console.ReadKey();
        }

        static void FutureGenetics()
        {
            Console.Clear();
            Console.WriteLine("Future of Genetics");
            Console.ReadKey();
        }

        static void ChromosomesAndTheirFunction()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Chromosomes and Their Function:");
                Console.WriteLine("Description of chromosomes, how they carry genetic information, and their role in cell division.");
                Console.Write("Input [0] to go back: ");
                subOption = Convert.ToInt32(Console.ReadLine());

            } while (subOption != 0);
        }

        static void GeneticMutations()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Genetic Mutations:");
                Console.WriteLine("             [ 1 ] Types of Mutations");
                Console.WriteLine("             [ 2 ] Causes of Mutations");
                Console.WriteLine("             [ 3 ] Effects of Mutations");
                Console.WriteLine("             [ 0 ] Go Back");
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

        static void TypesOfMutations()
        {
            Console.Clear();
            Console.WriteLine("Types of Mutations");
            Console.ReadKey();
        }

        static void CausesOfMutations()
        {
            Console.Clear();
            Console.WriteLine("Causes of Mutations");
            Console.ReadKey();
        }

        static void EffectsOfMutations()
        {
            Console.Clear();
            Console.WriteLine("Effects of Mutations");
            Console.ReadKey();
        }

        static void GeneticDisorders()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Genetic Disorders:");
                Console.WriteLine("             [ 1 ] Single-Gene Disorders");
                Console.WriteLine("             [ 2 ] Chromosomal Disorders");
                Console.WriteLine("             [ 3 ] Multifactorial Disorders");
                Console.WriteLine("             [ 4 ] Mitochondrial Disorders");
                Console.WriteLine("             [ 0 ] Go Back");
                Console.Write("Choose an option: ");

                subOption = Convert.ToInt32(Console.ReadLine());

                switch (subOption)
                {
                    case 1: SingleGeneDisorders(); break;
                    case 2: ChromosomalDisorders(); break;
                    case 3: MultifactorialDisorders(); break;
                    case 4: MitochondrialDisorders(); break;
                }

            } while (subOption != 0);
        }

        static void SingleGeneDisorders()
        {
            Console.Clear();
            Console.WriteLine("Single-Gene Disorders");
            Console.ReadKey();
        }

        static void ChromosomalDisorders()
        {
            Console.Clear();
            Console.WriteLine("Chromosomal Disorders");
            Console.ReadKey();
        }

        static void MultifactorialDisorders()
        {
            Console.Clear();
            Console.WriteLine("Multifactorial Disorders");
            Console.ReadKey();
        }

        static void MitochondrialDisorders()
        {
            Console.Clear();
            Console.WriteLine("Mitochondrial Disorders");
            Console.ReadKey();
        }

        static void GeneEditing()
        {
            int subOption = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("Gene Editing (CRISPR and Other Technologies):");
                Console.WriteLine("             [ 1 ] What is CRISPR?");
                Console.WriteLine("             [ 2 ] How CRISPR Works");
                Console.WriteLine("             [ 3 ] Applications of CRISPR in Medicine");
                Console.WriteLine("             [ 4 ] Gene Therapy and CRISPR");
                Console.WriteLine("             [ 5 ] Ethical Issues in Gene Editing");
                Console.WriteLine("             [ 6 ] Future of CRISPR Technology");
                Console.WriteLine("             [ 7 ] Other Gene Editing Technologies (Zinc Finger Nucleases, TALENs)");
                Console.WriteLine("             [ 8 ] Gene Editing in Agriculture");
                Console.WriteLine("             [ 9 ] Gene Editing and Cancer Research");
                Console.WriteLine("             [ 10 ] Risks and Limitations of Gene Editing");
                Console.WriteLine("             [ 0 ] Go Back");
                Console.Write("Choose an option: ");

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
            Console.WriteLine("What is CRISPR?");
            Console.ReadKey();
        }

        static void HowCRISPRWorks()
        {
            Console.Clear();
            Console.WriteLine("How CRISPR Works");
            Console.ReadKey();
        }

        static void ApplicationsOfCRISPR()
        {
            Console.Clear();
            Console.WriteLine("Applications of CRISPR in Medicine");
            Console.ReadKey();
        }

        static void GeneTherapy()
        {
            Console.Clear();
            Console.WriteLine("Gene Therapy and CRISPR");
            Console.ReadKey();
        }

        static void EthicalIssuesGeneEditing()
        {
            Console.Clear();
            Console.WriteLine("Ethical Issues in Gene Editing");
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
                Console.WriteLine("Human Genome Project:");
                Console.WriteLine("             [ 1 ] Overview of the Human Genome Project");
                Console.WriteLine("             [ 2 ] Goals of the Human Genome Project");
                Console.WriteLine("             [ 3 ] Timeline of the Human Genome Project");
                Console.WriteLine("             [ 4 ] Achievements of the Human Genome Project");
                Console.WriteLine("             [ 5 ] Impact of the Human Genome Project on Medicine");
                Console.WriteLine("             [ 6 ] Ethical Concerns Related to the Human Genome Project");
                Console.WriteLine("             [ 7 ] International Collaboration in the Human Genome Project");
                Console.WriteLine("             [ 8 ] Role of Technology in the Human Genome Project");
                Console.WriteLine("             [ 9 ] Human Genome Project and Personalized Medicine");
                Console.WriteLine("             [ 10 ] Future of Genomic Research");
                Console.WriteLine("             [ 0 ] Go Back");
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
                Console.WriteLine("███████╗██████╗  █████╗ ███╗   ██╗ ██████╗ ██████╗ ");
                Console.WriteLine("██╔════╝██╔══██╗██╔══██╗████╗  ██║██╔════╝██╔═══██╗");
                Console.WriteLine("█████╗  ██████╔╝███████║██╔██╗ ██║██║     ██║   ██║");
                Console.WriteLine("██╔══╝  ██╔══██╗██╔══██║██║╚██╗██║██║     ██║   ██║");
                Console.WriteLine("██║     ██║  ██║██║  ██║██║ ╚████║╚██████╗╚██████╔╝");
                Console.WriteLine("╚═╝     ╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝ ╚═════╝ ╚═════╝");
                Console.WriteLine("Epigenetics:");
                Console.WriteLine("             [ 1 ] What is Epigenetics?");
                Console.WriteLine("             [ 2 ] DNA Methylation");
                Console.WriteLine("             [ 3 ] Histone Modification");
                Console.WriteLine("             [ 4 ] Environmental Impact on Epigenetics");
                Console.WriteLine("             [ 5 ] Role of Epigenetics in Disease");
                Console.WriteLine("             [ 0 ] Go Back");
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
                Console.WriteLine("Evolution and Genetics:");
                Console.WriteLine("             [ 1 ] What is Evolution?");
                Console.WriteLine("             [ 2 ] Natural Selection");
                Console.WriteLine("             [ 3 ] Genetic Drift");
                Console.WriteLine("             [ 4 ] Gene Flow");
                Console.WriteLine("             [ 5 ] Evolutionary Developmental Biology");
                Console.WriteLine("             [ 0 ] Go Back");
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
