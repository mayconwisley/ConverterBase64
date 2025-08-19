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
        RTxtBase64.Clear();
        Converter converter = new(TxtLocalArquivo.Text.Trim());
        RTxtBase64.Text = converter.ToBase64();
    }

    private void BtnCopiar_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(RTxtBase64.Text);
    }

    private void BtnLimpar_Click(object sender, EventArgs e)
    {
        RTxtBase64.Clear();
    }
}
