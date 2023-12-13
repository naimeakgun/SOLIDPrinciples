### SOLID | Liskov Substitution Prensibi (LSP)

```
Bu prensip adını Barbara Liskov'dan almaktadır. Başka diğer deyişle "Yerine Geçme Prensibi" şeklinde bilinmektedir.
MIT'de profesor olan Liskov, 80'li yıllarda çıkardığı bir kitabında ilk defa bu prensipten bahsetmiştir.
Kitabında yer alan açıklama tamamen matematiksel bir dilde olup çoğu insan tarafından açıklayıcı bulunmamıştır.
Birçok türk/yabancı blog yazarı olabildiğince açık ifadeler paylaşmaya çalışmıştır.
Buradaki açıklamalarım her ne kadar kısa ve öz olsun istesem de aşağıya Liskov'un cümlesini ve anladığımı 
   şematik bir şekilde eklemek isterim.
```

> What is wanted here is something like the following substitution property: 
   If for each object o1 of type S there is an object o2 of type T such that for all programs P defined in terms of T, 
   the behavior of P is unchanged when o1 is substituted for o2 then S is a subtype of T.

![Liskov Substitution Definition](LiskovDefinitionScheme.png)

```
Bu prensipte asıl amaç şu şekildedir diyebiliriz:
Alt sınıflardan oluşan nesneler, üst sınıfın nesneleri ile yer değiştirdikleri zaman aynı davranışı sergilemelidir.
```
```
Örnekle açıklayacak olursak;
	Bazen olabildiğince aynı sınıftan türemesi adına base olacak abstract class'lar oluştururuz.
	Ve bu base class'larda yer alan bazı metotların alt sınıflarda override olmasını zorunlu tutarız.
	Böyle durumlarda base class'ta olması zorunlu olan ancak alt sınıfta olması zorunlu olmayan metotlar 
	oluşabilmektedir ve "throw not Implemented" durumda kalabilmektedir.
	LSP'ye göre alt seviyedeki base'den türeyen bu düşük seviyedeki class'lar, "throw not Implemented" durumda 
	metot içerdiklerinden üst sınıfın yerine geçemeyecektir.
```
```
Sonuç olarak; LSP, aslında implemente edilemeyen metotların önüne geçmek ve kodu genişletilebilir de kılmak amacıyla
daha doğru soyutlama yapmamız gerektiğini söylemektedir.

Ayrıca; bu prensibi açıklayan ve en çok aklımda kalan Ördek Testi de aşağıdaki gibidir.
```
> Eğer bir şey ördek gibi görünüyor, onun gibi yüzüyor, ama pile ihtiyaç duyuyor ise
	muhtemelen yanlış bir soyutlamaya sahipsiniz.

![Duck Test](DuckTest.png)


```
Bu proje içerisinde her uygulama için bir klasör oluşturulmuş olup 
	her uygulama için prensibin uygulanmış ve uygulanmamış hali olmak üzere iki adet class oluşturulmuştur.
Her class içerisinde uygun açıklamalar bulunmaktadır.
```


#### Referanslar

* https://stackify.com/solid-design-liskov-substitution-principle/
* https://gokhana.medium.com/liskov-substitution-prensibi-nedir-kod-%C3%B6rne%C4%9Fiyle-soli%CC%87d-3cfc1cd63c1a
* https://code-maze.com/liskov-substitution-principle/
* https://www.turkayurkmez.com/liskov-substitution-principle-liskov-yerdegistirme-prensibi-lsp/
* https://www.gencayyildiz.com/blog/liskovun-yerine-gecme-prensibiliskov-substitution-principle-lsp/
* https://www.gokhan-gokalp.com/liskov-substitution-principle-lsp-liskovun-yerine-gecme-prensibi/
* https://www.yazilimperver.com/index.php/2019/09/08/solid-3-liskovun-yerine-gecme-prensibi/
