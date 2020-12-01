using System;
namespace Heist{
    public class LockSpecialist:IRobber{
        public LockSpecialist(){}
        public LockSpecialist(String Name, int SkillLevel, int PercentageCut){
            this.Name=Name;
            this.SkillLevel=SkillLevel;
            this.PercentageCut=PercentageCut;
        }
        public string Name{get; set;}
        public int SkillLevel{get; set;}
        public int PercentageCut{get; set;}
        public void PerformSkill(Bank bank){
            bank.VaultScore-=SkillLevel;
            System.Console.WriteLine($"{Name} is unlocking the vault. Decreased security by {SkillLevel} points");
            if(bank.VaultScore<0){
                System.Console.WriteLine($"{Name} has unlocked the vault!");
            }
        }
    }
}