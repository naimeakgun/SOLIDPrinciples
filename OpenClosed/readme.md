### SOLID | Open-Closed Prensibi

```
Bu prensipte asıl amaç, kod yazarken bizden sonrakiler için uygun bir ortam oluşturmaktır.
Yeni bir kod bloğu ekleyecekleri zaman var olanı değiştirmeden ancak ilave yapabilecekleri şekilde zemin hazırlamaktır.
Yani örneğin, elimizde bir ödeme metodu (Pay()) olduğunu düşündüğümüzde her ödeme tipi için if-else bloğu bulunmakta,
	yeni bir ödeme tipi eklemek istediğimizde Pay() ana metoduna gidip yeni bir if bloğu eklememiz gerekecektir.
	Tam da bu noktada Open-Closed Prensibi buradaki değişimin önüne geçmeyi önermektedir.
	Ödeme Tipi şeklinde bir interface içerisinde Pay() imzası olsa ve her ödeme tipi bu interface'ten
	türese yeni bir ödeme tipi ekleneceği veya kaldırılacağı zaman Pay() metoduna dokunmak yerine doğrudan
	ödeme tipine dokunabileceğiz.
Bu şekilde temiz kod çerçevesinde gelişime açık bir kod yazmamız için etkili bir prensiptir diyebiliriz.
```

```
Bu proje içerisinde her uygulama için bir klasör oluşturulmuş olup 
	her uygulama için prensibin uygulanmış ve uygulanmamış hali olmak üzere iki adet class oluşturulmuştur.
Her class içerisinde uygun açıklamalar bulunmaktadır.
```

##### Referanslar
* https://stackify.com/solid-design-open-closed-principle/
* https://gokhana.medium.com/open-closed-prensibi-nedir-kod-%C3%B6rne%C4%9Fiyle-soli%CC%87d-679619d5376a
* https://dotnettutorials.net/lesson/open-closed-principle/
