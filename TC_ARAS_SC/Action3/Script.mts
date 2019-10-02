Browser("Aras Innovator").Page("Aras Innovator").WebElement("Icon_Add_New").Click

'Frame
'Browser("Aras Innovator").Page("Aras Innovator").Frame("Frame").WebElement("document.isEditMode =").Click
Set Props = Browser("Aras Innovator").Page("Aras Innovator").Frame("Frame").GetAllROProperties

NumberOfProperties = Props.Count
For i = 0 To NumberOfProperties - 1
    Print Props(i).Name & ": " & Props(i).Value
Next
