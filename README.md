# Otel_Rezervasyon

[![C#](https://img.shields.io/badge/C%23-WinForms-512BD4?style=flat-square&logo=csharp&logoColor=white)]()

Otel ve tur rezervasyonlarını yönetmek için geliştirilmiş bir Windows Forms masaüstü uygulaması.

## Proje Hakkında

Uygulama; giriş/kayıt ekranları, otel arama, çeşitli otel ve tur seçenekleri (kültür turları, gemi turları, yurt dışı turları vb.) ile rezervasyon ve ödeme akışını kapsayan çok formlu bir masaüstü uygulamasıdır. Veriler Microsoft Access (`.accdb`) veritabanlarında tutulur.

## Kullanılan Teknolojiler

- C# (.NET Framework 4.7.2), Windows Forms
- Microsoft Access (.accdb)

## Kurulum ve Çalıştırma

1. `Otel_Rezervasyon/Otel_Arayüz/a.sln` dosyasını Visual Studio ile açın.
2. `.accdb` veritabanı dosyalarının proje dizininde olduğundan emin olun.
3. Projeyi derleyip (F5) çalıştırın.

## Proje Yapısı

Başlıca ekranlar: giriş/kayıt (`girisyap`, `kayit`), otel arama ve otel sayfaları (`OtelArama`, `AlgedraOtel`, `AlinaOtel`, `RenoOtel` vb.), tur sayfaları (`TurKültürBodrum`, `TurGemi`, `TurYurtDışıBalkan` vb.) ve ödeme (`odeme`).

## İletişim

Merve — [GitHub](https://github.com/mrvbyrm)
