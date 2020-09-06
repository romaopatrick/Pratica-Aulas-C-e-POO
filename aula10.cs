using System;

class Aula10
{
    enum DiasSemana{Domingo,Segunda,Terça,Quarta,Quinta,Sexta,Sabado}
    static void Main ()
    {
        int ds = (int)DiasSemana.Sexta;
        //DiasSemana ds =(DiasSemana)3;
        Console.WriteLine(ds);
    }
}