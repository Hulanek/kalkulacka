#Sample Makefile
NAME = xhrdinj00_xrousja00_xhomolj00_xkonecm00
ZIP = $$HOME/source/$(NAME)
ZIP_SCRIPT = 'Compress-Archive -Path "$$HOME/source/$(NAME)" -DestinationPath "$(ZIP)"'



all: run
make: 
	powershell -Command foreach ($$file in Get-ChildItem -Path "$(CURDIR)" -Filter *.csproj -Recurse) { msbuild $$file.FullName}
	
pack: 
	powershell -Command "New-Item -ItemType Directory -Path "$$HOME/source" -Name "$(NAME)" "
	powershell -Command "New-Item -ItemType Directory -Path "$$HOME/source/$(NAME)" -Name "repo" "
	powershell -Command "Copy-Item -Path "$$HOME/source/killed/*"  -Destination "$$HOME/source/$(NAME)/repo" -Recurse"
	powershell -Command "New-Item -ItemType Directory -Path "$$HOME/source/$(NAME)" -Name "doc" "
	powershell -Command "New-Item -ItemType Directory -Path "$$HOME/source/$(NAME)" -Name "install" " 
	powershell -Command "Get-Item -Path "$$HOME/source/$(NAME)/repo/instalacka.exe" | Move-Item  -Destination "$$HOME/source/$(NAME)/install"  "
	powershell -Command "Get-Item -Path "$$HOME/source/$(NAME)/repo/instalacka_odchylky.exe" | Move-Item  -Destination "$$HOME/source/$(NAME)/install"
	powershell -Command "Get-ChildItem -Path "$$HOME/source/$(NAME)/repo/dokumentace.*" | Move-Item  -Destination "$$HOME/source/$(NAME)/doc"
	powershell -Command $(ZIP_SCRIPT)
	powershell -Command  Remove-Item -Path "$$HOME/source/$(NAME)" -Recurse -Force"

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