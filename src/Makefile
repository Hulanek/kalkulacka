#Sample Makefile
NAME = xhrdinj00_xrousja00_xhomolj00_xkonecm00
ZIP = $(NEW_DIR_2)/$(NAME)
ZIP_SCRIPT = 'Compress-Archive -Path "$$HOME/source/$(NAME)" -DestinationPath "$(ZIP)"'
$(eval NEW_DIR_2 = $(shell powershell -Command "(Get-Item -Path (Split-Path -Path (Split-Path -Path $$PWD -Parent) -Parent)).FullName"))
$(eval NEW_DIR = $(shell powershell -Command "(Get-Item -Path (Split-Path -Path $$PWD -Parent)).FullName"))
MSBUILD_PATH = $(shell powershell -Command "(Get-ChildItem -Path 'C:\' -Filter 'msbuild.exe' -Recurse -File | Select-Object -First 1 | Select-Object -ExpandProperty FullName)")

all: run
make: 
	
	powershell -Command foreach ($$file in Get-ChildItem -Path "$(CURDIR)" -Filter *.csproj -Recurse) {  "& '$(MSBUILD_PATH)' $$file.FullName" }
	
pack: 
	$(MAKE) clean
	powershell -Command "New-Item -ItemType Directory -Path "$(NEW_DIR_2)" -Name "$(NAME)" "
	powershell -Command "New-Item -ItemType Directory -Path "$(NEW_DIR_2)/$(NAME)" -Name "repo" "
	powershell -Command "Copy-Item -Path "$(NEW_DIR)/*"  -Destination "$(NEW_DIR_2)/$(NAME)/repo" -Recurse"
	powershell -Command "New-Item -ItemType Directory -Path "$(NEW_DIR_2)/$(NAME)" -Name "doc" "
	powershell -Command "New-Item -ItemType Directory -Path "$(NEW_DIR_2)/$(NAME)" -Name "install" " 
	powershell -Command "Get-Item -Path "$(NEW_DIR_2)/$(NAME)/repo/instalacka.exe" | Move-Item  -Destination "$(NEW_DIR_2)/$(NAME)/install"  "
	powershell -Command "Get-Item -Path "$(NEW_DIR_2)/$(NAME)/repo/instalacka_odchylky.exe" | Move-Item  -Destination "$(NEW_DIR_2)/$(NAME)/install"
	powershell -Command "Get-ChildItem -Path "$(NEW_DIR_2)/$(NAME)/repo/dokumentace.*" | Move-Item  -Destination "$(NEW_DIR_2)/$(NAME)/doc"
	powershell -Command $(ZIP_SCRIPT)
	powershell -Command  Remove-Item -Path "$(NEW_DIR_2)/$(NAME)" -Recurse -Force"

clean:
	powershell -Command foreach ($$file in Get-ChildItem -Path "$(CURDIR)" -Filter *.exe -Recurse) { Remove-Item $$file.FullName}
run:
	powershell -Command  if (Test-Path -Path "$(CURDIR)/*.exe") { "& { & $(CURDIR)/*.exe }" }	elseif (Test-Path -Path $(CURDIR)/MainForm/MainForm/bin/Debug/MainForm.exe) { "& { Start-Process $(CURDIR)/MainForm/MainForm/bin/Debug/MainForm.exe }" } else { echo 'Program nebyl sestaven ve VS, nebo pomoci ''make make'' a nelze spustit' }
profile:
	./MainForm/Odchylka/bin/Debug/net8.0/Odchylka.exe MainForm/Odchylka/bin/Debug/net8.0/TestSoubor.txt 
help:
	@echo Napoveda:
	@echo Manualne zkompilujte program ve VS a nasledne pouzit 'make run' nebo 'make' pro spusteni kalkulacky
	@echo Pouzit prikaz 'make make' a nasledne pouzit 'make' nebo 'make run' pro spusteni kalkulacky