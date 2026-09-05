# 🛠️ TeknikServisOtomasyonu - Arıza ve Teknik Servis Sistemi

Teknik servislerin cihaz durumlarını, müşteri kayıtlarını ve tamir maliyetlerini uçtan uca takip etmesini sağlayan kurumsal bir operasyon yazılımıdır.

## 🛠️ Kullanılan Teknolojiler
* **C# 13** & .NET 9.0 (Blazor Server Architecture)
* HTML5 & Bootstrap CSS (Görsel Tasarım)

## 🚀 Ne Yapıyor?
* **Durum Yönetimi:** Cihazların tamir aşamalarını (Beklemede, Tamir Ediliyor, Parça Bekliyor, Hazır, Teslim Edildi) anlık takip eder.
* **Akıllı Finans Motoru:** Cihaz durumu "Teslim Edildi"ye çekildiği an, işçilik ve yedek parça maliyetlerini otomatik toplayarak gün sonu cirosuna ekler.
* **Gelişmiş Veri Doğrulama:** 
  * Müşteri adı alanına sayı, telefon alanına harf girilmesini engeller.
  * Telefon numarasının kalıcı olarak `0` ile başlamasını zorunlu kılar ve en fazla 11 hane ile kısıtlar.

