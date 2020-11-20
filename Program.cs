using System;
using System.Collections.Generic;
namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
