using System.Diagnostics;
using System.Threading.Channels;



internal class Program
{
    private static void Main(string[] args)
    {
        string cevap = string.Empty;
        do
        {
            //Nereye gideceğini sorum stringi küçük harfe çevirdim
            Console.Write("Nereye gitmek istersiniz? Giriniz(Bodrum-Marmaris-Cesme): ");
            string location = Console.ReadLine();
            string locationLower = location.ToLower();

            //eğer input yanlış girilirse durmadan kodu çeviriyor.
            while (!(locationLower == "bodrum" || locationLower == "cesme" || locationLower == "marmaris"))
            {
                Console.Write("Yanlış il girdiniz. Tekrar giriniz:");
                location = Console.ReadLine();
                locationLower = location.ToLower();
            }


            // kişi sayısı aldım 
            Console.Write("Kişi sayısını giriniz: ");
            int people = Convert.ToInt32(Console.ReadLine());


            //Ulaşım seçeneğini seçtirdim.
            Console.Write(
        @"Ulaşım seçenekleri:
        1) Kara yolu: Kişi başı gidiş-dönüş 1500TL
        2) Hava yolu: Kişi başı gidiş-dönüş 4000TL
        1 veya 2 tuşlayınız: ");
            int transportation = Convert.ToInt32(Console.ReadLine());


            // 1 veya 2 dışında bir değer girerse tekrar soruyor.
            while (!(transportation == 1 || transportation == 2))
            {
                Console.Write("Yanlış değer girdiniz. Tekrar giriniz:");
                transportation = Convert.ToInt32(Console.ReadLine());
            }




            // kaç gün kalacağının bilgisi.
            Console.Write("Kaç gün Kalacaksınız ?:");
            int days = Convert.ToInt32(Console.ReadLine());


            // caselere göre fiyat hesaplama
            int bodrumPrice = 4000;
            int marmarisPrice = 3000;
            int cesmePrice = 5000;

            int price = 0;
            switch (locationLower)
            {
                case "bodrum":
                    Console.WriteLine(
                 @"Bodrum'un eski adı 'Halikarnassos'tur. Türkçe'de 'Halikarnassos' olarak okunmuştur.
                 Kent Aziz Petrus Kalesi olarak adlandırılan kale ile birlikte Aziz Petrus'a adanmasından
                 sonra 'Petrium' adını almıştır. Zamanla bu isim 'petrum', ardından 'potrum' ve son olarak
                 'Bodrum' olarak telaffuz edilmiştir. Bodrum'da çok şey var. Muhteşem bir deniz, muhteşem bir doğa,
                 Turistik yerler, müzeler, camiler, tarihi yerler, eski kiliseler, gezi yerleri ve daha fazlası..");

                    price = people * (bodrumPrice + transportation) * days;
                    Console.WriteLine(people + " kişilik " + days + " günlük Bodrum tatiliniz ortalama " + price + "TL.");

                    break;

                case "marmaris":
                    Console.WriteLine(
                 @"Marmaris'in tarihi MÖ 12000'lere kadar gider. 2007 yılında Bedir Adasındaki Nimara Mağarasında yapılan kazı çalışmaları
                 sonucu bulunan materyaller bunu teyit etmektedir. 17 Eylül 2007'de Marmaris Müzesi'ndeki basın toplantısı}... Bölgeye Karia adı Kar'ın ülkesi anlamıda
                 sonradan verilmiştir.Ege ve Akdeniz'in kıyılarının bereketi, bölgeyi devamlı çekici kılmıştır. Şehir Rodos ve Ege adalarına açılan en önemli köprüdür.                  
                 Böylece Marmaris zaman içinde pek çok medeniyetin hüküm sürdüğü bir yer haline gelmiştir. Bölgede yapılacak gezilerde Karia, Rodos ve ada uygarlıkları, 
                 Mısır, Asur, İon, Pers, Makedon, Suriye, Roma, Bizans, Selçuklu ve Osmanlı medeniyetlerinin izlerini görmek mümkündür. Fiskos kentin ilk adıdır. Bugün
                 Asartepe denilen mevkide kalıntıları görülebilir.");


                    price = people * (marmarisPrice + transportation) * days;
                    Console.WriteLine(people + " kişilik " + days + " günlük Bodrum tatiliniz ortalama " + price + "TL.");

                    break;

                case "cesme":

                    Console.WriteLine(
                @"İlk çağda CYSUS adıyla bilinen Çeşme, Anadolu’nun batı kıyısında MÖ 1000 yıllarında kurulduğu tahmin edilen 12 İonya kentinden biri olan ERYTHRAI (ERİTRE)’nin
                Ildır iskelesiydi.Çeşme’nin bugünkü  adını denizcilerin su temin ettikleri “çeşme”lerden aldığı sanılmaktadır. Bugün arkeolojik ve turistik yönden büyük önem taşıyan
                ERİTRE MÖ 7. ve 8. yüzyıllarda büyük bir iktisadi güce sahip olmuştur. Bu dönemde kent, Doğu Akdeniz özellikle Kıbrıs ile ticari ilişkilerde bulunuyor ve (CHIOS)-SAKIZ 
                Adası ile birlikte esir ve şarap ticaretini elinde tutuyordu.");

                    price = people * (cesmePrice + transportation) * days;
                    Console.WriteLine(people + " kişilik " + days + " günlük Bodrum tatiliniz ortalama " + price + "TL.");

                    break;

                default:
                    Console.WriteLine("Yanlış giriş yaptınız. Lütfen Bodrum-Çeşme_Marmaris illerinden birini giriniz. ");

                    break;
            }
            // cevap hayır olduğunda döngüden çıkacak
            Console.Write("Başka bir yolculuk daha planlıyor musunuz ? Evet veya Hayır yazınız: ");
            cevap = Console.ReadLine().ToLower();
        }
        while (cevap == "evet");
        
        Console.WriteLine("İyi günler dileriz !!!");   
                
                
            
            



        
    }
}