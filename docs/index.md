## Cirali

Das Cirali-XML-Format speichert Formulare für die öffentliche Verwaltung der Bundesrepublik Deutschland.

Zum Beispiel wird es verwendet von:
* Land Niedersachsen (DE-NI)
* Freistaat Thüringen (DE-TH)
* Freistaat Bayern (DE-BY)

### Dokumentation

* Eine Beispiel-XML-Datei, wie so ein Formular aussieht: [data/example.xml](data/example.xml)
* Eine Tabelle aller Elemente mit ihren jeweiligen Attributen: [data/example.csv](data/example.csv)
* Ein Graph aller Elemente, als [data/example.png](data/example.png) und [data/example.svg](data/example.svg)
* Ein XML-Schema für die Validierung von Formularen: [data/example.xsd](data/example.xsd)

### Struktur

```xml
<CIRALI version="4.0">
  <FORMINFO>
    <FORMSERVER>
      <COPYRIGHT>United Nations Security Council</COPYRIGHT>
      <FORMID>2531</FORMID>
      <FORMNAME>Antrag auf Zulassung zur Atombombe</FORMNAME>
    </FORMSERVER>
  </FORMINFO>
  <OBJECTS>
    <BUTTON blue="147" bold="yes" fontface="Helvetica" fontsize="10" green="218" height="9.80" page="2" print="no" red="238" width="100.00" x="26.60" y="246.00">Internationale Atombombe beantragen</BUTTON>
    <CHECKBOX active="no" blue="128" group="1012" group_exclusive="6" height="3.00" hidden="yes" mustfill="yes" width="3.00" x="25.00" y="255.00">0</CHECKBOX>
    <CONTAINER height="4.00" page="0" width="10.00" x="190.00" y="50.00">Bombenplatz 7
01234 Berlin</CONTAINER>
    <DROPDOWN active="no" blue="194" bold="yes" custom_height="yes" page="0" print="no" red="253" underline="yes" width="15.00" x="137.00" y="92.00">
      <ITEM map="Zentrale">84111 Nürnberg, Postfach 12 39</ITEM>
      <VALUE>2021</VALUE>
    </DROPDOWN>
    <FRAME height="132.00" objid="FRM-4" page="1" width="7.00" x="8.0" y="146.0" />
    <HOTSPOT height="10.00" objid="HTS-1" page="3" print="no" tab="no" valparam4="https://www.un-sec.org" width="180.00" x="20.00" y="120.00" />
    <IMAGE decodedlength="1040" grayscale="yes" halt="Symbolbeschreibung: abstrakte Darstellung einer Atombombe" height="5.80" mimetype="jpeg" objid="IMG-1" objnext="TXT-7" objprev="TXT-6" page="6" print="no" sizetype="fixed" url="TH-LFD-Logo" view="no" width="4.60" x="15.00" y="159.60">/9j/4AAQSkZJRgABAgAAZABkAAD/7AARRHVBAwMBPxDc/9k=</IMAGE>
    <INFO customizable="yes" height="4.00" iconsize="small" objid="INF-1" objnext="TXT-21" objprev="TXT-18" page="0" tab="no" width="4.00" x="190.80" y="104.40">Ein rechtliches Interesse ist gegeben.</INFO>
    <LINE blue="255" green="255" hidden="yes" linesize="0.50" objid="LIN-48" page="0" print="no" red="255" view="no" x="130.00" x2="185.00" y="170.00" y2="170.00" />
    <RECTANGLE blue="192" drawtype="solid" green="255" height="78.00" hidden="yes" linesize="1.50" objid="RTA-16" orientation="b" page="1" print="no" red="255" shape="circle" view="no" width="176.00" x="24.00" y="198.00" />
    <TEXT align="justify" angle="90" bold="yes" fontblue="128" fontface="Helvetica" fontgreen="128" fontred="255" fontsize="10" height="5.46" hidden="yes" hstruct="H2" italic="yes" lineheight="0.90" objid="TXT-88" objnext="CHB-19" objprev="CHB-18" page="0" print="no" ulend="1" ulstart="1" underline="yes" view="no" width="100.00" x="85.00" y="230.92">Hämatologie</TEXT>
    <TEXTAREA active="no" blue="217" bold="yes" border="no" customizable="yes" fontface="Helvetica" fontsize="9" group="1019" height="17.74" hidden="yes" htmlhidden="1" ignorelines="yes" label="#.TXT-141#" lineheight="0.80" lines="5" linesize="0.50" maxlen="999" mustfill="yes" nobarrier="Anschrift Ihrer Beschäftigungsstelle (z. B. Schule / Amt)" objid="TXA-4" objnext="PAGE2" objprev="TXT-141" page="1" print="no" tab="no" view="no" width="54.00" x="26.00" y="257.80">Gemeinde Atom
Rathausplatz 1
15722 Neu York</TEXTAREA>
    <TEXTCLUSTER align="justify" angle="90" height="83.60" hstruct="H2" lineheight="0.90" objid="TXC-1" objnext="PAGE1" objprev="TXF-11" page="1" print="no" ulend="2" ulstart="2" view="no" width="5.00" x="9.0" y="189.0">
      <ATOM bold="yes" fontblue="134" fontface="Helvetica" fontgreen="120" fontred="255" fontsize="7.00" italic="yes" underline="yes">- Zentrale Formularservicestelle</ATOM>
    </TEXTCLUSTER>
    <TEXTFIELD active="no" align="right" blue="0" bold="yes" border="no" custom_height="yes" fontface="Helvetica" fontred="255" fontsize="8" green="0" group="1024" height="3.89" hidden="yes" htmlhidden="1" ignorefontheight="yes" label="#.TXT-79#" linesize="0.50" maxlen="199" mustfill="yes" objid="TXF-45" objnext="TXT-75" objprev="TXT-79" page="0" print="no" red="0" tab="no" view="no" width="20.00" x="60.00" y="276.00">,</TEXTFIELD>
  </OBJECTS>
  <WORKFLOW>
    <ATTACHMENTS filter=".pdf" maxsize="3" sigma="2" />
  </WORKFLOW>
</CIRALI>
```

### Beispielverwendung

Der autogenerierte Code für dieses Listing befindet sich in [data/example.cs](data/example.cs):

```csharp
private static void ReadAndWrite(string input, string output)
{
    var serializer = new XmlSerializer(typeof(CIRALI));
    var xml = (CIRALI)serializer.Deserialize(File.OpenRead(input));
    serializer.Serialize(XmlWriter.Create(File.Create(output), new XmlWriterSettings { Indent = true }), xml);
}
```
