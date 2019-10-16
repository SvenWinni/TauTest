'*******************************************************************
'Action name: 02_Navigation
'Checkpoint: CP_Verwendung
'*******************************************************************

'Maximiert das Programmfenster
Browser("Aras Innovator").Maximize
'Klick auf das manuell angelegte BMW Item im Navigationsbaum
Browser("Aras Innovator").Page("Aras Innovator").WebElement("Nav_BMW").Click @@ script infofile_;_ZIP::ssf1.xml_;_
'Klick auf die Unterkategorie Vorgänge
Browser("Aras Innovator").Page("Aras Innovator").WebElement("Nav_Vorgänge").Click @@ script infofile_;_ZIP::ssf2.xml_;_
'erster konstanter Überprüfungspunkt auf den Spaltennamen der angezeigten Tabelle
Browser("Aras Innovator").Page("Aras Innovator").Frame("Frame").WebElement("Verwendung").Check CheckPoint("CP_Verwendung") @@ script infofile_;_ZIP::ssf3.xml_;_

	'*******************************************************************
	'End Of Action :  02_Navigation
	'*******************************************************************
