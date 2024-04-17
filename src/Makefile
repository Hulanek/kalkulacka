#Sample Makefile
CSC = csc
CSC_FLAGS = /warn:4 /optimize+ /nologo #/target:4.7.2

SOURCE = MainForm
SOURCES = $(wildcard $(SOURCE)/**/*.cs)
OUTPUT = Kalkulacka.exe

ZIP = xlogin01_xlogin02_xlogin03_xlogin04.zip #doplnit tymove loginy
ZIP_SCRIPT = 'Compress-Archive -Path ".." -DestinationPath "$(ZIP)"'


all: $(OUTPUT)
$(OUTPUT): $(SOURCES)
	$(CSC) $(CSC_FLAGS) $^ -out:$@
	
pack: 
	powershell -Command $(ZIP_SCRIPT)
clean:
	del -f $(OUTPUT)
run:
	./$(OUTPUT) 
	./MainForm/MainForm/bin/Debug/MainForm.exe #zkusit zautomatizovat pri nejhorsim nechat
profile:
help:
	@echo Napoveda:
	@echo Je potreba pouzit 'make' pro prelozeni projektu a nasledene 'make run' pro spusteni
	@echo Manualne zkompilovat program ve VS a nasledne pouzit 'make run'