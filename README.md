# 📚 Üniversite Kütüphane Sistemi - OpenAPI 3.0 Tanımı
Bu çalışma, BLM3062 - Açık Kaynak Kodlu Yazılımlar dersi kapsamında hazırlanmıştır.
Bu proje, bir üniversiteye ait çevrim içi kütüphane sisteilişkin REST API yapısını **OpenAPI 3.0.3** standardına uygun olarak tanımlamaktadır.
---

## 📝 API Açıklaması

### 🔹 Varlıklar (Entities)

Sistem 3 ana varlık üzerine kuruludur:

1. **books**
   - Kitap bilgilerini içerir.
   - Alanlar: `id`, `title`, `author`, `isbn`, `publisher`, `pageCount`, `stock`

2. **students**
   - Öğrencilere ait temel bilgileri içerir.
   - Alanlar: `id`, `name`, `studentNumber`, `email`, `isActive`

3. **loans**
   - Kitap ödünç alma işlemlerini yönetir.
   - Alanlar: `id`, `studentId`, `bookId`, `loanDate`, `returnDate`, `status` (enum: `ongoing`, `returned`, `late`)

---

### 🔹 CRUD İşlemleri ve Endpoint’ler

Tüm CRUD işlemleri RESTful ilkelere uygun olarak tanımlanmıştır:

#### 📘 `/books`
| Metod | Açıklama |
|-------|----------|
| GET   | Tüm kitapları getir (sayfalama destekli) |
| GET `/books/{id}` | Belirli bir kitabı getir |
| POST  | Yeni kitap oluştur |
| PUT `/books/{id}` | Kitap bilgilerini güncelle |
| DELETE `/books/{id}` | Kitap sil |

#### 👤 `/students`
| Metod | Açıklama |
|-------|----------|
| GET   | Tüm öğrencileri getir |
| GET `/students/{id}` | Belirli öğrenciyi getir |
| POST  | Yeni öğrenci oluştur |
| PUT `/students/{id}` | Öğrenci bilgilerini güncelle |
| DELETE `/students/{id}` | Öğrenci sil |

#### 🔄 `/loans`
| Metod | Açıklama |
|-------|----------|
| GET   | Tüm ödünç işlemlerini getir |
| GET `/loans/{id}` | Belirli ödünç kaydını getir |
| POST  | Yeni ödünç işlemi oluştur |
| PATCH `/loans/{id}/return` | Kitabı iade et (durumu `returned` olarak günceller) |

---

### 🔹 `components` Kullanımı

- **`schemas`**: Her varlık için `Book`, `Student`, `Loan` adında şema tanımları yapılmıştır. `required`, `format`, `enum` gibi özellikler aktif olarak kullanılmıştır.
- **`parameters`**: `path` ve `query` parametreleri (`id`, `page`, `size`) tanımlanarak tekrar kullanılabilir hale getirilmiştir.
- **`responses`**: 200, 201, 204, 400, 404 gibi yaygın HTTP yanıtları ayrıntılı şekilde tanımlanmıştır. Bazı yanıtlar örnek (`example`) içerir.

---

### 🔹 Sayfalama ve Hatalar

- **Sayfalama**, `GET /books` endpoint’inde `page` ve `size` parametreleri ile desteklenmektedir.
- **Hatalar**, `400` (geçersiz istek), `404` (bulunamadı), `500` (sunucu hatası) gibi durum kodlarıyla tanımlanmıştır.
- `PATCH /loans/{id}/return` gibi özel işlemler için ayrı endpoint oluşturularak kaynak tasarımı bozulmadan iade işlemi modellenmiştir.

---

## 🛠 Teknoloji ve Araçlar

- OpenAPI 3.0.3 (YAML formatı)
- Swagger Editor – dokümantasyon ve test için
- GitHub – sürüm kontrolü ve proje yönetimi
- (Opsiyonel) SwaggerHub veya Stoplight ile görsel editör desteği




