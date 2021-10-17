using System;



namespace Tanki
{

    class Tank

{
    private string name { get; set; }

    private int ammunition { get; set; }

    private int armor_level { get; set; }

    private int maneuverability_level { get; set; }

    private int index { get; set; }



    public Tank (string Name)
    {
        name = Name;
        Random rnd = new Random();
        ammunition = rnd.Next(0, 100);
        armor_level = rnd.Next(0, 100);
        maneuverability_level = rnd.Next(0, 100);

    }

       

       public void Print()
        {
            Console.WriteLine($"{name}\n{ammunition}\n{armor_level}\n{ maneuverability_level}");
        }



        public static string operator *(Tank t1, Tank t2)
        {
            if (t1.ammunition > t2.ammunition && t1.armor_level > t2.armor_level)
            { 
                Console.WriteLine($"Win{t1.name}");
                return t1.name ;
            }
            if (t1.ammunition > t2.ammunition && t1.maneuverability_level > t2.maneuverability_level)
            {
                Console.WriteLine($"Win{t1.name}");
                return t1.name;
            }
            if (t1.armor_level > t2.armor_level && t1.maneuverability_level > t2.maneuverability_level)
            {
                Console.WriteLine($"Win{t1.name}");
                return t1.name;
            }
            else
            {
                Console.WriteLine($"Win{t2.name}");
                return t2.name;
            }
        }
    }

    

class Program
    {
        static void Main(string[] args)
        {
            

            Tank tanksT34_1=new Tank("T_34_1");
           
            Tank tanksT34_2 = new Tank("T_34_2");
            Tank tanksT34_3 = new Tank("T_34_3");
            Tank tanksT34_4 = new Tank("T_34_4");
            Tank tanksT34_5 = new Tank("T_34_5");


            Tank tanksPanther1 = new Tank("Panther1");
            Tank tanksPanther2 = new Tank("Panther2");
            Tank tanksPanther3 = new Tank("Panther3");
            Tank tanksPanther4 = new Tank("Panther4");
            Tank tanksPanther5 = new Tank("Panther5");

            
          
            string result = tanksPanther1 * tanksT34_1;
            string result1 = tanksPanther2 * tanksT34_2;
            string result2 = tanksPanther3 * tanksT34_3;
            string result3 = tanksPanther4 * tanksT34_4;
            string result4 = tanksPanther5 * tanksT34_5;

           
            
            

        }
    }
}