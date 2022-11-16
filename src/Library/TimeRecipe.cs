namespace Full_GRASP_And_SOLID
{
    //Agregado por OCP, ya que no se puede cambiar "Recipe", solo extender, creo esta clase por composición.
    public class TimeRecipe : TimerClient
    {
        public Recipe Recipe{get;set;}

        public TimeRecipe (Recipe recipe, int valor)
        {
            this.Recipe = recipe;
            CountdownTimer countdownTimer = new CountdownTimer();
            countdownTimer.Register(valor,this);
        }
        public void TimeOut()
        {
            this.Recipe.Cooked = true;
        }
    }
}