namespace Coffee
{
    public class Cortado : Coffee , IMilk
    {
        public override int Price(){
            return 25;
        }
        public override string Strength(){
            return "Medium";
        }
        public override string ToString(){
            return "The strength of the cortado is " + Strength() + " and it has this much milk in it: " + mlMilk() + "ml";
        }
        public int mlMilk(){
            return 40;
        }
    }
}