// See https://aka.ms/new-console-template for more information
using Dependency_Injection.Concrete;

XProduct xproduct = new XProduct();

    Market marketX = new Market(xproduct);
    marketX.Sell();

    Market marketY = new Market(new YProduct());
    marketY.Sell();


//Setter DI
    Market2 marketZ = new Market2();
    marketZ._product = new ZProduct();
    marketZ.Sell();


//Bir sınıfın farklı zamanlarda farklı tipte fakat aynı işlemi yapan sınıfları kullanmaya ihtiyaç duyması durumunda Injection kullanılır.