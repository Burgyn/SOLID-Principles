# S.O.L.I.D. Principles
Repository contain examples for S.O.L.I.D principles.

Príprava na prednášku o S.O.L.I.D na FRI

Osnova (poznámky)

1. Kto som? Čo som? Prečo som tu?
    + Moje meno je Milan Martiniak. Som absolvent FRI a v súčasnosti pracujem ako senior developer v spoločnosti KROS a.s.
    + Starám sa o technologický rast projektov a ľudí na nich.
1. O čom si budeme rozprávať?
    + Dnes by som Vám chcel porozprávať svoje skúsenosti s vývojom vväčších (enterprise) projektov. S akými problémami sa stretávame a ako sa to dá riešiť.
1. Aké typy programátorov rozlišujem?
    + Ešte skôr ako začnem by som chcel povedať pár slov o tom ako ja rozdeľujem programátorov.
    1. Kóder
        + Vie algoritmovať,
        + dokáže deduktívne myslieť a riešiť problémy,
        + má rád technológie a rád sa v nich šprtá.
        + Takýto človek dokáže spraviť čokoľvek. Dáte mu zadanie a on ho vyrieši. Opraví chybu. Vytvorí Vám script, jednoduchú aplikáciu.
        + Nevie navrhnúť riešenie, ktoré sa ma dlhodobo rozvíjať.
        + Toto jednoducho máme mať v sebe. Je to predpoklad. Väčšina z toho sa nedá naučiť.
    1. Vývojár
        + Čistota kódu (štábna kultúra)
        + Vie navrhnúť vnútornú štruktúru projektu tak aby sa na tom dalo stavať dlhodobé riešnie.
        + Vie premyslieť súvyslosti..
        + Niekto to má prirodzene v sebe. Pozrie sa na vec a jednoducho vie. My ostatní smrteľníci to musíme nadobudnúť praxou.
1. Prečo je dôležité zamýšľať sa nad architekúrou?
    + Pokiaľ vytvárame jednoúčelové aplikácie, scripty, jednoduché stránky, krátkodobé projekty, tak to riešiť nemusíme.
    + Akonáhla začíname pracovať na projekte, na ktorom pracuje viacero ľúdí a má sa dlhodobo rozvíjať, musíme to začať riešiť.

    Vývojár začne stavať aplikáciu s dobrým a čistým návrhom podľa jeho aktuálnych skúsenosti. Časom, príde oprava chýb, zapracovanie nových požiadaviek, na ktoré sa v začiatkoch nemyslelo. A pôvodna architektúra je vystavená novým a novým požiadavkam.

    Môže sa stať, že po určitom čase bude zapracovávanie novej funkčnosti stále náročnejšie. Bude si to vyžadovať komplexné znalosti celého systému a zývyslosti v ňom. Každá ďalšia požiadavka bude drahšia.

    Vývojári zvyknú zvaľovať vynu práve na tieto nové požiadavky. Hovoria, že zákazník si navymýšľa veci a nám to rozbíja celú aplikáciu.

    Ktoje však za tento stav zodpovedný?
    Nie sú to nové požiadavky, je to práve ta pôvodná architektúra.

    Každý chce tvoriť nový softvér, začínať na zelenej lúke s novými technológiami. Realita je však iná. Aj pokiaľ sa Vám podarí začať pracovať na niečom novom, tak väčšinu našej práce je rozširovanie existujúcich projektov. Každý kód, ktorý sme napísali včera, minlý mesiac, rok je v princípe zlý kód. Je to tak správne. Pretože sme ho písali s aktuálnymi vedomosťami, ktoré sme si opäť obohatili.
    Technológie sa menia, menia sa rôzne techniky. Ale princípi, o ktorých si budeme dnes rozprávať sú stále. Boli sformulované pred 20rokmi a stále sú aktuálne.

    Najčastejšími chybami bývajú:
    1. Postupné nabaľovanie zodpovednosti jednotlivých tried.
    1. Zavádzanie závyslostí a väzieb medzi jednotlivými triedami. (Zmena v jednej môže mať za následok narušenie iných)
    1. Rozširovanie duplicitného kódu.

1. Ako sa to dá riešiť?
    + >Podľa môjho názoru je to neriešiteľné. (Vždy sa nájde požiadavka /nemusí sa však realizovať/, ktorá naruší akokoľvek dobrý návrh)
    + Existuje, ale pár pravidiel, odporúčaní, zásad, usmernení, ..., ktoré to vedia výrazne zlepšiť.
    1. Výber správnej architektúry. (MVC, MVVM, MVP, Microservices, ...)
        + Architektonické návrhové vzory. Dávajú nám šablónu na to, ako má vyzerať komunikácia medzi jednotlivými vrstvami aplikácie.
    1. Nasledovanie Design Principles.
    1. Používanie správnych návrhových vzorov na riešenie jednotlivých problémov.
        1. Design patterns. Pôvodne GOF 23 vzorov. Pokrývajú väčšinu problémov, s ktorými sa pri vývojí aplikácií stretneme.
