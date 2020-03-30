namespace Coffee
{
    public class Latte : Coffee , IMilk
    {
        public override int Price(){
            return 40;
        }
        public override string Strength(){
            return "Weak";
        }
        public override string ToString(){
            return "The strength of the latte is " + Strength() + " and it has this much milk in it: " + mlMilk() + "ml";
        }
        public int mlMilk(){
            return 200;
        }
    }
}