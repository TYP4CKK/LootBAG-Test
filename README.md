# LootBAG-Test
Öncelikle Unity Hub üzerinden Universal 2D template'ini kullanarak bir 2D URP proje oluşturdum.
GitHub üzerinden readme ve gitignore dosyalarını da dahil ederek bir repository oluşturdum.
Bu repository'i kolay dosya aktarımı için cihazıma klonladım.
Unity'deki projemin dosyalarını da bu repository klonuna taşıyıp push işlemiyle repository'e yükledim.
Hazır verilen assetleri de aynı şekilde önce projeye sonra repository'e yükledim.
Unity içerisinden sadece kamera ve ışıklandırmaya sahip bir sahne ekledim.
Bu sahnenin içerisine dikdörtgen bir sprite ekleyerek zemin yaptım.
Box Collider 2D Componentini ekleyerek zeminin fizik etkileşimini sağladım.
Sahneye idle dosyasını sürükleyerek player'ı ekledim. (idle dosyasındaki Sprite Mode'u animasyon istediğim için multiple olarak ayarladım ve boyutu büyütmek için pixels per uniti 16 yaptım.)
Box Collider 2D Componentini ekleyerek karakterin fizik etkileşimini sağladım.
Animator componentini ekledim, idle.anim dosyası yerine yeni bir .anim dosyası oluşturdum. Animation penceresine idle.png'deki her bir frame'i 10'ar saniye aralıkla yerleştirdim ve sabit duruş animasyonunun çalışmasını sağladım. Walk ve Melee animasyonlarını da aynı şekilde ekledim.
Karakterin yatay düzlemde hareket edebilmesi için RigidBody componenti ekledim ve C# bilmediğim için ChatGPT'ye karakteri hareket ettirmek için bir script yazdırıp karaktere yükledim.
Kod kısaca kullanıcıdan hareket edilecek yönün inputunu alıyor ve koddaki yürüme hızı ve yatay hız formülünü kullanarak hareket ediyor. Ayrıca iswalking condition'ını da input alındığı sürece True'ya çevirdiği için bu condition'ı animator ekranından idle ve walk animasyonlarının birbiri arasında geçişine bağladım.
Hasar alabilen nesnelerin ortak özelliklerini içeren IDamageable isimli bir interface ve bu interface'in altında target isimli bir class oluşturdum. Target scriptini kare şeklindeki bir hedef objeye implemente ettim. Aynı zamanda bu objeye Box Collision da ekledim.
Melee Animasyonunu E tuşuna atadım. E Basılı tutulduğu sürece melee animasyonu döngüde çalışıyor.
Target scriptinin içine hasar aldığında renk değiştirmesini sağlayan kodları ekledim.
(Şu ana kadar yazdığım şeyler normalde sabah saat 6 sularında bitmişti ama hasar tetikleme mekanizmasını yapmaya sabahtan beridir uğraştığım halde başarılı bi mekanizma yapamadım)
