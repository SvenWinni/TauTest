'*******************************************************************
'Action name: 03_Add_Item
'Checkpoint: CP_Verwendung
'            CP_Messzeitpunkt
'*******************************************************************

'Klicke auf Icon für Neue Anlage
Browser("Aras Innovator").Page("Aras Innovator").WebElement("Icon_Add_New").Click
'manuell erzeugte Object Repository Elemente mit Parametrisierung:
'Eingabe des parametrisierten Textes im Textfeld für Verwendung
Browser("Aras Innovator").Page("Aras Innovator").WebEdit("TextBox_Verwendung").Set DataTable("Verwendung", dtGlobalSheet)
'Eingabe des parametrisierten Datums im Textfeld für Messzeitpunkt:
Browser("Aras Innovator").Page("Aras Innovator").WebEdit("TextBox_Messzeitpunkt").Set DataTable("Messzeitpunkt", dtGlobalSheet)
'Klickt das Speicher Icon in der Toolbar
Browser("Aras Innovator").Page("Aras Innovator").WebElement("ToolbarBtn_Save").Click
'Checkpoints: Überprüfung des eingegebenen Textes auf der Übersichtseite
Browser("Aras Innovator").Page("Aras Innovator").Frame("Frame").WebElement("Verwendung").Check CheckPoint("CP_Verwendung") @@ script infofile_;_ZIP::ssf3.xml_;_
Browser("Aras Innovator").Page("Aras Innovator").Frame("Frame").WebElement("Messzeitpunkt").Check CheckPoint("CP_Messzeitpunkt") @@ script infofile_;_ZIP::ssf4.xml_;_

'Deskriptiver Ansatz
'Bsp. für Textfeld:
'Browser("Aras Innovator").Page("Aras Innovator").WebEdit("xpath:=//*[@id='6E812F259DF3457C9C75866726866B65']").Set "Deskr"
'Bsp. für Toolbar Icon
'Browser("Aras Innovator").Page("Aras Innovator").WebElement("xpath:=//*[@id='top_toolbar']/div/div/div[1]/span[21]").Click

	'*******************************************************************
	'End Of Action :  03_Add_Item
	'*******************************************************************
