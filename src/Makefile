#Sample Makefile
CSC = csc
CSC_FLAGS = /warn:4 /optimize+ /nologo #/target:4.7.2

SOURCE = MainForm
SOURCES = $(wildcard $(SOURCE)/**/*.cs)
OUTPUT = Kalkulacka.exe

ZIP = xlogin01_xlogin02_xlogin03_xlogin04 #doplnit tymove loginy
ZIP_SCRIPT = 'Compress-Archive -Path ".." -DestinationPath "$(ZIP)"'
CLEAN_SCRIPT = $(CURDIR)/MainForm/MainForm/bin/Debug/MainForm.exe

SOURCE_RUN = $(wildcard *.exe)

all: $(OUTPUT)
$(OUTPUT): $(SOURCES)
	$(CSC) $(CSC_FLAGS) $^ -out:$@
	
pack: 
	powershell -Command $(ZIP_SCRIPT)
clean:
	powershell -Command if ( Test-Path -Path $(CURDIR)/*.exe) { del	*.exe} 
	powershell -Command if (Test-Path -Path $(CURDIR)/MainForm/MainForm/bin/Debug/*.exe) { del "$(CURDIR)\MainForm\MainForm\bin\Debug\*.exe"}
run:
	powershell -Command  if (Test-Path -Path "$(CURDIR)/*.exe") { "& { & $(CURDIR)/*.exe }" }	elseif (Test-Path -Path $(CURDIR)/MainForm/MainForm/bin/Debug/MainForm.exe) { "& { Start-Process $(CURDIR)/MainForm/MainForm/bin/Debug/MainForm.exe }" } else { echo "ok3" }
profile:
help:
	@echo Napoveda:
	@echo Je potreba pouzit 'make' pro prelozeni projektu a nasledene 'make run' pro spusteni
	@echo Manualne zkompilovat program ve VS a nasledne pouzit 'make run'