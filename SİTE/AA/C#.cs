using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tamsayı Veri tipleri
            // işaretli; sbyte(8bit) shor (16bit), int (32 bit ), long (64bit) işaretli sayılar hem eksı hem artı deger alır
            //işaretsiz: byte,       ushort        uint           ulong       işretsizler sadece pozıtıf sayılar degerı alır
            //Ondalıksayı VERİ TİPLERİ
            //float 4b
            //double 8B      EN COK DOUBLE KULLANILIR
            //decimal 12B
            //MANTIKSAL VERI TIPLERI
            //bool: ture/folse
            //karakter ve metin tiplerı
            // char: tek karakter verı tıpı / yazarken tek tırnak
            // string: karakter dizisi / yazarken cıft tınrak
            //Nesne Veri  tipi
            //object her turlu veryı ıcerır her turlu seyı tutabılır
            //TARİH VE SAAT VERI TIPLERI
            //DATE TİME
            //Genel değişken tanımlama tipi
            // var : variable
            // TİP DONUSUMLERI
            // CONVERT SINIFI ILE
            // PARSE/TRYPARSE ile
            // Kutuluma ile
            // Bilincsiz ile genenlıkle ıle sayı verı tıplerı arasındakı donusum
            // string verı tıplerı
            //string sti = "123";
            // int sayi1 = int.Parse(sti);
            // Console.WriteLine(sayi1 * 10);
            //Console.Read();
            // byte Byte bb;
            //sbyte sByte sbb;
            //short Int 16 i16
            //ushort ınt16 ui16
            // string strign
            //float single


            //kodlar ve yonlendırme
            // if (eger), switch(yonlenme, ?; ??, ?.
            // DONGU TEKRARLAMA
            // FOR WHILE DO-WHİLE

            // kod parcıgın ustunde ıken tab+tab yapılır

            // 3  durumlu ıf komutu
            // sayı pozıfı mı negatıf mı sıfır mı
            //if (sayı > 0)
            //{
            //  Console.WriteLine("pozitşf);
            //}
            //else
            //{
            //  if (sayı < 0)
            //{

            //}//
            //}

            //sctoplamı 100 olana kadar gırılen sayılar
            //int toplam = 0;
            // for (; toplam<100)
            // {
            //    int.TryParse(Console.ReadLine());
            // }

            //Console.WriteLine("Toplam:{0}",toplam);
            //Console.Read();


            //ortalaması 50 ve ustu oluncaya akdar klavyeden sayı gırme


            // int toplam = 0, ortalama = 0;
            // for (int i = 0; ortalama<50; i++)
            // {
            //   if int.TryParse(Console.ReadLine(),out int sayı){
            //       toplama += sayı;
            //       i++;
            //       ortalama = toplam / adet;
            //    }
            //    Console.WriteLine("Topalama:{0},Ortalama:{1}",toplam,ortalama);
            //    Console.Read();
            //}



            //klavyeden gırıle 10 sayının tek cıft ortalmasını hesaplama

        //    int toplam_tek = 0, toplam_cift = 0, adet_tek = 0, adet_cift = 0;
        
          //  for (int sayac = 0; sayac <10; sayac++)
          //  {
          //      if {
          //        int.TryParse(Console.ReadLine(),out,int sayı)
          //
          //           if (sayı%2==0)
          //       {
          //          toplam_cift+=sayı
          //          adet_cift++;
          //      }
          //     if (sayı%2!=0)
          //     {
          //         toplam_tek += sayı;
          //         adet_tek++;
          //     }
          //      double o
          //   }
          // }

            // break: herhangı bir döugunun adım sayısı bıtmeden sonlandırır
            //  for (int i = 0; i < 10; i++)
            //   {
            //      if(i==7)break
            //      Console.WriteLine( "i" );
            //  }
            //  Console.Read();


            //sıfır gırılınceye kadar sayıalrın ortlaamsı

            //int toplam=0, adet = 0;
            //    for (; ; )
            //    {
            //        int.TryParse(Console.ReadLine(), out, int sayi);
            //        if (sayı == 0) break;
            //        toplam+=Sayı
            //         adet++;
            //    }
            //    Console.WriteLine("Ortalama {0}" , toplam/adet);
            //    Console.Read();


            //do-while
            //en az bir işlem yaptıktan sonra kontrol ediir
          //  do
            {
                //   int toplam = 0, adet = 0;
                //    for (; ; )
                //    {
                //        int.TryParse(Console.ReadLine(), out, int sayi);
                //        if (sayı == 0) break;
                //        toplam+=Sayı
                //         adet++;
 
            }// while (true);


            //  Console.WriteLine("Ortalama {0}", toplam / adet);
            //    Console.Read();

            // foreach 
            //string metin = "celal bayar";
            //foreach(var harf in metin)
            //    Console.WriteLine(harf);

            // switch (değişken)
            // case durum1:break;
            // case durum2 break ;


            Örnek kalvyeden gırılen sayının yazı ıle gosterılmesı
            Console.WriteLine("sayı gir :");
            int.TryParse(Console.ReadLine(), out indexer sayı)
             if (sayı == 1) Console.WriteLine("bir");
            if (sayı == 2) Console.WriteLine("iki");
            if (sayı == 3) Console.WriteLine("üç");

            //diziler
            //int a = 8, b =4, c = 6;
            //Console.WriteLine("a:{0} b:{1} c:{2}" a, b, ,c);
            //if (a>b)
            //{
            //    x = a;
            //    a = b;
            //    b = x;
            //}
            //Console.WriteLine("a:{0} b:{1} c:{2}" a, b, , c);
            //if (b>c)
            //{
            //    x = b;
            //    b = c;
            //    c = x;
            //}

            // diziler [] ile tanımlanıyor
            //int[] dizi1 = new int[5] { 10, 8, 6, 4, 2 };
            //Console.WriteLine(dizi1[3]);

            // random komutu
            //rastgele sayı uretır
            // random.NextDouble(); (ondalıklı sayılarda da olur)
            // random.NextBytes(); ( 
            // random.Next(); (tam sayı)
            //next 3 kullanımı vardır
            // int.MaxValue 0 ile  max arası
            // Next(min,max) belirtilen mın ıle berlırtılen max degerı arasını secmk ıcın



            //Random random = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(random.Next());
            //}
            //Console.Read();

            //rastgele sayı yazar 


            // RANDOM 10 iki basakamlı SAYININ BUYUKTEN KUCUGE SIRALANMASI
            //var random = new Random();
            //int[] sayılar = new int[10];
            //for (int i = 0; i < sayılar.Length; i++)
            //{
            //    sayılar[i] = random.Next(10,100);
            //}
            //Array.Sort(sayılar);
            //Array.Reverse(sayılar);
            //foreach (var item in sayılar)
            //    Console.WriteLine(item);
            //Console.Read();



            // Rastgele uretıle bırbırnden farklı 10 ile 30 arasında iki
            // basamaklı sayının
            // büyükten kucuge sıralanması
            //var random = new Random();
            //int[] sayılar = new int[10];
            //for (int i = 0; i < sayılar.Length; i++)
            //{
            //    var sayi = random.Next(10, 30);
            //    if (Array.IndexOf(sayılar, sayi) != -1) continue;
            //    sayılar[i] = sayi;
            //    i++;
            //}
            //Array.Sort(sayılar);
            //Array.Reverse(sayılar);
            //foreach (var item in sayılar)
            //    Console.WriteLine(item);
            //Console.Read();

            //diziyi kopyalama
            //dizi.copy(dizi2,5);

            //Array.Copy(dizi,dizi2,5); hedef diziye, kaynak dizideki ilk 5 degerı kopyala


            // dizidekileri değleri sıralar
            // Array.sort(dizi)

            //dizideki değerleri ters cevir
            // Array.reverse(dizi)


            // belirli bir konumdan başlamak üzere verileri siler
            //Array.Clear (dizi , 4, 2);

            // boş dizi oluşturur
            // int [] boşdizi=Array.empty <int>();

            //belirtilen değeriin indeksini döndürür eğer yoksa  -1 degeri dondurulur
            //Array.IndexOf(dizi,8)

            // belirtilen değerin dizide olup olmadıgını kontrol eder
            //Array.Exists(dizi,9)

            //cift sayıları bulma
            // int [] ciftler = Array.FindAll(dizi, x => % 2 == 0 );

            //belirtine değerin indeksini gösterir
            // Array.FındIndex(dizi, x => x == 9 );

            // diziyi yeniiden boyutlandırır
            //Array.Resize( ref dizi, 3 );


            //Örnek
            // klavyeden araya virgül girlerek gırılen degelere gore
            //toplam, ortalama , min ,max adet degerını gosteren prg

            //            Console.WriteLine("Degeleri gir");
            //            string = girilen_değerler = Console.ReadLine();
            //            // herhangi bir ifadeyi parçalamak ıcın split kullanılır
            //            var parçala= girilen_değerler.Split(',')
            //            var sayılar = Array.ConvertAll(parçala, x -> int.Parse(x))
            //Console.WriteLine("Adet       : {0}",sayılar.Length );
            //            Console.WriteLine("Min    : {0}", sayılar.Min ());
            //            Console.WriteLine("Max    :  {0}" ,sayılar.Max());
            //            Console.WriteLine("Toplam  :  {0}",sayılar.Sum());   // SUM TOPLAM DEGELERINDE
            //            Console.WriteLine("Ortalama :  {0}",sayılar.Average());  // ORTALAMA DEGERLERINDE AVERAGE KULLANILIR
            //            Console.Read();



            // iki veya daha fazla boyutulu diziler
            // eger her eleman ıcersınde alt elaman sayısı esıtse
            // [,] seklinde tanımlanıdr
            // değilse
            // [] [] seklınde tanımlanır
            // "," boyut saysını belırtır  boyut saysının bır eksıgı kadar , kullanılır
            // veri tipi [,] new veri tipi [n,m]
            // m: birinci boyut değer sayısı (satır sayısı)
            // n : ikinci boyut deger sayısı ( her bir satırdakı suutun sayısı )




            ////tek boyutlu dizi
            //var dizi1 = new int[10];
            //var dizi2 = new[] { "a", "b" };


            ////cok boyutlu 

            //var dizi3 = new int[3, 2];

            ////1 2
            ////1 2
            ////1 2

            ////duzensiz cok boyutlu

            //var dizi4 = new int[3][];
            //dizi4[0] = new int[4];
            //dizi4[0] = new int[2];
            //dizi4[0] = new int[5];

            ////1 2 3 4
            ////1 2
            ////1 2 3 4 5



            //Console.WriteLine(dizi1.Length); //tüm elemanların sayısı
            //Console.WriteLine(dizi3.Length); //tüm elemanların sayısı
            //Console.WriteLine(dizi3.GetLength(0)); //satır sayısı
            //Console.WriteLine(dizi3.GetLength(1)); //sutun sayısı
            //Console.WriteLine(dizi4.Length);
            //Console.WriteLine(dizi4[0].Length); //birinci satırdaki eleman sayısı






            //int[][][] d = new int[2][][];

            //d[0] = new int[3][];
            //d[1] = new int[2][];

            //d[0][0] = new int[4];
            //d[0][1] = new int[5];
            //d[0][2] = new int[6];

            //d[1][0] = new int[7];
            //d[1][1] = new int[8];


            //for (int i = 0; i < d.Length; i++)
            //{
            //    for (int j = 0; j < d[i].Length; j++)
            //    {
            //        for (int k = 0; k < d[i][j].Length; k++)
            //        {
            //            Console.Write("{0,3}",d[i][j][k]);
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}


            //var d1 = new int[5] {1,2,3,4,5 };
            //var d2 = new int[10];
            //Array.Copy(d1, 1, d2, 6, 3);

            //foreach (var item in d2)
            //{
            //    Console.WriteLine(item);
            //}


            //int[] dd = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //foreach (var item in dd)
            //{
            //    Console.Write("{0}", item);
            //}
            //Console.WriteLine();

            //var dd2 = Array.FindAll(dd, x => x % 2 == 0);

            //Array.ForEach(dd2, x => Console.Write("{0}",x*x));



            //foreach (var item in dd2)
            //{
            //    Console.Write("{0}", item);
            //}



            ////string sınıfı ile ilgili özellik ve metotlar
            //string s = "ali veli selami";
            //string s2 = "veli";

            //char[] ch = new char[3];
            //ch[0] = 'a';
            //ch[1] = 'l';
            //ch[2] = 'i';

            ////Console.WriteLine(s);

            ////foreach (var item in ch)
            ////{
            ////    Console.Write(item);
            ////}



            ////metotlar
            ////contains: belirtilen değeri içerir mi?
            ////Console.WriteLine("Contains: {0}", s.Contains("veli"));


            ////IndexOf: belirtilen değerin konumunu(indexisin) gösterir (yoksa -1)

            //Console.WriteLine("IndexOf:{0}", s.IndexOf("veli"));



            //Console.WriteLine(":{0}", s.LastIndexOf("veli"));


            //Console.WriteLine("Replace:{0}", s.Replace("veli", "ayse")); //belirtilen değeri , diger deger ile degistirir

            //Console.WriteLine("Remove:{0}", s.Remove(4, 5)); //belirtilen indexi silme işlemi

            //Console.WriteLine("Remove:{0}", s.Remove(s.IndexOf("selami", 7)));







            ////substring: belirtilen konumdan itibaren, belirtilen sayida karakteri elde etme
            ////ikinci deger verilmezse metnin sonuna kadar tum karakterler alinir
            //Console.WriteLine("Substring:{0}", s.Substring(4, 3));
            //Console.WriteLine("Substring:{0}", s.Substring(4, 3));

            //string str = "Celal Bayar Üniversitesi";

            //var index = str.IndexOf("Bayar");
            //Console.WriteLine("Remove:{0}", str.Remove(index, 5)); // Celal Üniversitesi
            //Console.WriteLine("Substring:{0}", str.Substring(index, 5)); //bayar

            ////start, end il baslar/biter: belirtilenm ifade ile baslama veya bitme kontrolu (true,false) büyük küçük harf duyarlıdır
            //Console.WriteLine("StartsWith:{0}", str.StartsWith("A")); //true false
            //Console.WriteLine("EndsWith:{0}", str.EndsWith("A")); //true ,false


            ////toupper,tolower: metnin tumunu buyuk veya kucuk harfe cevirir
            //Console.WriteLine("ToUpper:{0}", str.ToUpper());
            //Console.WriteLine("ToLower:{0}", str.ToLower());




            //string ss = "           ali veli selami               ";
            //Console.WriteLine("Trim:{0}", ss.Trim());//bütün boşlukları temizler
            //Console.WriteLine("TrimStart:{0}", ss.TrimStart());//baştaki boşlukları siler
            //Console.WriteLine("TrimEnd:{0}", ss.TrimEnd());//sonda ki boşlukları siler




            ////Padleft, PadRight: metnin uzunluğundan kalan kısmın başına veya sonuna belirtilen değer kadar boşluk bırakır
            //string metin = "abc";
            //Console.WriteLine("PadLeft:{0}", metin.PadLeft(10));
            //Console.WriteLine("PadRight:{0}", metin.PadRight(10));

            ////metindeki karakterleri karakter dizisi olarak döndürür
            ////char[] ch = str.ToCharArray();
            ////for (int i = 0; i < ch.Length; i++)
            ////{
            ////    Console.WriteLine("ToCharArray:{0}",ch[i]);
            ////}



            //Console.WriteLine("son");
            //Console.ReadLine();
        }
        }
    }


}
    }
}
