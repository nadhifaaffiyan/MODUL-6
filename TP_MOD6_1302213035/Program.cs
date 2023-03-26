// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo sayaTubeVideo = new SayaTubeVideo("Tutorial Design by Contract [Nadhifa Affiyan Zalwi]");
        sayaTubeVideo.IncreasePlayCount(500);
        sayaTubeVideo.PrintVideoDetails();
        sayaTubeVideo.IncreasePlayCount(2147483647);
    }
}
