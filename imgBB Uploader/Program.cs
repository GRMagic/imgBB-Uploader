using imgBBUploader;
using System;

namespace imgBB_Uploader
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = "e78ccbec6005bc7812e9837e18cd19a7";
            var imgBB = new Uploader(key);

            var result = imgBB.UploadImageFileAsync(@"C:\Users\gustavo.muller\Desktop\Teste.jpg").Result;
            if (result.success)
            {
                Console.WriteLine("Image: " + result.data.url);
            }

            result = imgBB.UploadFromUrlAsync(@"https://s2.glbimg.com/Zuz5QTdCesKk42uMjtJYzKwhQJA=/0x0:3240x2160/1600x0/smart/filters:strip_icc()/i.s3.glbimg.com/v1/AUTH_59edd422c0c84a879bd37670ae4f538a/internal_photos/bs/2019/X/1/6KAgaSQaeJ4NPq2XLzUQ/birdseclipse-caldas-3240.jpg").Result;
            if (result.success)
            {
                Console.WriteLine("Image: " + result.data.url);
            }
        }
    }
}
