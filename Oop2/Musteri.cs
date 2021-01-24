using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    class Musteri
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }

        //Bir veri üzerinde sayısal bir işlem yapmıyorsan (toplama ve çıkartma gibi) onlara string değeri vermek daha doğrudur (ör: TC No.).
        //Bir nesnede bir değeri kullanmak zorunda değil gibi gözüküyorsan, o nesneye ait değiş gibi duruyorsa o alan demek ki orada bir "soyutlama" hatası
        //var demektir.

    }
}
