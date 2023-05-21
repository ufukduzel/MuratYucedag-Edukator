using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.EntityLayer.Concrete
{
    // Amacımız Code First çalışmak
    // Sınıfları Visual Studio da yazacağız, bunları SQL de bir tabloya dönüştüreceğiz
    public class Category
    {
        // değişken
        //int x; // x e bir kısıtlama yapamayız

        // property (nitelik, özellik)
        //int y { get; set; } // y ye bir kısıtlama yapabiliriz
        // y için sadece 10 20 aralığında ol veya negatif değerleri alma kısıtlaması yapabiliriz

        public int CategoryID { get; set; }
        // Bu yazılış, sınıfın birincil ID si ve otomatik artan formatta olduğunu belirtiyor

        public string CategoryName { get; set; }
    }
}
