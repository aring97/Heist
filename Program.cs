using System;
using System.Collections.Generic;
namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Muscle Jim=new Muscle("Jim", 30, 15);
            Hacker steve=new Hacker("Steve", 50, 25);
            LockSpecialist john=new LockSpecialist("John", 60, 35);
            Muscle sue=new Muscle("Sue", 25, 15);
            Hacker yol=new Hacker("Yol", 30, 15);
            LockSpecialist grey=new LockSpecialist("Grey", 45, 20);
            List<IRobber> rolodex=new List<IRobber>(){Jim, steve, john, sue, yol, grey};
            System.Console.WriteLine($"There are currently {rolodex.Count} avalible operatives");
            System.Console.WriteLine("Please enter the name of a new operative. Leave blank to continue.");
            string newName=Console.ReadLine();
            while(newName!=""){
                System.Console.WriteLine("Please enter the Specialty of the new opretive");
                System.Console.WriteLine("Hacker (Disables alarm)");
                System.Console.WriteLine("Muscle (Disams guards)");
                System.Console.WriteLine("Lock Specialist (cracks vaults)");
                string Specialty=Console.ReadLine();
                System.Console.WriteLine("How skilled is this new operative. (between 1 and 100)");
                int skill=-1;
                while(skill<1||skill>100){
                try{
                    skill=int.Parse(Console.ReadLine());
                }
                catch(System.FormatException){
                    System.Console.WriteLine("The skill level was entered incorrectly. Please try again.");
                    
                }
                }
                int cut=-1;
                System.Console.WriteLine("Enter the percentage cut.");
                while(cut<1){
                    try{
                        cut=int.Parse(Console.ReadLine());
                    }
                    catch(System.FormatException){
                        System.Console.WriteLine("The percentage was entered incorrectly please try again.");
                    }
                }
                if (Specialty.ToLower()=="hacker"){
                    Hacker newOperative= new Hacker(newName, skill, cut);
                    rolodex.Add(newOperative);
                }else if (Specialty.ToLower()=="muscle"){
                    Muscle newOperative=new Muscle(newName, skill, cut);
                    rolodex.Add(newOperative);
                }else if(Specialty.ToLower()=="lock specialist"){
                    LockSpecialist newOperative=new LockSpecialist(newName, skill, cut);
                    rolodex.Add(newOperative);
                }
                System.Console.WriteLine("Please enter the name of a new operative. Leave blank to continue.");
                newName=Console.ReadLine();
            }
            /*
            int bankDifficulty=0;
            while(bankDifficulty==0){
                System.Console.WriteLine("Enter the difficulty of the bank.");
            try{
                bankDifficulty=int.Parse(Console.ReadLine());
            }
            catch(System.FormatException){
                System.Console.WriteLine("Failed to enter a number.");
            }
            }
            List<Member> TeamList=new List<Member>();
            Console.WriteLine("Plan Your Heist");
            System.Console.WriteLine("Enter the team members name:");
            string name=Console.ReadLine();
            while(name!=""){
            System.Console.WriteLine("Enter the team members skill level (positive values only):");
            int skill=-100;
            while(skill<0){
                try{
                skill=int.Parse(Console.ReadLine());
            }
            catch(System.FormatException){
                System.Console.WriteLine("Failed to enter a number.");
            }
            if(skill<0){
                System.Console.WriteLine("The skill level is to low. Please enter a positive value.");
                }
            }
            System.Console.WriteLine("Enter the team members courage factor (between 0.0 and 2.0):");
            double courage=-100;
            while(courage<0 || courage>2){
                try{
                courage=double.Parse(Console.ReadLine());
            }
            catch(System.FormatException){
                System.Console.WriteLine("failure to enter a number.");
            }
                System.Console.WriteLine("The courage factor is incorrect. Please enter a value between 0.0 and 2.0.");
            }
            TeamList.Add(new Member(name, skill, courage));
            System.Console.WriteLine("Enter the team members name:");
            name=Console.ReadLine();
            }
            int skillSum=0;
            foreach(Member member in TeamList){
                skillSum+=member.skillLevel;
            }
            int success=0;
            int Failure=0;
            int runs=0;
            System.Console.WriteLine("How many times would you like to run the scenario?");
            while(runs==0){
            try{
             runs=int.Parse(Console.ReadLine());
            }
            catch(System.FormatException){
                System.Console.WriteLine("Failure to enter a number.");
            }
            }
            for(;runs>0;runs--){
            Random random=new Random();
            int luck=random.Next(-10, 10);
            int newDifficulty=bankDifficulty+luck;
            System.Console.WriteLine($"The Teams skill level: {skillSum}");
            System.Console.WriteLine($"The bank difficulty: {newDifficulty}");
            if(skillSum>=newDifficulty){
                System.Console.WriteLine("Success! we are rich!");
                success++;
            }else {
                System.Console.WriteLine("Failure. we are in prison.");
                Failure++;
            }
            }
            System.Console.WriteLine($"Number of successes: {success}");
            System.Console.WriteLine($"Number of failures: {Failure}");
            */
        }
    }
}
