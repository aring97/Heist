using System;
namespace Heist{
    public class Member{
        public Member(){}
        public Member(string name, int skill, double courage){
            Name=name;
            skillLevel=skill;
            courageFactor=courage;
        }
        public string Name{get; set;}
        public int  skillLevel{get; set;}
        public double courageFactor{get; set;}
    }
}