# 🌈📚 Sınav Programı Oluşturma Otomasyonu

<div align="center">

# ✨ SınavNet Otomasyon Sistemi ✨

### 🎓 Görsel Programlama Dersi Projesi  
### 🖥️ C# Windows Forms + SQL Server Tabanlı Sınav Programı Yönetim Sistemi

<br>

![C#](https://img.shields.io/badge/C%23-Programming-68217A?style=for-the-badge&logo=csharp&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-Desktop%20App-0078D7?style=for-the-badge&logo=windows&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL%20Server-Database-CC2927?style=for-the-badge&logo=microsoftsqlserver&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-IDE-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white)
![GitHub](https://img.shields.io/badge/GitHub-Version%20Control-181717?style=for-the-badge&logo=github&logoColor=white)

</div>

---

## 📌 Proje Tanımı

**Sınav Programı Oluşturma Otomasyonu**, eğitim kurumlarında sınav planlama sürecini daha düzenli, hızlı ve yönetilebilir hale getirmek amacıyla geliştirilmiş bir masaüstü otomasyon sistemidir.

Bu proje ile bölüm, ders, sınıf, derslik, akademik takvim ve zaman dilimi bilgileri kullanılarak sınav programları oluşturulabilir, listelenebilir ve Excel uyumlu formatta dışa aktarılabilir.


---

## 🎯 Projenin Amacı

Bu projenin temel amacı, sınav programı hazırlama sürecinde yaşanan karışıklıkları azaltmak ve işlemleri dijital ortamda daha kontrollü hale getirmektir.

Manuel sınav programı hazırlarken oluşabilecek problemler:

- ⛔ Derslerin aynı zamana denk gelmesi
- ⛔ Derslik kapasitesinin yetersiz olması
- ⛔ Akademik takvim karışıklıkları
- ⛔ Bölüm bazlı program takibinin zorlaşması
- ⛔ Programların paylaşımında düzensizlik yaşanması

Bu otomasyon sistemi sayesinde bu süreç daha düzenli, takip edilebilir ve yönetilebilir hale getirilmiştir.

---

## 🧰 Kullanılan Teknolojiler

| Teknoloji | Kullanım Amacı |
|---|---|
| 💜 **C#** | Uygulamanın ana programlama dili |
| 🖥️ **Windows Forms** | Masaüstü arayüz tasarımı |
| 🗄️ **SQL Server** | Veritabanı yönetimi |
| 🔗 **ADO.NET** | Veritabanı bağlantı işlemleri |
| 🧠 **Visual Studio** | Geliştirme ortamı |
| 🌍 **GitHub** | Proje paylaşımı ve sürüm kontrolü |

---

## 👥 Kullanıcı Rolleri

Projede iki temel kullanıcı rolü bulunmaktadır:

---

### 🔐 Yönetici Paneli

Yönetici, sistemdeki temel verileri yönetebilen ana kullanıcıdır.

Yönetici modülünde yapılabilen işlemler:

- 👤 Kullanıcı yönetimi
- 🏫 Bölüm yönetimi
- 📘 Ders yönetimi
- 🧑‍🎓 Sınıf seviyesi yönetimi
- 🏛️ Derslik yönetimi
- 📅 Akademik takvim yönetimi
- ⏰ Takvim zaman dilimi yönetimi
- 📋 Tüm sınav programlarını görüntüleme
- 📤 Programları Excel uyumlu CSV formatında dışa aktarma

---

### 👨‍🏫 Hoca / Personel Paneli

Hoca veya personel kullanıcısı, kendi bölümüne ait sınav programı işlemlerini gerçekleştirebilir.

Hoca modülünde yapılabilen işlemler:

- 📚 Kendi bölümüne ait dersleri görüntüleme
- 🧩 Sınav programı oluşturma
- 📋 Oluşturulan sınav programlarını listeleme
- 🔢 Program versiyonları arasında seçim yapma

---

## 🏗️ Proje Yapısı

```text
GorselProgramlamaProje/
│
├── LoginModulForm/
│   ├── LoginForm.cs
│   ├── YoneticiModul.cs
│   ├── HocaModul.cs
│   ├── KullaniciYonetimi.cs
│   ├── BolumYonetimi.cs
│   ├── DersYonetimi.cs
│   ├── DersArama.cs
│   ├── DerslikYonetimi.cs
│   ├── DerslikAraForm.cs
│   ├── SinifYonetimi.cs
│   ├── AkademikTakvim.cs
│   ├── TakvimZamanDilimi.cs
│   ├── SinavProgramiOlustur.cs
│   ├── SinavProgramiMotoru.cs
│   ├── TumProgramlar.cs
│   └── DataBaseClass.cs
│
├── SinavNet/
├── packages/
├── LoginModulForm.slnx
├── .gitignore
└── README.md
