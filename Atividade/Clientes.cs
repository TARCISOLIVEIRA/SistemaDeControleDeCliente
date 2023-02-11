namespace Atividade
{
    class Clientes
    {
      public string nome {get; set;} 
      public string endereco {get; set;} 
      public string valor {get;protected set;} 
      public string valor_imposto {get; protected set;} 
      public string total {get; protected set;} 
    
    public virtural void Pagar_Imposto(float v)
     {
        this.valor = v;
        this.valor_imposto = this.valor * 10/100;
        this.total = this.valor + this.valor_imposto;
     }


    }
}