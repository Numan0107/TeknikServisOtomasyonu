using System;

public class Cihaz
{
    public int Id { get; set; }
    public string MusteriAdi { get; set; } = string.Empty;
    public string Telefon { get; set; } = string.Empty;
    public string CihazModeli { get; set; } = string.Empty;
    public string ArizaDetayi { get; set; } = string.Empty;
    
    // Durumlar: "Beklemede", "Tamir Ediliyor", "Parça Bekliyor", "Hazır", "Teslim Edildi"
    public string Durum { get; set; } = "Beklemede"; 
    
    // Maliyet Hesaplama Alanları
    public decimal IscilikUcreti { get; set; }
    public decimal ParcaMaliyeti { get; set; }
    
    // İşçilik ve parçayı otomatik toplayan akıllı C# özelliği
    public decimal ToplamUcret => IscilikUcreti + ParcaMaliyeti;
    
    public DateTime KayitTarihi { get; set; } = DateTime.Now;
}
