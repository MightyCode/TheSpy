using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theSpyCardEditor
{
    class TestSimulation
    {
        public static bool TestBooleenCondition()
        {
            Dictionary<string, int> parameters = new Dictionary<string, int>(GameProperties.BasicParameters);
            parameters.Add("p1", 18);
            parameters.Add("p2", 19);

            string[] condition = new string[]{
                "money > 30",
                "money > 30 && money > 30",
                "money > 30 && !(money < 30)",
                "!(money < 30)",
                "!(life < money) && (money > 30)",
                "p1 > p2 || p2 > p1",
                "money == cover",
                "money != p1",
                "money + 1 == money + 1",
                "money + 1 != money",
                "money + (2 * 3 + -(-3)) == 59",
                "25 % 5 + (5 * 2) == 10 && money/-2 == -25"
            };

            Console.WriteLine("\n------------------");
            Console.WriteLine("Test boolean expression conditon");
            Console.WriteLine("------------------\n");

            for (int i = 0; i < condition.Length; ++i)
            {
                SimulationComputations.CreateNewReader(condition[i]);
                if (!SimulationComputations.EvaluateBooleanExpression().Value(parameters))
                {
                    Console.WriteLine("Condition not passed : " + condition[i]);
                    return false;
                }
                else
                {
                    Console.WriteLine("Condition passed : " + condition[i]);
                }
            }

            return true;
        }


        public static bool TestLabel()
        {
            Dictionary<string, int> parameters = new Dictionary<string, int>(GameProperties.BasicParameters);

            string[] condition = new string[]{
                "if (money > 30){\n" +
                "   coucou\n" +
                "   if (life < 30){\n" +
                "       hello\n" +
                "   }\n" +
                "}\n" +
                "end",

                "if (money < 30){\n" +
                "   poor\n" +
                "} else if (money > 30){\n" +
                "   rich\n" +
                "}\n" +
                "end",

                "if (money < 30){\n" +
                "   poor\n" +
                "} else {\n" +
                "   rich\n" +
                "}\n" +
                "end",

                "if (money > 50){\n" + 
                "rich\n" + 
                "} else {\n" + 
                "low\n" +
                "}",

                "if (money > 49){\n" +
                "rich\n" +
                "} else {\n" +
                "low\n" +
                "}",
            };

            List<List<string>> solution = new List<List<string>>()
            {
                new List<string>(){"coucou", "end" },
                new List<string>(){"rich", "end" },
                new List<string>(){"rich", "end" },
                new List<string>(){"low" },
                new List<string>(){"rich" },
            };

            List<string> proposition;

            Console.WriteLine("\n------------------");
            Console.WriteLine("Test label getting from condition");
            Console.WriteLine("------------------\n");

            for (int i = 0; i < condition.Length; ++i)
            {
                SimulationComputations.CreateNewReader(condition[i]);
                proposition = SimulationComputations.GetLabels(new List<string>(), parameters);

                if (proposition == null)
                {
                    Console.WriteLine("Label getting not passed : \n" + condition[i]);
                    return false;
                }
                if (!proposition.SequenceEqual(solution[i]))
                {
                    Console.WriteLine("Label getting not passed : \n" + condition[i]);
                    Console.WriteLine(proposition.Count);
                    return false;
                }

                Console.WriteLine("Label getting passed : \n" + condition[i]);
            }

            return true;
        }

        public static bool TestReturnTextFromLabels()
        {
            Dictionary<string, int> parameters = new Dictionary<string, int>(GameProperties.BasicParameters);

            List<string> labels = new List<string>()
            {
                "begin",
                "end",
                "middle",
                "rich"
            };

            string[] texts = new string[]{
                "",

                "Je suis un cuicui.",

                "The actor seems to see him\n" +
                "end {\n" +
                " madely.\n" +
                "}\n" +
                "hey{\n" +
                " mentaly.\n" +
                "}\n" +
                ". And won't know a thing about him too.\n" +
                "end{\n" +
                " This is the end.\n" +
                "}",

                "money += 50;\n" +
                "add card n001;\n" +
                "poor {\n" +
                " go card 245;" +
                "}\n" +
                "rich{\n" +
                " go card 244;\n" +
                "}"
            };

            List<string> solution = new List<string>()
            {
                "",

                "Je suis un cuicui.",

                "The actor seems to see him madely. And won't know a thing about him too. This is the end.",

                "money += 50;\n" +
                "add card n001; go card 244;"
            };

            Console.WriteLine("\n------------------");
            Console.WriteLine("Text getting using labels");
            Console.WriteLine("------------------\n");

            for (int i = 0; i < texts.Length; ++i)
            {
                string result = SimulationComputations.ReturnTextFromLabels(texts[i], labels);
                if (!result.Equals(solution[i]))
                {
                    Console.WriteLine("Text getting not passed : \n" + solution[i]);
                    Console.WriteLine("it returns : \n" + result);
                    return false;
                }

                Console.WriteLine("Text getting passed : \n" + texts[i] + "\n");
            }

            return true;
        }
    }
}
