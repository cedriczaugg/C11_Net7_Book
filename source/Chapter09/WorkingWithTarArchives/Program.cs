// See https://aka.ms/new-console-template for more information

using System.Formats.Tar;

try
{
    var current = Environment.CurrentDirectory;
    WriteInformation($"Current directory: {current}");

    var sourceDirectory = Path.Combine(current, "images");
    var destinationDirectory = Path.Combine(current, "extracted");
    var tarFile = Path.Combine(current, "images-archive.tar");

    if (!Directory.Exists(sourceDirectory))
    {
        WriteError($"The {sourceDirectory} directory must exist. Please create it and some files in ir.");
        return;
    }

    if (File.Exists(tarFile))
    {
        // If the Tar archive file already exists then we must delete it.
        File.Delete(tarFile);
        WriteWarning($"{tarFile} already existed so it was deleted.");
    }

    WriteInformation($"Archiving directory: {sourceDirectory}\n To .tar file: {tarFile}");

    TarFile.CreateFromDirectory(
        sourceDirectory,
        tarFile,
        true);

    WriteInformation($"Does {tarFile} exist? {File.Exists(tarFile)}.");

    if (!Directory.Exists(destinationDirectory))
    {
        // If the destination directory does not exist then we must create
        // it before extracting a Tar archive to it.
        Directory.CreateDirectory(destinationDirectory);
        WriteWarning($"{destinationDirectory} did not exist so it was created.");
    }

    WriteInformation(
        $"Extracting archive: {tarFile}\n To directory: {destinationDirectory}");
    TarFile.ExtractToDirectory(
        tarFile,
        destinationDirectory,
        true);
    if (Directory.Exists(destinationDirectory))
        foreach (var dir in Directory.GetDirectories(destinationDirectory))
            WriteInformation(
                $"Extracted directory {dir} containing these files: " +
                string.Join(',', Directory.EnumerateFiles(dir)
                    .Select(file => Path.GetFileName(file))));
}
catch (Exception ex)
{
    WriteError(ex.Message);
}