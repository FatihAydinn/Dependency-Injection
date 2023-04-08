# Dependency-Injection

Dependency Injection, bağımlılıkları soyutlamak demektir.

Bir sınıfın farklı zamanlarda farklı tipte fakat aynı işlemi yapan sınıfları kullanmaya ihtiyaç duyması durumunda Injection kullanılır.

Constructor Injection (Yapıcı Enjeksiyon): Bu yöntemde, bir sınıfın bağımlılıkları, sınıfın yapıcı metoduna parametre olarak geçirilir. 
Bu sayede, bir nesne yaratıldığında, bağımlılıkları doğrudan yapıcı metodunda tanımlanır ve bu nesnenin tüm ömrü boyunca bu bağımlılıklar kullanılabilir.

Setter Injection (Ayarlayıcı Enjeksiyon): Bu yöntemde, bir sınıfın bağımlılıkları, birer özellik (property) olarak tanımlanır ve bağımlı nesne oluşturulduktan sonra bu özelliklere atama yapılır.

