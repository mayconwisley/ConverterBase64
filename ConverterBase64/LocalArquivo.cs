namespace ConverterBase64;

internal class LocalArquivo
{
    public static string Local()
    {
        OpenFileDialog openFileDialog = new()
        {
            Multiselect = false
        };
        if (openFileDialog.ShowDialog() == DialogResult.OK)
            return openFileDialog.FileName;

        return string.Empty;
    }
}
