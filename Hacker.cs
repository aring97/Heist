using System;
namespace Heist{
    public class  Hacker:IRobber{
        public Hacker(){}
        public Hacker(String Name, int SkillLevel, int PercentageCut){
            this.Name=Name;
            this.SkillLevel=SkillLevel;
            this.PercentageCut=PercentageCut;
        }
        public string Name{get; set;}
        public int SkillLevel{get; set;}
        public int PercentageCut{get; set;}
        public void PerformSkill(Bank bank){
            bank.AlarmScore-=SkillLevel;
            System.Console.WriteLine($"{Name} is hacking the alarm. Decreased security by {SkillLevel} points");
            if(bank.AlarmScore<0){
                System.Console.WriteLine($"{Name} has disabled the alarm system!");
            }
        }
    }
}