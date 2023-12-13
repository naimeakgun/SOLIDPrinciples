### SOLID | Interface Segregation Prensibi

```
Bu prensip'te interface'lere yüklediğimiz sorumlukları azaltmaya çalışmak ve bu sayede
kod okunaklılığını arttırmaya yönelik bir davranış mekanizması benimsenmiştir.

Yani bir çalışmada bütün sorumlulukları tek bir interface'e yüklemek yerine görevlerine göre
kategorize edip birden fazla interface oluşturarak devam edebileceğimizi söylemektedir.
```

```
Prensibin daha akılda kalıcı örnekleri Application klasörleri içerisinde açıklanmıştır.
Örneğin, AnimalApplication içerisindeki WithoutPrinciple dosyasına bakabilirsiniz.
```

##### Liskov Substitution vs Interface Segregation

Örnekleri incelediğinizde Liskov Substitution Prensibi ile benzerlikler olduğunu görebilirsiniz.
Ancak temelde özellikle amaç bakımından bu iki prensip birbirinden farklıdır.

Liskov Substitution Prensibi | Interface Segregation Prensibi
---|---
Temel fikir, alt sınıf-üst sınıf ilişkisine odaklanır. | Temel fikir, interface'leri amaçlarına göre bölmeye odaklanır.
Alt sınıf ve üst sınıf ilişkisinde override edilmesi gereken metotlar varsa bu sözler yerine getirilsin istenmektedir. Bu sayede alt sınıf üst sınıfın yerine geçebilmektedir. Yerine geçme işleminin doğru uygulanması için alt sınıflarda Not Implemented durumda metotlar bulunmamalıdır. | Soyutlama yaparken ihtiyaç duyulan interface'ler kullanılsın istenmektedir. Yani ihtiyaç duyulan özelliklere göre var olan interface'ler daha küçük interface'lere bölünmeli, class'lar da ihtiyaç duyduğu interface'leri implemente etmelidir. Bu sayede Not Implemented durumda metotlarla da karşılaşmayız.


```
Bu proje içerisinde her uygulama için bir klasör oluşturulmuş olup 
	her uygulama için prensibin uygulanmış ve uygulanmamış hali olmak üzere iki adet class oluşturulmuştur.
Her class içerisinde uygun açıklamalar bulunmaktadır.
```


#### Referanslar

* https://gokhana.medium.com/interface-segregation-prensibi-nedir-kod-%C3%B6rne%C4%9Fiyle-soli%CC%87d-ac0fd6812ecf
* https://www.oodesign.com/interface-segregation-principle
* https://softwareapprenticeshipblog.wordpress.com/2016/08/16/isp-vs-lsp/