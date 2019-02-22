We could not find a data exchange file at the path Unhandled Exception: System.BadImageFormatException: The module was expected to contain an assembly manifest. (Exception from HRESULT: 0x80131018)

Please open an issue at https://github.com/techtalk/SpecFlow/issues/
Complete output: 

Unhandled Exception: System.BadImageFormatException: The module was expected to contain an assembly manifest. (Exception from HRESULT: 0x80131018)
   at System.Reflection.RuntimeAssembly.nLoadFile(String path, Evidence evidence)
   at System.Reflection.Assembly.LoadFile(String path)
   at TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.CommandLineHandling.PreLoadAssemblies()
   at TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.CommandLineHandling.PreLoadAssemblies()
   at TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.Program.Main(String[] args)



Command: C:\Users\fszymaniak\AppData\Local\Microsoft\VisualStudio\15.0_36a34d3a\Extensions\0pcxkurm.0hv\TechTalk.SpecFlow.VisualStudio.CodeBehindGenerator.exe
Parameters: GenerateTestFile --featurefile C:\Users\fszymaniak\AppData\Local\Temp\tmp34E8.tmp --outputdirectory C:\Users\fszymaniak\AppData\Local\Temp --projectsettingsfile C:\Users\fszymaniak\AppData\Local\Temp\tmp34E7.tmp
Working Directory: 
