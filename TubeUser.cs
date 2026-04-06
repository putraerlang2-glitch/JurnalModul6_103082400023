using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace JurnalModul6_103082400023
{
 public class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string username;

        public SayaTubeUser(string username)
        {
            Random acak = new Random();
            this.id = acak.Next(10000, 99999);
            this.username = username;
            this.uploadedVideos = new List<SayaTubeVideo>();
        }
        public void AddVideo(SayaTubeVideo video)
        {
            uploadedVideos.Add(video);
        }
        public int GetTotalvideoPlayCount()
        {
            int total = 0;
            foreach (var video in uploadedVideos)
            {
                total += 0; // nanti kita upgrade
            }
            return total;
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User: " + username);
            int i = 1;
            foreach (var video in uploadedVideos)
            {
                Console.WriteLine("Video " + i + ": ");
                i++;
            }
        }
    }

}
