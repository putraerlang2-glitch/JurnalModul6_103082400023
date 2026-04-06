using JurnalModul6_103082400023;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeUser user = new SayaTubeUser("Erlang");

        SayaTubeVideo v1 = new SayaTubeVideo("Review Film Gachiakuta oleh Eru");
        SayaTubeVideo v2 = new SayaTubeVideo("Review Film Hunger oleh Eru");

        user.AddVideo(v1);
        user.AddVideo(v2);

        v1.IncreasePlayCount(100);
        v2.IncreasePlayCount(200);

        v1.PrintVideoDetails();
        v2.PrintVideoDetails();

        user.PrintAllVideoPlayCount();
    }
}
