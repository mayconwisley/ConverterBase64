namespace ConverterBase64;

internal class Converter(string path)
{
    public string ToBase64()
    {
        byte[] bytesArquivo = File.ReadAllBytes(path);
        string base64String = Convert.ToBase64String(bytesArquivo);
        return base64String;
    }
}
