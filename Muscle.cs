using System;
namespace Heist{
    public class Muscle:IRobber{
        public Muscle(){}
        public Muscle(String Name, int SkillLevel, int PercentageCut){
            this.Name=Name;
            this.SkillLevel=SkillLevel;
            this.PercentageCut=PercentageCut;
        }
        public string Name{get; set;}
        public int SkillLevel{get; set;}
        public int PercentageCut{get; set;}
        public void PerformSkill(Bank bank){
            bank.SecurityGuardScore-=SkillLevel;
            System.Console.WriteLine($"{Name} is attacking the guards. Decreased security by {SkillLevel} points");
            if(bank.SecurityGuardScore<0){
                System.Console.WriteLine($"{Name} has knocked out the guards!");
            }
        }
    }
}