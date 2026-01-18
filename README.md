# Mağaza Uygulaması

C# ve Windows Forms kullanılarak geliştirilen, **Nesne Yönelimli Programlama (OOP)** prensiplerini gerçek hayat senaryosunda uygulayan sanal market projesidir.

## 🌟 Projenin Amacı
Kullanıcıların ürün seçebileceği, sepet yönetimi yapabileceği, indirim kuponu kullanabileceği ve farklı ödeme yöntemlerini (Nakit/Kart) deneyimleyebileceği interaktif bir simülasyon sunmaktır.

## ⚙️ Teknik Özellikler
* **Dinamik Sepet:** Ürün ekleme, silme ve anlık tutar hesaplama.
* **OOP Mimarisi:**
  * **Polimorfizm:** Ödeme yöntemleri (Kart/Nakit) tek merkezden yönetilir.
  * **Operator Overloading:** İndirim kuponu hesaplamaları için özel operatör tanımlanmıştır.
  * **Interface (Arayüz):** `IUrun` arayüzü ile ürün standartları (Ad, Fiyat) belirlenmiştir.
  * **Kapsülleme:** Hatalı veri ve negatif fiyat girişleri engellenmiştir.

## 🚀 Kurulum
1.  Projeyi indirin (`Clone` veya `Download ZIP`).
2.  `Magaza.sln` dosyasını Visual Studio ile açın.
3.  **Start** tuşuna basarak çalıştırın.
