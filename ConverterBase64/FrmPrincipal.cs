namespace ConverterBase64;

public partial class FrmPrincipal : Form
{
    public FrmPrincipal()
    {
        InitializeComponent();
    }

    private void BtnProcurar_Click(object sender, EventArgs e)
    {
        TxtLocalArquivo.Text = LocalArquivo.Local();
    }

    private void BtnConverter_Click(object sender, EventArgs e)
    {
        LimparResultadoBase64();

        string caminhoArquivo = TxtLocalArquivo.Text.Trim();
        if (string.IsNullOrEmpty(caminhoArquivo))
        {
            MessageBox.Show("Selecione um arquivo para converter!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        try
        {
            HabilitarControles(false);
            Cursor = Cursors.WaitCursor;

            Converter converter = new(caminhoArquivo);
            converter.ToBase64(parteBase64 =>
            {
                RTxtBase64.AppendText(parteBase64);
                RTxtBase64.ClearUndo();
            });
            RTxtBase64.ClearUndo();
        }
        catch (Exception ex)
        {
            LimparResultadoBase64();
            MessageBox.Show($"Não foi possível converter o arquivo.{Environment.NewLine}{ex.Message}", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            Cursor = Cursors.Default;
            HabilitarControles(true);
            LiberarMemoriaTemporaria();
        }
    }

    private void BtnCopiar_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(RTxtBase64.Text);
    }

    private void BtnLimpar_Click(object sender, EventArgs e)
    {
        LimparResultadoBase64();
        TxtLocalArquivo.Clear();
        LiberarMemoriaTemporaria();
    }

    private void LimparResultadoBase64()
    {
        RTxtBase64.Clear();
        RTxtBase64.ClearUndo();
    }

    private void HabilitarControles(bool habilitar)
    {
        BtnProcurar.Enabled = habilitar;
        BtnConverter.Enabled = habilitar;
        BtnCopiar.Enabled = habilitar;
        BtnLimpar.Enabled = habilitar;
    }

    private static void LiberarMemoriaTemporaria()
    {
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();
    }
}
