# S.O.L.I.D. Principles
Repository contain examples for S.O.L.I.D principles.

Príprava na prednášku o S.O.L.I.D na FRI

Osnova (poznámky)

1. Kto som? Čo som? Prečo som tu?
    + Moje meno je Milan Martiniak. Pracujem ako senior developer v spoločnosti KROS a.s.
    + Starám sa o technologický rast projektov a ľudí na nich.
1. O čom si budeme rozprávať?
    + Dnes by som Vám chcel porozprávať svoje skúsenosti s vývojom veľých (enterprise) projektov. S akými problémami sa stretávame a ako sa to dá riešiť.
1. Aké typy programátorov rozlišujem?
    + Ešte skôr ako začnem by som chcel povedať pár slov o tom ako ja rozdeľujem programátorov.
    1. Kóder
        + Vie algoritmovať,
        + dokáže deduktívne myslieť a riešiť problémy,
        + má rád technológie a rád sa v nich šprtá.
        + Takýto človek dokáže spraviť čokoľvek. Dáte mu zadanie a on ho vyrieši. Opraví chybu. Vytvorí Vám script, jednoduchú aplikáciu.
        + Nevie navrhnúť riešenie, ktoré sa ma dlhodobo rozvíjať.
        + Nevie premyslieť súvyslosti.
        + .. **(dopíš)**
        + Toto jednoducho máme mať v sebe. Je to predpoklad. Väčšina z toho sa nedá naučiť.
    1. Vývojár
        + Vie udržať čistotu kódu.
        + Človek, ktorý dokáže vyvýjať enterprise riešenia.
        + Vie navrhnúť vnútornú štruktúru projektu tak aby sa na tom dalo stavať dlhodobé riešnie. **(preformulovať)**
        + Niekto to má prirodzene v sebe. Pozrie sa na vec a jednoducho vie. My ostatní smrteľníci to musíme nadobudnúť praxou.
1. Prečo je dôležité riešiť takéto veci?
    + Pokiaľ vytvárame jednoúčelové aplikácie, scripty, jednoduché stránky, krátkodobé projekty, tak to riešiť nemusíme.
    + Pokiaľ však začíname pracovať na projekte, ktorý sa má dlhodobo rozvíjať, musíme sa zamýšľať nad jeho architektúrou.
     
    Vývojár začne stavať aplikáciu s dobrým a čistým návrhom podľa jeho aktuálnych skúusenosti. Ale časom, príde oprava chýb, zapracovanie nových požiadaviek, na ktoré sa v začiatkoch nemyslelo. A pôvodna architektúra je vystavená novým a novým požiadavkam.
    
    Môže sa stať, že po určitom čase bude zapracovávanie novej funkčnosti stále náročnejšie. Bude si to vyžadovať komplexné znalosti celého systému a zývyslosti v ňom. Každá ďalšia požiadavka bude drahšia.
    
    Vývojári zvyknú zvaľovať vynu práve na tieto nové požiadavky. Hovoria, že zákazník sa navymýšľa veci a nám to rozbíja celú aplikáciu.

    Ktoje však za tento stav zodpovedný? 
    Nie sú to nové požiadavky, je to práve ta pôvodná architektúra.

    Najčastejšími chybami bývajú:
    1. Postupné nabaľovanie zodpovednosti jednotlivých tried.
    1. Zavádzanie závyslostí a väzieb medzi jednotlivými triedami. (Zmena v jednej môže mať za následok narušenie iných)
    1. Rozširovanie duplicitného kódu.

1. Ako sa to dá riešiť?
    + >Z vlastnej skúsenosti Vám poviem, že je to vlastne neriešiteľné. (Vždy sa nájde požiadavka /nemusí sa však realizovať/, ktorá naruší akokoľvek dobrý návrh)
    + Existuje, ale pár pravidiel, odporúčaní, zásad, usmernení, ..., ktoré to vedia výrazne zlepšiť.
    1. Výber správnej architektúry. (MVC, MVVM, MVP, Microservices, ...)
        + Architektonické návrhové vzory. Dávajú nám šablónu na to, ako má vyzerať komunikácia medzi jednotlivými vrstvami aplikácie. 
    1. Nasledovanie Design Principles.
    1. Používanie správnych návrhových vzorov na riešenie jednotlivých problémov.
        1. Design patterns. Pôvodne GOF 23 vzorov. Pokrývajú väčšinu problémov, s ktorými sa pri vývojí aplikácií stretneme. 
1. S.O.L.I.D.
    Dodržiavanie týchto princípov nám umožní vyhnúť sa veľkému množstvu chýb pri návrhu. Ukazujú nám cestu, ako máme prejsť z "tightly coupled code" na kód, ktorý má voľné väzby a správne zapúzderné bussiness pravidlá.

    Sformuloval ich Robert C. (Cecil) Martin známi tiež v komunite ako Uncle Bob.


    1. Acronym
    1. **S** - Single Responsibility Principle (SRP)
    1. **O** - Open closed Principle (OCP)
    1. **L** - Liskov substitution Principle (LSP)
    1. **I** - Interface Segregation Principle (ISP)
    1. **D** - Dependency Inversion Princile (DIP)


    - ## **S** - Single Responsibility Principle (SRP)
        > Every software module should have only one reason to change.

    - ## **O** - Open closed Principle (OCP)
        > A software module/class is open for extension and closed for modification.
    - ## **L** - Liskov substitution Principle (LSP)
        > You should be able to use any derived class instead of a parent class and have it behave in the same manner without modification
    - 
    - ## **I** - Interface Segregation Principle (ISP)
        > Clients should not be forced to implement interfaces they don't use. Instead of one fat interface many small interfaces are preferred based on groups of methods, each one serving one sub module.
    - 
    - ## **D** - Dependency Inversion Princile (DIP)
        > High-level modules/classes should not depend upon low-level modules/classes. Both should depend upon abstractions. Secondly, abstractions should not depend upon details. Details should depend upon abstractions.

1. IoC
1. Diskusia