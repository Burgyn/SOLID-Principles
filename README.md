# S.O.L.I.D. Principles
Repository contain examples for S.O.L.I.D principles.

Príprava na prednášku o S.O.L.I.D na FRI

Osnova (poznámky)

1. Kto som? Čo som? Prečo som tu?
    + Moje meno je Milan Martiniak. Som absolvent FRI a v súčasnosti pracujem ako senior developer v spoločnosti KROS a.s.
    + Starám sa o technologický rast projektov a ľudí na nich.
    + Budem rozprávať o SOLID princípoch. Keď som si začal túto prezentáciu pripravovať, tak som rozmýšľal ako na to? Na internete sú o tom mraky článkov, lepších aj horších, s učebnicovími príkladmi aj s príkladmi z reálneho sveta.
    + Povedal som si, že to skúsim trošku ináč. Pokúsim sa Vám úkazať s akými problémami sa potýkajú ľudia pri vývojí softvéru, a ako sa tieto situácie dajú riešiť.
    + Skúsim to spraviť trošku interaktívne, budem sa Vás často pýtať. A tiež dúfam, že sa budete pýtať vy mňa. Nebojte sa ma kedykoľvek prerušiť a opýtať na čokoľvek. 

1. Kto z vás už počul pojem S.O.L.I.D Principles
    + Začnem hneď prvou otázkou. Kto z vás už počul pojem SOLID principles?
    + Super ... to je fajn. Aj Marek, to by sa patrilo :-)
    + Nikto. Nevadí, veď práve preto ste prišli, aby ste sa o tom niečo dozvedeli.
1. Kto z Vás vie vymenovať všetkých 5 princípov?
    + To už je menej rúk, ale predsa sú.
    + Takže Marek vieš vymenovať týchto 5 princípov?
1. Kto vie vysvetliť LSP?
    + Bol som na konferencii, kde bola celá sála senior vývojárov z celého česko-slovenska. Prezentujúci položil túto istú otázku a ani jedna ruka sa nezdvihla :-)
    + Aj preto od kedy som Marekovi sľúbil, že spravím túto prednášku poriadne nespávam.
    + Pretože vysvetliť SOLID principles je podľa mňa veľmi náročné.

    + Na začiatok poviem, že nie je dôležité poznať tieto princípy. Ich mená ani definície. Dôležité je podľa nich vyvýjať a to sa dá aj bez toho aby ste ich poznali.
    + Pretože, niekoho sa to musí učť, iný to získa oddretou praxou a niekto (tejto skupine vážne závidím) to má jednoducho v sebe. Pozrie sa na vec a prirodzene to spraví tak aby to bolo dobre. 

1. Kto z Vás chce byť vývojárom / vývojárkou?
    + Kto sa chce živiť tým, že bude vyvýjať softvér?

1. Kto z Vás si myslí, že bude vyvýjať stále nový softvér?
    + Realita je taká, že aj keď bude tý šťastnejší a budete mať možnosť robiť na voných projektoch.
    + Tak raz daný projekt príde do produkcie (nasadí sa zákazníkom) a vy ho budete musieť rozvýjať (zapracovávať nové požiadavku, funkčnosť), udržiavať (opravovať chyb) atď..
    + No a práve tu sa najviac ukáže to, ako dobre ste vašu aplikáciu navrhli.
    + Vývojári sa zvyknú vyhovárať, že používateľ si toho navymýšľa a nám sa to ťažko zapracováva.
    + Zákazník si bude stále vymýšľať nové požiadavky. Veď softvér mu má uľahčovať život. A na druhú stranu nás to živí. (účty niekto platiť musí)
    + Chyba nie je v požiadavkách, chyba je častokrát v zlom návrhu.

1. Čo vyplýva zo zlého návrhu?
    (otázka)
    + Zhoršuje sa čitateľnosť kódu.
    + Zvyšuje sa pravdepodobnosť zavedenia nových chýb. (častá otázka testorov, čo si pokazil opravou tejto chyb?)
    + Sú potrebný ľudia s komplexnou vedomosťou celého systému.
    + Predražuje sa zapracovanie novej funkčnosti.

1. Ako spoznáme zlý návrh?
    (otázka)
    + Jednotlivým triedam sa začne postupne nabaľovať zodpovednosť. (Vznikajú takzvané God classes)
    + Vznikajú závyslosti a silné väzby medzi jednotlivými triedami. (Zmena v jednej môže mať za následok narušenie iných)
    + Rozširovanie duplicitného kódu. (v rámci aplikácie sa začne rozširovať duplicitný kód. Keď budete chcieť opraviť, respektíve zmeniť funkčnosť na jednom mieste na n-ďalších zabudnete.)

