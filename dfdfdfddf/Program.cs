using System;
using System.Collections.Generic;
using System.Threading;

public class TextAdventureGame
{
    // ====== OYUN DURUMU DEĞİŞKENLERİ ======
    public static string playerName = "";
    public static int playerHealth = 100;
    public static int playerAttack = 15;
    public static List<string> playerInventory = new List<string>();
    public static string currentLocation = "BaslangicOdasi";
    public static bool hasKey = false;
    public static bool hasSword = false;
    public static bool goblinDefeated = false;
    public static bool dragonDefeated = false;
    public static bool gameEnded = false;
    public static bool stoneTabletRead = false;
    public static bool trapDisarmed = false;
    public static bool bookRead = false;
    public static bool codeCracked = false;

    // ====== ANA OYUN DÖNGÜSÜ ======
    public static void Main(string[] args)
    {
        // Program.cs'den alınan CountryCard fonksiyonu için değişkenler
        string ulkeAdiGiris = "";
        string baskentGiris = "";
        string bayrakRengiGiris = "";

        // CountryCard kısmı
        Console.WriteLine("Ülke Bilgisi Kartı Oluşturucu");
        Console.Write("Ülke Adı Giriniz: ");
        ulkeAdiGiris = Console.ReadLine(); //

        Console.Write("Başkenti Giriniz: ");
        baskentGiris = Console.ReadLine(); //

        Console.Write("Bayrak Rengini Giriniz: ");
        bayrakRengiGiris = Console.ReadLine(); //

        Console.WriteLine(CountryCard(ulkeAdiGiris, baskentGiris, bayrakRengiGiris)); //
        Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz")); //
        Console.ReadKey(); //
        Console.Clear(); // Konsolu temizleyelim ki oyun başlasın

        // Metin Macera Oyunu kısmı başlıyor
        GameIntro();
        PlayerSetup();

        while (!gameEnded)
        {
            Console.Clear();
            DisplayStatus();
            ExecuteLocationLogic(false); // Her yeni turda konum açıklamasını göster

            if (!gameEnded)
            {
                Console.WriteLine("\nNe yapmak istersin?");
                Console.Write("Komut gir (yardım için 'yardim'): ");
                string command = Console.ReadLine().ToLower().Trim();
                ProcessCommand(command);
            }
            Thread.Sleep(500); // Küçük bir bekleme
        }

        Console.WriteLine("\nOyun sona erdi. Oynadığınız için teşekkürler!");
        Console.ReadKey();
    }

    // ====== CountryCard Metodu (İlk ekran görüntüsünden) ======
    public static string CountryCard(string countryName, string capital, string flagColor) //
    {
        string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor; //
        return cardInfo; //
    }

