# Cubethon

Proje Gulliver's Games stajyerlik başvurusu kapsamında geliştirilmiştir. Kullanılan Unity versiyon: 2018.4.22 LTS

Dilerseniz proje klasörü içerisindeki Building dosyası içerisinden direk uygulama .exe'sine erişebilirsiniz. Dilerseniz de Unity ile erişebilirsiniz. Unity ile erişmeniz durumunda;

kullanıcı ve engellerin hızlarını, oyun süresini kendinize göre ayarlayabilirsiniz.


Proje içeriği;

Assets/Animation ;  bölüm sonrası animasyonu içermektedir.

Assets/Fonts ; proje içerisinde gereken yazıların font ayarlamasında kullanılan fontları içermektedir.

Assets/Materials ; engel, engel fiziksel görünüm, player fiziksel görünüm bilgilerini içermektedir.

Assets/Prefabs ; Canvas, GameManager, Main Camera, Player objelerini içermektedir.

Assets/Scripts ; credits, FollowPlayer, GameManager, LevelComplete, Menu, Moved, PlayerCollision, PlayerMovement, Score kod scrit'lerini içerkemtedir.

Assets ; Menu, Level01, Level02, Level03, Credits sahnelerini ve Slippery physicMaterial'i içermektedir.

Proje başlarken;

Eğer SimpleScene veya untitledScene sahneleri açık ise Assets içerisinden Menu sahnesi açılmalıdır.

Kamera açısını belirlemek için; Level menulerine girip Main Camera objesi içerisinden Offset değerlerini değiştirebilirsin.
                                (Tercihen x:0 tutulup yükseklik için y, uzaklık için z değeri değiştirmeniz önerilir.)

Oyun süresini belirlemek için; Level menulerine girip Canvas->Score objesi içerisinde Score(Script) içerisinden Score Limit Count değeri değiştirilebilir.
                               (Saniyede 2 puan işlemektedir.)

Player hızını belirlemek için; Level menulerine girip Player objesi içerisinde Player Movement(Script) içerisinden Sideways Force değeri değiştirilebilir.

Engel hızlarını belirlemek için: Level menulerine girip herhangi bir Obstacle objesi içerisinde Moved(Scripts) içerisinden Forward Force değerini değiştirip,
                                 en üst menüden Apply All seçeneğini seçerseniz tüm engellerin hızlarını değiştirmiş olursunuz.

Proje başlayınca;

Menu ekranından start butonuna basarak projeye başlayabilirsiniz. 

'A' ve 'D' tuşları ile bloğunuzu sol ve sağa yönlendirerek, girdiğiniz puana erişene kadar hedeflerden kaçmanız beklenmetedir.(Bloğumuza ileri, geri yönlendirilmesi 
yapılmamaktadır.)

Eğer engellere çarpar veya platformdan düşerseniz bölüm baştan başlamaktadır.


UYARI


Uygulamanın incelenebilirliği açısından 1.Levelde 2, 2.Levelde 3, 3.Levelde 4 engel vardır. Dilerseniz Level menusundan Obstacle objesine tıklayıp ctrl+d yaparak engel objelerinizi çoğaltabilirsiniz.

Bölümün sürdürülebilirliği için engel objelerimiz kullanıcı bloğumuz tarafından atlatıldıktan sonra platformun ilerisinde yatay bir pozisyonda rastgele bir konumda yeniden başlar ve üzerimize gelmeye devam eder.

3 levelde sona erdiğinde gelen credit ekranındaki QUIT butonu çalışmamaktadır.


Not: Sebebini henüz çözemediğim bir hatadan dolayı Console ekranında Error Pause açıksa oyun, her level başında pause olabiliyor.
     Oyuna başlamadan Console ekranından Error Pause un seçilini olmadığından emin olunuz.

İyi oyunlar..

Alperen İLERİ
