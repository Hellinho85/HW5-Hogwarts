using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts_Game
{

    class Wizard
    {
        public string Name;
        public int PowerLevel;
        public int Age;
        public string DateOfAdm;
        public bool GraduationStatus;

        public Wizard(string name, int powerLevel, int age, string dateOfAdm, bool graduationStatus)
        {
            this.Name = name;
            this.PowerLevel = powerLevel;
            this.Age = age;
            this.DateOfAdm = dateOfAdm;
            this.GraduationStatus = graduationStatus;
        }

        public void WizardStats()
        {
            Console.WriteLine($"Name: {Name}, PowerLevel: {PowerLevel}, Age: {Age}, Date of admission: {DateOfAdm}, Graduation Status: {GraduationStatus}.");
        }

    }

    class Creature
    {
        public string Name;
        public int PowerLevel;
        public int Age;
        public bool Tamed;

        public Creature(string name, int powerLevel, int age, bool tamed)
        {
            this.Name = name;
            this.PowerLevel = powerLevel;
            this.Age = age;
            this.Tamed = tamed;
        }

        public void CreatureStats()
        {
            Console.WriteLine($"Name: {Name}, PowerLevel: {PowerLevel}, Age: {Age}, If they are tamed: {Tamed}.");
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            //The head of the board of the Hogwarts school of Witchcraft and Wizardry want to be a bit more ‘hip with the kids’,
            //so they have appointed you as the head of IT and have asked you to model out a new console game, consisting of 2 classes:

            //Wizards(each having their own name(string), power level(int), age(int), date of admission in Hogwarts(DateTime),
            //a value for their graduation status(boolean))
            //Creatures(each having their own name(string), age(int), power level(int), information if they have been tamed(boolean))

            //Each wizard should be able to duel a creature if the creature has not yet been tamed.
            //If the wizard’s power level is greater than the creature’s power level,
            //they essentially win the duel and that creature is at that moment tamed.

            //Main task: create a class for both participants above, and try to determine if the wizard wins the duel.

            //Extra Task: create classes in different files and use them in the main method.

            //Extra task: define separate arrays of wizards and creatures,
            //and determine if all creatures can be tamed by that array of wizards.
            //If there is a creature that no wizard can tame, specify that creature’s name.


            Wizard g1 = new Wizard("Hellinho", 500, 33, "01.01.2000", true);
            g1.WizardStats();
            Creature g2 = new Creature("Goblin", 200, 10, true);
            g2.CreatureStats();

            if (g1.PowerLevel > g2.PowerLevel)
            {
                Console.WriteLine("The Wizard wins the duel.");
            }
            else
            {
                Console.WriteLine("The Creature is more powerful and the Wizard loses the duel");
            }

            Console.Read();

        }
    }
}
