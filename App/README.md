# 📦 App – Basit Kütüphane API Uygulaması

Bu proje, **BLM3062 - Açık Kaynak Kodlu Yazılımlar** dersi kapsamında geliştirilen OpenAPI tanımına uygun olarak hazırlanmış basit bir ASP.NET Core Web API uygulamasıdır.

Amaç, bir üniversite kütüphane sisteminde yer alan `loans` varlığına ait işlemleri gerçekleştiren bir REST API oluşturmak ve bu yapıyı dosya tabanlı veri yönetimi ile desteklemektir.

---

## 🧩 Kullanılan API Endpoint’i

Proje, OpenAPI tanımında belirtilen aşağıdaki zorunlu endpoint’lerden sadece **`/loans`** varlığına ait ikisini temel alır:

| Endpoint         | HTTP Metodu | Açıklama                      |
|------------------|-------------|-------------------------------|
| `/loans`         | `POST`      | Yeni ödünç kaydı oluşturur    |
| `/loans`         | `GET`       | Tüm ödünç kayıtlarını getirir |

---

## 🏗 Yapı ve Kullanılan Paketler

Bu proje **hiçbir harici NuGet paketi** kullanmadan, sadece .NET SDK ile çalışır. Swagger desteği için yalnızca `Swashbuckle.AspNetCore` eklenmiştir.

**Kurulum paket:**
```bash
dotnet add package Swashbuckle.AspNetCore
dotnet run
```