    // ====== OYUN GİRİŞ VE KURULUM METOTLARI ======
    public static void GameIntro()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("*************************************");
        Console.WriteLine("* Derin Zindanların Gizemi          *");
        Console.WriteLine("* Konsol Macera Oyunu               *");
        Console.WriteLine("*************************************");
        Console.ResetColor();
        Console.WriteLine("\nKaranlık bir zindanın soğuk taşları üzerindesin.");
        Console.WriteLine("Hiçbir şey hatırlamıyorsun, sadece bir maceranın seni beklediğini hissediyorsun.");
        Thread.Sleep(2000);
    }

    public static void PlayerSetup()
    {
        Console.Write("\nKahramanın adı ne olacak? ");
        playerName = Console.ReadLine().Trim();
        if (string.IsNullOrEmpty(playerName))
        {
            playerName = "Cesur Gezgin";
            Console.WriteLine($"Adını belirtmediğin için '{playerName}' olarak devam edeceksin.");
        }
        Console.WriteLine($"\nHoş geldin, {playerName}! Maceraya hazır mısın?");
        Console.ReadKey();
    }

    // ====== GÖRSEL VE BİLGİ GÖSTERİM METOTLARI ======
    public static void DisplayStatus()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("-------------------------------------");
        Console.WriteLine($"Konum: {currentLocation} | Can: {playerHealth}/{100} | Saldırı: {playerAttack}");
        Console.Write("Envanter: ");
        if (playerInventory.Count == 0)
        {
            Console.WriteLine("Boş");
        }
        else
        {
            Console.WriteLine(string.Join(", ", playerInventory));
        }
        Console.WriteLine("-------------------------------------");
        Console.ResetColor();
    }

    public static void ShowHelp()
    {
        Console.WriteLine("\n--- Yardım ---");
        Console.WriteLine("  git [yön]    : Belirtilen yöne gider (kuzey, güney, doğu, batı, kuzeybatı, kuzeydoğu, güneybatı).");
        Console.WriteLine("  bak          : Bulunduğun odayı veya spesifik nesneleri inceler (örn: bak tablet).");
        Console.WriteLine("  al [eşya]    : Bir eşyayı envanterine alır (örn: al kılıç).");
        Console.WriteLine("  kullan [eşya]: Envanterindeki bir eşyayı kullanır (örn: kullan anahtar).");
        Console.WriteLine("  oku [nesne]  : Bazı nesneleri okur (örn: oku kitap).");
        Console.WriteLine("  çöz [nesne]  : Bazı bilmeceleri çözer (örn: çöz bilmece).");
        Console.WriteLine("  saldır       : Düşman varsa saldırır.");
        Console.WriteLine("  envanter     : Envanterini görüntüler.");
        Console.WriteLine("  durum        : Mevcut can, saldırı ve konum bilgilerini gösterir.");
        Console.WriteLine("  çık          : Oyundan çıkar.");
        Console.WriteLine("  yardim       : Bu yardım mesajını gösterir.");
        Console.WriteLine("--------------");
    }

    // ====== OYUN KOMUT İŞLEME METODU ======
    public static void ProcessCommand(string command)
    {
        string[] parts = command.Split(' ', 2);
        string action = parts[0];
        string target = parts.Length > 1 ? parts[1] : "";

        switch (action)
        {
            case "git":
                MovePlayer(target);
                break;
            case "bak":
                ProcessLookCommand(target);
                break;
            case "al":
                TakeItem(target);
                break;
            case "kullan":
                UseItem(target);
                break;
            case "saldır":
                AttackEnemy();
                break;
            case "oku":
                ProcessReadCommand(target);
                break;
            case "çöz":
                ProcessSolveCommand(target);
                break;
            case "envanter":
                DisplayStatus();
                break;
            case "durum":
                DisplayStatus();
                break;
            case "yardim":
                ShowHelp();
                break;
            case "çık":
                Console.WriteLine("Oyundan çıkılıyor...");
                gameEnded = true;
                break;
            default:
                Console.WriteLine("Bilinmeyen komut! 'yardim' yazarak komutları görebilirsin.");
                break;
        }
    }

    // ====== YENİ: Bak Komutunu İşleme Metodu ======
    public static void ProcessLookCommand(string target)
    {
        if (target == "tablet" && currentLocation == "ZindaninDerinlikleri" && !stoneTabletRead)
        {
            Console.WriteLine("Tablette eski dilde şunlar yazıyor: 'Gerçek güç, inancında yatar.' Bu sana +5 saldırı gücü kazandırdı!");
            playerAttack += 5;
            stoneTabletRead = true;
        }
        else if (target == "tablet" && currentLocation == "ZindaninDerinlikleri" && stoneTabletRead)
        {
            Console.WriteLine("Tableti zaten okudun.");
        }
        else if (string.IsNullOrEmpty(target))
        {
            ExecuteLocationLogic(true); // Genel "bak" komutu
        }
        else
        {
            Console.WriteLine("Bakabileceğin bir şey bulamadın.");
        }
    }

    // ====== YENİ: Oku Komutunu İşleme Metodu ======
    public static void ProcessReadCommand(string target)
    {
        if (target == "kitap" && currentLocation == "GizemliKutuphane" && !bookRead)
        {
            Console.WriteLine("Kitabı okudun. İçinde zindanın gizli geçitlerine dair bazı ipuçları var. Sanırım Ejderha Mağarası artık haritada gözüküyor!");
            bookRead = true;
            Console.WriteLine("Yeni bir bölge 'EjderhaMagarasiGirisi' açıldı! Koridordan oraya gitmeyi dene.");
        }
        else if (target == "kitap" && currentLocation == "GizemliKutuphane" && bookRead)
        {
            Console.WriteLine("Kitabı zaten okudun.");
        }
        else
        {
            Console.WriteLine("Okuyabileceğin bir şey yok.");
        }
    }

    // ====== YENİ: Çöz Komutunu İşleme Metodu ======
    public static void ProcessSolveCommand(string target)
    {
        if (target == "bilmece" && currentLocation == "SifreliOda" && !codeCracked)
        {
            Console.WriteLine("Bilmeceyi çözmek için bir sayı gir: Ben her zaman gelirim ama asla ulaşamam. Ben neyim?");
            Console.Write("Cevabın: ");
            string answer = Console.ReadLine().ToLower().Trim();
            if (answer == "yarın" || answer == "yarin")
            {
                Console.WriteLine("Doğru bildin! Kapı açıldı.");
                codeCracked = true;
            }
            else
            {
                Console.WriteLine("Yanlış cevap! Kapı kilitli kaldı.");
            }
        }
        else if (target == "bilmece" && currentLocation == "SifreliOda" && codeCracked)
        {
            Console.WriteLine("Bilmece zaten çözüldü.");
        }
        else
        {
            Console.WriteLine("Çözebileceğin bir şey yok.");
        }
    }


    // ====== HAREKET METODU ======
    public static void MovePlayer(string direction)
    {
        string newLocation = currentLocation;
        switch (currentLocation)
        {
            case "BaslangicOdasi":
                if (direction == "kuzey") newLocation = "Koridor";
                else Console.WriteLine("O yöne gidemezsin.");
                break;
            case "Koridor":
                if (direction == "güney") newLocation = "BaslangicOdasi";
                else if (direction == "doğu") newLocation = "GoblinOdasi";
                else if (direction == "batı") newLocation = "HazineOdasiGirisi";
                else if (direction == "kuzey") newLocation = "ZindaninDerinlikleri";
                else if (direction == "güneybatı") newLocation = "TuzakliKoridor";
                else if (direction == "kuzeydoğu") newLocation = "GizemliKutuphane";
                else if (direction == "kuzeybatı") newLocation = "EjderhaMagarasiGirisi";
                else Console.WriteLine("O yöne gidemezsin.");
                break;
            case "GoblinOdasi":
                if (direction == "batı") newLocation = "Koridor";
                else Console.WriteLine("O yöne gidemezsin.");
                break;
            case "HazineOdasiGirisi":
                if (direction == "doğu") newLocation = "Koridor";
                else if (direction == "kuzey")
                {
                    if (hasKey)
                    {
                        Console.WriteLine("Kapıyı anahtarla açtın ve hazine odasına girdin!");
                        newLocation = "HazineOdasi";
                    }
                    else
                    {
                        Console.WriteLine("Kapı kilitli görünüyor. Bir anahtara ihtiyacın var.");
                    }
                }
                else Console.WriteLine("O yöne gidemezsin.");
                break;
            case "HazineOdasi":
                if (direction == "güney") newLocation = "HazineOdasiGirisi";
                else Console.WriteLine("O yöne gidemezsin.");
                break;
            case "EjderhaMagarasiGirisi":
                if (direction == "kuzey") newLocation = "EjderhaMagarasi";
                else if (direction == "güney") newLocation = "Koridor";
                else Console.WriteLine("O yöne gidemezsin.");
                break;
            case "EjderhaMagarasi":
                if (direction == "güney") newLocation = "EjderhaMagarasiGirisi";
                else Console.WriteLine("O yöne gidemezsin.");
                break;
            case "ZindaninDerinlikleri":
                if (direction == "güney") newLocation = "Koridor";
                else if (direction == "doğu") newLocation = "SifreliOda";
                else Console.WriteLine("O yöne gidemezsin.");
                break;
            case "TuzakliKoridor":
                if (direction == "kuzeydoğu") newLocation = "Koridor";
                else if (direction == "güney")
                {
                    if (trapDisarmed)
                    {
                        Console.WriteLine("Tuzak etkisiz hale getirildi. Güvenle Son Çıkış'a ilerliyorsun.");
                        newLocation = "SonCikis";
                    }
                    else
                    {
                        Console.WriteLine("Önce tuzu etkisiz hale getirmelisin! 'kullan ip' komutunu denesen iyi olur.");
                    }
                }
                else Console.WriteLine("O yöne gidemezsin.");
                break;
            case "GizemliKutuphane":
                if (direction == "güneybatı") newLocation = "Koridor";
                else Console.WriteLine("O yöne gidemezsin.");
                break;
            case "SifreliOda":
                if (direction == "batı") newLocation = "ZindaninDerinlikleri";
                else if (direction == "kuzey")
                {
                    if (codeCracked)
                    {
                        Console.WriteLine("Kapı açıldı. Yeni bir alana giriyorsun!");
                        newLocation = "EjderhaMagarasiGirisi";
                    }
                    else
                    {
                        Console.WriteLine("Önce kapıyı açmalısın!");
                    }
                }
                else Console.WriteLine("O yöne gidemezsin.");
                break;
            case "SonCikis":
                if (direction == "kuzey") newLocation = "TuzakliKoridor";
                else Console.WriteLine("O yöne gidemezsin.");
                break;
        }

        if (newLocation != currentLocation)
        {
            Console.WriteLine($"\n{currentLocation} konumundan {newLocation} konumuna gidiyorsun...");
            currentLocation = newLocation;
            Thread.Sleep(1000);
        }
    }

    // ====== ODA MANTIKLARI - Tek bir metotta tüm konumları işliyoruz ======
    public static void ExecuteLocationLogic(bool lookAgain = false)
    {
        switch (currentLocation)
        {
            case "BaslangicOdasi":
                if (!lookAgain) Console.WriteLine("\nBaslangic Odasi: Etrafına bakıyorsun. Hafif bir ışık kuzeyden geliyor.");
                break;
            case "Koridor":
                if (!lookAgain) Console.WriteLine("\nKoridor: Uzun ve loş bir koridordasın. Doğuda tuhaf sesler, batıda kapalı bir kapı var. Kuzeyde Zindanın Derinliklerine, güneyde Tuzaklı Koridor'a, kuzeybatıda Ejderha Mağarası Girişi'ne, kuzeydoğuda Gizemli Kütüphane'ye giden yollar var.");
                break;
            case "GoblinOdasi":
                if (!goblinDefeated)
                {
                    if (!lookAgain)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nGoblin Odasi: İğrenç bir koku var! Bir goblin sana doğru hırlayarak geliyor!");
                        Console.ResetColor();
                        Console.WriteLine("Saldırmak için 'saldır' yaz.");
                    }
                }
                else
                {
                    if (!lookAgain) Console.WriteLine("\nGoblin Odasi: Goblin ölü. Odada bir kılıç parıldıyor.");
                    if (!hasSword) { Console.WriteLine("Etrafta parlak bir kılıç var."); }
                }
                break;
            case "HazineOdasiGirisi":
                if (!lookAgain) Console.WriteLine("\nHazine Odası Girişi: Ağır, demir bir kapı var. Kapının üzerinde paslı bir kilit duruyor.");
                break;
            case "HazineOdasi":
                if (!lookAgain)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nHazine Odası: Gözlerin kamaşıyor! Altınlar, mücevherler ve ortada pırıl pırıl bir anahtar!");
                    Console.ResetColor();
                    if (!playerInventory.Contains("anahtar"))
                    {
                        Console.WriteLine("Anahtarı almak için 'al anahtar' yaz.");
                    }
                }
                break;
            case "EjderhaMagarasiGirisi":
                if (!lookAgain) Console.WriteLine("\nEjderha Mağarası Girişi: Havada sülfür kokusu var. Mağaranın derinliklerinden uğultular geliyor. Kuzeye doğru devasa bir geçit uzanıyor.");
                break; // Hata burada olabilir, case içinde noktalı virgül eksikliği veya yanlış kapanış
            case "EjderhaMagarasi":
                if (!dragonDefeated)
                {
                    if (!lookAgain)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nEjderha Mağarası: Koca bir ejderha önünde duruyor, gözleri alev alev!");
                        Console.ResetColor();
                        Console.WriteLine("Hayatta kalmak için 'saldır' yaz.");
                    }
                }
                else
                {
                    if (!lookAgain) Console.WriteLine("\nEjderha Mağarası: Ejderha cansız yatıyor. Artık güvendesin. Teşekkürler!");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\nTebrikler! Ejderhayı yendin ve zindanı güvence altına aldın!");
                    Console.WriteLine("Büyük bir kahraman oldun!");
                    Console.ResetColor();
                    gameEnded = true; // Oyunun sonu
                }
                break;
            case "ZindaninDerinlikleri":
                if (!lookAgain)
                {
                    if (!stoneTabletRead)
                    {
                        Console.WriteLine("\nZindanın Derinlikleri: Burası ürkütücü derecede sessiz. Ortada eski bir taş tablet duruyor.");
                        Console.WriteLine("Tableti incelemek için 'bak tablet' yaz.");
                    }
                    else
                    {
                        Console.WriteLine("\nZindanın Derinlikleri: Taş tabletin üzerindeki yazıları okudun. Odada başka ilginç bir şey yok.");
                    }
                }
                break;
            case "TuzakliKoridor":
                if (!lookAgain)
                {
                    if (!trapDisarmed)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nTuzaklı Koridor: Yere basar basmaz bir tık sesi duydun! Zehirli oklar sana doğru fırlıyor!");
                        Console.ResetColor();
                        playerHealth -= 20;
                        Console.WriteLine("Zehirli oklardan 20 can kaybettin! Canın: " + playerHealth);
                        Console.WriteLine("Tuzak çok basit değil, devre dışı bırakmak için bir yol bulmalısın. Belki bir 'ip' işe yarar?");
                        if (playerHealth <= 0)
                        {
                            Console.WriteLine("Zehirli oklar seni öldürdü! Oyun bitti.");
                            gameEnded = true;
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nTuzaklı Koridor: Tuzak devre dışı bırakıldı. Güvenle geçebilirsin.");
                    }
                }
                break;
            case "GizemliKutuphane":
                if (!lookAgain)
                {
                    if (!bookRead)
                    {
                        Console.WriteLine("\nGizemli Kütüphane: Tozlu raflar ve eski kitaplar. Ortada büyük, ciltli bir kitap var.");
                        Console.WriteLine("Kitabı okumak için 'oku kitap' yaz.");
                    }
                    else
                    {
                        Console.WriteLine("\nGizemli Kütüphane: Kitabı okudun. Artık bu odadan ayrılabilirsin.");
                    }
                }
                break;
            case "SifreliOda":
                if (!lookAgain)
                {
                    if (!codeCracked)
                    {
                        Console.WriteLine("\nŞifreli Oda: Kapının üzerinde garip semboller ve bir bilmece var.");
                        Console.WriteLine("Bilmeceyi çözmek için 'çöz bilmece' yaz.");
                    }
                    else
                    {
                        Console.WriteLine("\nŞifreli Oda: Şifreyi çözdün! Diğer odaya geçebilirsin.");
                    }
                }
                break;
            case "SonCikis":
                if (!lookAgain)
                {
                    if (dragonDefeated)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nSon Çıkış: Zindandan çıkış kapısı! Güneş ışığını görüyorsun!");
                        Console.WriteLine("Zindanın tüm tehlikelerini aştın ve dışarı çıktın!");
                        Console.ResetColor();
                        gameEnded = true;
                    }
                    else
                    {
                        Console.WriteLine("\nSon Çıkış: Burası çıkışa benziyor ama bir his seni durduruyor. Zindanın hala üstesinden gelmen gereken tehlikeleri var gibi. Ejderha hala hayattaysa çıkamazsın.");
                    }
                }
                break;
            default:
                Console.WriteLine("\nBilinmeyen bir yerdesin. Bu bir hata olabilir.");
                break;
        }
    }

    // ====== EŞYA ALMA METODU - Tek bir metotta tüm eşyaları işliyoruz ======
    public static void TakeItem(string item)
    {
        switch (currentLocation)
        {
            case "GoblinOdasi":
                if (item == "kılıç" && goblinDefeated && !hasSword)
                {
                    playerInventory.Add("kılıç");
                    playerAttack += 10;
                    hasSword = true;
                    Console.WriteLine("Parlak kılıcı aldın! Saldırı gücün arttı.");
                }
                else if (item == "kılıç" && !goblinDefeated)
                {
                    Console.WriteLine("Önce goblin'i yenmelisin!");
                }
                else if (item == "kılıç" && hasSword)
                {
                    Console.WriteLine("Kılıcı zaten aldın.");
                }
                else
                {
                    Console.WriteLine("Burada böyle bir eşya yok.");
                }
                break;
            case "HazineOdasi":
                if (item == "anahtar" && !hasKey)
                {
                    playerInventory.Add("anahtar");
                    hasKey = true;
                    Console.WriteLine("Pırıl pırıl bir anahtar aldın!");
                }
                else if (item == "anahtar" && hasKey)
                {
                    Console.WriteLine("Anahtarı zaten aldın.");
                }
                else
                {
                    Console.WriteLine("Burada böyle bir eşya yok.");
                }
                break;
            case "ZindaninDerinlikleri":
                if (item == "ip" && !playerInventory.Contains("ip"))
                {
                    playerInventory.Add("ip");
                    Console.WriteLine("Yere düşmüş bir 'ip' buldun ve envanterine ekledin.");
                }
                else if (item == "ip" && playerInventory.Contains("ip"))
                {
                    Console.WriteLine("İpi zaten aldın.");
                }
                else
                {
                    Console.WriteLine("Burada böyle bir eşya yok.");
                }
                break;
            default:
                Console.WriteLine("Burada alabileceğin bir eşya yok.");
                break;
        }
    }

    // ====== EŞYA KULLANMA METODU - Tek bir metotta tüm kullanım senaryolarını işliyoruz ======
    public static void UseItem(string item)
    {
        if (!playerInventory.Contains(item))
        {
            Console.WriteLine("Envanterinde böyle bir eşya yok.");
            return;
        }

        switch (item)
        {
            case "anahtar":
                if (currentLocation == "HazineOdasiGirisi")
                {
                    if (hasKey)
                    {
                        Console.WriteLine("Anahtarı kullandın! Hazine Odası kapısı şimdi açık. 'git kuzey' yazarak girebilirsin.");
                    }
                    else
                    {
                        Console.WriteLine("Anahtarın yok ki!");
                    }
                }
                else
                {
                    Console.WriteLine("Bu eşyayı burada kullanamazsın.");
                }
                break;
            case "kılıç":
                Console.WriteLine("Kılıcı kuşandın! (Saldırı için 'saldır' komutunu kullan)");
                break;
            case "ip":
                if (currentLocation == "TuzakliKoridor" && !trapDisarmed)
                {
                    Console.WriteLine("İpi kullanarak tuzak mekanizmasını devre dışı bıraktın! Artık güvenle geçebilirsin.");
                    trapDisarmed = true;
                    playerInventory.Remove("ip");
                }
                else
                {
                    Console.WriteLine("İpi burada kullanamazsın.");
                }
                break;
            default:
                Console.WriteLine($"'{item}' adlı eşyayı şu an kullanamıyorsun.");
                break;
        }
    }

    // ====== SAVAŞ METODU ======
    public static void AttackEnemy()
    {
        switch (currentLocation)
        {
            case "GoblinOdasi":
                if (!goblinDefeated)
                {
                    Console.WriteLine("Goblin'e saldırıyorsun!");
                    int goblinHealth = 30;
                    int goblinAttack = 5;

                    while (playerHealth > 0 && goblinHealth > 0)
                    {
                        Console.WriteLine("Sen saldırıyorsun...");
                        goblinHealth -= playerAttack;
                        if (goblinHealth <= 0)
                        {
                            Console.WriteLine("Goblin'i yendin!");
                            goblinDefeated = true;
                            Console.WriteLine("Etrafta bir kılıç parıldıyor.");
                            break;
                        }

                        Console.WriteLine($"Goblin'in canı: {goblinHealth}");
                        Console.WriteLine("Goblin sana saldırıyor...");
                        playerHealth -= goblinAttack;
                        if (playerHealth <= 0)
                        {
                            Console.WriteLine("Goblin seni yendi! Oyun bitti.");
                            gameEnded = true;
                            break;
                        }
                        Console.WriteLine($"Senin canın: {playerHealth}");
                        Thread.Sleep(1000);
                    }
                }
                else
                {
                    Console.WriteLine("Burada saldıracak kimse yok.");
                }
                break;
            case "EjderhaMagarasi":
                if (!dragonDefeated)
                {
                    Console.WriteLine("Ejderha'ya saldırıyorsun!");
                    int dragonHealth = 100;
                    int dragonAttack = 20;

                    if (!hasSword)
                    {
                        Console.WriteLine("Kılıcın olmadan ejderhayla savaşmak delilik olur! Geri çekilmelisin!");
                        Console.WriteLine("Ejderha seni tek darbede yendi! Oyun bitti.");
                        playerHealth = 0;
                        gameEnded = true;
                        return;
                    }

                    while (playerHealth > 0 && dragonHealth > 0)
                    {
                        Console.WriteLine("Sen saldırıyorsun...");
                        dragonHealth -= playerAttack;
                        if (dragonHealth <= 0)
                        {
                            Console.WriteLine("Ejderha'yı yendin! Muhteşem bir zafer!");
                            dragonDefeated = true;
                            gameEnded = true;
                            break;
                        }

                        Console.WriteLine($"Ejderhanın canı: {dragonHealth}");
                        Console.WriteLine("Ejderha sana alev püskürtüyor...");
                        playerHealth -= dragonAttack;
                        if (playerHealth <= 0)
                        {
                            Console.WriteLine("Ejderha seni yendi! Maalesef oyun bitti.");
                            gameEnded = true;
                            break;
                        }
                        Console.WriteLine($"Senin canın: {playerHealth}");
                        Thread.Sleep(1500);
                    }
                }
                else
                {
                    Console.WriteLine("Burada saldıracak kimse yok.");
                }
                break;
            default:
                Console.WriteLine("Burada saldıracak bir düşman yok.");
                break;
        }
    }
}