1. S.O.L.I.D.
    Dodržiavanie týchto princípov nám umožní vyhnúť sa veľkému množstvu chýb pri návrhu. Ukazujú nám cestu, ako máme prejsť z "tightly coupled code" na kód, ktorý má voľné väzby a správne zapúzderné bussiness pravidlá.

    Sformuloval ich Robert C. (Cecil) Martin známi tiež v komunite ako Uncle Bob.


    Acronym
    1. **S** - Single Responsibility Principle (SRP)
    1. **O** - Open closed Principle (OCP)
    1. **L** - Liskov substitution Principle (LSP)
    1. **I** - Interface Segregation Principle (ISP)
    1. **D** - Dependency Inversion Princile (DIP)


## **S** - Single Responsibility Principle (SRP)
> Every software module should have one, and only one reason to change.

poznámky
- Rob jednu vec a rob to dobre.
- Je možné písať SMS počas šoférovania? Áno je to možné. Ale stači málo a vie to spôsobiť vážnu nehodu. Rovnako je to aj keď jedna trieda robí viacero vecí.
- Zásah do takejto triedy môže spôsobiť chybu v inej časti programu. Systém je neprehľadný a náchylný na chyby.
- Znamená to, že každá trieda, vo vašom systéme (aplikácia, knižnica, ...) má mať len jednu úloho. "Má robiť iba jednu vec."
- Neznamená to, že môže mať len jednu metódu, respektíve property. Môže tam byť samozrejme viacero metód, ale musia sa vzťahovať k jednemu účelu.
- Počas fázy návrhu nám to dáva dobrý spôsob identifikácie tried a núti nás to premýšľať, ako sa môže trieda v čase meniť.
- Je to jeden z najdôležitejších a zároveň najťažších problémov návrhu, určiť aká je zodpovednosť danej triedy a kde sú tie hranice.


Príklad:

```
public class PeopleController : Controller
{

    [HttpGet]
    public IActionResult SendReport([FromBody] string to)
    {
        using (var database = new Database())
        {
            var sb = new StringBuilder();
            var people = database.Query<Person>();

            sb.AppendLine(@"<html>
                                <body>
                                    <table>");
            sb.AppendLine(@"<tr>
                                <th>Firstname</th>
                                <th>Lastname</th>
                                <th>Age</th>
                            </tr>");
            foreach (var person in people)
            {
                sb.AppendLine("<tr>");
                sb.Append($"<td>{person.FirstName}</td><td>{person.LastName}</td><td>{person.Age}</td>");
                sb.AppendLine("</tr>");
            }

            sb.AppendLine("</table></body></html>");

            using (var client = new SmtpClient("myServerHost"))
            using (var mailMessage = new MailMessage())
            {
                // ..
                mailMessage.To.Add(to);
                mailMessage.Body = sb.ToString();

                client.Send(mailMessage);
            }
        }

        return Ok();
    }
}
```

Bežná požiadavka. Potrebujete do vášho systému zapracovať funkčnosť na odosielanie reportov (konkrétne odoslať oznam osôb ako html email.)

Pozrime sa na tento jednoduchý príklad.

Čo je to Controller? Vysvetli.

Prečo nie je dobré, že to je napísané sem? Oki, narúša to SRP, pretože úlohou controllera je príjmať požiadavky.
Ale prečo je to naozaj zle?

Čo keď budeme chcieť tento istý report spraviť z iného miesta aplikácie? Čo keď to budeme chcieť použiť v desktopovej verzii?

Vytvoríme PeopleReportService

Ok, lepšie. Ale spĺňa to SRP?

Čo je tu ešte zle?

Začnime odspodu? odosielanie emailov.

Načítanie dát.

Spravíme repository, mail service.

Takto to môže vyzerať.



## **O** - Open closed Principle (OCP)
> A software module/class is open for extension and closed for modification.

V jednoduchosti povedané: mali by sme navrhovať tak, aby v prípade potreby zapracovania nových požiadaviek by sme to mali byť schopný spraviť s minimálnym zásahom do pôvodnej triedy.
Pôvodnú triedu by sme mali upravovať ideálne iba v prípade opravy chýb.

riešenia:
    - dedičnosť
    - abstrakcia pomocou interfejsov
    - generiká
    - návrhové vzory: strategy, visitor

príklady:
školský areacalculator 3 úrovne (prva úroveň našitá na Rectangle, druhá cez objekt, tretia cez dedičnosť, respektíve dedičnosť)
reporty

## **L** - Liskov substitution Principle (LSP)
> You should be able to use any derived class instead of a parent class and have it behave in the same manner without modification

Znamená to to, že keď dedíme triedu musíme si dávať pozor aby sme nenarušili správanie pôvodnej triedy.


Composition over inheritance

## **I** - Interface Segregation Principle (ISP)
> Clients should not be forced to implement interfaces they don't use. Instead of one fat interface many small interfaces are preferred based on groups of methods, each one serving one sub module.

## **D** - Dependency Inversion Princile (DIP)
> High-level modules/classes should not depend upon low-level modules/classes. Both should depend upon abstractions. Secondly, abstractions should not depend upon details. Details should depend upon abstractions.

1. IoC
1. Diskusia



Skús ešte zakomponovať
- na začiatok sa opýtaj kto programuje v CSharp