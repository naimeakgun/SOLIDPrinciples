### SOLID | Dependency Inversion Prensibi

```
Öncelikle, bu prensip için ana tanım aşağıdaki gibidir. Ve tanımda ifade edilen ana düşünce; 
class bağımlılıklarının indirgenmesi için kullanılacak yöntemin interface'ler yönünde olması gerekliliğidir.
```

>  High level modules should not depend on low level modules; 
   both should depend on abstractions. Abstractions should not depend on details.
   Details should depend upon abstractions.

```
Aynı zamanda bu prensip'te birbirine bağlı olan class'ların bağımlılıklarının kodu değiştirmeyecek 
bir yapıya indirgenebilmesi amaçlanmıştır.
```

```
Birbirine bağlı olan class'lardan kasıt şu şekildedir:
Bir ihtiyaca yönelik yazılmış bir class var elimizde. (Düşük seviyede kalıyor)
Başka bir class da bu class'ı çağırıp kullanmakta. (Yüksek seviyede kalıyor)
Bu durumda yüksek seviye class, düşük seviye class'a bağımlı oluyor doğal olarak.
Düşük seviye class'ta bir değişiklik olması durumunda bu class'ın kullanıldığı yüksek seviyeli 
class içerisinde de değişiklik yapılması gerekecektir.
Tam da bu noktada bu prensip devreye giriyor.
Bu şekilde bir bağımlılık olmasının engellenmesi isteniyor.
```

```
Bu prensip çalışılırken sürekli Dependency Injection kavramıyla da karşılaşırız.
Dependency Injection bir tasarım desenidir, bağımlılıkların dışarıdan alınmasını veya
enjekte edilmesini söyler. Dependency Inversion ise bir prensiptir ve bağımlılıkları
soyutlamamızı ister. İşte bu noktada örnekleri de incelediğimizde aslında
Dependency Inversion prensibi uygulanırken Dependency Injection kullanılmaktadır.
```

```
Bu proje içerisinde her uygulama için bir klasör oluşturulmuş olup 
	her uygulama için prensibin uygulanmış ve uygulanmamış hali olmak üzere iki adet class oluşturulmuştur.
Her class içerisinde uygun açıklamalar bulunmaktadır.
```


#### Referanslar

* https://deviq.com/principles/dependency-inversion-principle
* https://www.gencayyildiz.com/blog/bagimliligin-ters-cevrilmesi-prensibidependency-inversion-principle-dip/
* https://umayeras.medium.com/solid-prensipleri-dependency-inversion-principle-dip-efea6939e430
