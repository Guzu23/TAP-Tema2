# tap-tema2-codebase-master

Aplicarea principiilor SOLID:

1. Single Responsibility Principle (SRP):

Prin crearea claselor:
	ProcessOrder (mostenita de urmatoarele)
	ProcessOrderBreakfast
	ProcessOrderProduct
	ProcessOrderRoom
	ProcessOrderSauna
	ProcessOrderUnknown

fiecare clasa se ocupa de un singur lucru, si anumme de procesarea unui anumit tip de comanda(Breakfast, Product, etc).

2. Open/Closed Principle (OCP):

	Clasa HotelReception este inchisa pentru modificari, dar poate fi extinsa prin diferite noi comenzi fara a fi modificata (adaugarea de noi clase ce mostenesc ProcessOrder). Acest lucru se realizeaza in clasa OrderFactory in metoda Create. Codul este deschis pentru extensie, dar inchis pentru modificare. Ca de exemplu, clasa ProcessOrderSauna pe care am adaugat-o demonstreaza faptul ca proiectul e deschis pentru extensie, dar e inchis pentru modificare(in clasa HotelReception).

3. Liskov Substitution Principle (LSP):
	Acest lucru se intampla prin mostenirea clasei ProcessOrder de catre clasele mentionate la punctul 1. Se poate observa mai bine acest principiu in clasa HotelReception la liniile:

```c#
var processOrder = factory.Create(order); //creeaza o derivata a clasei ProcessOrder
decimal orderPrice = processOrder.process(); //foloseste aceasta derivata pentru a calcula pretul comenzii
```

4. Interface Segregation Principle (ISP):
	Fiecare interfata din proiect realizeaza un singur lucru, astfel userul nu va trebui sa depinda de metode pe care nu le foloseste. De exemplu: 
		Interfata ILogger se ocupa doar cu afisarea mesajelor, 
		Interfata IFileSource se ocupa doar returnarea comenzii(ca tip string) din fisierul "orders.json",
		Interfata IOrderGetter se ocupa doar cu returnarea comenzii(ca tip Order),
		etc.
	Separarea responsabilitatilor în interfete distincte contribuie la flexibilitatea si decuplarea codului. Astfel, codul e mai usor de inteles si de mentinut.

5. Dependency Inversion Principle (DIP):
 	Proiectul se foloseste pe cat posibil de interfete/abstractii pentru a avea un cod flexibil, care nu necesita multe modificari daca modificam o anumita interfata. De exemplu, ne folosim de DIP in clasa OrderGetter. Chiar daca modificam clasa FileSource( : IFileSource) (modificam adresa fisierului de exemplu) nu vom avea de facut si alte modificari in proiect. Acelasi lucru putem spune si despre clasa HotelReception care se foloseste de ILogger si IOrderGetter. Acest principiu face testarea unitara mai usoara.
	
