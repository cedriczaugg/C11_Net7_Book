// See https://aka.ms/new-console-template for more information

using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

SectionTitle("Handling cross-platform environments and filesystems");
WriteLine("{0,-33} {1}", "Path.PathSeparator", PathSeparator);
WriteLine("{0,-33} {1}", "Path.DirectorySeparatorChar", DirectorySeparatorChar);
WriteLine("{0,-33} {1}", "Directory.GetCurrentDirectory()", GetCurrentDirectory());
WriteLine("{0,-33} {1}", "Environment.CurrentDirectory", CurrentDirectory);
WriteLine("{0,-33} {1}", "Environment.SystemDirectory", SystemDirectory);
WriteLine("{0,-33} {1}", "Path.GetTempPath()", GetTempPath());
WriteLine("GetFolderPath(SpecialFolder");
WriteLine("{0,-33} {1}", " .System)", GetFolderPath(SpecialFolder.System));
WriteLine("{0,-33} {1}", " .ApplicationData)", GetFolderPath(SpecialFolder.ApplicationData));
WriteLine("{0,-33} {1}", " .MyDocuments)", GetFolderPath(SpecialFolder.MyDocuments));
WriteLine("{0,-33} {1}", " .Personal)", GetFolderPath(SpecialFolder.Personal));

SectionTitle("Managing drives");
WriteLine("{0,-30} | {1,-10} | {2,-7} | {3,18} | {4,18}",
    "NAME", "TYPE", "FORMAT", "SIZE (BYTES)", "FREE SPACE");

foreach (var drive in DriveInfo.GetDrives())
    if (drive.IsReady)
        WriteLine(
            "{0,-30} | {1,-10} | {2,-7} | {3,18:N0} | {4,18:N0}",
            drive.Name, drive.DriveType, drive.DriveFormat,
            drive.TotalSize, drive.AvailableFreeSpace);
    else
        WriteLine("{0,-30} | {1,-10}", drive.Name, drive.DriveType);

SectionTitle("Managing directories");

// Define a directory path for a new folder
// starting in the user's folder.
var newFolder = Combine(GetFolderPath(SpecialFolder.Personal), "NewFolder");

WriteLine($"Working with: {newFolder}");

// Check if it exists
WriteLine($"Does it exist? {Path.Exists(newFolder)}");

// create directory 
WriteLine("Creating it...");
CreateDirectory(newFolder);
WriteLine($"Does it exist? {Path.Exists(newFolder)}");
Write("Confirm the directory exists, and then press ENTER: ");
ReadLine();
// delete directory 
WriteLine("Deleting it...");
Delete(newFolder, true);
WriteLine($"Does it exist? {Path.Exists(newFolder)}");

SectionTitle("Managing files");
// define a directory path to output files
// starting in the user's folder
var dir = Combine(
    GetFolderPath(SpecialFolder.Personal), "OutputFiles");
CreateDirectory(dir);
// define file paths
var textFile = Combine(dir, "Dummy.txt");
var backupFile = Combine(dir, "Dummy.bak");
WriteLine($"Working with: {textFile}");
// check if a file exists
WriteLine($"Does it exist? {File.Exists(textFile)}");
// create a new text file and write a line to it
var textWriter = File.CreateText(textFile);
textWriter.WriteLine("Hello, C#!");
textWriter.Close(); // close file and release resources
WriteLine($"Does it exist? {File.Exists(textFile)}");
// copy the file, and overwrite if it already exists
File.Copy(textFile,
    backupFile, true);
WriteLine(
    $"Does {backupFile} exist? {File.Exists(backupFile)}");
Write("Confirm the files exist, and then press ENTER: ");
ReadLine();
// delete file
File.Delete(textFile);
WriteLine($"Does it exist? {File.Exists(textFile)}");
// read from the text file backup
WriteLine($"Reading contents of {backupFile}:");
var textReader = File.OpenText(backupFile);
WriteLine(textReader.ReadToEnd());
textReader.Close();

SectionTitle("Managing paths");
WriteLine($"Folder Name: {GetDirectoryName(textFile)}");
WriteLine($"File Name: {GetFileName(textFile)}");
WriteLine("File Name without Extension: {0}",
    GetFileNameWithoutExtension(textFile));
WriteLine($"File Extension: {GetExtension(textFile)}");
WriteLine($"Random File Name: {GetRandomFileName()}");
WriteLine($"Temporary File Name: {GetTempFileName()}");

SectionTitle("Getting file information");
FileInfo info = new(backupFile);
WriteLine($"{backupFile}:");
WriteLine($"Contains {info.Length} bytes");
WriteLine($"Last accessed {info.LastAccessTime}");
WriteLine($"Has readonly set to {info.IsReadOnly}");