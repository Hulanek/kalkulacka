#Sample Makefile
ZIP = xhrdinj00_xrousja00_xhomolj00_xkonecm00
ZIP_SCRIPT = 'Compress-Archive -Path ".." -DestinationPath "$(ZIP)"'

all: run
make: 
	powershell -Command foreach ($$file in Get-ChildItem -Path "$(CURDIR)" -Filter *.csproj -Recurse) { msbuild $$file.FullName}
	
pack: 
	powershell -Command $(ZIP_SCRIPT)
clean:
	powershell -Command foreach ($$file in Get-ChildItem -Path "$(CURDIR)" -Filter *.exe -Recurse) { Remove-Item $$file.FullName}
run:
	powershell -Command  if (Test-Path -Path "$(CURDIR)/*.exe") { "& { & $(CURDIR)/*.exe }" }	elseif (Test-Path -Path $(CURDIR)/MainForm/MainForm/bin/Debug/MainForm.exe) { "& { Start-Process $(CURDIR)/MainForm/MainForm/bin/Debug/MainForm.exe }" } else { echo 'Program nebyl sestaven ve VS, nebo pomoci ''make make'' a nelze spustit' }
profile:
	./MainForm/Odchylka/bin/Debug/net8.0/Odchylka.exe MainForm/Odchylka/bin/Debug/net8.0/TestSoubor.txt 
help:
	@echo Napoveda:
	@echo Manualne zkompilujte program ve VS a nasledne pouzit 'make run' nebo 'make'
	@echo Pouzit prikaz 'make make' a nasledne pouzit 'make' nebo 'make run'