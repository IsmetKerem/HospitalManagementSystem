# 🏥 HospitalManagementSystem

⚡ **C# ile geliştirilmiş kapsamlı Hastane Yönetim Sistemi** ⚡  
Bu proje, gerçek bir hastanenin günlük işleyişini dijital ortama taşımak için tasarlanmış bir uygulamadır.  
Hastaların kolayca randevu alabilmesi, doktorların randevularını ve hastaları takip edebilmesi, sekreterlerin tüm yönetimsel işlemleri hızlıca yapabilmesi amaçlanmıştır.  
Kısacası bu sistem, **hastane içinde iletişim, organizasyon ve yönetimi** tek bir panel üzerinden sağlamayı hedefler.  

👨‍⚕️ Doktorlar → Hasta bilgilerine ve randevulara hızlı erişim.  
👩‍💼 Sekreterler → Branş, doktor ve randevu yönetimini üstlenir.  
👤 Hastalar → Kendi giriş ekranlarıyla sisteme girip randevularını takip eder.  

Modern hastanelerde kullanılan yönetim panellerine benzer şekilde kurgulanan bu proje, hem eğitim amaçlı hem de temel bir demo yazılımı olarak değerlendirilebilir.

---

## ✨ Özellikler

### 👤 Hasta Paneli
- **Giriş / Kayıt**: TC Kimlik No ve şifre ile giriş veya yeni kayıt olma.  
- **Randevu İşlemleri**: Branş ve doktor seçerek yeni randevu oluşturma.  
- **Randevu Geçmişi**: Önceden alınmış randevuların listesi.  
- **Aktif Randevular**: Güncel randevuların detaylı görüntülenmesi.  

### 👨‍⚕️ Doktor Paneli
- **Bilgi Görüntüleme**: Doktor TC, isim bilgileri ve kişisel bilgiler.  
- **Randevu Listesi**: Hastaların alınan randevularının listelenmesi.  
- **Randevu Detayı**: Hasta şikayetleri ve randevu bilgilerine hızlı erişim.  
- **Duyurular**: Hastane yönetimi tarafından yapılan duyuruları görme.  

### 👩‍💼 Sekreter Paneli
- **Branş Yönetimi**: Branş ekleme, silme ve güncelleme.  
- **Doktor Yönetimi**: Doktorların branşlara atanması.  
- **Randevu İşlemleri**: Tarih, saat, branş ve doktor seçerek randevu oluşturma.  
- **Duyuru Oluşturma**: Hastane genelinde görüntülenecek duyurular ekleme.  

### 📢 Duyurular
- Hastane yönetiminden anlık mesajlar.  
- Toplantı, nöbet çizelgesi veya yeni düzenlemeler için kullanılır.  

---

## 📸 Görseller

### 🔐 Hasta Giriş Ekranı
 <img width="1132" height="588" alt="hastalogin" src="https://github.com/user-attachments/assets/9e3488f0-3538-486a-b61c-10e2a3f8576b" />

> Hastalar TC ve şifreleriyle giriş yapar veya yeni üye olabilir.  

### 🏥 Ana Sayfa (Rol Seçimi)
<img width="1131" height="586" alt="homepage" src="https://github.com/user-attachments/assets/df6dd604-5dd5-424e-90cd-afbdf7402471" />

> Kullanıcı girişte hasta, doktor veya sekreter rollerinden birini seçer.  

### 👨‍⚕️ Doktor Paneli
 <img width="1123" height="593" alt="doctorpaneli" src="https://github.com/user-attachments/assets/f726ef3b-1967-4f19-be2b-85ca31f06c01" />

> Doktorlar kendilerine ait randevuları ve hastaların şikayetlerini buradan görür.  

### 👩‍💼 Sekreter Yönetim Paneli
<img width="1129" height="588" alt="sekreterhome" src="https://github.com/user-attachments/assets/6a3e7739-e3eb-4473-a570-a703de4af123" />

> Sekreterler branş, doktor ve randevu yönetimini yapar; ayrıca duyuru ekleyebilir.  

### 📢 Duyuru Ekranı
<img width="1138" height="587" alt="duyurular" src="https://github.com/user-attachments/assets/f882a32a-4d09-4860-a957-10c01a7b896c" />

> Hastane yönetiminden gelen mesajlar listelenir.  

### 📅 Randevu Listesi
<img width="1132" height="588" alt="randevulistesi" src="https://github.com/user-attachments/assets/f603ed05-aab7-4d2a-bb88-c13583f5e7d6" />

> Tüm alınan randevular detaylı olarak görüntülenir.

### 😷 Hasta Randevu Alma Paneli
<img width="1168" height="604" alt="hastarandevu" src="https://github.com/user-attachments/assets/b3281849-3c07-40df-a327-b6a3c79640af" />
> Hastanın randevu aldığı panel.

---

## 🛠️ Kullanılan Teknolojiler
- **C# Windows Forms** → kullanıcı arayüzü  
- **MSSQL Database** → veri saklama  
- **ADO.NET** → veri tabanı bağlantısı  
