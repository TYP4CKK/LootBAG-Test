# LootBAG-Test
Öncelikle Unity Hub üzerinden Universal 2D template'ini kullanarak bir 2D URP proje oluşturdum.
GitHub üzerinden readme ve gitignore dosyalarını da dahil ederek bir repository oluşturdum.
Bu repository'i kolay dosya aktarımı için cihazıma klonladım.
Unity'deki projemin dosyalarını da bu repository klonuna taşıyıp push işlemiyle repository'e yükledim.
Hazır verilen assetleri de aynı şekilde önce projeye sonra repository'e yükledim.
Unity içerisinden sadece kamera ve ışıklandırmaya sahip bir sahne ekledim.
Bu sahnenin içerisine kare bir sprite ekleyerek zemin yaptım.
Box Collider 2D Componentini ekleyerek zeminin fizik etkileşimini sağladım.
Sahneye idle dosyasını sürükleyerek player'ı ekledim. (idle dosyasındaki Sprite Mode'u animasyon istediğim için multiple olarak ayarladım ve boyutu büyütmek için pixels per uniti 32 yaptım.)
Box Collider 2D Componentini ekleyerek karakterin fizik etkileşimini sağladım.
Animator componentini ekledim, idle.anim dosyası yerine yeni bir .anim dosyası oluşturdum. Animation penceresine idle.png'deki her bir frame'i 10'ar saniye aralıkla yerleştirdim ve sabit duruş animasyonunun çalışmasını sağladım.