1. Čo sa s tým dá robiť?
    (otázka)
    + (Ideálne riešenie neexistuje. Objektívne - vždy sa nájde požiadavka /nemusí sa však realizovať/, ktorá naruší akokoľvek dobrý návrh)
    + (Existuje, ale pár pravidiel, odporúčaní, zásad, usmernení, ..., ktoré to vedia výrazne zlepšiť.)
    1. Výber správnej architektúry. (MVC, MVVM, MVP, Microservices, ...)
        + Architektonické návrhové vzory. Dávajú nám šablónu na to, ako má vyzerať komunikácia medzi jednotlivými vrstvami aplikácie.
    1. Nasledovanie Design Principles.
    1. Používanie správnych návrhových vzorov na riešenie jednotlivých problémov.
        1. Design patterns. Pôvodne GOF 23 vzorov. Pokrývajú väčšinu problémov, s ktorými sa pri vývojí aplikácií stretneme.

1. Demo


1. Kto z Vás si myslí, že toto je dobre napísaná aplikácia?
    + Ja si to myslím. Veď som ju písal, nemôže byt predsa zlá. Programátori predsta máme svoje ego :-)
    + Táto aplikácie môže byť v určitých súvyslostiach považovaná za dobre napísanú.
    + Treba brať do úvahy dôvod pre ktorý vznikla.
    + Ak zákazní, šéf, mzdárka, večer o 5tej zavolá, že by narýchlo potrebovala spraviť takýto report, pretože to potrebuje odovzdať na sociálku. Tak prečo nie, je to najrýchlejšia cesta ako to spraviť.
    + Ak sa ale jedná o aplikáciu, ktorá sa má v budúcnosti rozširovať. Tak je to jednoznačne zlé napísané.
    + Z veľa jednoúčelových, narýchlo napísaných aplikácií sa časom stane niečo väčšie.
    + Tam by ale mal byť postup taký, že sa zastavíme, a prerobíme tú časť, ktorú potrebujeme rozširovať.

1. Aké požiadavky môžu prísť na túto jednoduchú aplikáciu?
    + Využitie na inom mieste.
        + Chceme to použiť na inom mieste aplikácie.
    + Zmena dátového zdroja
        + Vo firme môžme mať viacero zdrojov, odkiaľ je tieto dáta možné získať.
        + Táto aplikácia to má pevne viazané na databázu. (našťastie vďaka ORM, už mnohokrát neriešíme)
        + Čo ak chceme ten report spraviť z nejakého xml, xls, z webovej službu?
    + Zmena formátu reportu
        + Zákazník si zmyslí, že pre účely prepojenia s iným softvérom to musí byť vo formáte JSON.
    + Zmena spôsobu logovania
        + Pretože sme napríklad na nejakom virtuálnom severi a nemáme právo zapisovať na disk
    + Zmena spôsobu odosielania emailov.
    + Nová funkčnosť
        + Využiť túto aplikáciu na import zamestnancov z externých dát. Veď sú tam úž niektoré triedy na to pripravené, tak prečo to nevyužiť.
    + a veľa ďalších ...
    + (tieto všetky požiadavky môžu mať za následok, že začneme dopracovávať jednotlivé funkčnosti priamo do existujúcich tried a postupne sa z toho stane moloch.)

1. Nevýhody
    **ešte to preformuluj**
    1. možno na začiatok zložitejší systém
    1. určite viac kódu (chcel som spraviť porovnanie počtu riadkov pôvodnej aplikácie a finálnej, ale tým, že sme tam zapravcovali viac funkčnosti to nie je jednoduché. Tu to je cítiť. Ale pri väšej aplikácií sa to čiastočne vráti tým, že jednotlivé triedy sú znovupoužiteľné.)

1. SOLID principles.
    + Tak poďme konečne na to.
    + Čo je to ten SOLID.
    + Je to akronym.
    + Jednolivé princípy majú svojich autorov, ale ako celok to sformuloval Robert C. (Cecil) Martin v komunite známi tiež ako Uncle Bob. 1996

1. SRP
    + Trieda má mať jeden, len jeden dôvod na zmenu.
    + 
---


1. Otázky?
    + To je z prezentácie všetko, chcem sa poďakovať Marekovi, že mi umožnil sa sem opäť postaviť.
    + A teraz je priestor na voľnú debatu.


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