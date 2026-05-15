namespace ConverterBase64;

internal sealed class Converter(string path)
{
    private const int TamanhoBufferEntrada = 24 * 1024;

    public void ToBase64(Action<string> escrever)
    {
        ArgumentNullException.ThrowIfNull(escrever);

        byte[] bufferEntrada = new byte[TamanhoBufferEntrada + 2];
        char[] bufferSaida = new char[((bufferEntrada.Length + 2) / 3) * 4];
        int bytesPendentes = 0;

        try
        {
            using FileStream arquivo = new(path, FileMode.Open, FileAccess.Read, FileShare.Read, TamanhoBufferEntrada, FileOptions.SequentialScan);

            while (true)
            {
                int bytesLidos = arquivo.Read(bufferEntrada, bytesPendentes, TamanhoBufferEntrada - bytesPendentes);
                if (bytesLidos == 0)
                    break;

                int totalBytes = bytesPendentes + bytesLidos;
                int bytesParaConverter = totalBytes - (totalBytes % 3);

                if (bytesParaConverter > 0)
                {
                    int caracteresConvertidos = Convert.ToBase64CharArray(bufferEntrada, 0, bytesParaConverter, bufferSaida, 0);
                    escrever(new string(bufferSaida, 0, caracteresConvertidos));
                }

                bytesPendentes = totalBytes - bytesParaConverter;
                if (bytesPendentes > 0)
                    Buffer.BlockCopy(bufferEntrada, bytesParaConverter, bufferEntrada, 0, bytesPendentes);
            }

            if (bytesPendentes > 0)
            {
                int caracteresConvertidos = Convert.ToBase64CharArray(bufferEntrada, 0, bytesPendentes, bufferSaida, 0);
                escrever(new string(bufferSaida, 0, caracteresConvertidos));
            }
        }
        finally
        {
            Array.Clear(bufferEntrada);
            Array.Clear(bufferSaida);
        }
    }
}
