using System.Drawing;
using System.IO;
using System.Linq;

namespace CoffeeShop
{
    public class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public string info { get; set; }
        public bool amount { get; set; }
        public Image image { get; set; }

        public byte[] ImageToByte()
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }


    }
}