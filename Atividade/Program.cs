using System;

namespace Atividade
{
    class Program
    {
        static void Main (string[]args)

        {
          float val_pag;
          Console.Writeln("Informar Nome");
          String var_nome = Console.ReadLine();
          Console.Writeln("Informar o endereço");
          String var_endereco = Console.ReadLine();
          Console.Writeln("Pessoa Física (f) ou Juridica (j)");
          String var_tipo = Console.ReadLine();
          if (var_tipo == 'f')
          {

           Pessoa_Fisica pf  = new Pessoa_Fisica();
           pf.nome = var_nome;
           pf.endereco = var_endereco;
           Console.Writeln ("Informar o CPF");
           pf.cpf = Console.ReadLine();
           Console.Writeln ("Informe o RG");
           pf.rg = Console.ReadLine();
           Console.Writeln("Informar o valor de compra:");
           val_pag = float.Parse(Console.ReadLine());
           pf.Pagar_Imposto (val_pag);
           Console.Writeln("---------Pessoa Fisica_____");
           Console.Writeln(" Nome-------:" + pf.nome);
           Console.Writeln(" Endereço-------:" + pf.endereco);
           Console.Writeln(" CPF-------:" + pf.cpf);
           Console.Writeln(" RG-------:" + pf.rg);
           Console.Writeln(" Valor da Compra-------:" + pf.valor.ToString("C"));
           Console.Writeln(" Imposto-------:" + pf.valor_imposto.ToString("C"));
           Console.Writeln(" Total-------:" + pf.total.ToString("C"));
          }
          if(var_tipo == "j")
          {
           Pessoa_Juridica pj = new Pessoa_Juridica ();
           pj.nome = var_nome;
           pj.endereco = var_endereco;
           

          }





          }
        }
    }
}
