namespace ConverterBase64;

internal sealed class LocalArquivo
{
    public static string Local()
    {
        using OpenFileDialog openFileDialog = new()
        {
            Multiselect = false
        };
        if (openFileDialog.ShowDialog() == DialogResult.OK)
            return openFileDialog.FileName;

        return string.Empty;
    }
}
