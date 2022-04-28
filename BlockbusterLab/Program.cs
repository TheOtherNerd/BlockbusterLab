namespace BlockbusterLab
{
    public class Program
    {
        public static void Main()
        {
            DVD d = new DVD("Shrek 2", 800, Genre.Romance, "scene1", "scene2", "scene3", "scene4");
            d.Play();
            d.PrintInfo();
            d.PrintScenes();

            Blockbuster b = new Blockbuster();
            b.Checkout();
        }
    }
}