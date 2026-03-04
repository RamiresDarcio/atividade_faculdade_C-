namespace aular_4;
//esse função da atividade
public class conta_bancaria_p
{
    
    private string _titular;
    private float _saldo;
    private string _numero;
    private string _senha;
    private int _agencia;
    private string _tipo;

    public string Titular
    {
        get { return this._titular;}
        set { this._titular = value; }
        
    }

    public float Saldo
    {
        get { return this._saldo; }
        set { this._saldo = value; }
    } 
    public string Numero
    {
        get { return this._numero;}
        set { this._numero = value; }
    }

    public string Senha
    {
        get { return this._senha;}
        set { this._senha = value; }
    }

    public int Agencia
    {
        get { return this._agencia;}
        set { this._agencia = value; }
    }
    public string Tipo
    {
        get { return this._tipo;}
        set { this._tipo = value; }
    }
}