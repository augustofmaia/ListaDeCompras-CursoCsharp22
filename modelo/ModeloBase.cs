namespace Modelo;

public abstract class ModeloBase {
    
    public List<string> Errors {get; set; } = new List<string>();

    public void AdicionarValidacao(bool ehIvalido, string mensagem) {
        if(ehIvalido)
            Errors.Add(mensagem);
    }
    public bool Valido() {
        return Errors.Count() == 0;
    }
}