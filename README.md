# 📘 MVC ile Geliştirilmiş Blog

Bu proje, çeşitli modern yazılım bileşenleri ve mimari desenler kullanılarak geliştirilmiş bir blog platformudur.

## 🚀 Kullanılan Teknolojiler ve Yapılar

- 🔒 **Identity**: Kullanıcı kimlik doğrulama ve yetkilendirme işlemleri için.
- 🔄 **Mapster**: Nesne-dönüşümleri için kullanıldı.
- 🛠️ **Utilities Yapısı**: Projede yaygın olarak kullanılan işlemler için yardımcı sınıflar. Bu yapı, veri sonuçları ve hata yönetimi için `DataResult`, `Result`, `SuccessResult`, `ErrorDataResışt` vs. gibi yapıları içerir. Bu sayede işlem sonuçları tutarlı ve okunabilir bir şekilde yönetilir.
- 📚 **Generic Repository**: Veri erişim katmanında kullanılan genel amaçlı repository desenleri.
- 🏛️ **Katmanlı Mimari**: Uygulamanın iş mantığı ve veri erişim katmanlarının ayrılması.
- 📧 **Mail Kit**: E-posta gönderimi için.
- 🌐 **Localizer**: Çoklu dil desteği için.
- 📝 **Auditable Entity ve Base Entity Yapısı**: Hard delete ve soft delete işlemleri için temel varlık yapıları.
- 🗄️ **Entity Framework Core**: Veri erişim ve yönetimi için.
- 🔔 **Toast Notification**: Kullanıcı bildirimleri için.
- 🕵️ **EntityFramework Proxies**: Lazy loading desteği için.
- 💉 **Dependency Injection**: Bağımlılıkların yönetimi için.

## 🌟 Özellikler

- 👤 **Kullanıcı Kayıt ve Giriş**: Kullanıcılar sisteme kayıt olabilir ve giriş yapabilirler.
- ✍️ **Makale Yönetimi**: Giriş yapan kullanıcılar kendi makalelerini yazabilir, güncelleyebilir veya silebilirler.
- 📈 **En Çok Okunan Makaleler**: En çok okunan makaleler sidebar'da listelenir.
- 🎞️ **Anasayfa Slider**: Anasayfada öne çıkan makaleler için slider yapısı kullanıldı.
- ✅ **E-posta Onayı**: E-posta onayı yapmayan kullanıcılar sisteme giriş yapamazlar.

