#Sample Makefile
CSC = csc
CSC_FLAGS = /warn:4 /optimize+ /nologo #/target:4.7.2

SOURCE = MainForm
SOURCES = $(wildcard $(SOURCE)/**/*.cs)
OUTPUT = Kalkulacka.exe

all: $(OUTPUT)
$(OUTPUT): $(SOURCES)
	$(CSC) $(CSC_FLAGS) $^ -out:$@
	
pack:
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