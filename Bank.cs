using System.Collections.Generic;
namespace Heist{
    public class Bank{
        public Bank(){}
        public Bank(int cash, int alarm, int vault, int guard){
            CashOnHand=cash;
            AlarmScore=alarm;
            VaultScore=vault;
            SecurityGuardScore=guard;
        }
        public int CashOnHand{get; set;}
        public int AlarmScore{get; set;}
        public int VaultScore{get; set;}
        public int SecurityGuardScore{get; set;}
        public bool IsSecure{
            get{
                if(AlarmScore>0|| VaultScore>0||SecurityGuardScore>0){
                    return true;
                }
                else{return false;}
            }
        }
           public List<string> compair(){
            List<string> recon=new List<string>();
            if(AlarmScore>VaultScore&&AlarmScore>SecurityGuardScore)
            {
                recon.Add("Alarm");
                if(VaultScore>SecurityGuardScore){
                    recon.Add("Security");
                }else{
                    recon.Add("Vault");
                }
            }
            else if(VaultScore>SecurityGuardScore){
                recon.Add("Vault");
                if(AlarmScore>SecurityGuardScore){
                    recon.Add("Security");
                }else{recon.Add("Alarm");}
            }else{
                recon.Add("Security");
                if(VaultScore>AlarmScore){
                    recon.Add("Alarm");
                }else{recon.Add("Vault");}
            }
            return recon;
        }
    }
}