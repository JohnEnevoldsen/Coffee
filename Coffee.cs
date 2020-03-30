namespace Coffee
{
    public abstract class Coffee
    {
        public virtual int Price(){
            return 20;
        }
        public abstract string Strength();
    }
}