#Sample Makefile
CSC = csc
CSC_FLAGS = /warn:4 /optimize+ /nologo #/target:4.7.2

SOURCES = MainForm/MainForm/Form1.cs MainForm/MainForm/Form1.Designer.cs MainForm/MainForm/NumButton.cs MainForm/MainForm/OperationButton.cs MainForm/MainForm/Operations.cs MainForm/MainForm/Program.cs MainForm/MainForm/Properties/AssemblyInfo.cs MainForm/MainForm/Properties/Resources.Designer.cs MainForm/MainForm/Properties/Settings.Designer.cs 
OUTPUT = Kalkulacka.exe

all: $(OUTPUT)
$(OUTPUT): $(SOURCES)
	$(CSC) $(CSC_FLAGS) $^ -out:$@
	
pack:
clean:
	del -f $(OUTPUT)
run:
	./$(OUTPUT)
profile:
help: