using System;

namespace Atividade
{
    class Program
    {
        static void Main (string[]args)

        {
          
          float val_pag;
          Console.WriteLine("Informar Nome");
          String var_nome = Console.ReadLine();
          Console.WriteLine("Informar o endereço");
          String var_endereco = Console.ReadLine();
          Console.WriteLine("Pessoa Física (f) ou Juridica (j)");
          String var_tipo = Console.ReadLine();
          if (var_tipo == "f")
          {

          Pessoa_Fisica pf  = new Pessoa_Fisica();
           pf.nome = var_nome;
           pf.endereco = var_endereco;
           Console.WriteLine ("Informar o CPF.......:");
           pf.cpf = Console.ReadLine();
           Console.WriteLine ("Informe o RG.......:");
           pf.rg = Console.ReadLine();
           Console.WriteLine("Informar o valor de compra.........:");
           val_pag = float.Parse(Console.ReadLine());
           pf.Pagar_Imposto (val_pag);
           Console.WriteLine("---------Pessoa Fisica_____");
           Console.WriteLine(" Nome-------:" + pf.nome);
           Console.WriteLine(" Endereço-------:" + pf.endereco);
           Console.WriteLine(" CPF-------:" + pf.cpf);
           Console.WriteLine(" RG-------:" + pf.rg);
           Console.WriteLine(" Valor da Compra-------:" + pf.valor.ToString("C"));
           Console.WriteLine(" Imposto-------:" + pf.valor_imposto.ToString("C"));
           Console.WriteLine(" Total-------:" + pf.total.ToString("C"));
          }
          if(var_tipo == "j")
          {
           Pessoa_Juridica pj = new Pessoa_Juridica ();
           pj.nome = var_nome;
           pj.endereco = var_endereco;
           Console.WriteLine("Informar CNPJ");
           pj.cnpj = Console.ReadLine();
           Console.WriteLine("Informar IE");
           pj.ie = Console.ReadLine();
           Console.WriteLine("Informar o valor de compra");
           val_pag = float.Parse(Console.ReadLine());
           pj.Pagar_Imposto(val_pag);
           Console.WriteLine("_________Pessoa Juridica_____");
           Console.WriteLine("Nome________"+ pj.nome);
           Console.WriteLine("Endereço________"+ pj.endereco);
           Console.WriteLine("CNPJ________"+ pj.cnpj);
           Console.WriteLine("IE________"+ pj.ie);
           Console.WriteLine("Valor de compra________"+ pj.valor.ToString("C"));
           Console.WriteLine("Imposto________"+ pj.valor_imposto.ToString("C"));
           Console.WriteLine("total________"+ pj.total.ToString("C"));

          
           

          }





          }
        }
    }

