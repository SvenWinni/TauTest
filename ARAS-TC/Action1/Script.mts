
Browser("Aras Innovator Login").Page("Aras Innovator Login").Frame("main").WebEdit("username").Set "admin" @@ script infofile_;_ZIP::ssf1.xml_;_
Browser("Aras Innovator Login").Page("Aras Innovator Login").Frame("main").WebEdit("password").SetSecure "5d9445b62c27ed5f5cb6dd2a76c39d514b156757b47666f7" @@ script infofile_;_ZIP::ssf2.xml_;_
Browser("Aras Innovator Login_2").Page("Aras Innovator Login").Frame("main").WebList("database").Select "11SP15_Demo"
Browser("Aras Innovator Login").Page("Aras Innovator Login").Frame("main").WebButton("Login").Click @@ script infofile_;_ZIP::ssf3.xml_;_
