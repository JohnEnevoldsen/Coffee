namespace Coffee
{
    public class BlackCoffee : Coffee
    {
        public override int Price(){
            return 20;
        }
        public override string Strength(){
            return "Strong";
        }
        public override string ToString(){
            return "The strength of the black coffee is " + Strength();
        }
    }
}